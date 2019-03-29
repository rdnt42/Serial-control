﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;

namespace SerialControl
{
    public partial class FormSerial : Form
    {
        SerialPort serialVesper = new SerialPort();
        delegate void SetTextMainCallback(string text);
        byte[] sendMess = new byte[8];
        byte[] reciveMess = new byte[8];

        public FormSerial()
        {
            InitializeComponent();
            GetNamePort();
        }

        void GetNamePort()
        {
            String[] ports = SerialPort.GetPortNames();
            comboBoxSerial.Items.AddRange(ports);

        }

        private void BtnOpen_Click(object sender, EventArgs e)
        {
            try
            {
                if ((comboBoxSerial.Text == ""))
                {
                    textBoxRead.Text = "Select Port";
                }

                else
                {

                    serialVesper.BaudRate = 9600;
                    serialVesper.Parity = Parity.None;
                    serialVesper.StopBits = StopBits.One;
                    serialVesper.Handshake = Handshake.None;
                    serialVesper.PortName = comboBoxSerial.Text;
                    serialVesper.ReadTimeout = 500;                    // TIME OUT
                    serialVesper.DataReceived += new SerialDataReceivedEventHandler(SerialPort_DataReceived);
                    // serialVesper.ReadBufferSize = 8;
                    serialVesper.Open();
                    BtnOpen.Enabled = false;
                    BtnClose.Enabled = true;
                }
            }
            catch (UnauthorizedAccessException)
            {
                textBoxRead.Text = "Port not open";
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            serialVesper.Close();
            BtnOpen.Enabled = true;
            BtnClose.Enabled = false;
        }
        private void SetTextMain(string text)
        {

            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.textBoxRead.InvokeRequired)
            {
                SetTextMainCallback d = new SetTextMainCallback(SetTextMain);
                this.Invoke(d, new object[] { text });

            }
            else
            {
                if (sendMess[6] == reciveMess[6] && sendMess[7] == reciveMess[7])
                    textBoxRead.Text = "<<< " + text + " CRC OK" + Environment.NewLine
                                        + textBoxRead.Text;
                else
                    textBoxRead.Text = "<<< " + text + " CRC NOT OK" + Environment.NewLine
                                        + textBoxRead.Text;

            }
        }
        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            byte[] arr = new byte[8];
            string data = "";
            Thread.Sleep(5);
            int i = 0;
            while (serialVesper.BytesToRead > 0)
            {
                reciveMess[i] = Convert.ToByte(serialVesper.ReadByte());
                data += reciveMess[i];
                i++;
            }
            /*
            for (int i = 0; i < 8; i++)
            {
                reciveMess[i] = Convert.ToByte(serialVesper.ReadByte());
                data += reciveMess[i];
            }
            */
            SetTextMain(data);
        }

        private void BtnSend_Click(object sender, EventArgs e)
        {
            serialVesper.WriteLine(textBoxSend.Text);
        }

        public byte[] GetCrc(byte[] buf)
        {
            UInt16 crc = 0xFFFF;

            for (int pos = 0; pos < buf.Length; pos++)
            {
                crc ^= (UInt16)buf[pos];

                for (int i = 8; i != 0; i--)
                {
                    if ((crc & 0x0001) != 0)
                    {
                        crc >>= 1;
                        crc ^= 0xA001;
                    }
                    else
                        crc >>= 1;
                }
            }
            crc = (ushort)((crc >> 8) | (crc << 8));

            return GetTwoWords10(crc);                                      //перевод из 10 в 16
        }

        byte[] GetTwoWords10(int twoNumI)
        {
            string twoNumS = twoNumI.ToString("x"); ;

            while (twoNumS.Length < 4)
                while (twoNumS.Length < 4)
                    twoNumS = "0" + twoNumS;
            byte[] twoWords10 = new byte[2];
            for (int i = 0; i < twoNumS.Length / 2; i++)                    //разбиение числа на 2
            {                                                                 //перевод из 16 в 10
                twoWords10[i] = Convert.ToByte((twoNumS[i * 2].ToString() + twoNumS[i * 2 + 1].ToString()), 16);

            }
            return twoWords10;
        }

        byte[] SetFreqValue(string freqRpm)
        {
            int freqHz = Convert.ToInt32(Int32.Parse(freqRpm) * 3.33);
            if (freqHz != 0) freqHz++;
            return GetTwoWords10(freqHz);
        }

        byte[] CreatePackage(byte[] id, byte[] code, byte[] command, byte[] data)
        {

            byte[] package = new byte[id.Length + code.Length
                                    + command.Length + data.Length];
            id.CopyTo(package, 0);
            code.CopyTo(package, id.Length);
            command.CopyTo(package, id.Length + code.Length);
            data.CopyTo(package, id.Length + code.Length + command.Length);
            byte[] crc = GetCrc(package);
            byte[] packageCrc = new byte[package.Length + 2];
            package.CopyTo(packageCrc, 0);
            crc.CopyTo(packageCrc, package.Length);
            return packageCrc;
        }

        private void BtnOnMo_Click(object sender, EventArgs e)
        {
            byte[] package = CreatePackage(new byte[] { 0x08 }, new byte[] { 0x06 }, new byte[] { 0x00, 0x00 },
                       new byte[] { 0x00, 0x01 });
            //serialVesper.Write(package, 0, package.Length);
            SendPackage(package);
        }

        private void BtnOffMo_Click(object sender, EventArgs e)
        {
            byte[] package = CreatePackage(new byte[] { 0x08 }, new byte[] { 0x06 }, new byte[] { 0x00, 0x00 },
                       new byte[] { 0x00, 0x00 });
            // serialVesper.Write(package, 0, package.Length);
            SendPackage(package);
        }

        private void BtnFreqMo_Click(object sender, EventArgs e)
        {
            byte[] package = CreatePackage(new byte[] { 0x08 }, new byte[] { 0x06 }, new byte[] { 0x00, 0x01 },
                       SetFreqValue(TxtBoxFreqMo.Text));
            //serialVesper.Write(package, 0, package.Length);
            SendPackage(package);
        }

        private void TxtBoxFreqMo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnFreqMo_Click(sender, e);
            }
        }

        private void BtnOnMt_Click(object sender, EventArgs e)
        {
            byte[] package = CreatePackage(new byte[] { 0x10 }, new byte[] { 0x06 }, new byte[] { 0x00, 0x00 },
                       new byte[] { 0x00, 0x01 });
            //serialVesper.Write(package, 0, package.Length);
            SendPackage(package);
        }

        private void BtnOffMt_Click(object sender, EventArgs e)
        {
            byte[] package = CreatePackage(new byte[] { 0x10 }, new byte[] { 0x06 }, new byte[] { 0x00, 0x00 },
                       new byte[] { 0x00, 0x00 });
            //serialVesper.Write(package, 0, package.Length);
            SendPackage(package);
        }


        private void TxttBoxFreqMt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnFreqMt_Click(sender, e);
            }
        }

        private void BtnFreqMt_Click(object sender, EventArgs e)
        {
            byte[] package = CreatePackage(new byte[] { 0x10 }, new byte[] { 0x06 }, new byte[] { 0x00, 0x01 },
                       SetFreqValue(TxtBoxFreqMt.Text));
            SendPackage(package);
            //serialVesper.Write(package, 0, package.Length);
        }

        public void SendPackage(byte[] sendPack)
        {
            string message = "";
            serialVesper.Write(sendPack, 0, sendPack.Length);
            sendPack.CopyTo(sendMess, 0);
            foreach (var b in sendPack)
                message += b.ToString();

            textBoxRead.Text = ">>> " + message + Environment.NewLine
                                        + textBoxRead.Text;
        }

        private void BtnPortRefresh_Click(object sender, EventArgs e)
        {
            GetNamePort();
        }

    }
}
