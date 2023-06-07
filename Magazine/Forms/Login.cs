using CustomControls;
using CustomControls.RJControls;
using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Magizine_project
{
    public partial class Login : Form
    {
        #region  Rounded Form

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
(
    int nLeftRect,
    int nTopRect,
    int nRightRect,
    int nBottomRect,
    int nWidthEllipse,
    int nHeightEllipse
);
        #endregion
        public static Login Instance { get; private set; }
        public string username { get; set; }

        #region Database information
        string ordb = "Data Source=orcl;User Id=scott;Password=tiger;";
        #endregion

        public Login()
        {
            InitializeComponent();
            Instance = this;
        }

        #region Login Form Load
        private void Login_Load(object sender, EventArgs e)
        {
            // make winform rounded
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 50, 50)); 
        }

        #endregion

        #region Password Toggle
        private void rjToggleButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (rjToggleButton2.CheckState == CheckState.Checked)
            {
                login_pass.PasswordChar = false;

            }

            if (rjToggleButton2.CheckState == CheckState.Unchecked)
            {

                login_pass.PasswordChar = true;
            }


        }
        #endregion

        #region Don't Have Account ( Sign UP ) Button
        private void label7_Click(object sender, EventArgs e)
        {
            SignUp form = new SignUp();
            form.Show();
            form.Owner = this;
            this.Hide();
        }
        #endregion

        #region Forgot Password Button
        private void label4_Click(object sender, EventArgs e)
        {
            Recover form = new Recover();
            form.Show();
            form.Owner = this;
            this.Hide();

        }
        #endregion

        #region Signin Button
        public string x;
        private void Signinbtn_Click(object sender, EventArgs e)
        {
    

            if (login_usrname.Texts != string.Empty && login_pass.Texts != string.Empty)
            {
                login_usrname.BorderColor = Color.Black;
                login_pass.BorderColor = Color.Black;
                using (OracleConnection connection = new OracleConnection(ordb))
                {
                    try
                    {
                        connection.Open();

                        string sqlQuery = "SELECT PASS,admin FROM USERR WHERE username = :username";

                        using (OracleCommand command = new OracleCommand(sqlQuery, connection))
                        {
                            // Set parameter values
                            command.Parameters.Add(new OracleParameter("username", login_usrname.Texts.Trim()));

                            
                            using (OracleDataReader reader = command.ExecuteReader())
                            {
                                if (reader.HasRows)
                                {
                                    while (reader.Read())
                                    {
                                        x = login_usrname.Texts.Trim();
                                        string dbPass = reader["PASS"].ToString().Trim();
                                        string inputPass = login_pass.Texts.Trim();

                            
                                        if (dbPass == inputPass)
                                        {
                                            if (reader["admin"].ToString().Trim() == "y")
                                            {
                                                var result = RJMessageBox.Show("WELCOME ADMIN");
                                                username = login_usrname.Texts.Trim();
                                                Admin form = new Admin();
                                                form.Show();
                                                form.Owner = this;
                                                this.Hide();
                                            }
                                            else
                                            {
                                                var result = RJMessageBox.Show("WELCOME " + login_usrname.Texts.ToUpper());
                                                username = login_usrname.Texts.Trim();
                                                Users form = new Users();
                                                form.Show();
                                                form.Owner = this;
                                                this.Hide();

                                            }

                                        }
                                        else
                                        {
                                            RJMessageBox.Show("Invalid password.");
                                        }



                                    }
                                }
                                else
                                {
                                    RJMessageBox.Show("Your are not registerd");
                                }
                            }
                        }

                    }
                    catch (Exception ex)
                    {
                        RJMessageBox.Show("Error: " + ex.Message);
                    }
                }


            }
            else
            {
                RJMessageBox.Show("Make sure you correctly fill up the form");
                login_usrname.BorderColor = Color.Red;
                login_pass.BorderColor = Color.Red;
           
            }


        }



     
        public string TextBoxText
        {
            get { return x; }
        }




        #endregion

        #region RETURN
        private void hoverButton1_Click(object sender, EventArgs e)
        {
            Main mn = new Main();
            mn.Show();
            mn.Owner = this;
            this.Hide();

        }
        #endregion

    }
}
