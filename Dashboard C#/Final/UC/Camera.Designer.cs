namespace Final.UC
{
    partial class Camera
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblCameraDevices = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.comDevices = new System.Windows.Forms.ComboBox();
            this.comResolution = new System.Windows.Forms.ComboBox();
            this.lblResolutions = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnStart = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnStop = new Bunifu.Framework.UI.BunifuFlatButton();
            this.picImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCameraDevices
            // 
            this.lblCameraDevices.AutoSize = true;
            this.lblCameraDevices.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCameraDevices.Location = new System.Drawing.Point(171, 17);
            this.lblCameraDevices.Name = "lblCameraDevices";
            this.lblCameraDevices.Size = new System.Drawing.Size(119, 18);
            this.lblCameraDevices.TabIndex = 2;
            this.lblCameraDevices.Text = "Camera Devices:";
            // 
            // comDevices
            // 
            this.comDevices.FormattingEnabled = true;
            this.comDevices.Location = new System.Drawing.Point(291, 17);
            this.comDevices.Name = "comDevices";
            this.comDevices.Size = new System.Drawing.Size(121, 21);
            this.comDevices.TabIndex = 3;
            this.comDevices.SelectedIndexChanged += new System.EventHandler(this.comDevices_SelectedIndexChanged);
            // 
            // comResolution
            // 
            this.comResolution.FormattingEnabled = true;
            this.comResolution.Location = new System.Drawing.Point(508, 17);
            this.comResolution.Name = "comResolution";
            this.comResolution.Size = new System.Drawing.Size(147, 21);
            this.comResolution.TabIndex = 5;
            // 
            // lblResolutions
            // 
            this.lblResolutions.AutoSize = true;
            this.lblResolutions.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResolutions.Location = new System.Drawing.Point(422, 18);
            this.lblResolutions.Name = "lblResolutions";
            this.lblResolutions.Size = new System.Drawing.Size(85, 18);
            this.lblResolutions.TabIndex = 4;
            this.lblResolutions.Text = "Resolutions:";
            // 
            // btnStart
            // 
            this.btnStart.Activecolor = System.Drawing.Color.Lime;
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStart.BorderRadius = 7;
            this.btnStart.ButtonText = "     Start";
            this.btnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStart.DisabledColor = System.Drawing.Color.Gray;
            this.btnStart.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnStart.Iconcolor = System.Drawing.Color.Transparent;
            this.btnStart.Iconimage = null;
            this.btnStart.Iconimage_right = null;
            this.btnStart.Iconimage_right_Selected = null;
            this.btnStart.Iconimage_Selected = null;
            this.btnStart.IconMarginLeft = 0;
            this.btnStart.IconMarginRight = 0;
            this.btnStart.IconRightVisible = true;
            this.btnStart.IconRightZoom = 0D;
            this.btnStart.IconVisible = true;
            this.btnStart.IconZoom = 90D;
            this.btnStart.IsTab = false;
            this.btnStart.Location = new System.Drawing.Point(17, 9);
            this.btnStart.Name = "btnStart";
            this.btnStart.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnStart.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnStart.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnStart.selected = false;
            this.btnStart.Size = new System.Drawing.Size(71, 35);
            this.btnStart.TabIndex = 7;
            this.btnStart.Text = "     Start";
            this.btnStart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStart.Textcolor = System.Drawing.Color.White;
            this.btnStart.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Activecolor = System.Drawing.Color.Maroon;
            this.btnStop.BackColor = System.Drawing.Color.Red;
            this.btnStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStop.BorderRadius = 7;
            this.btnStop.ButtonText = "     Stop";
            this.btnStop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStop.DisabledColor = System.Drawing.Color.Gray;
            this.btnStop.Iconcolor = System.Drawing.Color.Transparent;
            this.btnStop.Iconimage = null;
            this.btnStop.Iconimage_right = null;
            this.btnStop.Iconimage_right_Selected = null;
            this.btnStop.Iconimage_Selected = null;
            this.btnStop.IconMarginLeft = 0;
            this.btnStop.IconMarginRight = 0;
            this.btnStop.IconRightVisible = true;
            this.btnStop.IconRightZoom = 0D;
            this.btnStop.IconVisible = true;
            this.btnStop.IconZoom = 90D;
            this.btnStop.IsTab = false;
            this.btnStop.Location = new System.Drawing.Point(93, 9);
            this.btnStop.Name = "btnStop";
            this.btnStop.Normalcolor = System.Drawing.Color.Red;
            this.btnStop.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnStop.OnHoverTextColor = System.Drawing.Color.White;
            this.btnStop.selected = false;
            this.btnStop.Size = new System.Drawing.Size(65, 35);
            this.btnStop.TabIndex = 7;
            this.btnStop.Text = "     Stop";
            this.btnStop.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStop.Textcolor = System.Drawing.Color.White;
            this.btnStop.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // picImage
            // 
            this.picImage.BackColor = System.Drawing.Color.WhiteSmoke;
            this.picImage.Location = new System.Drawing.Point(3, 50);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(659, 482);
            this.picImage.TabIndex = 6;
            this.picImage.TabStop = false;
            // 
            // Camera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.picImage);
            this.Controls.Add(this.comResolution);
            this.Controls.Add(this.lblResolutions);
            this.Controls.Add(this.comDevices);
            this.Controls.Add(this.lblCameraDevices);
            this.Name = "Camera";
            this.Size = new System.Drawing.Size(659, 546);
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel lblCameraDevices;
        private System.Windows.Forms.ComboBox comDevices;
        private System.Windows.Forms.ComboBox comResolution;
        private Bunifu.Framework.UI.BunifuCustomLabel lblResolutions;
        private System.Windows.Forms.PictureBox picImage;
        private Bunifu.Framework.UI.BunifuFlatButton btnStart;
        private Bunifu.Framework.UI.BunifuFlatButton btnStop;
    }
}
