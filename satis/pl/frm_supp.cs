﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using suaadabdu.EPL;
using System.Data.SqlClient;

namespace suaadabdu.pl
{
    public partial class frm_supp : Form
    {
        satış_yönetimiEntities db = new satış_yönetimiEntities();
        TB_Supp tb_supp = new TB_Supp();
        bl.methats methats = new bl.methats();
        
        int id;
        public frm_supp()
        {
            InitializeComponent();
            
            suaadabdu.satış_yönetimiEntities dbContext = new suaadabdu.satış_yönetimiEntities();
            // Call the LoadAsync method to asynchronously get the data for the given DbSet from the database.
            dbContext.TB_Supp.LoadAsync().ContinueWith(loadTask =>
            {
    // Bind data to control when loading complete
    gridControl1.DataSource = dbContext.TB_Supp.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        //add
        private void btn_add_Click(object sender, EventArgs e)
        {
            pl.FFRM_SUPP_ADD frm_add = new FFRM_SUPP_ADD();
            frm_add.id = 0;
            frm_add.btn_add.Text="ek";
            frm_add.Show();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            update_data();
        }

        private void gridControl1_Move(object sender, EventArgs e)
        {

        }
        //delet
        private void btn_delet_Click(object sender, EventArgs e)
        {
            
            toast Toast = new toast();
            dialog dialog = new dialog();
            try
            {
                id = Convert.ToInt32(tileView1.GetFocusedRowCellValue("ID"));
                var rs = MessageBox.Show("silme işlemi", "bub işlemden eminmisin", MessageBoxButtons.YesNo);
                if (rs == DialogResult.Yes)
                {

                    tb_supp = db.TB_Supp.Where(x => x.ID == id).FirstOrDefault();

                    db.Entry(tb_supp).State = EntityState.Deleted;
                    db.SaveChanges();
                    Toast.txt_caption.Text = "bir kaynak silindi";
                    Toast.Show();
                    update_data();
                    

                 }

            }
            
            catch
            {
                dialog.txt_caption.Text = "silinecek kaynak yok";
                dialog.Width = this.Width;
                dialog.Show();


            }


            
            }

        private void update_data()
        {
            db = new satış_yönetimiEntities();
            gridControl1.DataSource = db.TB_Supp.ToList();

        }
        
        
        //search
        private void btn_serch_Click(object sender, EventArgs e)
        {
            var _search = edit_sarch.Text;
            gridControl1.DataSource = db.TB_Supp.Where(x => x.supp_name.Contains(_search)|| x.supp_phone.Contains(_search) || x.supp_email.Contains(_search)).ToList();
        }
        //edit
        private void btn_edit_Click(object sender, EventArgs e)
        {
            pl.FFRM_SUPP_ADD frm_add = new FFRM_SUPP_ADD();
            id = Convert.ToInt32(tileView1.GetFocusedRowCellValue("ID"));
            tb_supp = db.TB_Supp.Where(x => x.ID == id).FirstOrDefault();
            frm_add.edt_name.Text = tb_supp.supp_name.ToString();
            frm_add.edt_phone.Text = tb_supp.supp_phone.ToString();
            frm_add.etd_email.Text = tb_supp.supp_email.ToString();
            methats.by = tb_supp.supp_image;
            frm_add.pic_cover.Image = Image.FromStream(methats.convert_image());
            frm_add.id = id;
            frm_add.btn_add.Text = "değiştir";
            frm_add.Show();
        }
    }
    }
