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
    public partial class FFRM_PUR_ADD   : Form
    {
        // init
        satış_yönetimiEntities db = new satış_yönetimiEntities();
        TB_Supp tb_supp = new TB_Supp();
        TB_PUR tb_PUR = new TB_PUR();
        bl.methats methats = new bl.methats();
        toast toast = new toast();
        dialog dialog = new dialog();
        double buy, sell, qt, tbuy, tsell, trev;

       


        public int id;

        public  FFRM_PUR_ADD ()
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
                    //add
                    // pic_cover.Image.Save(methats.ma, System.Drawing.Imaging.ImageFormat.Png);
                    tb_PUR.pur_name = edt_name.Text;
                    tb_PUR.pur_type = edt_typ.Text;
                    tb_PUR.pur_cat = edt_cat.Text;
                    tb_PUR.pur_supp = edt_supp.Text;
                    tb_PUR.pur_det = edt_det.Text;
                    tb_PUR.pur_buy = Convert.ToDouble(edt_buy.Text);
                    tb_PUR.pur_set = Convert.ToDouble(edt_sale.Text);
                    tb_PUR.pur_qu = Convert.ToDouble(edt_quantity.Text);
                    tb_PUR.pur_tbuy = Convert.ToDouble(edt_tsell.Text);
                    tb_PUR.pur_tset= Convert.ToDouble(edt_sale.Text);
                    tb_PUR.pur_tpro = Convert.ToDouble(edt_tqro.Text);

                    db.TB_PUR.Add(tb_PUR);

                   // tb_supp.supp_name = linkLabel1.Text;
                    //tb_supp.supp_phone = edt_phone.Text;
                    //tb_supp.supp_email = etd_email.Text;
                  //  tb_supp.supp_image = methats.convert_byte();
                   // db.TB_Supp.Add(tb_supp);
                    db.SaveChanges();
                    toast.txt_caption.Text = "satın alma yapıldı";
                    toast.Show();
                    
                    this.Close();

                }else
                {
                    
                 // pic_cover.Image.Save(methats.ma, System.Drawing.Imaging.ImageFormat.Png);
                    tb_PUR.ID = id;
                    tb_PUR.pur_name = edt_name.Text;
                    tb_PUR.pur_type = edt_typ.Text;
                    tb_PUR.pur_cat = edt_cat.Text;
                    tb_PUR.pur_supp = edt_supp.Text;
                    tb_PUR.pur_det = edt_det.Text;
                    tb_PUR.pur_buy = Convert.ToDouble(edt_buy.Text);
                    tb_PUR.pur_set = Convert.ToDouble(edt_sale.Text);
                    tb_PUR.pur_qu = Convert.ToDouble(edt_quantity.Text);
                    tb_PUR.pur_tbuy = Convert.ToDouble(edt_tsell.Text);
                    tb_PUR.pur_tset = Convert.ToDouble(edt_sale.Text);
                    tb_PUR.pur_tpro = Convert.ToDouble(edt_tqro.Text);
                    db.Entry(tb_PUR).State = System.Data.Entity.EntityState.Modified;
                   // tb_supp.supp_name= linkLabel1.Text;
                    //tb_supp.supp_phone = edt_phone.Text;
                    //tb_supp.supp_email = etd_email.Text;
                   // tb_supp.supp_image = methats.convert_byte();
                   // db.Entry(tb_supp).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    toast.txt_caption.Text = " satın alma değiştirildi";
                    toast.Show();
                    this.Close();
                }
            }

           
        }

        private void FFRM_PUR_ADD_Load(object sender, EventArgs e)
        {
            edt_cat.DataSource = db.TB_CAT.Select(x => x.CAT_Name).ToList();
            edt_supp.DataSource = db.TB_Supp.Select(x => x.supp_name).ToList();

        }

      
        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void edt_buy_TextChanged(object sender, EventArgs e)
        {
            pro_cal();
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
            pl.FFRM_CAT_ADD frm_add = new FFRM_CAT_ADD();
            frm_add.id = 0;
            frm_add.btn_add.Text = "ek";
            frm_add.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pl.FFRM_SUPP_ADD frm_add = new FFRM_SUPP_ADD();
            frm_add.id = 0;
            frm_add.btn_add.Text = "ek";
            frm_add.Show();
        }
        private void pro_cal()
        {
            sell = Convert.ToDouble(edt_sale.Text);
            buy = Convert.ToDouble(edt_buy.Text);
            qt = Convert.ToDouble(edt_quantity.Value);
            tsell=sell*qt;
            tbuy=buy*qt;
            trev=tsell - tbuy;
            edt_tset.Text=tsell.ToString();
            edt_tsell.Text=tbuy.ToString();
            edt_tqro.Text=trev.ToString();

        }

        private void edt_cat_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
