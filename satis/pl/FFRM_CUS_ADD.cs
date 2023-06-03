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
    public partial class FFRM_CUS_ADD  : Form
    {
        // init
        satış_yönetimiEntities db = new satış_yönetimiEntities();
        TB_cus tb_supp = new TB_cus();
        bl.methats methats = new bl.methats();
        toast toast = new toast();
        dialog dialog = new dialog();
       


        public int id;

        public FFRM_CUS_ADD()
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

            if (edt_name.Text=="")
            {
                dialog.Width = this.Width;
                    dialog.txt_caption.Text = "MÜŞTERİ adı gerekli";
                dialog.Show();
            }
            else
            {
                if (id==0)

                {
                    //add
                    pic_cover.Image.Save(methats.ma, System.Drawing.Imaging.ImageFormat.Png);
                    tb_supp.supp_name = edt_name.Text;
                    tb_supp.supp_phone = edt_phone.Text;
                    tb_supp.supp_email = etd_email.Text;
                    tb_supp.supp_image = methats.convert_byte();
                    db.TB_cus.Add(tb_supp);
                    db.SaveChanges();
                    toast.txt_caption.Text = "yeni bir MÜŞTERİ eklendi";
                    toast.Show();
                    db = new satış_yönetimiEntities();
                   
                    this.Close();

                }else
                {
                    //edit
                    pic_cover.Image.Save(methats.ma, System.Drawing.Imaging.ImageFormat.Png);
                    tb_supp.ID = id;
                    tb_supp.supp_name = edt_name.Text;
                    tb_supp.supp_phone = edt_phone.Text;
                    tb_supp.supp_email = etd_email.Text;
                    tb_supp.supp_image = methats.convert_byte();
                    db.Entry(tb_supp).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    toast.txt_caption.Text = " MÜŞTERİ değiştirildi";
                    toast.Show();
                    db = new satış_yönetimiEntities();

                    this.Close();
                }
            }

           
        }

        private void edt_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void edt_phone_TextChanged(object sender, EventArgs e)
        {

        }

        private void FFRM_CUS_ADD_Load(object sender, EventArgs e)
        {

        }
    }
}
