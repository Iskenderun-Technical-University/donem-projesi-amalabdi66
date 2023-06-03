using DevExpress.Office.Drawing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace suaadabdu.pl
{
    
    public partial class frm_home : Form
    {
        satış_yönetimiEntities db = new satış_yönetimiEntities();
        public frm_home()
        {
            InitializeComponent();
            List<TB_CAT> list_cat = db.TB_CAT.ToList();
            label2.Text = list_cat.Count.ToString();

            List<TB_Supp> list_supp = db.TB_Supp.ToList();
            label3.Text = list_supp.Count.ToString();

            List<TB_PUR> list_pur = db.TB_PUR.ToList();
            label5.Text = list_pur.Count.ToString();

            List<TB_cus> list_cus = db.TB_cus.ToList();
            label7.Text = list_cus.Count.ToString();

            List<tb_sell> list_sell = db.tb_sell.ToList();
            label9.Text = list_sell.Count.ToString();

          
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            pl.FFRM_CAT_ADD frm_add = new FFRM_CAT_ADD();
            frm_add.id = 0;
            frm_add.btn_add.Text = "ek";
            frm_add.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pl.FFRM_SELL_ADD frm_add = new FFRM_SELL_ADD();
            frm_add.id = 0;
            frm_add.btn_add.Text = "ek";
            frm_add.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pl.FFRM_PUR_ADD frm_add = new FFRM_PUR_ADD();
            frm_add.id = 0;
            frm_add.btn_add.Text = "ek";
            frm_add.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pl.FFRM_SUPP_ADD frm_add = new FFRM_SUPP_ADD();
            frm_add.id = 0;
            frm_add.btn_add.Text = "ek";
            frm_add.Show();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            pl.FFRM_CUS_ADD frm_add = new FFRM_CUS_ADD();
            frm_add.id = 0;
            frm_add.btn_add.Text = "ek";
            frm_add.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_update_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCards6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuCards3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCards1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
