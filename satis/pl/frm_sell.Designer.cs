namespace suaadabdu.pl
{
    partial class frm_sell
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_sell));
            this.panelcatgre = new System.Windows.Forms.Panel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colsell__name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsell_cus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsell_price = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsell_qt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsell_tprice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsell_date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_edit = new DevExpress.XtraEditors.SimpleButton();
            this.btn_add = new DevExpress.XtraEditors.SimpleButton();
            this.btn_update = new DevExpress.XtraEditors.SimpleButton();
            this.btn_delet = new DevExpress.XtraEditors.SimpleButton();
            this.btn_serch = new DevExpress.XtraEditors.SimpleButton();
            this.edit_sarch = new System.Windows.Forms.TextBox();
            this.gridSplitContainer1 = new DevExpress.XtraGrid.GridSplitContainer();
            this.panelcatgre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1.Panel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1.Panel2)).BeginInit();
            this.gridSplitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelcatgre
            // 
            this.panelcatgre.Controls.Add(this.gridControl1);
            this.panelcatgre.Controls.Add(this.panel1);
            this.panelcatgre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelcatgre.Location = new System.Drawing.Point(0, 0);
            this.panelcatgre.Name = "panelcatgre";
            this.panelcatgre.Size = new System.Drawing.Size(760, 553);
            this.panelcatgre.TabIndex = 0;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = typeof(suaadabdu.tb_sell);
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(760, 453);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click_1);
            this.gridControl1.Move += new System.EventHandler(this.gridControl1_Move);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colsell__name,
            this.colsell_cus,
            this.colsell_price,
            this.colsell_qt,
            this.colsell_tprice,
            this.colsell_date});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colsell__name
            // 
            this.colsell__name.Caption = "mal adı";
            this.colsell__name.FieldName = "sell__name";
            this.colsell__name.Name = "colsell__name";
            this.colsell__name.Visible = true;
            this.colsell__name.VisibleIndex = 0;
            // 
            // colsell_cus
            // 
            this.colsell_cus.Caption = "müşteri";
            this.colsell_cus.FieldName = "sell_cus";
            this.colsell_cus.Name = "colsell_cus";
            this.colsell_cus.Visible = true;
            this.colsell_cus.VisibleIndex = 1;
            // 
            // colsell_price
            // 
            this.colsell_price.Caption = "fiyat";
            this.colsell_price.FieldName = "sell_price";
            this.colsell_price.Name = "colsell_price";
            this.colsell_price.Visible = true;
            this.colsell_price.VisibleIndex = 2;
            // 
            // colsell_qt
            // 
            this.colsell_qt.Caption = "miktar";
            this.colsell_qt.FieldName = "sell_qt";
            this.colsell_qt.Name = "colsell_qt";
            this.colsell_qt.Visible = true;
            this.colsell_qt.VisibleIndex = 3;
            // 
            // colsell_tprice
            // 
            this.colsell_tprice.Caption = "toplam fiyat";
            this.colsell_tprice.FieldName = "sell_tprice";
            this.colsell_tprice.Name = "colsell_tprice";
            this.colsell_tprice.Visible = true;
            this.colsell_tprice.VisibleIndex = 4;
            // 
            // colsell_date
            // 
            this.colsell_date.Caption = "tarih";
            this.colsell_date.FieldName = "sell_date";
            this.colsell_date.Name = "colsell_date";
            this.colsell_date.Visible = true;
            this.colsell_date.VisibleIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_edit);
            this.panel1.Controls.Add(this.btn_add);
            this.panel1.Controls.Add(this.btn_update);
            this.panel1.Controls.Add(this.btn_delet);
            this.panel1.Controls.Add(this.btn_serch);
            this.panel1.Controls.Add(this.edit_sarch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 453);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(760, 100);
            this.panel1.TabIndex = 1;
            // 
            // btn_edit
            // 
            this.btn_edit.Enabled = false;
            this.btn_edit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_edit.ImageOptions.Image")));
            this.btn_edit.Location = new System.Drawing.Point(130, 17);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(109, 58);
            this.btn_edit.TabIndex = 13;
            this.btn_edit.Text = "DEĞİŞTİR";
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_add
            // 
            this.btn_add.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_add.ImageOptions.Image")));
            this.btn_add.Location = new System.Drawing.Point(3, 17);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(109, 58);
            this.btn_add.TabIndex = 12;
            this.btn_add.Text = "EK";
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_update
            // 
            this.btn_update.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_update.ImageOptions.Image")));
            this.btn_update.Location = new System.Drawing.Point(382, 17);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(109, 58);
            this.btn_update.TabIndex = 10;
            this.btn_update.Text = "GÜNCELLEME";
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delet
            // 
            this.btn_delet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_delet.ImageOptions.Image")));
            this.btn_delet.Location = new System.Drawing.Point(256, 17);
            this.btn_delet.Name = "btn_delet";
            this.btn_delet.Size = new System.Drawing.Size(109, 58);
            this.btn_delet.TabIndex = 9;
            this.btn_delet.Text = "SİLMEK";
            this.btn_delet.Click += new System.EventHandler(this.btn_delet_Click);
            // 
            // btn_serch
            // 
            this.btn_serch.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_serch.ImageOptions.Image")));
            this.btn_serch.Location = new System.Drawing.Point(693, 27);
            this.btn_serch.Name = "btn_serch";
            this.btn_serch.Size = new System.Drawing.Size(41, 38);
            this.btn_serch.TabIndex = 8;
            this.btn_serch.Click += new System.EventHandler(this.btn_serch_Click);
            // 
            // edit_sarch
            // 
            this.edit_sarch.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_sarch.Location = new System.Drawing.Point(497, 25);
            this.edit_sarch.Name = "edit_sarch";
            this.edit_sarch.Size = new System.Drawing.Size(190, 46);
            this.edit_sarch.TabIndex = 7;
            this.edit_sarch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gridSplitContainer1
            // 
            this.gridSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridSplitContainer1.Grid = null;
            this.gridSplitContainer1.Location = new System.Drawing.Point(0, 0);
            this.gridSplitContainer1.Name = "gridSplitContainer1";
            this.gridSplitContainer1.Size = new System.Drawing.Size(760, 453);
            this.gridSplitContainer1.TabIndex = 2;
            // 
            // frm_sell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(760, 553);
            this.Controls.Add(this.panelcatgre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_sell";
            this.Text = "frm_cat";
            this.panelcatgre.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1.Panel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1.Panel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1)).EndInit();
            this.gridSplitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btn_add;
        private DevExpress.XtraEditors.SimpleButton btn_update;
        private DevExpress.XtraEditors.SimpleButton btn_serch;
        private System.Windows.Forms.TextBox edit_sarch;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Panel panelcatgre;
        private DevExpress.XtraGrid.GridSplitContainer gridSplitContainer1;
        public DevExpress.XtraGrid.GridControl gridControl1;
        public DevExpress.XtraEditors.SimpleButton btn_delet;
        public DevExpress.XtraEditors.SimpleButton btn_edit;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colsell__name;
        private DevExpress.XtraGrid.Columns.GridColumn colsell_cus;
        private DevExpress.XtraGrid.Columns.GridColumn colsell_price;
        private DevExpress.XtraGrid.Columns.GridColumn colsell_qt;
        private DevExpress.XtraGrid.Columns.GridColumn colsell_tprice;
        private DevExpress.XtraGrid.Columns.GridColumn colsell_date;
    }
}