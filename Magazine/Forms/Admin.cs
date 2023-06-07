using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;



namespace Magizine_project
{
    public partial class Admin : Form
    {

        #region Rounded FORM
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);
        #endregion
        public Admin()
        {
            InitializeComponent();
        }

        #region Form Load
        private void AdminForm_Load(object sender, EventArgs e)
        {
            // make winform rounded
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 50, 50)); 
        }
        #endregion

        #region PanelControl

        //open forms in panel
        private void openformpanel(Form form)
        {
            // Remove all controls from the panel
            this.ContainerPanel.Controls.Clear();

            // Add the new form to the panel
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            this.ContainerPanel.Controls.Add(form);
            this.ContainerPanel.Tag = form;
            form.Show();

        }
        #endregion 

        #region Log out  button
        private void Return_Click(object sender, EventArgs e)
        {

            var result = RJMessageBox.Show("Log Out",
               "",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Login form = new Login();
                form.Show();
                form.Owner = this;
                this.Hide();
            }
       
        }

        #endregion

        #region MagazineLists
        private void MagazineList_Click(object sender, EventArgs e)
        {
            MagazineList frm = new MagazineList();
            openformpanel(frm);
        }
        #endregion

        #region UserLists
        private void UserLists_Click(object sender, EventArgs e)
        {
            UserLists frm = new UserLists();     
            openformpanel(frm);
        }
        #endregion

        #region Profile
        private void profile_Click(object sender, EventArgs e)
        {
            MyProfile frm = new MyProfile();
            openformpanel(frm);
        }
        #endregion

        #region Generate Report
        private void Settings_Click(object sender, EventArgs e)
        {
            generate frm = new generate();
            openformpanel(frm);
        }
        #endregion

        #region Dashboard
        private void Dashboard_Click(object sender, EventArgs e)
        {
            Dashboard frm = new Dashboard();
            openformpanel(frm);
        }
        #endregion

    }
}
