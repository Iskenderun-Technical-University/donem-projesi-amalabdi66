namespace suaadabdu
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.paneltop = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.ptnmax = new System.Windows.Forms.PictureBox();
            this.ptnmin = new System.Windows.Forms.PictureBox();
            this.btnclose = new System.Windows.Forms.PictureBox();
            this.panlnav = new System.Windows.Forms.Panel();
            this.lb_users = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton5 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton6 = new DevExpress.XtraEditors.SimpleButton();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pancont = new System.Windows.Forms.Panel();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.paneltop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptnmax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptnmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnclose)).BeginInit();
            this.panlnav.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // paneltop
            // 
            this.paneltop.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.paneltop.Controls.Add(this.label1);
            this.paneltop.Controls.Add(this.ptnmax);
            this.paneltop.Controls.Add(this.ptnmin);
            this.paneltop.Controls.Add(this.btnclose);
            this.paneltop.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneltop.Location = new System.Drawing.Point(178, 0);
            this.paneltop.Name = "paneltop";
            this.paneltop.Size = new System.Drawing.Size(753, 48);
            this.paneltop.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Font = new System.Drawing.Font("Swis721 Ex BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(259, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 19);
            this.label1.TabIndex = 14;
            this.label1.Text = "ANA EKRAN";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ptnmax
            // 
            this.ptnmax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ptnmax.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptnmax.Image = global::suaadabdu.Properties.Resources.square;
            this.ptnmax.Location = new System.Drawing.Point(618, 14);
            this.ptnmax.Name = "ptnmax";
            this.ptnmax.Size = new System.Drawing.Size(30, 25);
            this.ptnmax.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptnmax.TabIndex = 12;
            this.ptnmax.TabStop = false;
            this.ptnmax.Click += new System.EventHandler(this.ptnmax_Click);
            // 
            // ptnmin
            // 
            this.ptnmin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ptnmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptnmin.Image = global::suaadabdu.Properties.Resources.minus;
            this.ptnmin.Location = new System.Drawing.Point(666, 12);
            this.ptnmin.Name = "ptnmin";
            this.ptnmin.Size = new System.Drawing.Size(30, 28);
            this.ptnmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptnmin.TabIndex = 11;
            this.ptnmin.TabStop = false;
            this.ptnmin.Click += new System.EventHandler(this.ptnmin_Click);
            // 
            // btnclose
            // 
            this.btnclose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnclose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnclose.Image = global::suaadabdu.Properties.Resources.cancel1;
            this.btnclose.Location = new System.Drawing.Point(712, 11);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(32, 31);
            this.btnclose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnclose.TabIndex = 10;
            this.btnclose.TabStop = false;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // panlnav
            // 
            this.panlnav.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panlnav.Controls.Add(this.lb_users);
            this.panlnav.Controls.Add(this.flowLayoutPanel1);
            this.panlnav.Controls.Add(this.pictureBox5);
            this.panlnav.Dock = System.Windows.Forms.DockStyle.Left;
            this.panlnav.Location = new System.Drawing.Point(0, 0);
            this.panlnav.Name = "panlnav";
            this.panlnav.Size = new System.Drawing.Size(178, 553);
            this.panlnav.TabIndex = 1;
            this.panlnav.Paint += new System.Windows.Forms.PaintEventHandler(this.panlnav_Paint);
            // 
            // lb_users
            // 
            this.lb_users.AutoSize = true;
            this.lb_users.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lb_users.Location = new System.Drawing.Point(8, 122);
            this.lb_users.Name = "lb_users";
            this.lb_users.Size = new System.Drawing.Size(157, 19);
            this.lb_users.TabIndex = 1;
            this.lb_users.Text = "SUAAD ABDULJALİL";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.simpleButton1);
            this.flowLayoutPanel1.Controls.Add(this.simpleButton2);
            this.flowLayoutPanel1.Controls.Add(this.simpleButton3);
            this.flowLayoutPanel1.Controls.Add(this.simpleButton4);
            this.flowLayoutPanel1.Controls.Add(this.simpleButton5);
            this.flowLayoutPanel1.Controls.Add(this.simpleButton6);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 176);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(162, 393);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.ForeColor = System.Drawing.Color.White;
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Appearance.Options.UseForeColor = true;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(3, 3);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.simpleButton1.Size = new System.Drawing.Size(159, 36);
            this.simpleButton1.TabIndex = 15;
            this.simpleButton1.Text = "ANA";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton2.Appearance.ForeColor = System.Drawing.Color.White;
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.Appearance.Options.UseForeColor = true;
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(3, 45);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.simpleButton2.Size = new System.Drawing.Size(159, 36);
            this.simpleButton2.TabIndex = 16;
            this.simpleButton2.Text = "ÖĞELER";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton3
            // 
            this.simpleButton3.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton3.Appearance.ForeColor = System.Drawing.Color.White;
            this.simpleButton3.Appearance.Options.UseFont = true;
            this.simpleButton3.Appearance.Options.UseForeColor = true;
            this.simpleButton3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.ImageOptions.Image")));
            this.simpleButton3.Location = new System.Drawing.Point(3, 87);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.simpleButton3.Size = new System.Drawing.Size(159, 36);
            this.simpleButton3.TabIndex = 17;
            this.simpleButton3.Text = "TEDARİKÇİL";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // simpleButton4
            // 
            this.simpleButton4.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton4.Appearance.ForeColor = System.Drawing.Color.White;
            this.simpleButton4.Appearance.Options.UseFont = true;
            this.simpleButton4.Appearance.Options.UseForeColor = true;
            this.simpleButton4.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton4.ImageOptions.SvgImage")));
            this.simpleButton4.Location = new System.Drawing.Point(3, 129);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.simpleButton4.Size = new System.Drawing.Size(159, 36);
            this.simpleButton4.TabIndex = 18;
            this.simpleButton4.Text = "SATIN ALMALAR";
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // simpleButton5
            // 
            this.simpleButton5.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton5.Appearance.ForeColor = System.Drawing.Color.White;
            this.simpleButton5.Appearance.Options.UseFont = true;
            this.simpleButton5.Appearance.Options.UseForeColor = true;
            this.simpleButton5.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton5.ImageOptions.SvgImage")));
            this.simpleButton5.Location = new System.Drawing.Point(3, 171);
            this.simpleButton5.Name = "simpleButton5";
            this.simpleButton5.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.simpleButton5.Size = new System.Drawing.Size(159, 36);
            this.simpleButton5.TabIndex = 19;
            this.simpleButton5.Text = "MÜŞTERİLER";
            this.simpleButton5.Click += new System.EventHandler(this.simpleButton5_Click);
            // 
            // simpleButton6
            // 
            this.simpleButton6.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton6.Appearance.ForeColor = System.Drawing.Color.White;
            this.simpleButton6.Appearance.Options.UseFont = true;
            this.simpleButton6.Appearance.Options.UseForeColor = true;
            this.simpleButton6.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton6.ImageOptions.SvgImage")));
            this.simpleButton6.Location = new System.Drawing.Point(3, 213);
            this.simpleButton6.Name = "simpleButton6";
            this.simpleButton6.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.simpleButton6.Size = new System.Drawing.Size(159, 36);
            this.simpleButton6.TabIndex = 20;
            this.simpleButton6.Text = "SATIŞLAR";
            this.simpleButton6.Click += new System.EventHandler(this.simpleButton6_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::suaadabdu.Properties.Resources.user__1_;
            this.pictureBox5.Location = new System.Drawing.Point(28, 3);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(112, 106);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 0;
            this.pictureBox5.TabStop = false;
            // 
            // pancont
            // 
            this.pancont.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pancont.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pancont.Location = new System.Drawing.Point(177, 48);
            this.pancont.Name = "pancont";
            this.pancont.Size = new System.Drawing.Size(760, 508);
            this.pancont.TabIndex = 2;
            this.pancont.Paint += new System.Windows.Forms.PaintEventHandler(this.pancont_Paint);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panlnav;
            this.bunifuDragControl1.Vertical = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 553);
            this.Controls.Add(this.paneltop);
            this.Controls.Add(this.pancont);
            this.Controls.Add(this.panlnav);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.paneltop.ResumeLayout(false);
            this.paneltop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptnmax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptnmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnclose)).EndInit();
            this.panlnav.ResumeLayout(false);
            this.panlnav.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel paneltop;
        private System.Windows.Forms.Panel panlnav;
        private System.Windows.Forms.Panel pancont;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox ptnmax;
        private System.Windows.Forms.PictureBox ptnmin;
        private System.Windows.Forms.PictureBox btnclose;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.SimpleButton simpleButton5;
        private DevExpress.XtraEditors.SimpleButton simpleButton6;
        public System.Windows.Forms.Label lb_users;
    }
}