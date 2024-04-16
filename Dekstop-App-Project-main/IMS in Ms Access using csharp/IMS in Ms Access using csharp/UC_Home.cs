using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace IMS_in_Ms_Access_using_csharp
{
    public partial class UC_Home : UserControl
    {
        public UC_Home()
        {
            InitializeComponent();
        }

        private void db_ordersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.db_ordersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ds_orders);

        }
        private void sum()
        {
            int A = 0, B = 0;
            for (A = 0; A < db_ordersDataGridView.Rows.Count; ++A)
            {
                B += Convert.ToInt32(db_ordersDataGridView.Rows[A].Cells[6].Value);
            }

            lbl_total_amount.Text = B.ToString();
        }

        private void loaddata()
        {

            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=c:\users\hp\documents\visual studio 2010\Projects\IMS in Ms Access using csharp\IMS in Ms Access using csharp\IMS.mdf;Integrated Security=True;User Instance=True");

            con.Open();

            String str = "Select * From db_orders ";

            SqlCommand cmd = new SqlCommand(str, con);

            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);

            db_ordersDataGridView.DataSource = dt;

            con.Close();

        }

        private void usercount()
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=c:\users\hp\documents\visual studio 2010\Projects\IMS in Ms Access using csharp\IMS in Ms Access using csharp\IMS.mdf;Integrated Security=True;User Instance=True");

                con.Open();

                SqlCommand cmd = con.CreateCommand();

                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "Select Count(uid)From db_user";

                Int32 rows_count = Convert.ToInt32(cmd.ExecuteScalar());

                con.Close();

                lbl_user_count.Text = rows_count.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void customercount()
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=c:\users\hp\documents\visual studio 2010\Projects\IMS in Ms Access using csharp\IMS in Ms Access using csharp\IMS.mdf;Integrated Security=True;User Instance=True");

                con.Open();

                SqlCommand cmd = con.CreateCommand();

                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "Select Count(cusid)From db_customers";

                Int32 rows_count = Convert.ToInt32(cmd.ExecuteScalar());

                con.Close();

                lbl_customer_count.Text = rows_count.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void productcount()
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=c:\users\hp\documents\visual studio 2010\Projects\IMS in Ms Access using csharp\IMS in Ms Access using csharp\IMS.mdf;Integrated Security=True;User Instance=True");

                con.Open();

                SqlCommand cmd = con.CreateCommand();

                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "Select Count(proid)From db_product";

                Int32 rows_count = Convert.ToInt32(cmd.ExecuteScalar());

                con.Close();

                lbl_product_count.Text = rows_count.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void orderscount()
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=c:\users\hp\documents\visual studio 2010\Projects\IMS in Ms Access using csharp\IMS in Ms Access using csharp\IMS.mdf;Integrated Security=True;User Instance=True");

                con.Open();

                SqlCommand cmd = con.CreateCommand();

                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "Select Count(invono)From db_orders";

                Int32 rows_count = Convert.ToInt32(cmd.ExecuteScalar());

                con.Close();

                lbl_orders_count.Text = rows_count.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void UC_Home_Load(object sender, EventArgs e)
        {
            loaddata();
            sum();
            usercount();
            orderscount();
            productcount();
            customercount();
     
        }

        private void btn_Load_Click(object sender, EventArgs e)
        {
            loaddata();
            sum();
            usercount();
            orderscount();
            productcount();
            customercount();
     
        }
    }
}
