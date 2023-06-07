using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;


namespace Magizine_project
{
    public partial class Dashboard : Form
    {
        #region Database Connection

        string ordb = "Data Source=orcl;User Id=scott;Password=tiger;";
        OracleConnection conn;

        #endregion
        public Dashboard()
        {
            InitializeComponent();
        }

        #region FORM lOAD
        private void Dashboard_Load(object sender, EventArgs e)
        {

            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand("SELECT COUNT(*) FROM USERR", conn);
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            label4.Text = count.ToString();

            OracleCommand cmd2 = new OracleCommand("SELECT COUNT(*) FROM MAGAZINE", conn);
            int count2 = Convert.ToInt32(cmd2.ExecuteScalar());
            label3.Text = count2.ToString();

            OracleCommand cmd3 = new OracleCommand("SELECT COUNT(DISTINCT CATEGORY) FROM MAGAZINE", conn);
            int count3 = Convert.ToInt32(cmd3.ExecuteScalar());
            label7.Text = count3.ToString();

            OracleCommand cmd4 = new OracleCommand("SELECT COUNT(DISTINCT AUTHOR) FROM MAGAZINE", conn);
            int count4 = Convert.ToInt32(cmd4.ExecuteScalar());
            label6.Text = count4.ToString();

            OracleCommand cmd5 = new OracleCommand("SELECT COUNT(*) FROM ORDERR", conn);
            int count5 = Convert.ToInt32(cmd5.ExecuteScalar());
            label5.Text = count5.ToString();

            OracleCommand cmd6 = new OracleCommand("select sum(TOTAL) from ORDERR", conn);
            int count6 = Convert.ToInt32(cmd6.ExecuteScalar());
            label8.Text = count6.ToString() + " $";
            conn.Close();

          

        }
        #endregion

        #region EXIT
        private void exit_Click(object sender, EventArgs e)
        {
            var result = RJMessageBox.Show("Close Application? ",
            "Alert",
            MessageBoxButtons.OKCancel,
            MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
        }
        #endregion

    }
}
