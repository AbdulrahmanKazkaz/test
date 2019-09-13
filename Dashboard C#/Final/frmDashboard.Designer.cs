namespace Final
{
    partial class frmDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDashboard));
            this.controlBar = new System.Windows.Forms.Panel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.btnLogout = new Bunifu.Framework.UI.BunifuImageButton();
            this.lblLogo = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblUserLogin = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.saidBar = new System.Windows.Forms.Panel();
            this.lblLastLogin = new System.Windows.Forms.Label();
            this.btnCamera = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnDashboard = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.picUser = new System.Windows.Forms.PictureBox();
            this.body = new System.Windows.Forms.Panel();
            this.dashboard1 = new Final.UC.Dashboard();
            this.camera1 = new Final.UC.Camera();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.controlBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLogout)).BeginInit();
            this.saidBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).BeginInit();
            this.body.SuspendLayout();
            this.SuspendLayout();
            // 
            // controlBar
            // 
            this.controlBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.controlBar.Controls.Add(this.picLogo);
            this.controlBar.Controls.Add(this.btnLogout);
            this.controlBar.Controls.Add(this.lblLogo);
            this.controlBar.Controls.Add(this.lblUserLogin);
            this.controlBar.Controls.Add(this.lblWelcome);
            this.controlBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.controlBar.Location = new System.Drawing.Point(0, 0);
            this.controlBar.Name = "controlBar";
            this.controlBar.Size = new System.Drawing.Size(949, 35);
            this.controlBar.TabIndex = 5;
            // 
            // picLogo
            // 
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(8, 3);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(31, 29);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 1;
            this.picLogo.TabStop = false;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageActive = null;
            this.btnLogout.Location = new System.Drawing.Point(912, 6);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(25, 25);
            this.btnLogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnLogout.TabIndex = 1;
            this.btnLogout.TabStop = false;
            this.btnLogout.Zoom = 50;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            this.lblLogo.Location = new System.Drawing.Point(46, 6);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(177, 25);
            this.lblLogo.TabIndex = 0;
            this.lblLogo.Text = "Mixing Machine";
            // 
            // lblUserLogin
            // 
            this.lblUserLogin.AutoSize = true;
            this.lblUserLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblUserLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserLogin.ForeColor = System.Drawing.Color.Transparent;
            this.lblUserLogin.Location = new System.Drawing.Point(801, 6);
            this.lblUserLogin.Name = "lblUserLogin";
            this.lblUserLogin.Size = new System.Drawing.Size(0, 24);
            this.lblUserLogin.TabIndex = 9;
            this.lblUserLogin.Click += new System.EventHandler(this.lblUserLogin_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            this.lblWelcome.Location = new System.Drawing.Point(747, 6);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(54, 24);
            this.lblWelcome.TabIndex = 9;
            this.lblWelcome.Text = "Hello";
            // 
            // saidBar
            // 
            this.saidBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.saidBar.Controls.Add(this.lblLastLogin);
            this.saidBar.Controls.Add(this.btnCamera);
            this.saidBar.Controls.Add(this.btnDashboard);
            this.saidBar.Controls.Add(this.pictureBox1);
            this.saidBar.Controls.Add(this.pictureBox2);
            this.saidBar.Controls.Add(this.picUser);
            this.saidBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.saidBar.Location = new System.Drawing.Point(0, 35);
            this.saidBar.Name = "saidBar";
            this.saidBar.Size = new System.Drawing.Size(290, 546);
            this.saidBar.TabIndex = 6;
            // 
            // lblLastLogin
            // 
            this.lblLastLogin.AutoSize = true;
            this.lblLastLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.lblLastLogin.Location = new System.Drawing.Point(6, 343);
            this.lblLastLogin.Name = "lblLastLogin";
            this.lblLastLogin.Size = new System.Drawing.Size(0, 18);
            this.lblLastLogin.TabIndex = 3;
            // 
            // btnCamera
            // 
            this.btnCamera.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnCamera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnCamera.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCamera.BorderRadius = 0;
            this.btnCamera.ButtonText = "               Camera";
            this.btnCamera.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCamera.DisabledColor = System.Drawing.Color.Gray;
            this.btnCamera.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCamera.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnCamera.Iconimage")));
            this.btnCamera.Iconimage_right = null;
            this.btnCamera.Iconimage_right_Selected = null;
            this.btnCamera.Iconimage_Selected = null;
            this.btnCamera.IconMarginLeft = 0;
            this.btnCamera.IconMarginRight = 0;
            this.btnCamera.IconRightVisible = true;
            this.btnCamera.IconRightZoom = 0D;
            this.btnCamera.IconVisible = true;
            this.btnCamera.IconZoom = 70D;
            this.btnCamera.IsTab = true;
            this.btnCamera.Location = new System.Drawing.Point(0, 492);
            this.btnCamera.Name = "btnCamera";
            this.btnCamera.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnCamera.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnCamera.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnCamera.selected = false;
            this.btnCamera.Size = new System.Drawing.Size(287, 48);
            this.btnCamera.TabIndex = 2;
            this.btnCamera.Text = "               Camera";
            this.btnCamera.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCamera.Textcolor = System.Drawing.Color.Silver;
            this.btnCamera.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCamera.Click += new System.EventHandler(this.btnCamera_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnDashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDashboard.BorderRadius = 0;
            this.btnDashboard.ButtonText = "            Dashboard";
            this.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDashboard.DisabledColor = System.Drawing.Color.Gray;
            this.btnDashboard.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDashboard.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnDashboard.Iconimage")));
            this.btnDashboard.Iconimage_right = null;
            this.btnDashboard.Iconimage_right_Selected = null;
            this.btnDashboard.Iconimage_Selected = null;
            this.btnDashboard.IconMarginLeft = 0;
            this.btnDashboard.IconMarginRight = 0;
            this.btnDashboard.IconRightVisible = true;
            this.btnDashboard.IconRightZoom = 0D;
            this.btnDashboard.IconVisible = true;
            this.btnDashboard.IconZoom = 70D;
            this.btnDashboard.IsTab = true;
            this.btnDashboard.Location = new System.Drawing.Point(3, 438);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnDashboard.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnDashboard.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnDashboard.selected = true;
            this.btnDashboard.Size = new System.Drawing.Size(287, 48);
            this.btnDashboard.TabIndex = 2;
            this.btnDashboard.Text = "            Dashboard";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Textcolor = System.Drawing.Color.Silver;
            this.btnDashboard.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(31, 174);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(98, 102);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(31, 16);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(192, 109);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // picUser
            // 
            this.picUser.Image = ((System.Drawing.Image)(resources.GetObject("picUser.Image")));
            this.picUser.Location = new System.Drawing.Point(152, 236);
            this.picUser.Name = "picUser";
            this.picUser.Size = new System.Drawing.Size(132, 99);
            this.picUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picUser.TabIndex = 0;
            this.picUser.TabStop = false;
            // 
            // body
            // 
            this.body.BackColor = System.Drawing.Color.White;
            this.body.Controls.Add(this.dashboard1);
            this.body.Controls.Add(this.camera1);
            this.body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.body.Location = new System.Drawing.Point(290, 35);
            this.body.Name = "body";
            this.body.Size = new System.Drawing.Size(659, 546);
            this.body.TabIndex = 7;
            // 
            // dashboard1
            // 
            this.dashboard1.BackColor = System.Drawing.Color.Transparent;
            this.dashboard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dashboard1.Location = new System.Drawing.Point(0, 0);
            this.dashboard1.Name = "dashboard1";
            this.dashboard1.Size = new System.Drawing.Size(659, 546);
            this.dashboard1.Status = false;
            this.dashboard1.TabIndex = 1;
            // 
            // camera1
            // 
            this.camera1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.camera1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.camera1.Location = new System.Drawing.Point(0, 0);
            this.camera1.Name = "camera1";
            this.camera1.Size = new System.Drawing.Size(659, 546);
            this.camera1.TabIndex = 0;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.controlBar;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 10;
            this.bunifuElipse1.TargetControl = this;
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(949, 581);
            this.Controls.Add(this.body);
            this.Controls.Add(this.saidBar);
            this.Controls.Add(this.controlBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDashboard";
            this.Text = "frmTest";
            this.Load += new System.EventHandler(this.frmTest_Load);
            this.controlBar.ResumeLayout(false);
            this.controlBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLogout)).EndInit();
            this.saidBar.ResumeLayout(false);
            this.saidBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).EndInit();
            this.body.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel controlBar;
        private System.Windows.Forms.PictureBox picLogo;
        private Bunifu.Framework.UI.BunifuImageButton btnLogout;
        private Bunifu.Framework.UI.BunifuCustomLabel lblLogo;
        private System.Windows.Forms.Panel saidBar;
        private System.Windows.Forms.Label lblLastLogin;
        private Bunifu.Framework.UI.BunifuFlatButton btnCamera;
        private Bunifu.Framework.UI.BunifuFlatButton btnDashboard;
        private System.Windows.Forms.PictureBox picUser;
        private System.Windows.Forms.Panel body;
        private UC.Dashboard dashboard1;
        private UC.Camera camera1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label lblUserLogin;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;

    }
}