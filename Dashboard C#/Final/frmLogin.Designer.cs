namespace Final
{
    partial class frmLogin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.doubleBitmapControl1 = new BunifuAnimatorNS.DoubleBitmapControl();
            this.labError = new System.Windows.Forms.Label();
            this.slidePass = new Bunifu.Framework.UI.BunifuSeparator();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.slideUser = new Bunifu.Framework.UI.BunifuSeparator();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.btnPassword = new System.Windows.Forms.Label();
            this.labExit = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.picLock = new System.Windows.Forms.PictureBox();
            this.btnLogin = new Bunifu.Framework.UI.BunifuThinButton2();
            this.picLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picLock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // doubleBitmapControl1
            // 
            this.doubleBitmapControl1.Location = new System.Drawing.Point(91, 141);
            this.doubleBitmapControl1.Name = "doubleBitmapControl1";
            this.doubleBitmapControl1.Size = new System.Drawing.Size(75, 23);
            this.doubleBitmapControl1.TabIndex = 0;
            this.doubleBitmapControl1.Text = "doubleBitmapControl1";
            this.doubleBitmapControl1.Visible = false;
            // 
            // labError
            // 
            this.labError.AutoSize = true;
            this.labError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(239)))));
            this.labError.Location = new System.Drawing.Point(56, 300);
            this.labError.Name = "labError";
            this.labError.Size = new System.Drawing.Size(0, 20);
            this.labError.TabIndex = 46;
            // 
            // slidePass
            // 
            this.slidePass.BackColor = System.Drawing.Color.Transparent;
            this.slidePass.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.slidePass.LineThickness = 2;
            this.slidePass.Location = new System.Drawing.Point(48, 277);
            this.slidePass.Name = "slidePass";
            this.slidePass.Size = new System.Drawing.Size(210, 3);
            this.slidePass.TabIndex = 44;
            this.slidePass.Transparency = 100;
            this.slidePass.Vertical = false;
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtPassword.ForeColor = System.Drawing.Color.Gray;
            this.txtPassword.Location = new System.Drawing.Point(49, 252);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(209, 22);
            this.txtPassword.TabIndex = 40;
            this.txtPassword.Text = "Password";
            this.txtPassword.Enter += new System.EventHandler(this.Enter2);
            this.txtPassword.Leave += new System.EventHandler(this.Leave2);
            // 
            // slideUser
            // 
            this.slideUser.BackColor = System.Drawing.Color.Transparent;
            this.slideUser.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.slideUser.LineThickness = 2;
            this.slideUser.Location = new System.Drawing.Point(49, 228);
            this.slideUser.Name = "slideUser";
            this.slideUser.Size = new System.Drawing.Size(210, 3);
            this.slideUser.TabIndex = 43;
            this.slideUser.Transparency = 100;
            this.slideUser.Vertical = false;
            // 
            // txtUser
            // 
            this.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtUser.ForeColor = System.Drawing.Color.Gray;
            this.txtUser.Location = new System.Drawing.Point(50, 203);
            this.txtUser.Multiline = true;
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(209, 22);
            this.txtUser.TabIndex = 39;
            this.txtUser.Text = "Username";
            this.txtUser.Enter += new System.EventHandler(this.Enter1);
            this.txtUser.Leave += new System.EventHandler(this.Leave1);
            // 
            // btnPassword
            // 
            this.btnPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnPassword.ForeColor = System.Drawing.Color.DarkGray;
            this.btnPassword.Location = new System.Drawing.Point(47, 396);
            this.btnPassword.Name = "btnPassword";
            this.btnPassword.Size = new System.Drawing.Size(210, 23);
            this.btnPassword.TabIndex = 38;
            this.btnPassword.Text = "Forgot the password?";
            this.btnPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPassword.Click += new System.EventHandler(this.btnPassword_Click);
            // 
            // labExit
            // 
            this.labExit.AutoSize = true;
            this.labExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(239)))));
            this.labExit.Location = new System.Drawing.Point(285, 9);
            this.labExit.Name = "labExit";
            this.labExit.Size = new System.Drawing.Size(27, 25);
            this.labExit.TabIndex = 42;
            this.labExit.Text = "X";
            this.labExit.Click += new System.EventHandler(this.labExit_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 10;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // picLock
            // 
            this.picLock.Image = global::Final.Properties.Resources._lock;
            this.picLock.Location = new System.Drawing.Point(266, 259);
            this.picLock.Name = "picLock";
            this.picLock.Size = new System.Drawing.Size(17, 17);
            this.picLock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLock.TabIndex = 45;
            this.picLock.TabStop = false;
            this.picLock.Click += new System.EventHandler(this.picLock_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.ActiveBorderThickness = 1;
            this.btnLogin.ActiveCornerRadius = 30;
            this.btnLogin.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(239)))));
            this.btnLogin.ActiveForecolor = System.Drawing.Color.White;
            this.btnLogin.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(239)))));
            this.btnLogin.BackColor = System.Drawing.Color.White;
            this.btnLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogin.BackgroundImage")));
            this.btnLogin.ButtonText = "Login";
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnLogin.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnLogin.IdleBorderThickness = 1;
            this.btnLogin.IdleCornerRadius = 30;
            this.btnLogin.IdleFillColor = System.Drawing.Color.White;
            this.btnLogin.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(239)))));
            this.btnLogin.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(239)))));
            this.btnLogin.Location = new System.Drawing.Point(50, 332);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(212, 47);
            this.btnLogin.TabIndex = 37;
            this.btnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // picLogo
            // 
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(78, 16);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(165, 148);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picLogo.TabIndex = 41;
            this.picLogo.TabStop = false;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(324, 442);
            this.Controls.Add(this.labError);
            this.Controls.Add(this.picLock);
            this.Controls.Add(this.slidePass);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.slideUser);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.btnPassword);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.labExit);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.doubleBitmapControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLogin";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picLock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BunifuAnimatorNS.DoubleBitmapControl doubleBitmapControl1;
        private System.Windows.Forms.Label labError;
        private System.Windows.Forms.PictureBox picLock;
        private Bunifu.Framework.UI.BunifuSeparator slidePass;
        private System.Windows.Forms.TextBox txtPassword;
        private Bunifu.Framework.UI.BunifuSeparator slideUser;
        public System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label btnPassword;
        private Bunifu.Framework.UI.BunifuThinButton2 btnLogin;
        private System.Windows.Forms.Label labExit;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}