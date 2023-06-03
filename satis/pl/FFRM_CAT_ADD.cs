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
    public partial class FFRM_CAT_ADD : Form
    {
        // init
        satış_yönetimiEntities db = new satış_yönetimiEntities();
        TB_CAT tb_cat = new TB_CAT();
        bl.methats methats = new bl.methats();
        toast toast = new toast();
        dialog dialog = new dialog();
        pl.frm_cat frm_cat = new frm_cat();


        public int id;

        public FFRM_CAT_ADD()
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
                    dialog.txt_caption.Text = "öğe adı gerekli";
                dialog.Show();
            }
            else
            {
                if (id==0)

                {
                    //add
                    pic_cover.Image.Save(methats.ma, System.Drawing.Imaging.ImageFormat.Jpeg);
                    tb_cat.CAT_Name = edt_name.Text;
                    tb_cat.CAT_Cover = methats.convert_byte();
                    db.TB_CAT.Add(tb_cat);
                    db.SaveChanges();
                    toast.txt_caption.Text = "yeni bir kategori eklendi";
                    toast.Show();
                    db = new satış_yönetimiEntities();
                   frm_cat.gridControl1.DataSource = db.TB_CAT.ToList();
                    this.Close();

                }else
                {
                    //edit
                    pic_cover.Image.Save(methats.ma, System.Drawing.Imaging.ImageFormat.Jpeg);
                    tb_cat.CAT_Name = edt_name.Text;
                    tb_cat.ID = id;
                    tb_cat.CAT_Cover = methats.convert_byte();
                    db.Entry(tb_cat).State = System.Data.Entity.EntityState.Modified;
                    db.TB_CAT.Add(tb_cat);
                    db.SaveChanges();
                    toast.txt_caption.Text = "yeni bir inif değiştirildi";
                    toast.Show();
                    db = new satış_yönetimiEntities();
                    frm_cat.gridControl1.DataSource = db.TB_CAT.ToList();
                    this.Close();
                }
            }

           
        }

        private void edt_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
