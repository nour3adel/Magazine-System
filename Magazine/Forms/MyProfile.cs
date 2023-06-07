using Oracle.DataAccess.Client;
using System;
using System.Data;
using System.Windows.Forms;
using Magazine.Properties;

namespace Magizine_project
{
    public partial class MyProfile : Form
    {
       
        #region Database information

        string ordb = "Data source=orcl;User Id=scott; Password=tiger;";
        OracleConnection conn;

        #endregion

        public MyProfile()
        {

            InitializeComponent();
        }

        #region FORM LOAD
        private void MyProfile_Load(object sender, EventArgs e)
        {          
            DisplayProfile();
        }
        #endregion

        #region Display Profile
        void DisplayProfile()
        {
            try
            {
                string str = Login.Instance.username;


                conn = new OracleConnection(ordb);
                OracleCommand c = new OracleCommand();
                conn.Open();

                c.Connection = conn;
                c.CommandText = "select * from USERR where USERNAME = :username";
                c.Parameters.Add(new OracleParameter("username", OracleDbType.Varchar2)).Value = str;
                OracleDataReader dr = c.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                if (dt.Rows.Count > 0)
                {
                    Username.Text = str;
                    rjTextBox3.Texts = dt.Rows[0]["FNAME"].ToString();
                    rjTextBox10.Texts = dt.Rows[0]["LNAME"].ToString();
                    rjTextBox2.Texts = dt.Rows[0]["ADDRESS"].ToString();
                    Email.Text = dt.Rows[0]["EMAIL"].ToString();
                    rjTextBox9.Texts = dt.Rows[0]["Bio"].ToString();
                    string gender = dt.Rows[0]["Gender"].ToString();
                    if (rjComboBox1.Items.Contains(gender))
                    {
                        rjComboBox1.SelectedItem = gender;
                    }
             

                }
                dr.Close();
                conn.Close();

                if(rjComboBox1.SelectedItem.ToString() == null || rjComboBox1.Texts == "Select")
                {
                    //Do Nothing
                }
                else
                {
                    if (rjComboBox1.SelectedItem.ToString() == "Male")
                    {

                        if (str == "nour3del")
                        {
                            rjCircularPictureBox1.BackgroundImage = Resources.nour;
                        }
                        else
                        {
                            rjCircularPictureBox1.BackgroundImage = Resources.user;
                        }

                    }
                    else
                    {
                        rjCircularPictureBox1.BackgroundImage = Resources.woman;
                    }
                }
               

            }
            catch (Exception)
            {
                
            }
        }

        #endregion

        #region Update Profile
        private void UpdateUserData()
        {
           string str = Login.Instance.username;

            try
            {
                using (OracleConnection conn = new OracleConnection(ordb))
                {
                    conn.Open();

                    using (OracleCommand cmd = new OracleCommand("UPDATE USERR SET FNAME = :fname, LNAME = :lname, ADDRESS = :address, Bio = :bio , Gender = :gender  WHERE USERNAME = :username", conn))
                    {

                        cmd.Parameters.Add(new OracleParameter("fname", OracleDbType.Varchar2)).Value = rjTextBox3.Texts;
                        cmd.Parameters.Add(new OracleParameter("lname", OracleDbType.Varchar2)).Value = rjTextBox10.Texts;
                        cmd.Parameters.Add(new OracleParameter("address", OracleDbType.Varchar2)).Value = rjTextBox2.Texts;
                        cmd.Parameters.Add(new OracleParameter("bio", OracleDbType.Varchar2)).Value = rjTextBox9.Texts;
                        cmd.Parameters.Add(new OracleParameter("gender", OracleDbType.Varchar2)).Value = rjComboBox1.SelectedItem;
                        cmd.Parameters.Add(new OracleParameter("username", OracleDbType.Varchar2, str, ParameterDirection.Input));
                        cmd.ExecuteNonQuery();
                    }
                }

                var result = RJMessageBox.Show("User data updated successfully!");
            }
            catch (Exception ex)
            {
                var result = RJMessageBox.Show("Error updating user data: " + ex.Message);
            }
        }

        #endregion

        #region EXIT
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

        #region Edit Button
        private void rjButton3_Click(object sender, EventArgs e)
        {
            UpdateUserData();
        }

        #endregion

    }
}
