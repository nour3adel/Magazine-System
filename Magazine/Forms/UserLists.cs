using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace Magizine_project
{
    public partial class UserLists : Form
    {

        #region Database Connection
        string ordb = "Data Source=orcl;User Id=scott;Password=tiger;";

        OracleDataAdapter Adapter;
        DataSet ds;
        OracleCommandBuilder builder;
        #endregion
        public UserLists()
        {
            InitializeComponent();
        }

        #region FORM LOAD
        private void UserLists_Load(object sender, EventArgs e)
        {
            string q = "select * from USERR ";
            ds = new DataSet();
            Adapter = new OracleDataAdapter(q, ordb);
            builder = new OracleCommandBuilder(Adapter);
            Adapter.Fill(ds);
            dataGridView2.DataSource = ds.Tables[0];
        }
        #endregion

        #region Save Changes
        private void rjButton1_Click(object sender, EventArgs e)
        {

            try
            {
                Adapter.Update(ds.Tables[0]);
                var result = RJMessageBox.Show("Update Succefuly");


            }
            catch (Exception)
            {
                var result = RJMessageBox.Show("Update Failed",
               "",
               MessageBoxButtons.OK,
               MessageBoxIcon.Error);

            }
  
        }
        #endregion

        #region EXIT Button
        private void exit_Click(object sender, EventArgs e)
        {
            var result = RJMessageBox.Show("Close Application? ",
                "Alert",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        #endregion

    }
}
