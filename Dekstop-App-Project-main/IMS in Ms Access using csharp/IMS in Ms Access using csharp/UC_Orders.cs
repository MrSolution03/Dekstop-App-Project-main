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
    public partial class UC_Orders : UserControl
    {
        public UC_Orders()
        {
            InitializeComponent();
        }

        private void db_ordersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.db_ordersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ds_orders);

        }

        private void UC_Orders_Load(object sender, EventArgs e)
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

        private void pcb_search_by_invoiceno_Click(object sender, EventArgs e)
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

        private void pcb_search_by_customer_name_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=c:\users\hp\documents\visual studio 2010\Projects\IMS in Ms Access using csharp\IMS in Ms Access using csharp\IMS.mdf;Integrated Security=True;User Instance=True");

            con.Open();

            String str = "Select * From db_orders Where cusname = '" + txt_customername.Text + "'";

            SqlCommand cmd = new SqlCommand(str, con);

            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);

            db_ordersDataGridView.DataSource = dt;

            con.Close();
      
        }

        private void txt_invoiceno_TextChanged(object sender, EventArgs e)
        {

            if (txt_invoiceno.Text == "")
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
  
        }

        private void txt_customername_TextChanged(object sender, EventArgs e)
        {
            if (txt_customername.Text == "")
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
       
        }

        private void btn_refresh_Click(object sender, EventArgs e)
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
    }
}
