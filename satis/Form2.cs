using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace suaadabdu
{
    public partial class Form2 : Form
    {
        pl.frm_home FRE_HOME = new pl.frm_home();
        pl.frm_cat FRM_CAT = new pl.frm_cat();
        pl.frm_supp Frm_supp = new pl.frm_supp();
        pl.frm_pur frm_Pur = new pl.frm_pur();
        pl.frm_cus Frm_Cus = new pl.frm_cus();
        
        
        tb_users tb_Users = new tb_users();
        



      //  pl.frm_report frm_Report = new pl.frm_report();

        pl.frm_sell frm_Sell = new pl.frm_sell();

        satış_yönetimiEntities db = new satış_yönetimiEntities();
        public Form2()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pancont_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void ptnmin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void ptnmax_Click(object sender, EventArgs e)
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

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            pancont.Controls.Clear();
            pancont.Controls.Add(FRM_CAT.panelcatgre);
            db = new satış_yönetimiEntities();
            FRM_CAT.gridControl1.DataSource = db.TB_CAT.ToList();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            pancont.Controls.Clear();
            pancont.Controls.Add(Frm_supp.panelcatgre);
            db = new satış_yönetimiEntities();
            FRM_CAT.gridControl1.DataSource = db.TB_CAT.ToList();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            pancont.Controls.Clear();
            pancont.Controls.Add(FRE_HOME.pnhome);


        }


        private void Form2_Load(object sender, EventArgs e)
        {
            pancont.Controls.Clear();
            pancont.Controls.Add(FRE_HOME.pnhome);

           


        } 

        private void panlnav_Paint(object sender, PaintEventArgs e)
        {

        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            pancont.Controls.Clear();
            pancont.Controls.Add(frm_Pur.panelcatgre);
            db = new satış_yönetimiEntities();
            
            FRM_CAT.gridControl1.DataSource = db.TB_CAT.ToList();
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            pancont.Controls.Clear();
            pancont.Controls.Add(Frm_Cus.panelcatgre);
            db = new satış_yönetimiEntities();

            FRM_CAT.gridControl1.DataSource = db.TB_CAT.ToList();
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            pancont.Controls.Clear();
            pancont.Controls.Add(frm_Sell.panelcatgre);
            db = new satış_yönetimiEntities();

            FRM_CAT.gridControl1.DataSource = db.TB_CAT.ToList();
        }

        private void simpleButton7_Click(object sender, EventArgs e)
        {
           
        }

        private void simpleButton8_Click(object sender, EventArgs e)
        {
          
        }

        private void simpleButton9_Click(object sender, EventArgs e)
        {

        }

        private void ptnnot_Click(object sender, EventArgs e)
        {
           
        }
    }
    }



