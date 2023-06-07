using CrystalDecisions.Shared;
using Magazine.Reports;
using Oracle.DataAccess.Client;
using System;
using System.Data;
using System.Windows.Forms;



namespace Magizine_project
{
    public partial class generate : Form
    {
        CrystalReport1 cr;
        CrystalReport2 cr1;

        #region Database Connection

        string ordb = "Data source=orcl;User Id=scott; Password=tiger;";
        OracleConnection conn;

        #endregion
        public generate()
        {
            InitializeComponent();
        }

        #region FORM LOAD
        private void CategoryLists_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            displayUsers();
            cr = new CrystalReport1();
            cr1 = new CrystalReport2();
            foreach (ParameterDiscreteValue v in cr.ParameterFields[0].DefaultValues)
                rjComboBox1.Items.Add(v.Value);

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

        #region Display all Users
        void displayUsers()
        {
            try
            {

                OracleCommand c = new OracleCommand();
                conn.Open();
                c.Connection = conn;
                c.CommandText = "select USERNAME from USERR ";
                c.CommandType = CommandType.Text;

                OracleDataReader dr = c.ExecuteReader();
                while (dr.Read())
                {
                    rjComboBox1.Items.Add(dr[0]);
                }
                dr.Close();

        

            }
            catch (Exception)
            {
                MessageBox.Show("Invalid data");
            }
        }

        #endregion

        #region Generate Specific User Info
        private void rjButton1_Click(object sender, EventArgs e)
        {
            cr.SetParameterValue(0, rjComboBox1.Texts);
            crystalReportViewer1.ReportSource = cr;
        }
        #endregion

        #region Generate Complete Report
        private void rjButton2_Click(object sender, EventArgs e)
        {
            crystalReportViewer1.ReportSource = cr1;
        }

        #endregion

    }
}
