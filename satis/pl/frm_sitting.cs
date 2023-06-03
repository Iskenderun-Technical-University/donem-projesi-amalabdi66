using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Configuration;



namespace suaadabdu.pl
{
    public partial class frm_sitting  : Form
    {

       
        private object Configurationmanager;

        public frm_sitting()
        {
            InitializeComponent();
            
        }


        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            const string qu = "\"";
            var sv = edt_sv.Text;
            var constr = @"metadata=res://*/SMPM.csdl|res://*/SMPM.ssdl|res://*/SMPM.msl;provider=System.Data.SqlClient;provider connection string="+qu+";data source=" + sv + ";initial catalog=satış_yönetimi;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework\";";
        
            var config = Configurationmanager.openexeconfiguration(configurationUserLeve1.none);
        
        }

    }
    }

