namespace suaadabdu.pl
{
    partial class frm_cat
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
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition1 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition2 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement1 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement2 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_cat));
            this.colCAT_Cover = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colCAT_Name = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.panelcatgre = new System.Windows.Forms.Panel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.tileView1 = new DevExpress.XtraGrid.Views.Tile.TileView();
            this.colID = new DevExpress.XtraGrid.Columns.TileViewColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.tileView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1.Panel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1.Panel2)).BeginInit();
            this.gridSplitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // colCAT_Cover
            // 
            this.colCAT_Cover.FieldName = "CAT_Cover";
            this.colCAT_Cover.Name = "colCAT_Cover";
            this.colCAT_Cover.Visible = true;
            this.colCAT_Cover.VisibleIndex = 0;
            // 
            // colCAT_Name
            // 
            this.colCAT_Name.FieldName = "CAT_Name";
            this.colCAT_Name.Name = "colCAT_Name";
            this.colCAT_Name.Visible = true;
            this.colCAT_Name.VisibleIndex = 1;
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
          
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.tileView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(760, 453);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.tileView1});
            this.gridControl1.Move += new System.EventHandler(this.gridControl1_Move);
            // 
            // tileView1
            // 
            this.tileView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCAT_Cover,
            this.colCAT_Name,
            this.colID});
            this.tileView1.GridControl = this.gridControl1;
            this.tileView1.Name = "tileView1";
            this.tileView1.OptionsTiles.ItemSize = new System.Drawing.Size(248, 192);
            this.tileView1.OptionsTiles.RowCount = 0;
            tableRowDefinition1.Length.Value = 45D;
            tableRowDefinition2.Length.Value = 107D;
            this.tileView1.TileRows.Add(tableRowDefinition1);
            this.tileView1.TileRows.Add(tableRowDefinition2);
            tileViewItemElement1.Column = this.colCAT_Cover;
            tileViewItemElement1.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement1.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Squeeze;
            tileViewItemElement1.RowIndex = 1;
            tileViewItemElement1.Text = "colCAT_Cover";
            tileViewItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement2.Column = this.colCAT_Name;
            tileViewItemElement2.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement2.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Squeeze;
            tileViewItemElement2.Text = "colCAT_Name";
            tileViewItemElement2.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.tileView1.TileTemplate.Add(tileViewItemElement1);
            this.tileView1.TileTemplate.Add(tileViewItemElement2);
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 2;
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
            // frm_cat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(760, 553);
            this.Controls.Add(this.panelcatgre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_cat";
            this.Text = "frm_cat";
            this.panelcatgre.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileView1)).EndInit();
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
        private DevExpress.XtraGrid.Views.Tile.TileView tileView1;
        private DevExpress.XtraGrid.Columns.TileViewColumn colCAT_Cover;
        private DevExpress.XtraGrid.Columns.TileViewColumn colCAT_Name;
        private DevExpress.XtraGrid.Columns.TileViewColumn colID;
        public DevExpress.XtraGrid.GridControl gridControl1;
        public DevExpress.XtraEditors.SimpleButton btn_delet;
        public DevExpress.XtraEditors.SimpleButton btn_edit;
    }
}