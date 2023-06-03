namespace suaadabdu.pl
{
    partial class frm_sitting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_sitting));
            this.gridSplitContainer1 = new DevExpress.XtraGrid.GridSplitContainer();
            this.panelcatgre = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.edt_sv = new System.Windows.Forms.TextBox();
            this.btnclose = new System.Windows.Forms.PictureBox();
            this.btn_add = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1.Panel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1.Panel2)).BeginInit();
            this.gridSplitContainer1.SuspendLayout();
            this.panelcatgre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnclose)).BeginInit();
            this.SuspendLayout();
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
            // panelcatgre
            // 
            this.panelcatgre.Controls.Add(this.label1);
            this.panelcatgre.Controls.Add(this.edt_sv);
            this.panelcatgre.Controls.Add(this.btnclose);
            this.panelcatgre.Controls.Add(this.btn_add);
            this.panelcatgre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelcatgre.Location = new System.Drawing.Point(0, 0);
            this.panelcatgre.Name = "panelcatgre";
            this.panelcatgre.Size = new System.Drawing.Size(560, 376);
            this.panelcatgre.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 29);
            this.label1.TabIndex = 16;
            this.label1.Text = "server adı";
            // 
            // edt_sv
            // 
            this.edt_sv.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edt_sv.Location = new System.Drawing.Point(189, 169);
            this.edt_sv.Multiline = true;
            this.edt_sv.Name = "edt_sv";
            this.edt_sv.Size = new System.Drawing.Size(309, 40);
            this.edt_sv.TabIndex = 15;
            this.edt_sv.Text = ".\\SQLEXPRESS";
            this.edt_sv.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnclose
            // 
            this.btnclose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnclose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnclose.Image = global::suaadabdu.Properties.Resources.cancel1;
            this.btnclose.Location = new System.Drawing.Point(525, 3);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(32, 31);
            this.btnclose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnclose.TabIndex = 14;
            this.btnclose.TabStop = false;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // btn_add
            // 
            this.btn_add.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_add.ImageOptions.Image")));
            this.btn_add.Location = new System.Drawing.Point(146, 293);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(302, 47);
            this.btn_add.TabIndex = 13;
            this.btn_add.Text = "kaydetmek";
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // frm_sitting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(560, 376);
            this.Controls.Add(this.panelcatgre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_sitting";
            this.Text = "frm_cat";
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1.Panel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1.Panel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1)).EndInit();
            this.gridSplitContainer1.ResumeLayout(false);
            this.panelcatgre.ResumeLayout(false);
            this.panelcatgre.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnclose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.GridSplitContainer gridSplitContainer1;
        public System.Windows.Forms.Panel panelcatgre;
        private DevExpress.XtraEditors.SimpleButton btn_add;
        private System.Windows.Forms.PictureBox btnclose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox edt_sv;
    }
}