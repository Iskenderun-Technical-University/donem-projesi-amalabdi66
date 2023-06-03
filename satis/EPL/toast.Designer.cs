namespace suaadabdu.EPL
{
    partial class toast
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_caption = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pic_toast = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_toast)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(407, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(38, 34);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txt_caption
            // 
            this.txt_caption.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_caption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_caption.Font = new System.Drawing.Font("Swis721 Ex BT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_caption.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txt_caption.Location = new System.Drawing.Point(59, 0);
            this.txt_caption.Name = "txt_caption";
            this.txt_caption.Size = new System.Drawing.Size(348, 34);
            this.txt_caption.TabIndex = 16;
            this.txt_caption.Text = "MESAJ";
            this.txt_caption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txt_caption.Click += new System.EventHandler(this.txt_caption_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 4000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pic_toast
            // 
            this.pic_toast.Dock = System.Windows.Forms.DockStyle.Left;
            this.pic_toast.Image = global::suaadabdu.Properties.Resources.finish__1_;
            this.pic_toast.Location = new System.Drawing.Point(0, 0);
            this.pic_toast.Name = "pic_toast";
            this.pic_toast.Size = new System.Drawing.Size(59, 34);
            this.pic_toast.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_toast.TabIndex = 0;
            this.pic_toast.TabStop = false;
            // 
            // toast
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(445, 34);
            this.Controls.Add(this.txt_caption);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pic_toast);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "toast";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "toast";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pic_toast)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.PictureBox pic_toast;
        public System.Windows.Forms.Label txt_caption;
    }
}