using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Magizine_project
{
    public partial class CategoryLists : Form
    {

        #region Databsae Connection
        string ordb = "Data source=orcl;User Id=scott; Password=tiger;";

        OracleConnection conn;
        OracleDataAdapter Adapter;
        DataSet ds;
        OracleCommandBuilder builder;

        #endregion

        public CategoryLists()
        {
            InitializeComponent();
        }

        #region FORM LOAD
        private void CategoryLists_Load(object sender, EventArgs e)
        {
            roundedButton4.Visible = false;
            conn = new OracleConnection(ordb);
            list();
        }
        #endregion

        #region List Of Magazine
        private void list()
        {
            OracleCommand cmd = new OracleCommand();
            conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = "magazin_list";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("id", OracleDbType.RefCursor, ParameterDirection.Output);
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                rjComboBox1.Items.Add(dr[0]);
            }
            dr.Close();
            conn.Close();
        }

        #endregion

        #region Get User ID
        int getid()
        {
            string str = Login.Instance.username;

            int r = 0;
            try
            {
                conn.Open();
                OracleCommand c = new OracleCommand();
                c.Connection = conn;
                c.CommandText = "SELECT U_ID FROM USERR WHERE USERNAME=:username";
                c.Parameters.Add(new OracleParameter("username", OracleDbType.Varchar2, str, ParameterDirection.Input));
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

        #region Get Magazine Details 
        int[] ret_info_MAg()
        {
            int[] inf = new int[3];
            OracleCommand cmd = new OracleCommand();
            conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = "Getp";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("name", rjComboBox1.SelectedItem);
            cmd.Parameters.Add("iid", OracleDbType.Int32, ParameterDirection.Output);
            cmd.Parameters.Add("pri", OracleDbType.Int32, ParameterDirection.Output);
            cmd.Parameters.Add("quan", OracleDbType.Int32, ParameterDirection.Output);
            cmd.ExecuteNonQuery();
            inf[0] = Convert.ToInt32(cmd.Parameters["iid"].Value.ToString());
            inf[1] = Convert.ToInt32(cmd.Parameters["pri"].Value.ToString());
            inf[2] = Convert.ToInt32(cmd.Parameters["quan"].Value.ToString());
            conn.Close();
            return inf;
        }
        int[] info = new int[3];

        private void rjComboBox1_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            info = ret_info_MAg();
        }

        #endregion

        #region Change Total Price
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (info[2] - numericUpDown1.Value >= 0)
            {
                label2.Text = Convert.ToString(info[1] * numericUpDown1.Value);
            }
            else
            {
                var result = RJMessageBox.Show("From this magazine there are" + info[2]);
                numericUpDown1.Value = info[2];
            }
        }
        #endregion

        #region Make Order
        void makeorder()
        {
            int x = getid();
            if (rjComboBox1.Texts == "" || rjComboBox1.Texts == "Select") 
            {
                RJMessageBox.Show("Please Select Item:");
            }
            else
            {
                if (numericUpDown1.Value == 0)
                {
                    RJMessageBox.Show("Invalid Quantity");

                }
                else
                {
                    OracleCommand cmd1 = new OracleCommand();
                    conn.Open();
                    cmd1.Connection = conn;
                    cmd1.CommandText = "GetorderID";
                    cmd1.CommandType = CommandType.StoredProcedure;
                    cmd1.Parameters.Add("id", OracleDbType.Int32, ParameterDirection.Output);
                    cmd1.ExecuteNonQuery();
                    try
                    {
                        max = Convert.ToInt32(cmd1.Parameters["id"].Value.ToString());
                        newid = max + 1;
                    }
                    catch { newid = 0; }
                    try
                    {
                        OracleCommand cmd = new OracleCommand();

                        cmd.Connection = conn;
                        cmd.CommandText = "insert into orderr Values(:od,:Cost,:dorder,:useri)"; cmd.Parameters.Add("od", newid);
                        cmd.Parameters.Add("Cost", 1.0);
                        cmd.Parameters.Add("dorder", DateTime.Now.Date);
                        cmd.Parameters.Add("useri", x);

                        cmd.ExecuteNonQuery();
                        conn.Close();
                        additem(newid);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Error in data");
                        conn.Close();
                    }


               


                    rjComboBox1.Texts = "";
                    rjComboBox1.Items.Clear();
                    numericUpDown1.Value = 0;
                    label2.Text = "";
                    list();

                }
            }
        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {
            makeorder();
        }

        #endregion

        #region Save Order in database
        void savee()
        {
            roundedButton4.Visible = false;
            roundedButton1.Visible = true;

            conn.Open();
            OracleCommand c = new OracleCommand();
            c.Connection = conn;
            c.CommandText = "update ORDERR set TOTAL=:newq where O_ID =:id";
            int x = Convert.ToInt32(label1.Text);
            c.Parameters.Add("newq", x.ToString());
            c.Parameters.Add("id", newid);
            c.ExecuteNonQuery();
            conn.Close();
            RJMessageBox.Show("order succsses");

            dataGridView1.DataSource = null;
            dataGridView1.Refresh();
        }

        #endregion

        #region Add Extra Items

        int max = 0, newid = 0;
        void additem(int newidd)
        {
            int maxc = 0, idc = 0;
            if (rjComboBox1.Texts == "" || rjComboBox1.Texts == "Select")
            {
                RJMessageBox.Show("Please Select Item:");
            }
            else
            {

                if (numericUpDown1.Value == 0)
                {
                    RJMessageBox.Show("Invalid Quantity");

                }
                else
                {
                    conn.Open();
                    OracleCommand cmd1 = new OracleCommand();

                    cmd1.Connection = conn;
                    cmd1.CommandText = "GetCRTID";
                    cmd1.CommandType = CommandType.StoredProcedure;
                    cmd1.Parameters.Add("id", OracleDbType.Int32, ParameterDirection.Output);
                    cmd1.ExecuteNonQuery();
                    try
                    {
                        maxc = Convert.ToInt32(cmd1.Parameters["id"].Value.ToString());
                        idc = maxc + 1;
                    }
                    catch { idc = 0; }
                    OracleCommand cmd2 = new OracleCommand();
                    cmd2.Connection = conn;
                    cmd2.CommandText = "insert into CART Values(:mid,:itemqty,:itemprice,:usero ,:cid)";
                    cmd2.Parameters.Add("mid", info[0]);
                    cmd2.Parameters.Add("itiemqty", numericUpDown1.Value);
                    cmd2.Parameters.Add("itemprice", Convert.ToInt32(label2.Text));
                    cmd2.Parameters.Add("usero", newidd);
                    cmd2.Parameters.Add("usero", idc);
                    cmd2.ExecuteNonQuery();
                    // conn.Close();
                    string q = "select CC.CA_ID,M.NAMEE,CC.QUANTITY ,CC.PRICE from CART CC , MAGAZINE M where :oid = CC.OR_ID and CC.MA_ID = M.M_NO";
                    DataSet ds1 = new DataSet();
                    Adapter = new OracleDataAdapter(q, ordb);
                    Adapter.SelectCommand.Parameters.Add(":oid", newidd);
                    builder = new OracleCommandBuilder(Adapter);
                    Adapter.Fill(ds1);
                    dataGridView1.DataSource = ds1.Tables[0];
                    // conn.Open();
                    OracleCommand c = new OracleCommand();
                    c.Connection = conn;
                    c.CommandText = "select SUM(PRICE) from CART where  OR_ID=:id";
                    c.Parameters.Add("id", newidd);
                    OracleDataReader dr = c.ExecuteReader();
                    while (dr.Read())
                    {

                        label1.Text = dr[0].ToString();
                    }
                    dr.Close();
                    OracleCommand cm = new OracleCommand();
                    cm.Connection = conn;
                    cm.CommandText = "update MAGAZINE set QUANTITY=:newqq where M_NO =:id";

                    cm.Parameters.Add("newqq", (info[2] - numericUpDown1.Value));
                    cm.Parameters.Add("id", info[0]);
                    cm.ExecuteNonQuery();

                    conn.Close();

                    if (info[2] - numericUpDown1.Value != 0)
                    {

                        var result = RJMessageBox.Show("You Want to Add New item ?",
                        "Make an Order",
                        MessageBoxButtons.YesNo);

                        if (result == DialogResult.Yes)
                        {
                            roundedButton4.Visible = true;
                            roundedButton1.Visible = false;
                        }
                        else if (result == DialogResult.No)
                        {
                            savee();
                        }
                    }
                    else
                    {
                        savee();
                    }
                rjComboBox1.Text = "";
                rjComboBox1.Items.Clear();
                numericUpDown1.Value = 0;
                label2.Text = "";
                label1.Text = "";
                list();
                }
            }
        }


        private void roundedButton4_Click(object sender, EventArgs e)
        {
            additem(newid);

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
    }
}
