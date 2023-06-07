using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace Magizine_project
{

    public partial class Team : Form
    {
        #region Rounded Form
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect,int nTopRect,int nRightRect,int nBottomRect,int nWidthEllipse,int nHeightEllipse);

        #endregion

        public Team()
        {
            InitializeComponent();
        }

        #region Home Form Load
        private void Form1_Load(object sender, EventArgs e)
        {
            // make winform rounded
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 50, 50)); 
        }

        #endregion

        #region back Button
        private void hoverButton4_Click(object sender, EventArgs e)
        {
            Main form = new Main();
            form.Show();
            form.Owner = this;
            this.Hide();
        }

        #endregion

    }
}
