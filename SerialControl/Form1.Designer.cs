namespace SerialControl
{
    partial class FormSerial
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnPortRefresh = new System.Windows.Forms.Button();
            this.buttonFreq2 = new System.Windows.Forms.Button();
            this.TxtBoxFreqMt = new System.Windows.Forms.TextBox();
            this.BtnOffMt = new System.Windows.Forms.Button();
            this.BtnOnMt = new System.Windows.Forms.Button();
            this.BtnFreqMo = new System.Windows.Forms.Button();
            this.TxtBoxFreqMo = new System.Windows.Forms.TextBox();
            this.BtnOffMo = new System.Windows.Forms.Button();
            this.BtnOnMo = new System.Windows.Forms.Button();
            this.BtnSend = new System.Windows.Forms.Button();
            this.textBoxSend = new System.Windows.Forms.TextBox();
            this.textBoxRead = new System.Windows.Forms.TextBox();
            this.BtnClose = new System.Windows.Forms.Button();
            this.BtnOpen = new System.Windows.Forms.Button();
            this.comboBoxSerial = new System.Windows.Forms.ComboBox();
            this.textBoxSerialStyle = new System.Windows.Forms.TextBox();
            this.textBoxMoStyle = new System.Windows.Forms.TextBox();
            this.textBoxMtStyle = new System.Windows.Forms.TextBox();
            this.RadioButtonMdbs = new System.Windows.Forms.RadioButton();
            this.RadioButtonAny = new System.Windows.Forms.RadioButton();
            this.PrgBarSerial = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // BtnPortRefresh
            // 
            this.BtnPortRefresh.BackgroundImage = global::SerialControl.Properties.Resources.refr;
            this.BtnPortRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnPortRefresh.Location = new System.Drawing.Point(165, 36);
            this.BtnPortRefresh.Name = "BtnPortRefresh";
            this.BtnPortRefresh.Size = new System.Drawing.Size(31, 31);
            this.BtnPortRefresh.TabIndex = 35;
            this.BtnPortRefresh.UseVisualStyleBackColor = true;
            this.BtnPortRefresh.Click += new System.EventHandler(this.BtnPortRefresh_Click);
            // 
            // buttonFreq2
            // 
            this.buttonFreq2.Location = new System.Drawing.Point(135, 319);
            this.buttonFreq2.Name = "buttonFreq2";
            this.buttonFreq2.Size = new System.Drawing.Size(75, 23);
            this.buttonFreq2.TabIndex = 34;
            this.buttonFreq2.Text = "send freq";
            this.buttonFreq2.UseVisualStyleBackColor = true;
            this.buttonFreq2.Click += new System.EventHandler(this.BtnFreqMt_Click);
            // 
            // TxtBoxFreqMt
            // 
            this.TxtBoxFreqMt.Location = new System.Drawing.Point(38, 319);
            this.TxtBoxFreqMt.Name = "TxtBoxFreqMt";
            this.TxtBoxFreqMt.Size = new System.Drawing.Size(75, 20);
            this.TxtBoxFreqMt.TabIndex = 33;
            // 
            // BtnOffMt
            // 
            this.BtnOffMt.Location = new System.Drawing.Point(135, 277);
            this.BtnOffMt.Name = "BtnOffMt";
            this.BtnOffMt.Size = new System.Drawing.Size(75, 23);
            this.BtnOffMt.TabIndex = 32;
            this.BtnOffMt.Text = "OFF";
            this.BtnOffMt.UseVisualStyleBackColor = true;
            this.BtnOffMt.Click += new System.EventHandler(this.BtnOffMt_Click);
            // 
            // BtnOnMt
            // 
            this.BtnOnMt.Location = new System.Drawing.Point(38, 277);
            this.BtnOnMt.Name = "BtnOnMt";
            this.BtnOnMt.Size = new System.Drawing.Size(75, 23);
            this.BtnOnMt.TabIndex = 31;
            this.BtnOnMt.Text = "ON";
            this.BtnOnMt.UseVisualStyleBackColor = true;
            this.BtnOnMt.Click += new System.EventHandler(this.BtnOnMt_Click);
            // 
            // BtnFreqMo
            // 
            this.BtnFreqMo.Location = new System.Drawing.Point(135, 203);
            this.BtnFreqMo.Name = "BtnFreqMo";
            this.BtnFreqMo.Size = new System.Drawing.Size(75, 23);
            this.BtnFreqMo.TabIndex = 30;
            this.BtnFreqMo.Text = "send freq";
            this.BtnFreqMo.UseVisualStyleBackColor = true;
            this.BtnFreqMo.Click += new System.EventHandler(this.BtnFreqMo_Click);
            // 
            // TxtBoxFreqMo
            // 
            this.TxtBoxFreqMo.Location = new System.Drawing.Point(38, 203);
            this.TxtBoxFreqMo.Name = "TxtBoxFreqMo";
            this.TxtBoxFreqMo.Size = new System.Drawing.Size(75, 20);
            this.TxtBoxFreqMo.TabIndex = 29;
            // 
            // BtnOffMo
            // 
            this.BtnOffMo.Location = new System.Drawing.Point(135, 154);
            this.BtnOffMo.Name = "BtnOffMo";
            this.BtnOffMo.Size = new System.Drawing.Size(75, 23);
            this.BtnOffMo.TabIndex = 28;
            this.BtnOffMo.Text = "OFF";
            this.BtnOffMo.UseVisualStyleBackColor = true;
            this.BtnOffMo.Click += new System.EventHandler(this.BtnOffMo_Click);
            // 
            // BtnOnMo
            // 
            this.BtnOnMo.Location = new System.Drawing.Point(38, 154);
            this.BtnOnMo.Name = "BtnOnMo";
            this.BtnOnMo.Size = new System.Drawing.Size(75, 23);
            this.BtnOnMo.TabIndex = 27;
            this.BtnOnMo.Text = "ON";
            this.BtnOnMo.UseVisualStyleBackColor = true;
            this.BtnOnMo.Click += new System.EventHandler(this.BtnOnMo_Click);
            // 
            // BtnSend
            // 
            this.BtnSend.Location = new System.Drawing.Point(343, 319);
            this.BtnSend.Name = "BtnSend";
            this.BtnSend.Size = new System.Drawing.Size(75, 23);
            this.BtnSend.TabIndex = 26;
            this.BtnSend.Text = "send";
            this.BtnSend.UseVisualStyleBackColor = true;
            this.BtnSend.Click += new System.EventHandler(this.BtnSend_Click);
            // 
            // textBoxSend
            // 
            this.textBoxSend.Location = new System.Drawing.Point(343, 248);
            this.textBoxSend.Multiline = true;
            this.textBoxSend.Name = "textBoxSend";
            this.textBoxSend.Size = new System.Drawing.Size(186, 63);
            this.textBoxSend.TabIndex = 25;
            // 
            // textBoxRead
            // 
            this.textBoxRead.Location = new System.Drawing.Point(343, 12);
            this.textBoxRead.Multiline = true;
            this.textBoxRead.Name = "textBoxRead";
            this.textBoxRead.ReadOnly = true;
            this.textBoxRead.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxRead.Size = new System.Drawing.Size(298, 228);
            this.textBoxRead.TabIndex = 24;
            // 
            // BtnClose
            // 
            this.BtnClose.Enabled = false;
            this.BtnClose.Location = new System.Drawing.Point(227, 70);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(75, 23);
            this.BtnClose.TabIndex = 23;
            this.BtnClose.Text = "Close Port";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // BtnOpen
            // 
            this.BtnOpen.Location = new System.Drawing.Point(227, 36);
            this.BtnOpen.Name = "BtnOpen";
            this.BtnOpen.Size = new System.Drawing.Size(75, 23);
            this.BtnOpen.TabIndex = 22;
            this.BtnOpen.Text = "Open Port";
            this.BtnOpen.UseVisualStyleBackColor = true;
            this.BtnOpen.Click += new System.EventHandler(this.BtnOpen_Click);
            // 
            // comboBoxSerial
            // 
            this.comboBoxSerial.FormattingEnabled = true;
            this.comboBoxSerial.Location = new System.Drawing.Point(38, 36);
            this.comboBoxSerial.Name = "comboBoxSerial";
            this.comboBoxSerial.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSerial.TabIndex = 21;
            // 
            // textBoxSerialStyle
            // 
            this.textBoxSerialStyle.BackColor = System.Drawing.Color.PaleTurquoise;
            this.textBoxSerialStyle.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBoxSerialStyle.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSerialStyle.Location = new System.Drawing.Point(12, 12);
            this.textBoxSerialStyle.Multiline = true;
            this.textBoxSerialStyle.Name = "textBoxSerialStyle";
            this.textBoxSerialStyle.ReadOnly = true;
            this.textBoxSerialStyle.Size = new System.Drawing.Size(306, 104);
            this.textBoxSerialStyle.TabIndex = 38;
            this.textBoxSerialStyle.Text = "Serial";
            // 
            // textBoxMoStyle
            // 
            this.textBoxMoStyle.BackColor = System.Drawing.Color.PowderBlue;
            this.textBoxMoStyle.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBoxMoStyle.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMoStyle.Location = new System.Drawing.Point(12, 122);
            this.textBoxMoStyle.Multiline = true;
            this.textBoxMoStyle.Name = "textBoxMoStyle";
            this.textBoxMoStyle.ReadOnly = true;
            this.textBoxMoStyle.Size = new System.Drawing.Size(306, 118);
            this.textBoxMoStyle.TabIndex = 39;
            this.textBoxMoStyle.Text = "Motor One";
            // 
            // textBoxMtStyle
            // 
            this.textBoxMtStyle.BackColor = System.Drawing.Color.LightGreen;
            this.textBoxMtStyle.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBoxMtStyle.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMtStyle.Location = new System.Drawing.Point(12, 246);
            this.textBoxMtStyle.Multiline = true;
            this.textBoxMtStyle.Name = "textBoxMtStyle";
            this.textBoxMtStyle.ReadOnly = true;
            this.textBoxMtStyle.Size = new System.Drawing.Size(306, 118);
            this.textBoxMtStyle.TabIndex = 40;
            this.textBoxMtStyle.Text = "Motor Two";
            // 
            // RadioButtonMdbs
            // 
            this.RadioButtonMdbs.AutoSize = true;
            this.RadioButtonMdbs.BackColor = System.Drawing.Color.PaleTurquoise;
            this.RadioButtonMdbs.Checked = true;
            this.RadioButtonMdbs.Location = new System.Drawing.Point(38, 63);
            this.RadioButtonMdbs.Name = "RadioButtonMdbs";
            this.RadioButtonMdbs.Size = new System.Drawing.Size(63, 17);
            this.RadioButtonMdbs.TabIndex = 42;
            this.RadioButtonMdbs.TabStop = true;
            this.RadioButtonMdbs.Text = "Modbus";
            this.RadioButtonMdbs.UseVisualStyleBackColor = false;
            // 
            // RadioButtonAny
            // 
            this.RadioButtonAny.AutoSize = true;
            this.RadioButtonAny.BackColor = System.Drawing.Color.PaleTurquoise;
            this.RadioButtonAny.Location = new System.Drawing.Point(38, 86);
            this.RadioButtonAny.Name = "RadioButtonAny";
            this.RadioButtonAny.Size = new System.Drawing.Size(43, 17);
            this.RadioButtonAny.TabIndex = 43;
            this.RadioButtonAny.TabStop = true;
            this.RadioButtonAny.Text = "Any";
            this.RadioButtonAny.UseVisualStyleBackColor = false;
            // 
            // PrgBarSerial
            // 
            this.PrgBarSerial.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PrgBarSerial.Location = new System.Drawing.Point(165, 69);
            this.PrgBarSerial.Maximum = 1;
            this.PrgBarSerial.Name = "PrgBarSerial";
            this.PrgBarSerial.Size = new System.Drawing.Size(31, 23);
            this.PrgBarSerial.Step = 1;
            this.PrgBarSerial.TabIndex = 44;
            // 
            // FormSerial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 408);
            this.Controls.Add(this.PrgBarSerial);
            this.Controls.Add(this.RadioButtonAny);
            this.Controls.Add(this.RadioButtonMdbs);
            this.Controls.Add(this.BtnPortRefresh);
            this.Controls.Add(this.buttonFreq2);
            this.Controls.Add(this.TxtBoxFreqMt);
            this.Controls.Add(this.BtnOffMt);
            this.Controls.Add(this.BtnOnMt);
            this.Controls.Add(this.BtnFreqMo);
            this.Controls.Add(this.TxtBoxFreqMo);
            this.Controls.Add(this.BtnOffMo);
            this.Controls.Add(this.BtnOnMo);
            this.Controls.Add(this.BtnSend);
            this.Controls.Add(this.textBoxSend);
            this.Controls.Add(this.textBoxRead);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.BtnOpen);
            this.Controls.Add(this.comboBoxSerial);
            this.Controls.Add(this.textBoxSerialStyle);
            this.Controls.Add(this.textBoxMoStyle);
            this.Controls.Add(this.textBoxMtStyle);
            this.Name = "FormSerial";
            this.Text = "Serial control";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnPortRefresh;
        private System.Windows.Forms.Button buttonFreq2;
        private System.Windows.Forms.TextBox TxtBoxFreqMt;
        private System.Windows.Forms.Button BtnOffMt;
        private System.Windows.Forms.Button BtnOnMt;
        private System.Windows.Forms.Button BtnFreqMo;
        private System.Windows.Forms.TextBox TxtBoxFreqMo;
        private System.Windows.Forms.Button BtnOffMo;
        private System.Windows.Forms.Button BtnOnMo;
        private System.Windows.Forms.Button BtnSend;
        private System.Windows.Forms.TextBox textBoxSend;
        private System.Windows.Forms.TextBox textBoxRead;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Button BtnOpen;
        private System.Windows.Forms.ComboBox comboBoxSerial;
        private System.Windows.Forms.TextBox textBoxSerialStyle;
        private System.Windows.Forms.TextBox textBoxMoStyle;
        private System.Windows.Forms.TextBox textBoxMtStyle;
        private System.Windows.Forms.RadioButton RadioButtonMdbs;
        private System.Windows.Forms.RadioButton RadioButtonAny;
        private System.Windows.Forms.ProgressBar PrgBarSerial;
    }
}

