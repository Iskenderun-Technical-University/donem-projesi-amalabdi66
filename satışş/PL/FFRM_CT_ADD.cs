using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using satışş.EPL;
namespace satışş.PL
{
    public partial class FFRM_CT_ADD : Form
    {
        //init
        SATIŞEntities db = new SATIŞEntities();
        TB_CAT tb_cat = new TB_CAT();
        BL.Methods methods = new BL.Methods();
        Toast toast = new Toast();
        Dialog dialog = new Dialog();
        public int id;
        public FFRM_CT_ADD()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        //add or edit

        private void btn_add_Click(object sender, EventArgs e)
        {//check if add or edit
            if (edt_name.Text == "")
            {
                dialog.Width = this.Width;
                dialog.txt_caption.Text = "Lütfen ürün adını giriniz";
                dialog.Show();
            }
            else
            {//chrck if add or edit
                if (id == 0)
                {//Add
                    pic_cover.Image.Save(methods.ma, System.Drawing.Imaging.ImageFormat.Jpeg);
                    tb_cat.CAT_Name = edt_name.Text;
                    tb_cat.CAT_Cover = methods.convert_byte();
                    db.TB_CAT.Add(tb_cat);
                    db.SaveChanges();

                    toast.txt_caption.Text = "Yeni ürün eklendi";
                    toast.Show();
                }
                else
                {
                    //Edit
                }
           

        }
    }
}
