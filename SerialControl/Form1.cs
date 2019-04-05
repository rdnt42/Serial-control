using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;
using System.Threading;

namespace SerialControl
{
    public partial class FormSerial : Form
    {
        SerialPort serialDevice = new SerialPort();
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
            comboBoxSerial.Items.Clear();
            comboBoxSerial.ResetText();
            comboBoxSerial.Items.AddRange(ports);
        }

        private void BtnOpen_Click(object sender, EventArgs e)
        {
            try
            {
                if ((comboBoxSerial.Text == ""))
                {
                    OutMessage('w', "", "Select Port.");
                }

                else
                {
                    serialDevice.BaudRate = 9600;
                    serialDevice.Parity = Parity.None;
                    serialDevice.StopBits = StopBits.One;
                    serialDevice.Handshake = Handshake.None;
                    serialDevice.PortName = comboBoxSerial.Text;
                    serialDevice.ReadTimeout = 500;
                    serialDevice.DataReceived += new SerialDataReceivedEventHandler(SerialPort_DataReceived);
                    serialDevice.Open();
                    BtnOpen.Enabled = false;
                    BtnClose.Enabled = true;
                    PrgBarSerial.Value = 1;
                }
            }

            catch (UnauthorizedAccessException)
            {
                OutMessage('w', "", "Access is denied.");
            }

            catch (IOException)
            {
                OutMessage('w', "", "The port is in an invalid state.");
            }

            catch (InvalidOperationException)
            {
                OutMessage('w', "", "Port is already open.");
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            serialDevice.Close();
            BtnOpen.Enabled = true;
            BtnClose.Enabled = false;
            PrgBarSerial.Value = 0;
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
                if (text == "TimeEx")
                    OutMessage('w', "", "Time Out Exeption, check serial protocol.");

                else
                {
                    if (RadioButtonMdbs.Checked == true)
                    {
                        if (sendMess[6] == reciveMess[6] && sendMess[7] == reciveMess[7] &&
                        !(reciveMess[6] == 0 && reciveMess[7] == 0))
                            OutMessage('r', text, " CRC OK");
                        else if (reciveMess[6] == 0 && reciveMess[7] == 0)
                            OutMessage('r', text, " NOT Modbus protocol.");
                        else
                            OutMessage('r', text, " CRC NOT OK");
                    }

                    else if (RadioButtonAny.Checked == true)
                        OutMessage('r',text, "");
                }
            }
        }

        public void OutMessage(char messSymb, string text, string warning)
        {
            string messType;
            switch (messSymb)
            {
                case 'w':
                    messType = "!!!! ";
                    break;
                case 's':
                    messType = ">>>> ";
                    break;
                case 'r':
                    messType = "<<<< ";
                    break;
                default:
                    messType = "err ";
                    break;
            }
            textBoxRead.Text = messType + text + warning + Environment.NewLine
                                                + textBoxRead.Text;
        }

        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            byte[] arr = new byte[8];
            string data = "";
            if (RadioButtonMdbs.Checked == true)
            {
                try
                {
                    for (int i = 0; i < 8; i++)
                    {
                        reciveMess[i] = Convert.ToByte(serialDevice.ReadByte());
                        data += reciveMess[i];
                    }
                }
                catch (TimeoutException)
                {
                    //ArgumentException argEx = new ArgumentException("Incorrect Serial protocol", "Protocol must be Modbus", ex);
                    //throw argEx;
                    SetTextMain("TimeEx");
                }
            }
            else if (RadioButtonAny.Checked == true)
            {
                Thread.Sleep(5);
                while (serialDevice.BytesToRead > 0)
                {
                    data += serialDevice.ReadByte();
                }
            }

            SetTextMain(data);
        }

        private void BtnSend_Click(object sender, EventArgs e)
        {
            //rework
            try
            {
                serialDevice.WriteLine(textBoxSend.Text);
            }
            catch
            {
                OutMessage('w', "", "Send Error");
            }
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
            //перевод из 10 в 16
            crc = (ushort)((crc >> 8) | (crc << 8));

            return GetTwoWords10(crc);
        }

        byte[] GetTwoWords10(int twoNumI)
        {
            //rework
            //перевод из 10 в 16
            string twoNumS = twoNumI.ToString("x"); ;

            while (twoNumS.Length < 4)
                while (twoNumS.Length < 4)
                    twoNumS = "0" + twoNumS;
            byte[] twoWords10 = new byte[2];
            //разбиение числа на 2
            for (int i = 0; i < twoNumS.Length / 2; i++)
            {
                //перевод из 16 в 10
                twoWords10[i] = Convert.ToByte((twoNumS[i * 2].ToString() + twoNumS[i * 2 + 1].ToString()), 16);

            }
            return twoWords10;
        }

        byte[] SetFreqValue(int freqRpm)
        {

            int freqHz = Convert.ToInt32(freqRpm * 3.33);
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
            SendPackage(package);
        }

        private void BtnOffMo_Click(object sender, EventArgs e)
        {
            byte[] package = CreatePackage(new byte[] { 0x08 }, new byte[] { 0x06 }, new byte[] { 0x00, 0x00 },
                       new byte[] { 0x00, 0x00 });
            SendPackage(package);
        }

        private void BtnFreqMo_Click(object sender, EventArgs e)
        {
            if (Int32.TryParse(TxtBoxFreqMo.Text, out int number))
            {
                byte[] package = CreatePackage(new byte[] { 0x08 }, new byte[] { 0x06 }, new byte[] { 0x00, 0x01 },
                                       SetFreqValue(number));
                SendPackage(package);
            }

            else
            {
                OutMessage('w', "", "Input string was not in a correct format.");
            }
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
            SendPackage(package);
        }

        private void BtnOffMt_Click(object sender, EventArgs e)
        {
            byte[] package = CreatePackage(new byte[] { 0x10 }, new byte[] { 0x06 }, new byte[] { 0x00, 0x00 },
                       new byte[] { 0x00, 0x00 });
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
            if (Int32.TryParse(TxtBoxFreqMo.Text, out int number))
            {
                byte[] package = CreatePackage(new byte[] { 0x10 }, new byte[] { 0x06 }, new byte[] { 0x00, 0x01 },
                       SetFreqValue(number));
                SendPackage(package);
            }

            else
            {
                OutMessage('w', "", "Input string was not in a correct format.");
            }
        }

        public void SendPackage(byte[] sendPack)
        {
            string message = "";
            try
            {
                serialDevice.Write(sendPack, 0, sendPack.Length);
                sendPack.CopyTo(sendMess, 0);
                foreach (var b in sendPack)
                    message += b.ToString();
                OutMessage('s', message, "");
            }
            catch (InvalidOperationException)
            {
                OutMessage('w', "", "Port not open.");
            }
        }

        private void BtnPortRefresh_Click(object sender, EventArgs e)
        {
            GetNamePort();
        }

    }
}
