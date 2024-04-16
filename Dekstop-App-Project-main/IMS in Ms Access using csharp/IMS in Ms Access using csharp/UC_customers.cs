using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Data.SqlClient;

namespace IMS_in_Ms_Access_using_csharp
{
    public partial class UC_customers : UserControl
    {
        public UC_customers()
        {
            InitializeComponent();
        }

        public static string GetUniqueKey(int maxSize)
        {
            char[] chars = new char[62];
            chars =
            "123456789".ToCharArray();
            byte[] data = new byte[1];
            RNGCryptoServiceProvider crypto = new RNGCryptoServiceProvider();
            crypto.GetNonZeroBytes(data);
            data = new byte[maxSize];
            crypto.GetNonZeroBytes(data);
            StringBuilder result = new StringBuilder(maxSize);
            foreach (byte b in data)
            {
                result.Append(chars[b % (chars.Length)]);
            }
            return result.ToString();
        }
        private void auto()
        {
            txt_customerid.Text = "" + GetUniqueKey(5);
        }

        private void db_customersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.db_customersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ds_customers);

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_customerid.Text == "" || txt_customername.Text == "" || txt_contact.Text == "" || txt_address.Text == "")
                {
                    MessageBox.Show("Please , Insert all Information ... ", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=c:\users\hp\documents\visual studio 2010\Projects\IMS in Ms Access using csharp\IMS in Ms Access using csharp\IMS.mdf;Integrated Security=True;User Instance=True");

                    con.Open();

                    String str = "Insert Into db_customers (cusid,cusname,cuscontact,cusaddress)Values('" + txt_customerid.Text + "','" + txt_customername.Text + "','" + txt_contact.Text + "','" + txt_address.Text + "')";

                    SqlCommand cmd = new SqlCommand(str, con);

                    cmd.ExecuteNonQuery();

                    String str2 = "Select max(cusid) From db_customers";

                    SqlCommand cmd2 = new SqlCommand(str2, con);

                    SqlDataReader dr = cmd2.ExecuteReader();

                    if (dr.Read())
                    {
                        showdata();

                        MessageBox.Show("Customers Created Successfull ....", "Thank You", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        clear();

                        auto();

                        con.Close();

                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void clear()
        {
            txt_address.Clear();
            txt_contact.Clear();
            txt_customerid.Clear();
            txt_customername.Clear();
        }


        private void UC_customers_Load(object sender, EventArgs e)
        {
            auto();
            showdata();
        }
        
        private void showdata()
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=c:\users\hp\documents\visual studio 2010\Projects\IMS in Ms Access using csharp\IMS in Ms Access using csharp\IMS.mdf;Integrated Security=True;User Instance=True");

            con.Open();

            String str = "Select * From db_customers";

            SqlCommand cmd = new SqlCommand(str, con);

            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);

            db_customersDataGridView.DataSource = dt;

            con.Close();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_customerid.Text == "" || txt_customername.Text == "" || txt_contact.Text == "" || txt_address.Text == "")
                {
                    MessageBox.Show("Please , Insert all Information ... ", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=c:\users\hp\documents\visual studio 2010\Projects\IMS in Ms Access using csharp\IMS in Ms Access using csharp\IMS.mdf;Integrated Security=True;User Instance=True");

                    con.Open();

                    String str = "Update db_customers Set cusname = '" + txt_customername.Text + "',cuscontact = '" + txt_contact.Text + "',cusaddress = '" + txt_address.Text + "' Where cusid = '" + txt_customerid.Text + "'";

                    SqlCommand cmd = new SqlCommand(str, con);

                    cmd.ExecuteNonQuery();

                    String str2 = "Select max(cusid) From db_customers";

                    SqlCommand cmd2 = new SqlCommand(str2, con);

                    SqlDataReader dr = cmd2.ExecuteReader();

                    if (dr.Read())
                    {
                        showdata();

                        MessageBox.Show("Customers Updated Successfull ....", "Thank You", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        clear();

                        auto();

                        con.Close();

                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
      
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {

            try
            {
                if (txt_customerid.Text == "" || txt_customername.Text == "" || txt_contact.Text == "" || txt_address.Text == "")
                {
                    MessageBox.Show("Please , Insert all Information ... ", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=c:\users\hp\documents\visual studio 2010\Projects\IMS in Ms Access using csharp\IMS in Ms Access using csharp\IMS.mdf;Integrated Security=True;User Instance=True");

                    con.Open();

                    String str = "Delete From db_customers Where cusid = '" + txt_customerid.Text + "'";

                    SqlCommand cmd = new SqlCommand(str, con);

                    cmd.ExecuteNonQuery();

                    showdata();

                    MessageBox.Show("User Delete Successfull ....", "Thank You", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    clear();

                    auto();

                    con.Close();


                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
      
        }

        private void pcb_search_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=c:\users\hp\documents\visual studio 2010\Projects\IMS in Ms Access using csharp\IMS in Ms Access using csharp\IMS.mdf;Integrated Security=True;User Instance=True");

            con.Open();

            String str = "Select cusid,cusname,cuscontact,cusaddress From db_customers Where cusid = '" + txt_customerid.Text + "'";

            SqlCommand cmd = new SqlCommand(str, con);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                txt_customerid.Text = dr.GetValue(0).ToString();
                txt_customername.Text = dr.GetValue(1).ToString();
                txt_contact.Text = dr.GetValue(2).ToString();
                txt_address.Text = dr.GetValue(3).ToString();
            }

            con.Close();
        
        }

        private void pcb_search1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=c:\users\hp\documents\visual studio 2010\Projects\IMS in Ms Access using csharp\IMS in Ms Access using csharp\IMS.mdf;Integrated Security=True;User Instance=True");

            con.Open();

            String str = "Select cusid,cusname,cuscontact,cusaddress From db_customers Where cusname = '" + txt_customername.Text + "'";

            SqlCommand cmd = new SqlCommand(str, con);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                txt_customerid.Text = dr.GetValue(0).ToString();
                txt_customername.Text = dr.GetValue(1).ToString();
                txt_contact.Text = dr.GetValue(2).ToString();
                txt_address.Text = dr.GetValue(3).ToString();
            }

            con.Close();
       
        }

    }
}
