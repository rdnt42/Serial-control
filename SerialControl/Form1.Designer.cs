namespace SerialControl
{
    partial class Form1
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
            this.buttonPortRefresh = new System.Windows.Forms.Button();
            this.buttonFreq2 = new System.Windows.Forms.Button();
            this.textBoxFreq2 = new System.Windows.Forms.TextBox();
            this.buttonOff2 = new System.Windows.Forms.Button();
            this.buttonOn2 = new System.Windows.Forms.Button();
            this.buttonFreq1 = new System.Windows.Forms.Button();
            this.textBoxFreq1 = new System.Windows.Forms.TextBox();
            this.buttonOff1 = new System.Windows.Forms.Button();
            this.buttonOn1 = new System.Windows.Forms.Button();
            this.btn_send = new System.Windows.Forms.Button();
            this.textBoxSend = new System.Windows.Forms.TextBox();
            this.textBoxRead = new System.Windows.Forms.TextBox();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_open = new System.Windows.Forms.Button();
            this.comboBoxSerial = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // buttonPortRefresh
            // 
            this.buttonPortRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonPortRefresh.Location = new System.Drawing.Point(179, 30);
            this.buttonPortRefresh.Name = "buttonPortRefresh";
            this.buttonPortRefresh.Size = new System.Drawing.Size(31, 31);
            this.buttonPortRefresh.TabIndex = 35;
            this.buttonPortRefresh.UseVisualStyleBackColor = true;
            // 
            // buttonFreq2
            // 
            this.buttonFreq2.Location = new System.Drawing.Point(135, 243);
            this.buttonFreq2.Name = "buttonFreq2";
            this.buttonFreq2.Size = new System.Drawing.Size(75, 23);
            this.buttonFreq2.TabIndex = 34;
            this.buttonFreq2.Text = "send freq";
            this.buttonFreq2.UseVisualStyleBackColor = true;
            // 
            // textBoxFreq2
            // 
            this.textBoxFreq2.Location = new System.Drawing.Point(38, 243);
            this.textBoxFreq2.Name = "textBoxFreq2";
            this.textBoxFreq2.Size = new System.Drawing.Size(75, 20);
            this.textBoxFreq2.TabIndex = 33;
            // 
            // buttonOff2
            // 
            this.buttonOff2.Location = new System.Drawing.Point(135, 195);
            this.buttonOff2.Name = "buttonOff2";
            this.buttonOff2.Size = new System.Drawing.Size(75, 23);
            this.buttonOff2.TabIndex = 32;
            this.buttonOff2.Text = "OFF";
            this.buttonOff2.UseVisualStyleBackColor = true;
            // 
            // buttonOn2
            // 
            this.buttonOn2.Location = new System.Drawing.Point(38, 195);
            this.buttonOn2.Name = "buttonOn2";
            this.buttonOn2.Size = new System.Drawing.Size(75, 23);
            this.buttonOn2.TabIndex = 31;
            this.buttonOn2.Text = "ON";
            this.buttonOn2.UseVisualStyleBackColor = true;
            // 
            // buttonFreq1
            // 
            this.buttonFreq1.Location = new System.Drawing.Point(135, 144);
            this.buttonFreq1.Name = "buttonFreq1";
            this.buttonFreq1.Size = new System.Drawing.Size(75, 23);
            this.buttonFreq1.TabIndex = 30;
            this.buttonFreq1.Text = "send freq";
            this.buttonFreq1.UseVisualStyleBackColor = true;
            // 
            // textBoxFreq1
            // 
            this.textBoxFreq1.Location = new System.Drawing.Point(38, 144);
            this.textBoxFreq1.Name = "textBoxFreq1";
            this.textBoxFreq1.Size = new System.Drawing.Size(75, 20);
            this.textBoxFreq1.TabIndex = 29;
            // 
            // buttonOff1
            // 
            this.buttonOff1.Location = new System.Drawing.Point(135, 86);
            this.buttonOff1.Name = "buttonOff1";
            this.buttonOff1.Size = new System.Drawing.Size(75, 23);
            this.buttonOff1.TabIndex = 28;
            this.buttonOff1.Text = "OFF";
            this.buttonOff1.UseVisualStyleBackColor = true;
            // 
            // buttonOn1
            // 
            this.buttonOn1.Location = new System.Drawing.Point(38, 86);
            this.buttonOn1.Name = "buttonOn1";
            this.buttonOn1.Size = new System.Drawing.Size(75, 23);
            this.buttonOn1.TabIndex = 27;
            this.buttonOn1.Text = "ON";
            this.buttonOn1.UseVisualStyleBackColor = true;
            // 
            // btn_send
            // 
            this.btn_send.Location = new System.Drawing.Point(28, 359);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(75, 23);
            this.btn_send.TabIndex = 26;
            this.btn_send.Text = "send";
            this.btn_send.UseVisualStyleBackColor = true;
            // 
            // textBoxSend
            // 
            this.textBoxSend.Location = new System.Drawing.Point(28, 290);
            this.textBoxSend.Multiline = true;
            this.textBoxSend.Name = "textBoxSend";
            this.textBoxSend.Size = new System.Drawing.Size(186, 63);
            this.textBoxSend.TabIndex = 25;
            // 
            // textBoxRead
            // 
            this.textBoxRead.Location = new System.Drawing.Point(342, 52);
            this.textBoxRead.Multiline = true;
            this.textBoxRead.Name = "textBoxRead";
            this.textBoxRead.ReadOnly = true;
            this.textBoxRead.Size = new System.Drawing.Size(298, 277);
            this.textBoxRead.TabIndex = 24;
            // 
            // btn_close
            // 
            this.btn_close.Enabled = false;
            this.btn_close.Location = new System.Drawing.Point(227, 59);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 23);
            this.btn_close.TabIndex = 23;
            this.btn_close.Text = "Close Port";
            this.btn_close.UseVisualStyleBackColor = true;
            // 
            // btn_open
            // 
            this.btn_open.Location = new System.Drawing.Point(227, 30);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(75, 23);
            this.btn_open.TabIndex = 22;
            this.btn_open.Text = "Open Port";
            this.btn_open.UseVisualStyleBackColor = true;
            // 
            // comboBoxSerial
            // 
            this.comboBoxSerial.FormattingEnabled = true;
            this.comboBoxSerial.Location = new System.Drawing.Point(38, 30);
            this.comboBoxSerial.Name = "comboBoxSerial";
            this.comboBoxSerial.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSerial.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 404);
            this.Controls.Add(this.buttonPortRefresh);
            this.Controls.Add(this.buttonFreq2);
            this.Controls.Add(this.textBoxFreq2);
            this.Controls.Add(this.buttonOff2);
            this.Controls.Add(this.buttonOn2);
            this.Controls.Add(this.buttonFreq1);
            this.Controls.Add(this.textBoxFreq1);
            this.Controls.Add(this.buttonOff1);
            this.Controls.Add(this.buttonOn1);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.textBoxSend);
            this.Controls.Add(this.textBoxRead);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_open);
            this.Controls.Add(this.comboBoxSerial);
            this.Name = "Form1";
            this.Text = "Serial control";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPortRefresh;
        private System.Windows.Forms.Button buttonFreq2;
        private System.Windows.Forms.TextBox textBoxFreq2;
        private System.Windows.Forms.Button buttonOff2;
        private System.Windows.Forms.Button buttonOn2;
        private System.Windows.Forms.Button buttonFreq1;
        private System.Windows.Forms.TextBox textBoxFreq1;
        private System.Windows.Forms.Button buttonOff1;
        private System.Windows.Forms.Button buttonOn1;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.TextBox textBoxSend;
        private System.Windows.Forms.TextBox textBoxRead;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_open;
        private System.Windows.Forms.ComboBox comboBoxSerial;
    }
}

