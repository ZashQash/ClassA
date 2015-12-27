namespace Client_GUI
{
    partial class FrmClient
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
            this.txtbIP = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtbSend = new System.Windows.Forms.TextBox();
            this.lstbDispaly = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtbIP
            // 
            this.txtbIP.Location = new System.Drawing.Point(12, 13);
            this.txtbIP.Name = "txtbIP";
            this.txtbIP.Size = new System.Drawing.Size(179, 20);
            this.txtbIP.TabIndex = 0;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(197, 10);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(63, 23);
            this.btnConnect.TabIndex = 1;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(209, 198);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(51, 23);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtbSend
            // 
            this.txtbSend.Location = new System.Drawing.Point(12, 201);
            this.txtbSend.Name = "txtbSend";
            this.txtbSend.Size = new System.Drawing.Size(191, 20);
            this.txtbSend.TabIndex = 3;
            // 
            // lstbDispaly
            // 
            this.lstbDispaly.FormattingEnabled = true;
            this.lstbDispaly.Location = new System.Drawing.Point(12, 39);
            this.lstbDispaly.Name = "lstbDispaly";
            this.lstbDispaly.Size = new System.Drawing.Size(248, 147);
            this.lstbDispaly.TabIndex = 4;
            // 
            // FrmClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 226);
            this.Controls.Add(this.lstbDispaly);
            this.Controls.Add(this.txtbSend);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.txtbIP);
            this.Name = "FrmClient";
            this.Text = "Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbIP;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtbSend;
        private System.Windows.Forms.ListBox lstbDispaly;
    }
}

