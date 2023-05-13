
namespace satışş.PL
{
    partial class FFRM_CT_ADD
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
            this.label1 = new System.Windows.Forms.Label();
            this.edt_name = new System.Windows.Forms.TextBox();
            this.pic_cover = new System.Windows.Forms.PictureBox();
            this.btn_close = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_add = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic_cover)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_close)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Coral;
            this.label1.Location = new System.Drawing.Point(12, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 43);
            this.label1.TabIndex = 2;
            this.label1.Text = "ürün Adı";
            // 
            // edt_name
            // 
            this.edt_name.Location = new System.Drawing.Point(216, 135);
            this.edt_name.Multiline = true;
            this.edt_name.Name = "edt_name";
            this.edt_name.Size = new System.Drawing.Size(330, 53);
            this.edt_name.TabIndex = 3;
            // 
            // pic_cover
            // 
            this.pic_cover.Image = global::satışş.Properties.Resources.category1;
            this.pic_cover.Location = new System.Drawing.Point(216, 206);
            this.pic_cover.Name = "pic_cover";
            this.pic_cover.Size = new System.Drawing.Size(330, 265);
            this.pic_cover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_cover.TabIndex = 4;
            this.pic_cover.TabStop = false;
            this.pic_cover.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close.BackColor = System.Drawing.Color.Transparent;
            this.btn_close.Image = global::satışş.Properties.Resources._4a914054d1a9f9e136ba042d8d6a53852;
            this.btn_close.ImageActive = null;
            this.btn_close.Location = new System.Drawing.Point(699, 0);
            this.btn_close.Margin = new System.Windows.Forms.Padding(2);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(56, 31);
            this.btn_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_close.TabIndex = 1;
            this.btn_close.TabStop = false;
            this.btn_close.Zoom = 10;
            // 
            // btn_add
            // 
            this.btn_add.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_add.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_add.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_add.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_add.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_add.FillColor = System.Drawing.Color.Silver;
            this.btn_add.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold);
            this.btn_add.ForeColor = System.Drawing.Color.White;
            this.btn_add.Location = new System.Drawing.Point(595, 505);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(148, 65);
            this.btn_add.TabIndex = 26;
            this.btn_add.Text = " Ekle";
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // FFRM_CT_ADD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(755, 582);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.pic_cover);
            this.Controls.Add(this.edt_name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FFRM_CT_ADD";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pic_cover)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_close)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuImageButton btn_close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox edt_name;
        private System.Windows.Forms.PictureBox pic_cover;
        private Guna.UI2.WinForms.Guna2Button btn_add;
    }
}