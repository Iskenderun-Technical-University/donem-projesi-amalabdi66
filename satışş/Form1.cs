﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace satışş
{
    public partial class Main : Form
    {
        //init Form
        
        PL.FRM_Cat frm_cat = new PL.FRM_Cat();
        PL.FRM_HOME frm_home = new PL.FRM_HOME();
        public Main()
        {
            InitializeComponent();
        }
        //exit app
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            

        }

        private void pan_navbar_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void bunifuImageButton6_Click(object sender, EventArgs e)
        {
           
        }
        //load home 
        //اسمه btn_home
        private void bunifuImageButton6_Click_1(object sender, EventArgs e)
        {

           


        }

        private void label4_Click(object sender, EventArgs e)
        {
           
        }

        private void bunifuImageButton7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {

        }

        //min app
        private void btn_min_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;

        }

        private void btn_max_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;

            }
            else
            {
                WindowState = FormWindowState.Normal;


            }
        }

        private void bunifuImageButton13_Click(object sender, EventArgs e)
        {

        }
        //btn_cat
        //load cat
        private void bunifuImageButton12_Click(object sender, EventArgs e)
        {
            con.Controls.Clear();
            con.Controls.Add(frm_cat.pan_cat);

        }

        private void ptn_collapse_Click(object sender, EventArgs e)
        {
            if (pn_navbar.Width == 250)
            {
                pn_navbar.Width = 50;
                pn_titlenav.Visible = false;
                pn_headernavbar.Height = 217;
            }
            else
            {
                {
                    pn_navbar.Width = 250;
                    pn_titlenav.Visible = true;
                    pn_headernavbar.Height = 217;
                }


            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            con.Controls.Clear();
            con.Controls.Add(frm_home.pn_home); 
        }

        private void label11_Click(object sender, EventArgs e)
        {
            
        }

        private void bunifuCards1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
