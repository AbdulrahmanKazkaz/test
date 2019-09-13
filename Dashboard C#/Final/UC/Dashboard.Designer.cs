namespace Final.UC
{
    partial class Dashboard
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.btnStart = new System.Windows.Forms.Button();
            this.lbl12 = new System.Windows.Forms.Label();
            this.lblGaz = new System.Windows.Forms.Label();
            this.lbl11 = new System.Windows.Forms.Label();
            this.barG = new Bunifu.Framework.UI.BunifuProgressBar();
            this.lblTemp = new System.Windows.Forms.Label();
            this.lblHumidity = new System.Windows.Forms.Label();
            this.lbl10 = new System.Windows.Forms.Label();
            this.barH = new Bunifu.Framework.UI.BunifuProgressBar();
            this.barT = new Bunifu.Framework.UI.BunifuProgressBar();
            this.lbl9 = new System.Windows.Forms.Label();
            this.lbl8 = new System.Windows.Forms.Label();
            this.lbl7 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.comSerialCom = new System.Windows.Forms.ComboBox();
            this.lbl13 = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.btnRefresh = new System.Windows.Forms.Button();
            this.Buttons = new System.Windows.Forms.Panel();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl14 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.swPlan1 = new Bunifu.Framework.UI.BunifuiOSSwitch();
            this.swClean = new Bunifu.Framework.UI.BunifuiOSSwitch();
            this.swMix = new Bunifu.Framework.UI.BunifuiOSSwitch();
            this.piclevelWater = new System.Windows.Forms.PictureBox();
            this.circleG = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.circleT = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.circleH = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.Buttons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.piclevelWater)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(578, 515);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(79, 29);
            this.btnStart.TabIndex = 95;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lbl12
            // 
            this.lbl12.AutoSize = true;
            this.lbl12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl12.Location = new System.Drawing.Point(439, 319);
            this.lbl12.Name = "lbl12";
            this.lbl12.Size = new System.Drawing.Size(102, 20);
            this.lbl12.TabIndex = 91;
            this.lbl12.Text = "Gaz Flag  = ";
            // 
            // lblGaz
            // 
            this.lblGaz.AutoSize = true;
            this.lblGaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGaz.Location = new System.Drawing.Point(537, 321);
            this.lblGaz.Name = "lblGaz";
            this.lblGaz.Size = new System.Drawing.Size(114, 16);
            this.lblGaz.TabIndex = 94;
            this.lblGaz.Text = "No Gaz Detected ";
            // 
            // lbl11
            // 
            this.lbl11.AutoSize = true;
            this.lbl11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl11.Location = new System.Drawing.Point(443, 288);
            this.lbl11.Name = "lbl11";
            this.lbl11.Size = new System.Drawing.Size(129, 20);
            this.lbl11.TabIndex = 89;
            this.lbl11.Text = "Temperature  = ";
            // 
            // barG
            // 
            this.barG.BackColor = System.Drawing.Color.Gainsboro;
            this.barG.BorderRadius = 7;
            this.barG.Location = new System.Drawing.Point(53, 319);
            this.barG.MaximumValue = 100;
            this.barG.Name = "barG";
            this.barG.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(146)))), ((int)(((byte)(108)))));
            this.barG.Size = new System.Drawing.Size(365, 12);
            this.barG.TabIndex = 87;
            this.barG.Value = 0;
            // 
            // lblTemp
            // 
            this.lblTemp.AutoSize = true;
            this.lblTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemp.Location = new System.Drawing.Point(574, 288);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(44, 20);
            this.lblTemp.TabIndex = 92;
            this.lblTemp.Text = "30 C";
            // 
            // lblHumidity
            // 
            this.lblHumidity.AutoSize = true;
            this.lblHumidity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHumidity.Location = new System.Drawing.Point(568, 254);
            this.lblHumidity.Name = "lblHumidity";
            this.lblHumidity.Size = new System.Drawing.Size(47, 20);
            this.lblHumidity.TabIndex = 93;
            this.lblHumidity.Text = "40 %";
            // 
            // lbl10
            // 
            this.lbl10.AutoSize = true;
            this.lbl10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl10.Location = new System.Drawing.Point(443, 254);
            this.lbl10.Name = "lbl10";
            this.lbl10.Size = new System.Drawing.Size(105, 20);
            this.lbl10.TabIndex = 90;
            this.lbl10.Text = "Humidity   = ";
            // 
            // barH
            // 
            this.barH.BackColor = System.Drawing.Color.Gainsboro;
            this.barH.BorderRadius = 7;
            this.barH.Location = new System.Drawing.Point(53, 254);
            this.barH.MaximumValue = 100;
            this.barH.Name = "barH";
            this.barH.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(48)))), ((int)(((byte)(93)))));
            this.barH.Size = new System.Drawing.Size(365, 12);
            this.barH.TabIndex = 88;
            this.barH.Value = 40;
            // 
            // barT
            // 
            this.barT.BackColor = System.Drawing.Color.Gainsboro;
            this.barT.BorderRadius = 7;
            this.barT.Location = new System.Drawing.Point(53, 288);
            this.barT.MaximumValue = 100;
            this.barT.Name = "barT";
            this.barT.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(155)))), ((int)(((byte)(45)))));
            this.barT.Size = new System.Drawing.Size(365, 12);
            this.barT.TabIndex = 86;
            this.barT.Value = 18;
            // 
            // lbl9
            // 
            this.lbl9.AutoSize = true;
            this.lbl9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl9.Location = new System.Drawing.Point(493, 21);
            this.lbl9.Name = "lbl9";
            this.lbl9.Size = new System.Drawing.Size(40, 20);
            this.lbl9.TabIndex = 84;
            this.lbl9.Text = "Gaz";
            // 
            // lbl8
            // 
            this.lbl8.AutoSize = true;
            this.lbl8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl8.Location = new System.Drawing.Point(289, 21);
            this.lbl8.Name = "lbl8";
            this.lbl8.Size = new System.Drawing.Size(104, 20);
            this.lbl8.TabIndex = 75;
            this.lbl8.Text = "Temperature";
            // 
            // lbl7
            // 
            this.lbl7.AutoSize = true;
            this.lbl7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl7.Location = new System.Drawing.Point(116, 21);
            this.lbl7.Name = "lbl7";
            this.lbl7.Size = new System.Drawing.Size(75, 20);
            this.lbl7.TabIndex = 76;
            this.lbl7.Text = "Humidity";
            // 
            // timer1
            // 
            this.timer1.Interval = 1500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // comSerialCom
            // 
            this.comSerialCom.FormattingEnabled = true;
            this.comSerialCom.Location = new System.Drawing.Point(435, 520);
            this.comSerialCom.Name = "comSerialCom";
            this.comSerialCom.Size = new System.Drawing.Size(61, 21);
            this.comSerialCom.TabIndex = 97;
            // 
            // lbl13
            // 
            this.lbl13.AutoSize = true;
            this.lbl13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl13.Location = new System.Drawing.Point(346, 521);
            this.lbl13.Name = "lbl13";
            this.lbl13.Size = new System.Drawing.Size(90, 20);
            this.lbl13.TabIndex = 96;
            this.lbl13.Text = "SerialCom :";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(505, 519);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(61, 23);
            this.btnRefresh.TabIndex = 98;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // Buttons
            // 
            this.Buttons.Controls.Add(this.lbl1);
            this.Buttons.Controls.Add(this.lbl14);
            this.Buttons.Controls.Add(this.lbl4);
            this.Buttons.Controls.Add(this.swPlan1);
            this.Buttons.Controls.Add(this.swClean);
            this.Buttons.Controls.Add(this.swMix);
            this.Buttons.Location = new System.Drawing.Point(456, 361);
            this.Buttons.Name = "Buttons";
            this.Buttons.Size = new System.Drawing.Size(195, 114);
            this.Buttons.TabIndex = 99;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl1.Location = new System.Drawing.Point(123, 84);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(57, 20);
            this.lbl1.TabIndex = 95;
            this.lbl1.Text = "التنظيف";
            // 
            // lbl14
            // 
            this.lbl14.AutoSize = true;
            this.lbl14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl14.Location = new System.Drawing.Point(138, 15);
            this.lbl14.Name = "lbl14";
            this.lbl14.Size = new System.Drawing.Size(42, 20);
            this.lbl14.TabIndex = 94;
            this.lbl14.Text = "المزج";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl4.Location = new System.Drawing.Point(89, 50);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(91, 20);
            this.lbl4.TabIndex = 93;
            this.lbl4.Text = "الخلطة الاولى";
            // 
            // swPlan1
            // 
            this.swPlan1.BackColor = System.Drawing.Color.Transparent;
            this.swPlan1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("swPlan1.BackgroundImage")));
            this.swPlan1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.swPlan1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.swPlan1.Location = new System.Drawing.Point(10, 50);
            this.swPlan1.Name = "swPlan1";
            this.swPlan1.OffColor = System.Drawing.Color.Silver;
            this.swPlan1.OnColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(146)))), ((int)(((byte)(108)))));
            this.swPlan1.Size = new System.Drawing.Size(35, 20);
            this.swPlan1.TabIndex = 89;
            this.swPlan1.Value = false;
            this.swPlan1.OnValueChange += new System.EventHandler(this.swPlan1_OnValueChange);
            this.swPlan1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.swPlan1_MouseClick);
            // 
            // swClean
            // 
            this.swClean.BackColor = System.Drawing.Color.Transparent;
            this.swClean.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("swClean.BackgroundImage")));
            this.swClean.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.swClean.Cursor = System.Windows.Forms.Cursors.Hand;
            this.swClean.Location = new System.Drawing.Point(10, 84);
            this.swClean.Name = "swClean";
            this.swClean.OffColor = System.Drawing.Color.Silver;
            this.swClean.OnColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(146)))), ((int)(((byte)(108)))));
            this.swClean.Size = new System.Drawing.Size(35, 20);
            this.swClean.TabIndex = 87;
            this.swClean.Value = false;
            this.swClean.OnValueChange += new System.EventHandler(this.swClean_OnValueChange);
            this.swClean.MouseClick += new System.Windows.Forms.MouseEventHandler(this.swClean_MouseClick);
            // 
            // swMix
            // 
            this.swMix.BackColor = System.Drawing.Color.Transparent;
            this.swMix.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("swMix.BackgroundImage")));
            this.swMix.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.swMix.Cursor = System.Windows.Forms.Cursors.Hand;
            this.swMix.Location = new System.Drawing.Point(10, 15);
            this.swMix.Name = "swMix";
            this.swMix.OffColor = System.Drawing.Color.Silver;
            this.swMix.OnColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(146)))), ((int)(((byte)(108)))));
            this.swMix.Size = new System.Drawing.Size(35, 20);
            this.swMix.TabIndex = 88;
            this.swMix.Value = false;
            this.swMix.OnValueChange += new System.EventHandler(this.swMix_OnValueChange);
            this.swMix.MouseClick += new System.Windows.Forms.MouseEventHandler(this.swMix_MouseClick);
            // 
            // piclevelWater
            // 
            this.piclevelWater.Image = global::Final.Properties.Resources.full;
            this.piclevelWater.Location = new System.Drawing.Point(21, 348);
            this.piclevelWater.Name = "piclevelWater";
            this.piclevelWater.Size = new System.Drawing.Size(317, 193);
            this.piclevelWater.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.piclevelWater.TabIndex = 100;
            this.piclevelWater.TabStop = false;
            // 
            // circleG
            // 
            this.circleG.animated = false;
            this.circleG.animationIterval = 5;
            this.circleG.animationSpeed = 300;
            this.circleG.BackColor = System.Drawing.Color.Transparent;
            this.circleG.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("circleG.BackgroundImage")));
            this.circleG.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.circleG.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(146)))), ((int)(((byte)(108)))));
            this.circleG.LabelVisible = true;
            this.circleG.LineProgressThickness = 10;
            this.circleG.LineThickness = 2;
            this.circleG.Location = new System.Drawing.Point(428, 48);
            this.circleG.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.circleG.MaxValue = 100;
            this.circleG.Name = "circleG";
            this.circleG.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.circleG.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(146)))), ((int)(((byte)(108)))));
            this.circleG.Size = new System.Drawing.Size(166, 166);
            this.circleG.TabIndex = 69;
            this.circleG.Value = 0;
            // 
            // circleT
            // 
            this.circleT.animated = false;
            this.circleT.animationIterval = 5;
            this.circleT.animationSpeed = 300;
            this.circleT.BackColor = System.Drawing.Color.Transparent;
            this.circleT.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("circleT.BackgroundImage")));
            this.circleT.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.circleT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(155)))), ((int)(((byte)(45)))));
            this.circleT.LabelVisible = true;
            this.circleT.LineProgressThickness = 10;
            this.circleT.LineThickness = 2;
            this.circleT.Location = new System.Drawing.Point(252, 48);
            this.circleT.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.circleT.MaxValue = 100;
            this.circleT.Name = "circleT";
            this.circleT.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.circleT.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(155)))), ((int)(((byte)(45)))));
            this.circleT.Size = new System.Drawing.Size(166, 166);
            this.circleT.TabIndex = 70;
            this.circleT.Value = 18;
            // 
            // circleH
            // 
            this.circleH.animated = false;
            this.circleH.animationIterval = 5;
            this.circleH.animationSpeed = 300;
            this.circleH.BackColor = System.Drawing.Color.Transparent;
            this.circleH.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("circleH.BackgroundImage")));
            this.circleH.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.circleH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(48)))), ((int)(((byte)(93)))));
            this.circleH.LabelVisible = true;
            this.circleH.LineProgressThickness = 10;
            this.circleH.LineThickness = 2;
            this.circleH.Location = new System.Drawing.Point(70, 48);
            this.circleH.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.circleH.MaxValue = 100;
            this.circleH.Name = "circleH";
            this.circleH.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.circleH.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(48)))), ((int)(((byte)(93)))));
            this.circleH.Size = new System.Drawing.Size(166, 166);
            this.circleH.TabIndex = 71;
            this.circleH.Value = 40;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.piclevelWater);
            this.Controls.Add(this.Buttons);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.comSerialCom);
            this.Controls.Add(this.lbl13);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lbl12);
            this.Controls.Add(this.lblGaz);
            this.Controls.Add(this.lbl11);
            this.Controls.Add(this.barG);
            this.Controls.Add(this.lblTemp);
            this.Controls.Add(this.lblHumidity);
            this.Controls.Add(this.circleG);
            this.Controls.Add(this.circleT);
            this.Controls.Add(this.lbl10);
            this.Controls.Add(this.barH);
            this.Controls.Add(this.circleH);
            this.Controls.Add(this.barT);
            this.Controls.Add(this.lbl9);
            this.Controls.Add(this.lbl8);
            this.Controls.Add(this.lbl7);
            this.Name = "Dashboard";
            this.Size = new System.Drawing.Size(659, 546);
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.Buttons.ResumeLayout(false);
            this.Buttons.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.piclevelWater)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lbl12;
        private System.Windows.Forms.Label lblGaz;
        private System.Windows.Forms.Label lbl11;
        private Bunifu.Framework.UI.BunifuProgressBar barG;
        private System.Windows.Forms.Label lblTemp;
        private System.Windows.Forms.Label lblHumidity;
        private Bunifu.Framework.UI.BunifuCircleProgressbar circleG;
        private Bunifu.Framework.UI.BunifuCircleProgressbar circleT;
        private System.Windows.Forms.Label lbl10;
        private Bunifu.Framework.UI.BunifuProgressBar barH;
        private Bunifu.Framework.UI.BunifuCircleProgressbar circleH;
        private Bunifu.Framework.UI.BunifuProgressBar barT;
        private System.Windows.Forms.Label lbl9;
        private System.Windows.Forms.Label lbl8;
        private System.Windows.Forms.Label lbl7;
        private System.Windows.Forms.ComboBox comSerialCom;
        private System.Windows.Forms.Label lbl13;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Panel Buttons;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl14;
        private System.Windows.Forms.Label lbl4;
        private Bunifu.Framework.UI.BunifuiOSSwitch swPlan1;
        private Bunifu.Framework.UI.BunifuiOSSwitch swClean;
        private Bunifu.Framework.UI.BunifuiOSSwitch swMix;
        private System.Windows.Forms.PictureBox piclevelWater;
        private System.Windows.Forms.Timer timer1;
    }
}
