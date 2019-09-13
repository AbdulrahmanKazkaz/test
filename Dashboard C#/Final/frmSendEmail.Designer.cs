namespace Final
{
    partial class frmSendEmail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSendEmail));
            this.labClose = new System.Windows.Forms.Label();
            this.bunifuSeparator5 = new Bunifu.Framework.UI.BunifuSeparator();
            this.txtUserEmail = new System.Windows.Forms.TextBox();
            this.labSucssess = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.btnSend = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // labClose
            // 
            this.labClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.labClose.ForeColor = System.Drawing.Color.White;
            this.labClose.Location = new System.Drawing.Point(35, 403);
            this.labClose.Name = "labClose";
            this.labClose.Size = new System.Drawing.Size(210, 23);
            this.labClose.TabIndex = 40;
            this.labClose.Text = "Go Back";
            this.labClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labClose.Click += new System.EventHandler(this.labClose_Click);
            // 
            // bunifuSeparator5
            // 
            this.bunifuSeparator5.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator5.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuSeparator5.LineThickness = 2;
            this.bunifuSeparator5.Location = new System.Drawing.Point(49, 247);
            this.bunifuSeparator5.Name = "bunifuSeparator5";
            this.bunifuSeparator5.Size = new System.Drawing.Size(210, 3);
            this.bunifuSeparator5.TabIndex = 43;
            this.bunifuSeparator5.Transparency = 255;
            this.bunifuSeparator5.Vertical = false;
            // 
            // txtUserEmail
            // 
            this.txtUserEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(239)))));
            this.txtUserEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUserEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtUserEmail.ForeColor = System.Drawing.Color.White;
            this.txtUserEmail.Location = new System.Drawing.Point(50, 222);
            this.txtUserEmail.Multiline = true;
            this.txtUserEmail.Name = "txtUserEmail";
            this.txtUserEmail.Size = new System.Drawing.Size(209, 22);
            this.txtUserEmail.TabIndex = 41;
            this.txtUserEmail.Text = "Username";
            this.txtUserEmail.Click += new System.EventHandler(this.txtUserEmail_Click);
            this.txtUserEmail.Enter += new System.EventHandler(this.Enter1);
            this.txtUserEmail.Leave += new System.EventHandler(this.Leave1);
            // 
            // labSucssess
            // 
            this.labSucssess.AutoSize = true;
            this.labSucssess.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSucssess.ForeColor = System.Drawing.Color.White;
            this.labSucssess.Location = new System.Drawing.Point(68, 358);
            this.labSucssess.Name = "labSucssess";
            this.labSucssess.Size = new System.Drawing.Size(0, 25);
            this.labSucssess.TabIndex = 42;
            this.labSucssess.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picLogo
            // 
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(67, 12);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(165, 148);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picLogo.TabIndex = 44;
            this.picLogo.TabStop = false;
            // 
            // btnSend
            // 
            this.btnSend.ActiveBorderThickness = 1;
            this.btnSend.ActiveCornerRadius = 30;
            this.btnSend.ActiveFillColor = System.Drawing.Color.White;
            this.btnSend.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(239)))));
            this.btnSend.ActiveLineColor = System.Drawing.Color.White;
            this.btnSend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(239)))));
            this.btnSend.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSend.BackgroundImage")));
            this.btnSend.ButtonText = "Send Email";
            this.btnSend.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSend.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnSend.IdleBorderThickness = 1;
            this.btnSend.IdleCornerRadius = 30;
            this.btnSend.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(239)))));
            this.btnSend.IdleForecolor = System.Drawing.Color.White;
            this.btnSend.IdleLineColor = System.Drawing.Color.White;
            this.btnSend.Location = new System.Drawing.Point(49, 281);
            this.btnSend.Margin = new System.Windows.Forms.Padding(4);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(196, 52);
            this.btnSend.TabIndex = 39;
            this.btnSend.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // frmSendEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(324, 442);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.labClose);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.bunifuSeparator5);
            this.Controls.Add(this.txtUserEmail);
            this.Controls.Add(this.labSucssess);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSendEmail";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSendEmail";
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label labClose;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSend;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator5;
        private System.Windows.Forms.TextBox txtUserEmail;
        private System.Windows.Forms.Label labSucssess;
    }
}