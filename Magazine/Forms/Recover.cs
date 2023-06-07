using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using MimeKit;
using Oracle.DataAccess.Client;


namespace Magizine_project
{
    public partial class Recover : Form
    {

        #region Rounded FORM
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect,int nTopRect,int nRightRect,int nBottomRect,int nWidthEllipse,int nHeightEllipse);
        #endregion

        #region Database information
        string ordb = "Data Source=orcl;User Id=scott;Password=tiger;";
        #endregion
        public Recover()
        {
            InitializeComponent();
        }
        
        #region Recover Form Load
        private void Recover_Load(object sender, EventArgs e)
        {
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 50, 50)); // make winform rounded

        }
        #endregion

        #region Return
        private void hoverButton4_Click(object sender, EventArgs e)
        {
            Login form = new Login();
            form.Show();
            form.Owner = this;
            this.Hide();
        }
        #endregion

        #region Password Toggle
        private void rjToggleButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (rjToggleButton2.CheckState == CheckState.Checked)
            {
                pass.PasswordChar = false;
                pass_confirm.PasswordChar = false;

            }

            if (rjToggleButton2.CheckState == CheckState.Unchecked)
            {

                pass.PasswordChar = true;
                pass_confirm.PasswordChar = true;
            }
        }
        #endregion

        #region OTP BUTTON
        private string generateOTP()
        {
            email.BorderColor = Color.FromArgb(0, 128, 0);
            //OTP generator
            string otp_char = "0123456789";
            OTP = "";
            Random rnd = new Random();

            for (int i = 0; i < 6; i++)
            {

                var random_char = otp_char[rnd.Next(1, otp_char.Length)];
                OTP += random_char;

            }
            return OTP;
        }
     
        private void rjButton1_Click(object sender, EventArgs e)
        {
            using (OracleConnection connection = new OracleConnection(ordb))
            {
                connection.Open();
      
                string sqlQuery = "SELECT email FROM USERR WHERE email = :email";

                using (OracleCommand command = new OracleCommand(sqlQuery, connection))
                {
                    command.Parameters.Add(new OracleParameter("email", email.Texts.Trim()));

                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        string emailToSearch = email.Texts.Trim();

                 
                        if (reader.Read() )
                        {


                            //initialize variables
                            string msg = generateOTP();
                            string senderEmail, senderPass, receiverEmail;
                            receiverEmail = email.Texts;
                            senderEmail = "magazinesystem1@gmail.com";
                            senderPass = "uucnsuujooroulgo";  //Gmail's App Password Change this to your Gmail's App Password

                            MimeMessage message = new MimeMessage(); // Creating object for Message
                            message.From.Add(new MailboxAddress("Magazine System ", senderEmail)); //Sender's information
                            message.To.Add(MailboxAddress.Parse(receiverEmail)); //Receiver's Information

                            message.Subject = "One-Time-Password"; //Email's Subject

                            //Email's Body
                            message.Body = new TextPart("plain") //Plain text
                            {
                                Text = msg + " is your OTP" //MSG = OTP
                            };

                            MailKit.Net.Smtp.SmtpClient client = new MailKit.Net.Smtp.SmtpClient();



                            try
                            {
                                client.Connect("smtp.gmail.com", 465, true); //Gmail's smtp server, PORT: 465
                                client.Authenticate(senderEmail, senderPass); //Login sender's email and password
                                client.Send(message); //
                                RJMessageBox.Show("Kindly Check your email and don't forget to check your SPAM folders");
                            }
                            catch (Exception ex)
                            {
                                RJMessageBox.Show(ex.Message); //if errors display message
                            }
                            finally
                            {
                                client.Disconnect(true); // always disconnect
                                client.Dispose();
                            }
                        }
                        else
                        {

                            RJMessageBox.Show("Email is not registered");
                            email.BorderColor = Color.FromArgb(255, 0, 0);
                        }
                    }
                }
            }








        }
        #endregion

        #region  Recover BUTTON
        public string OTP;
        private void rjButton3_Click(object sender, EventArgs e)
        {
           
            if (email.Texts != string.Empty && pass.Texts != string.Empty && pass_confirm.Texts != string.Empty && OTPrec.Texts != string.Empty)
            {
                email.BorderColor = Color.FromArgb(0, 128, 0);
                if (OTPrec.Texts == OTP)
                    {
                    OTPrec.BorderFocusColor = Color.FromArgb(0, 128, 0);
                    if (pass.Texts == pass_confirm.Texts)
                        {  
                           
                            using (OracleConnection connection = new OracleConnection(ordb))
                                {
                                    connection.Open();

                                    string updateemail = email.Texts.Trim(); // Replace with appropriate username.
                                    string newPassword = pass.Texts.Trim(); // Get new password from textbox

                                    string sqlQuery = "UPDATE USERR SET PASS = :newPassword WHERE email = :updateemail";

                                    using (OracleCommand command = new OracleCommand(sqlQuery, connection))
                                    {
                                        command.Parameters.Add(new OracleParameter("newPassword", newPassword));
                                        command.Parameters.Add(new OracleParameter("email", updateemail));

                                        int rowsUpdated = command.ExecuteNonQuery();

                                        if (rowsUpdated > 0)
                                        {
                                       var result = RJMessageBox.Show("Account recovered successfully, Login");

                                        Login form = new Login();
                                        form.Show();
                                        form.Owner = this;
                                        this.Hide();
                                    }
                                        else
                                        {
                                        var result = RJMessageBox.Show("Failed To Recover The Account");

                                        }
                                    }
                                }


                            
                          
                        }
                        else
                        {
                        pass_confirm.BorderColor = Color.FromArgb(255, 0, 0);
                        var result = RJMessageBox.Show("Password are not identical");
                        }
                    }
                    else
                    {
                    OTPrec.BorderColor = Color.FromArgb(255, 0, 0);
                    var result = RJMessageBox.Show("Invalid OTP");
                    }

                }
              
            
            else
            {
                var result = RJMessageBox.Show("Make sure you correctly fill up the form");
                email.BorderColor = Color.FromArgb(255, 0, 0);
            }


        }

        #endregion

        #region Email
        private void email__TextChanged(object sender, EventArgs e)
        {
     
        }
        #endregion

        #region OTP TEXTBOX
        private void OTP__TextChanged(object sender, EventArgs e)
        {
            
           if (OTPrec.Texts == OTP)
             {
               OTPrec.BorderColor = Color.FromArgb(0, 128, 0);
             }
          
        }
        #endregion

        #region New Password
        private void pass__TextChanged(object sender, EventArgs e)
        {

        }
        #endregion

        #region New Password Confirm
        private void pass_confirm__TextChanged(object sender, EventArgs e)
        {
            if (pass_confirm.Texts != string.Empty)
            {

                if (pass.Texts == pass_confirm.Texts)
                {
                    pass_confirm.BorderColor = Color.FromArgb(0, 128, 0);
                    pass.BorderColor = Color.FromArgb(0, 128, 0);
                }
                else
                {
                    pass_confirm.BorderColor = Color.FromArgb(255, 0, 0);
                }


            }
            else
            {
                pass_confirm.BorderColor = Color.FromArgb(255, 0, 0);
            }
        }

        #endregion
    }
}
