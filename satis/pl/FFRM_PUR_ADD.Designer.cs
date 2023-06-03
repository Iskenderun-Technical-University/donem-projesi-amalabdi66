namespace suaadabdu.pl
{
    partial class FFRM_PUR_ADD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FFRM_PUR_ADD));
            this.label1 = new System.Windows.Forms.Label();
            this.btn_add = new DevExpress.XtraEditors.SimpleButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.edt_cat = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.edt_det = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.edt_typ = new System.Windows.Forms.TextBox();
            this.edt_name = new System.Windows.Forms.TextBox();
            this.edt_supp = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.edt_quantity = new DevExpress.XtraEditors.SpinEdit();
            this.edt_sale = new System.Windows.Forms.TextBox();
            this.edt_buy = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.edt_tqro = new System.Windows.Forms.Label();
            this.edt_tset = new System.Windows.Forms.Label();
            this.edt_tsell = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edt_quantity.Properties)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(58, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 22);
            this.label1.TabIndex = 15;
            this.label1.Text = "tür";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_add
            // 
            this.btn_add.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_add.ImageOptions.Image")));
            this.btn_add.Location = new System.Drawing.Point(244, 531);
            this.btn_add.Margin = new System.Windows.Forms.Padding(5);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(352, 42);
            this.btn_add.TabIndex = 18;
            this.btn_add.Text = "EK";
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Location = new System.Drawing.Point(31, 29);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 22);
            this.label2.TabIndex = 19;
            this.label2.Text = "özne ismi";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label3.Location = new System.Drawing.Point(58, 110);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 22);
            this.label3.TabIndex = 21;
            this.label3.Text = "sınıf";
            // 
            // edt_cat
            // 
            this.edt_cat.FormattingEnabled = true;
            this.edt_cat.Location = new System.Drawing.Point(171, 108);
            this.edt_cat.Margin = new System.Windows.Forms.Padding(5);
            this.edt_cat.Name = "edt_cat";
            this.edt_cat.Size = new System.Drawing.Size(179, 27);
            this.edt_cat.TabIndex = 24;
            this.edt_cat.SelectedIndexChanged += new System.EventHandler(this.edt_cat_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.linkLabel2);
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.edt_det);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.edt_typ);
            this.groupBox1.Controls.Add(this.edt_name);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.edt_supp);
            this.groupBox1.Controls.Add(this.edt_cat);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox1.Location = new System.Drawing.Point(411, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(369, 325);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "temel bilgiler";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(136, 150);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(29, 19);
            this.linkLabel2.TabIndex = 32;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "ek";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(134, 111);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(29, 19);
            this.linkLabel1.TabIndex = 31;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "ek";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label6.Location = new System.Drawing.Point(26, 226);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 22);
            this.label6.TabIndex = 30;
            this.label6.Text = "detaylar";
            // 
            // edt_det
            // 
            this.edt_det.Location = new System.Drawing.Point(113, 190);
            this.edt_det.Multiline = true;
            this.edt_det.Name = "edt_det";
            this.edt_det.Size = new System.Drawing.Size(237, 113);
            this.edt_det.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label5.Location = new System.Drawing.Point(31, 150);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 22);
            this.label5.TabIndex = 28;
            this.label5.Text = "tedarikçi";
            // 
            // edt_typ
            // 
            this.edt_typ.Location = new System.Drawing.Point(171, 62);
            this.edt_typ.Name = "edt_typ";
            this.edt_typ.Size = new System.Drawing.Size(179, 27);
            this.edt_typ.TabIndex = 27;
            // 
            // edt_name
            // 
            this.edt_name.Location = new System.Drawing.Point(171, 29);
            this.edt_name.Name = "edt_name";
            this.edt_name.Size = new System.Drawing.Size(179, 27);
            this.edt_name.TabIndex = 26;
            // 
            // edt_supp
            // 
            this.edt_supp.FormattingEnabled = true;
            this.edt_supp.Location = new System.Drawing.Point(171, 145);
            this.edt_supp.Margin = new System.Windows.Forms.Padding(5);
            this.edt_supp.Name = "edt_supp";
            this.edt_supp.Size = new System.Drawing.Size(179, 27);
            this.edt_supp.TabIndex = 25;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.edt_quantity);
            this.groupBox2.Controls.Add(this.edt_sale);
            this.groupBox2.Controls.Add(this.edt_buy);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox2.Location = new System.Drawing.Point(411, 349);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox2.Size = new System.Drawing.Size(369, 169);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "alış ve satış";
            // 
            // edt_quantity
            // 
            this.edt_quantity.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.edt_quantity.Location = new System.Drawing.Point(171, 118);
            this.edt_quantity.Name = "edt_quantity";
            this.edt_quantity.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edt_quantity.Properties.Appearance.Options.UseFont = true;
            this.edt_quantity.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.edt_quantity.Properties.MaskSettings.Set("mask", "");
            this.edt_quantity.Size = new System.Drawing.Size(179, 26);
            this.edt_quantity.TabIndex = 28;
            this.edt_quantity.EditValueChanged += new System.EventHandler(this.edt_quantity_EditValueChanged);
            // 
            // edt_sale
            // 
            this.edt_sale.Location = new System.Drawing.Point(171, 73);
            this.edt_sale.Multiline = true;
            this.edt_sale.Name = "edt_sale";
            this.edt_sale.Size = new System.Drawing.Size(179, 27);
            this.edt_sale.TabIndex = 27;
            this.edt_sale.Text = "0";
            this.edt_sale.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.edt_sale.TextChanged += new System.EventHandler(this.edt_sale_TextChanged);
            // 
            // edt_buy
            // 
            this.edt_buy.Location = new System.Drawing.Point(171, 29);
            this.edt_buy.Multiline = true;
            this.edt_buy.Name = "edt_buy";
            this.edt_buy.Size = new System.Drawing.Size(179, 27);
            this.edt_buy.TabIndex = 26;
            this.edt_buy.Text = "0";
            this.edt_buy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.edt_buy.TextChanged += new System.EventHandler(this.edt_buy_TextChanged);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label9.Location = new System.Drawing.Point(10, 33);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(164, 19);
            this.label9.TabIndex = 19;
            this.label9.Text = "satın alma fiyatı(tek)";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label10.Location = new System.Drawing.Point(58, 121);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 22);
            this.label10.TabIndex = 21;
            this.label10.Text = "miktar";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label11.Location = new System.Drawing.Point(26, 78);
            this.label11.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(131, 22);
            this.label11.TabIndex = 15;
            this.label11.Text = "satış fiyatı(tek)";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.edt_tqro);
            this.groupBox3.Controls.Add(this.edt_tset);
            this.groupBox3.Controls.Add(this.edt_tsell);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox3.Location = new System.Drawing.Point(14, 102);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox3.Size = new System.Drawing.Size(369, 347);
            this.groupBox3.TabIndex = 27;
            this.groupBox3.TabStop = false;
            // 
            // edt_tqro
            // 
            this.edt_tqro.AutoSize = true;
            this.edt_tqro.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edt_tqro.ForeColor = System.Drawing.Color.Orange;
            this.edt_tqro.Location = new System.Drawing.Point(158, 242);
            this.edt_tqro.Name = "edt_tqro";
            this.edt_tqro.Size = new System.Drawing.Size(28, 29);
            this.edt_tqro.TabIndex = 24;
            this.edt_tqro.Text = "0";
            // 
            // edt_tset
            // 
            this.edt_tset.AutoSize = true;
            this.edt_tset.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edt_tset.ForeColor = System.Drawing.Color.Orange;
            this.edt_tset.Location = new System.Drawing.Point(158, 150);
            this.edt_tset.Name = "edt_tset";
            this.edt_tset.Size = new System.Drawing.Size(28, 29);
            this.edt_tset.TabIndex = 23;
            this.edt_tset.Text = "0";
            // 
            // edt_tsell
            // 
            this.edt_tsell.AutoSize = true;
            this.edt_tsell.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edt_tsell.ForeColor = System.Drawing.Color.Orange;
            this.edt_tsell.Location = new System.Drawing.Point(158, 70);
            this.edt_tsell.Name = "edt_tsell";
            this.edt_tsell.Size = new System.Drawing.Size(28, 29);
            this.edt_tsell.TabIndex = 22;
            this.edt_tsell.Text = "0";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label12.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label12.Location = new System.Drawing.Point(81, 25);
            this.label12.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(210, 22);
            this.label12.TabIndex = 19;
            this.label12.Text = "satın alma fiyatı(toplam)";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label13.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label13.Location = new System.Drawing.Point(134, 204);
            this.label13.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 22);
            this.label13.TabIndex = 21;
            this.label13.Text = "miktar";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label14.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label14.Location = new System.Drawing.Point(93, 113);
            this.label14.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(169, 22);
            this.label14.TabIndex = 15;
            this.label14.Text = "satış fiyatı (toplam)";
            // 
            // FFRM_PUR_ADD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(797, 587);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_add);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FFRM_PUR_ADD";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.Activated += new System.EventHandler(this.FFRM_PUR_ADD_Load);
            this.Load += new System.EventHandler(this.FFRM_PUR_ADD_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edt_quantity.Properties)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        public DevExpress.XtraEditors.SimpleButton btn_add;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        public System.Windows.Forms.ComboBox edt_cat;
        public System.Windows.Forms.TextBox edt_typ;
        public System.Windows.Forms.TextBox edt_name;
        public System.Windows.Forms.ComboBox edt_supp;
        public System.Windows.Forms.TextBox edt_det;
        public System.Windows.Forms.TextBox edt_sale;
        public System.Windows.Forms.TextBox edt_buy;
        public System.Windows.Forms.Label edt_tqro;
        public System.Windows.Forms.Label edt_tset;
        public System.Windows.Forms.Label edt_tsell;
        public System.Windows.Forms.Label label13;
        public System.Windows.Forms.Label label14;
        public DevExpress.XtraEditors.SpinEdit edt_quantity;
        public System.Windows.Forms.Label label9;
    }
}