using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Magizine_project
{
    public partial class MyOrder : Form
    {
        #region Database Connection 

        string ordb = "Data source=orcl;User Id=scott; Password=tiger;";

        OracleDataAdapter Adapter;
        DataSet ds;
        OracleCommandBuilder builder;
        OracleConnection conn;
        #endregion
        public MyOrder()
        {
            InitializeComponent();
        }

        #region FORM LOAD
        private void CategoryLists_Load(object sender, EventArgs e)
        {
            roundedButton2.Visible = false;
            roundedButton4.Visible =  false;
            conn = new OracleConnection(ordb);
            list();
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

        #region Display Order
        void displayorder()
        {
            try
            {

                OracleCommand c = new OracleCommand();
                conn.Open();
                c.Connection = conn;
                c.CommandText = "select * from ORDERR where O_ID = :oid";
                string x = rjComboBox1.SelectedItem.ToString();
                c.Parameters.Add("oid", Convert.ToInt32(x));
                OracleDataReader dr = c.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                if (dt.Rows.Count > 0)
                {
                    label3.Text = dt.Rows[0]["O_ID"].ToString();
                    label4.Text = dt.Rows[0]["TOTAL"].ToString();
                    label1.Text = dt.Rows[0]["DATEORDER"].ToString();
                    label2.Text = dt.Rows[0]["U_ID"].ToString();
                }
                dr.Close();
                conn.Close();
            }
            catch (Exception )
            {
                RJMessageBox.Show("Invalid data displayorder");
            }
        }

        #endregion

        #region Display Items
        void displayitem()
        {
            try
            {
                string q = "select CC.CA_ID, M.NAMEE ,CC.QUANTITY,CC.PRICE from CART CC,MAGAZINE M where :oid = CC.OR_ID and CC.MA_ID = M.M_NO";
                ds = new DataSet();
                Adapter = new OracleDataAdapter(q, ordb);
                Adapter.SelectCommand.Parameters.Add(":oid", Convert.ToInt32(rjComboBox1.SelectedItem.ToString()));
                builder = new OracleCommandBuilder(Adapter);
                Adapter.Fill(ds);

                dataGridView1.DataSource = ds.Tables[0];
            }
            catch (Exception)
            {
                RJMessageBox.Show("Invalid data displayitem");
            }
        }

        #endregion

        #region Delete Order
        void deleteorder()
        {
            try
            {
                OracleCommand cmd = new OracleCommand();
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = "Delete from ORDERR  where O_ID=:id";
                cmd.Parameters.Add("id", Convert.ToInt32(rjComboBox1.SelectedItem.ToString()));
                int r1 = cmd.ExecuteNonQuery();
                if (r1 != -1)
                {
                    rjComboBox1.Items.RemoveAt(rjComboBox1.SelectedIndex);
                }
                conn.Close();                
            }
            catch (Exception)
            {
                RJMessageBox.Show("Invalid data deleteorder");
            }
        }

        #endregion

        #region Delete one Item
        void deleteoneitem(int i)
        {
            upqty(i);
            upprice(i);
            try
            {
                OracleCommand c = new OracleCommand();
                conn.Open();
                c.Connection = conn;
                c.CommandText = "Delete from CART  where CA_ID=:id";
                c.Parameters.Add("id", i);
                int r = c.ExecuteNonQuery();
                var result = RJMessageBox.Show("Item deleted");
                dataGridView1.Refresh();
                conn.Close();
                Adapter.Update(ds.Tables[0]);
            }
            catch (Exception)
            {
                var result = RJMessageBox.Show("Invalid data deleteitem");

            }
        }

        #endregion

        #region Get Count Of Items
        int countofitem()
        {
            int r = 0;
            try
            {
                conn.Open();
                OracleCommand c = new OracleCommand();
                c.Connection = conn;
                c.CommandText = "select COUNT(CA_ID) from CART where  OR_ID=:id";
                c.Parameters.Add("id", Convert.ToInt32(rjComboBox1.SelectedItem.ToString()));
                OracleDataReader dr = c.ExecuteReader();
                while (dr.Read())
                {

                    r = Convert.ToInt32(dr[0].ToString());
                }
                dr.Close();
                conn.Close();
            }
            catch (Exception )
            {
                RJMessageBox.Show("Invalid data");
            }
            return r;
        }
        #endregion

        #region Get Quantity
        int[] quantity(int i)
        {
            int[] qty = new int[3];
            OracleCommand c = new OracleCommand();
            conn.Open();
            c.Connection = conn;
            c.CommandText = " select CC.MA_ID ,M.QUANTITY ,CC. QUANTITY from MAGAZINE M ,CART CC where CC.CA_ID = :id and M.M_NO=CC.MA_ID";
            c.Parameters.Add("id", i);
            OracleDataReader dr = c.ExecuteReader();
            while (dr.Read())
            {
                qty[0] = Convert.ToInt32(dr[0].ToString());
                qty[1] = Convert.ToInt32(dr[1].ToString());
                qty[2] = Convert.ToInt32(dr[2].ToString());
            }
            dr.Close();
            conn.Close();
            return qty;
        }

        #endregion

        #region Update Quantity
        void upqty(int i)
        {
            int[] qty = quantity(i);
            OracleCommand cm = new OracleCommand();
            conn.Open();
            cm.Connection = conn;
            cm.CommandText = "update MAGAZINE set QUANTITY=:newqq where M_NO =:id";

            cm.Parameters.Add("newqq", (qty[1] + qty[2]));
            cm.Parameters.Add("id", qty[0]);
            cm.ExecuteNonQuery();

            conn.Close();
        }

        #endregion

        #region Update Total Price
        void upprice(int i)
        {
            int price = 0, total = 0, ido = 0;
            OracleCommand c = new OracleCommand();
            conn.Open();
            c.Connection = conn;
            c.CommandText = "select CC.PRICE ,CC.OR_ID ,OO.TOTAL from ORDERR OO, CART CC where CC.CA_ID = :id and OO.O_ID = CC.OR_ID";
            c.Parameters.Add("id", i);

            OracleDataReader dr = c.ExecuteReader();
            while (dr.Read())
            {
                price = Convert.ToInt32(dr[0].ToString());
                total = Convert.ToInt32(dr[2].ToString());
                ido = Convert.ToInt32(dr[1].ToString());
            }
            dr.Close();

            OracleCommand cm = new OracleCommand();
            //conn.Open();
            cm.Connection = conn;
            cm.CommandText = "update ORDERR set TOTAL=:newqq where O_ID =:id";

            cm.Parameters.Add("newqq", (total - price));
            cm.Parameters.Add("id", ido);
            cm.ExecuteNonQuery();

            conn.Close();
        }

        #endregion

        #region Get Cart ID
        int retcid()
        {
            int r = 0;

            conn.Open();
            OracleCommand c = new OracleCommand();
            c.Connection = conn;
            c.CommandText = "select CA_ID from CART where  OR_ID=:id";
            c.Parameters.Add("id", Convert.ToInt32(rjComboBox1.SelectedItem.ToString()));
            OracleDataReader dr = c.ExecuteReader();
            while (dr.Read())
            {

                r = Convert.ToInt32(dr[0].ToString());
                break;
            }
            dr.Close();
            conn.Close();
            return r;
        }

        #endregion

        #region List of Orders IDs
        private void list()
        {
            int x = getid();
            OracleCommand cmd = new OracleCommand();
            conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = "order_list";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("userid", x);
            cmd.Parameters.Add("oid", OracleDbType.RefCursor, ParameterDirection.Output);
            OracleDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                rjComboBox1.Items.Add(dr[0]);
            }
            dr.Close();
            conn.Close();
        }
        #endregion

        #region Order ComboBox
        private void rjComboBox1_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            displayorder();
            roundedButton2.Visible = true;
            roundedButton4.Visible = true;
            displayitem();
        }

        #endregion

        #region Delete Order Button
        private void roundedButton1_Click(object sender, EventArgs e)
        {
            if (rjComboBox1.Texts == "Select")
            {
                RJMessageBox.Show("Please Select Order");
            }
            else
            {
                int index = countofitem(), ca = retcid();
                for (int i = 0; i < index; i++)
                {
                    deleteoneitem(ca + i);
                }
                deleteorder();
                var result = RJMessageBox.Show("order deleted");
                conn.Close();

            }
        
        }
        #endregion

        #region Delete item Button
        private void roundedButton2_Click(object sender, EventArgs e)
        {

            int r = countofitem();
            if (r > 1)
            {

                deleteoneitem(selectedc);
                displayitem();
            }
            else if (r == 1)
            {

                deleteoneitem(selectedc);
                deleteorder();
                dataGridView1.DataSource = null;

            }

        }
        #endregion

        #region Print Order Button
        private void roundedButton4_Click(object sender, EventArgs e)
        {
            Print l = new Print(Convert.ToInt32(rjComboBox1.SelectedItem.ToString()));
            l.Show();
        }
        #endregion

        #region DataGrid

        int selectedc = 0;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            selectedc = Convert.ToInt32(row.Cells[0].Value.ToString());
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
