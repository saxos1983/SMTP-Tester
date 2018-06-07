namespace SMTP_Tester
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.tbFrom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbTo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbSubject = new System.Windows.Forms.TextBox();
            this.lblBody = new System.Windows.Forms.Label();
            this.tbBody = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbSMTP = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbPort = new System.Windows.Forms.TextBox();
            this.cbUseSSL = new System.Windows.Forms.CheckBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.tbErrorOutput = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbHelo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "From:";
            // 
            // tbFrom
            // 
            this.tbFrom.Location = new System.Drawing.Point(58, 7);
            this.tbFrom.Name = "tbFrom";
            this.tbFrom.Size = new System.Drawing.Size(214, 20);
            this.tbFrom.TabIndex = 1;
            this.tbFrom.Text = "test@example.com";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "To:";
            // 
            // tbTo
            // 
            this.tbTo.Location = new System.Drawing.Point(58, 33);
            this.tbTo.Name = "tbTo";
            this.tbTo.Size = new System.Drawing.Size(214, 20);
            this.tbTo.TabIndex = 2;
            this.tbTo.Text = "john.doe@acme.com";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Subject:";
            // 
            // tbSubject
            // 
            this.tbSubject.Location = new System.Drawing.Point(58, 59);
            this.tbSubject.Multiline = true;
            this.tbSubject.Name = "tbSubject";
            this.tbSubject.Size = new System.Drawing.Size(214, 20);
            this.tbSubject.TabIndex = 3;
            this.tbSubject.Text = "My Subject";
            // 
            // lblBody
            // 
            this.lblBody.AutoSize = true;
            this.lblBody.Location = new System.Drawing.Point(8, 89);
            this.lblBody.Name = "lblBody";
            this.lblBody.Size = new System.Drawing.Size(34, 13);
            this.lblBody.TabIndex = 0;
            this.lblBody.Text = "Body:";
            // 
            // tbBody
            // 
            this.tbBody.Location = new System.Drawing.Point(58, 86);
            this.tbBody.Multiline = true;
            this.tbBody.Name = "tbBody";
            this.tbBody.Size = new System.Drawing.Size(214, 112);
            this.tbBody.TabIndex = 4;
            this.tbBody.Text = "Message Content";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "SMTP:";
            // 
            // tbSMTP
            // 
            this.tbSMTP.Location = new System.Drawing.Point(58, 204);
            this.tbSMTP.Name = "tbSMTP";
            this.tbSMTP.Size = new System.Drawing.Size(214, 20);
            this.tbSMTP.TabIndex = 5;
            this.tbSMTP.Text = "mail.acme.com";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Port:";
            // 
            // tbPort
            // 
            this.tbPort.Location = new System.Drawing.Point(58, 231);
            this.tbPort.Name = "tbPort";
            this.tbPort.Size = new System.Drawing.Size(41, 20);
            this.tbPort.TabIndex = 6;
            this.tbPort.Text = "25";
            // 
            // cbUseSSL
            // 
            this.cbUseSSL.AutoSize = true;
            this.cbUseSSL.Location = new System.Drawing.Point(127, 233);
            this.cbUseSSL.Name = "cbUseSSL";
            this.cbUseSSL.Size = new System.Drawing.Size(68, 17);
            this.cbUseSSL.TabIndex = 7;
            this.cbUseSSL.Text = "Use SSL";
            this.cbUseSSL.UseVisualStyleBackColor = true;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(11, 339);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(261, 23);
            this.btnSend.TabIndex = 11;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // tbErrorOutput
            // 
            this.tbErrorOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbErrorOutput.Location = new System.Drawing.Point(11, 386);
            this.tbErrorOutput.Multiline = true;
            this.tbErrorOutput.Name = "tbErrorOutput";
            this.tbErrorOutput.ReadOnly = true;
            this.tbErrorOutput.Size = new System.Drawing.Size(260, 141);
            this.tbErrorOutput.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 370);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Output:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 262);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "User:";
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(58, 259);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(214, 20);
            this.tbUsername.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 290);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "PW:";
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(58, 287);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(214, 20);
            this.tbPassword.TabIndex = 9;
            // 
            // tbHelo
            // 
            this.tbHelo.Location = new System.Drawing.Point(58, 313);
            this.tbHelo.Name = "tbHelo";
            this.tbHelo.Size = new System.Drawing.Size(214, 20);
            this.tbHelo.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 316);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "HELO:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 539);
            this.Controls.Add(this.tbHelo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbErrorOutput);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.cbUseSSL);
            this.Controls.Add(this.tbPort);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.tbSMTP);
            this.Controls.Add(this.tbBody);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbSubject);
            this.Controls.Add(this.lblBody);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbTo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbFrom);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(300, 458);
            this.Name = "Form1";
            this.Text = "SMTP Mail Tester";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbFrom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbTo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbSubject;
        private System.Windows.Forms.Label lblBody;
        private System.Windows.Forms.TextBox tbBody;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbSMTP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbPort;
        private System.Windows.Forms.CheckBox cbUseSSL;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox tbErrorOutput;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbHelo;
        private System.Windows.Forms.Label label9;
    }
}

