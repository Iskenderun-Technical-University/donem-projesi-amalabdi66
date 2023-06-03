using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using suaadabdu.EPL;

namespace suaadabdu.pl
{
    public partial class FFRM_SELL_ADD   : Form
    {
        // init
        satış_yönetimiEntities db = new satış_yönetimiEntities();
        TB_Supp tb_supp = new TB_Supp();
        TB_PUR tB_PUR = new TB_PUR();
        tb_sell tb_Sell=new tb_sell();
        bl.methats methats = new bl.methats();
        toast toast = new toast();
        dialog dialog = new dialog();
        double buy, sell, qt, tbuy, tsell, trev;
        double qtp, qtn, qtr;




        public int id;

        public FFRM_SELL_ADD  ()
        {
            InitializeComponent();
        }
        //add or edit
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {

            toast toast = new toast();
            dialog dialog = new dialog();

            //check if add 0r edit
            qtp=Convert.ToDouble(edt_tqro.Text);
            qtn = Convert.ToDouble(edt_quantity.Text);
            qtr=qtp - qtn ;


            if (linkLabel1.Text=="")
          {
              dialog.Width = this.Width;
                  dialog.txt_caption.Text = "öğe adı gerekli";
              dialog.Show();
           }
         else
          {
                if (id==0)
           
                {
                    if(qtr>=0)
                    {
                        //add
                        tb_Sell.sell__name=edt_name.Text;
                        tb_Sell.sell_cus=edt_cus.Text;
                        tb_Sell.sell_price=Convert.ToDouble(edt_sale.Text);
                        tb_Sell.sell_qt = Convert.ToDouble(edt_quantity.Text);
                        tb_Sell.sell_tprice=(Convert.ToDouble(edt_quantity.Text)) * Convert.ToDouble(edt_sale.Text);
                        tb_Sell.sell_date=DateTime.Now;

                        db.tb_sell.Add(tb_Sell);
                        tB_PUR.pur_qu=qtr;
                        db.Entry(tB_PUR).State=System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();
                        toast.txt_caption.Text = "satış yapıldı";
                        toast.Show();

                        this.Close();
                    }
                    else
                    {
                        label4.Visible = true;
                    }
                
                }
            }

           
        }

        private void FFRM_PUR_ADD_Load(object sender, EventArgs e)
        {
            var rs1 = db.TB_PUR.Select(x => x.pur_name).ToList();
           var rs2 = db.TB_cus.Select(x => x.supp_name).ToList();
            edt_name.DataSource = rs1;
            edt_cus.DataSource = rs2;

            AutoCompleteStringCollection acsc1 = new AutoCompleteStringCollection();
            AutoCompleteStringCollection acsc2 = new AutoCompleteStringCollection();
            acsc1.AddRange(rs1.ToArray());
            acsc2.AddRange(rs2.ToArray());

            edt_name.AutoCompleteCustomSource = acsc1;
            edt_cus.AutoCompleteCustomSource = acsc2;


           




        }


        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void edt_buy_TextChanged(object sender, EventArgs e)
        {
            pro_cal();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void edt_tbuy_Click(object sender, EventArgs e)
        {
            
        }

        private void edt_tset_Click(object sender, EventArgs e)
        {
           
        }

        private void edt_tqro_Click(object sender, EventArgs e)
        {
           
        }

        private void edt_sale_TextChanged(object sender, EventArgs e)
        {
            pro_cal();
        }

        private void edt_quantity_EditValueChanged(object sender, EventArgs e)
        {
            pro_cal();
        }

        private void pic_cover_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pl.FFRM_PUR_ADD frm_add = new FFRM_PUR_ADD();
            frm_add.id = 0;
            frm_add.btn_add.Text = "ek";
            frm_add.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pl.FFRM_CUS_ADD frm_add = new FFRM_CUS_ADD();
            frm_add.id = 0;
            frm_add.btn_add.Text = "ek";
            frm_add.Show();
        }
        private void pro_cal()
        {
          /*  sell = Convert.ToDouble(edt_sale.Text);
         //   buy = Convert.ToDouble(edt_buy.Text);
            qt = Convert.ToDouble(edt_quantity.Value);
            tsell=sell*qt;
            tbuy=buy*qt;
            trev=tsell - tbuy;
            edt_tset.Text=tsell.ToString();
            edt_tbuy.Text=tbuy.ToString();
            edt_tqro.Text=trev.ToString();*/

        }

        private void edt_cat_SelectedIndexChanged(object sender, EventArgs e)
        {
            tB_PUR = db.TB_PUR.Where(x => x.pur_name == edt_name.Text).FirstOrDefault();
            edt_tbuy.Text = tB_PUR.pur_buy.ToString();
            edt_tset.Text = tB_PUR.pur_set.ToString();
            edt_tqro.Text = tB_PUR.pur_qu.ToString();
            edt_sale.Text = tB_PUR.pur_set.ToString();
        }
    }
}
