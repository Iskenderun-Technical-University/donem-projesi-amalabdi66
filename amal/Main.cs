using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace amal
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void guna2ImageButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pn_topbar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel3_Click(object sender, EventArgs e)
        {

        }
        //exit app
        private void pictureBox11_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //max app
        private void btn_max_Click(object sender, EventArgs e)
        {

            if (WindowState == FormWindowState.Normal)
            {

                WindowState= FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;

            }
        }
        //coollpse
        private void ptn_collpse_Click(object sender, EventArgs e)
        {
           
           if( pn_navbar.Width == 213)
            {
                pn_navbar.Width = 50;
                pn_titlennv.Visible= false;
                pn_header.Height = 150;
            }

            pn_navbar.Width = 213;
            pn_titlennv.Visible = true;
            pn_header.Height = 168;

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
