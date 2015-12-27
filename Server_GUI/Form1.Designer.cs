namespace Server_GUI
{
    partial class frmServer
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
            this.btnListen = new System.Windows.Forms.Button();
            this.lstbDisplay = new System.Windows.Forms.ListBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtbSend = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnListen
            // 
            this.btnListen.Location = new System.Drawing.Point(12, 12);
            this.btnListen.Name = "btnListen";
            this.btnListen.Size = new System.Drawing.Size(196, 23);
            this.btnListen.TabIndex = 0;
            this.btnListen.Text = "Listen";
            this.btnListen.UseVisualStyleBackColor = true;
            this.btnListen.Click += new System.EventHandler(this.btnListen_Click);
            // 
            // lstbDisplay
            // 
            this.lstbDisplay.FormattingEnabled = true;
            this.lstbDisplay.Location = new System.Drawing.Point(12, 41);
            this.lstbDisplay.Name = "lstbDisplay";
            this.lstbDisplay.Size = new System.Drawing.Size(196, 160);
            this.lstbDisplay.TabIndex = 1;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(166, 216);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(42, 23);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtbSend
            // 
            this.txtbSend.Location = new System.Drawing.Point(12, 216);
            this.txtbSend.Name = "txtbSend";
            this.txtbSend.Size = new System.Drawing.Size(148, 20);
            this.txtbSend.TabIndex = 3;
            // 
            // frmServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(220, 248);
            this.Controls.Add(this.txtbSend);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.lstbDisplay);
            this.Controls.Add(this.btnListen);
            this.Name = "frmServer";
            this.Text = "Server";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnListen;
        private System.Windows.Forms.ListBox lstbDisplay;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtbSend;
    }
}

