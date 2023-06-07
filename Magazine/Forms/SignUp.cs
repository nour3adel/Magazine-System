using CustomControls;
using Oracle.DataAccess.Client;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Magizine_project
{
    public partial class SignUp : Form
    {

        #region Database information
        string ordb = "Data Source=orcl;User Id=scott;Password=tiger;";
        #endregion

        #region Rounded Form

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect,int nTopRect,int nRightRect,int nBottomRect,int nWidthEllipse,int nHeightEllipse);

        #endregion
        public SignUp()
        {
            InitializeComponent();
        }
   
        #region SignUp Form Load
        private void SignUp_Load(object sender, EventArgs e)
        {
            // make winform rounded
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 50, 50));
        }

        #endregion

        #region Checkbox
        private void checkboxTerms_CheckedChanged(object sender, EventArgs e)
        {

        }

        #endregion

        #region return button
        private void hoverButton4_Click(object sender, EventArgs e)
        {
            Login form = new Login();
            form.Show();
            form.Owner = this;
            this.Hide();
        }

        #endregion

        #region Password Toggle
        private void passtoggle_CheckedChanged(object sender, EventArgs e)
        {
            if (pass_toggle.CheckState == CheckState.Checked)
            {
                signup_pass.PasswordChar = false;
                signup_pass2.PasswordChar = false;

            }

            if (pass_toggle.CheckState == CheckState.Unchecked)
            {

                signup_pass.PasswordChar = true;
                signup_pass2.PasswordChar = true;
            }
        }

        #endregion

        #region create account 
        private void Createbtn_Click(object sender, EventArgs e)
        {
            if (email.Texts != string.Empty && signup_usr.Texts != string.Empty && signup_pass.Texts != string.Empty && signup_pass2.Texts != string.Empty)
            {


                using (OracleConnection connection = new OracleConnection(ordb))
                {
                    connection.Open();
                    string countQuery = "SELECT COUNT(*) FROM USERR";
                    int userCount = 0;

                    using (OracleCommand command = new OracleCommand(countQuery, connection))
                    {
                        userCount = Convert.ToInt32(command.ExecuteScalar());
                    }
                    string emailToSearch = email.Texts.Trim(); // Replace with appropriate username.

                    var exist = "SELECT * FROM USERR WHERE email = :emailToSearch";
                 
                    using (var command = new OracleCommand(exist, connection))
                    {
                        command.Parameters.Add(new OracleParameter("email", emailToSearch));
                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                var result = RJMessageBox.Show("Email is already Registered");

                            }
                            
                            else
                            {
                                string sqlQuery = "INSERT INTO USERR (U_ID, USERNAME, PASS,EMAIL,ADMIN) VALUES (:U_ID, :USERNAME, :PASS , :EMAIL,'n')";
                                // Replace Employees with your actual table name and emp_id, first_name, last_name with your actual column names
                                using (OracleCommand command1 = new OracleCommand(sqlQuery, connection))
                                {


                                    command1.Parameters.Add(new OracleParameter("U_ID", userCount + 1));
                                    command1.Parameters.Add(new OracleParameter("USERNAME", signup_usr.Texts));
                                    command1.Parameters.Add(new OracleParameter("PASS", signup_pass.Texts));
                                    command1.Parameters.Add(new OracleParameter("EMAIL", email.Texts));
                                    if (signup_pass.Texts == signup_pass2.Texts)
                                    {
                                        if (checkboxTerms.Checked == true)
                                        {
                                            int rowsInserted = command1.ExecuteNonQuery();

                                            if (rowsInserted > 0)
                                            {
                                                var result = RJMessageBox.Show("Account successfully created, Please Sign In");
                                                checkboxTerms.Checked = false;
                                                Login form = new Login();
                                                form.Show();
                                                form.Owner = this;
                                                this.Hide();

                                            }
                                            else
                                            {
                                                var result = RJMessageBox.Show("Register failed.");
                                            }
                                        }
                                        else
                                        {
                                            var result = RJMessageBox.Show("Don't forget to check the Terms and Privacy Policy");
                                        }
                                    }
                                    else
                                    {
                                        var result = RJMessageBox.Show("Make sure your password is identical");
                                    }



                                }
                              
                        }
                        }
                    }

   
                }

     
            }
            else
            {
                var result = RJMessageBox.Show("Make sure you correctly fill up the form");
            }
        }

        #endregion

        #region Signup email
        private void email__TextChanged(object sender, EventArgs e)
        {
            if (email.Texts != string.Empty)
            {
                if (email.Texts.EndsWith(".com"))
                {
                    email.BorderColor = Color.FromArgb(0, 128, 0);
                }
        

            }
            else
            {
                email.BorderColor = Color.FromArgb(255, 0, 0);

            }
        }

        #endregion

        #region Signup Username
        private void signup_usr__TextChanged(object sender, EventArgs e)
        {
            if (signup_usr.Texts != string.Empty)
            {
                if (signup_usr.Texts.Length >= 8)
                {
                    signup_usr.BorderColor = Color.FromArgb(0, 128, 0);
                }
                else
                {
                    signup_usr.BorderColor = Color.FromArgb(255, 0, 0);
                }
            }
            else
            {
                signup_usr.BorderColor = Color.FromArgb(255, 0, 0);
            }
        }

        #endregion

        #region Signup Password
        private void signup_pass__TextChanged(object sender, EventArgs e)
        {
            if (signup_pass.Texts != string.Empty)
            {
                if (signup_pass.Texts.Length >= 8)
                {
                    signup_pass.BorderColor = Color.FromArgb(0, 128, 0);
                }
                else
                {
                    signup_pass.BorderColor = Color.FromArgb(255, 0, 0);
                    signup_pass2.BorderColor = Color.FromArgb(255, 0, 0);

                }



            }
            else
            {
                signup_pass.BorderColor = Color.FromArgb(255, 0, 0);
            }
        }
        #endregion

        #region Signup Password Confirm
        private void signup_pass2__TextChanged(object sender, EventArgs e)
        {
            if (signup_pass2.Texts != string.Empty)
            {
                if (signup_pass.Texts.Length >= 8)
                {
                    if (signup_pass2.Texts == signup_pass.Texts)
                    {
                        signup_pass2.BorderColor = Color.FromArgb(0, 128, 0);

                    }
                    else
                    {
                        signup_pass2.BorderColor = Color.FromArgb(255, 0, 0);
                    }
                }
                else
                {
                    signup_pass2.BorderColor = Color.FromArgb(255, 0, 0);

                }


            }
            else { 
               signup_pass2.BorderColor = Color.FromArgb(255, 0, 0);
            }
        }

        #endregion

        #region already have ( Log in )
        private void linkSignIn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login form = new Login();
            form.Show();
            form.Owner = this;
            this.Hide();
        }
        #endregion

    }
}
