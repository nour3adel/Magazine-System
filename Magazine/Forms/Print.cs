using System;
using System.Data;
using System.Windows.Forms;
using Magazine.Reports;
using Oracle.DataAccess.Client;

namespace Magizine_project
{
    public partial class Print : Form
    {
        CrystalReport3 cr;

        #region Database Connection
        string ordb = "Data source=orcl;User Id=scott; Password=tiger;";
        OracleConnection conn;
        #endregion
        int r;
        public Print(int x)
        {
            r = x;
            InitializeComponent();     
        }

        #region Form Load
        private void Print_Load(object sender, EventArgs e)
        {
            string str = Login.Instance.username;
            int useri = getid();
            int orderid = r;

            cr = new CrystalReport3();
            cr.SetParameterValue(0, str);
            cr.SetParameterValue(1, orderid);
            cr.SetParameterValue(2, useri);
            crystalReportViewer1.ReportSource = cr;
        }

        #endregion

        #region Get User ID
        int getid()
        {

            string str = Login.Instance.username;
            int r = 0;
            try
            {
                conn = new OracleConnection(ordb);
                conn.Open();
                OracleCommand c = new OracleCommand();
                c.Connection = conn;

                c.CommandText = "SELECT U_ID FROM USERR WHERE USERNAME = :username";
                c.Parameters.Add(new OracleParameter("username", OracleDbType.Varchar2)).Value = str;

                OracleDataReader dr = c.ExecuteReader();
                while (dr.Read())
                {
                    r = Convert.ToInt32(dr[0].ToString());
                }
                dr.Close();
            }
            catch (OracleException ex)
            {
                MessageBox.Show("Oracle error: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return r;
        }

        #endregion

    }
}
