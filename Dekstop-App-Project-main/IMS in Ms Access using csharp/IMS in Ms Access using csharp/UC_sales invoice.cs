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
    public partial class UC_sales_invoice : UserControl
    {
        public static string invoiceid;

        public UC_sales_invoice()
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
            txt_invoiceno.Text = "" + GetUniqueKey(5);
        }
        private void db_procardsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.db_procardsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ds_procard);

        }

        private void UC_sales_invoice_Load(object sender, EventArgs e)
        {
            auto();
        }

        private void btn_addtocard_Click(object sender, EventArgs e)
        {


            try
            {
                if (txt_invoiceno.Text == "")
                {
                    MessageBox.Show("Please , Enter Invoice No.", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    txt_invoiceno.Focus();

                }
                else
                    if (txt_productname.Text == "")
                    {
                        MessageBox.Show("Please , Enter Product Name ", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        txt_productname.Focus();

                    }
                    else
                        if (txt_productprice.Text == "")
                        {
                            MessageBox.Show("Please , Enter Product Price", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            txt_productprice.Focus();

                        }
                        else

                            if (txt_productquantity.Text == "")
                            {
                                MessageBox.Show("Please , Enter Product Quantity", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);

                                txt_productprice.Focus();

                            }
                            else
                            {
                                SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=c:\users\hp\documents\visual studio 2010\Projects\IMS in Ms Access using csharp\IMS in Ms Access using csharp\IMS.mdf;Integrated Security=True;User Instance=True");

                                con.Open();

                                String str = "Insert Into db_procards (invoid,cusid,proid,proname,proqut,proprice)Values('" + txt_invoiceno.Text + "','" + lbl_customerid.Text + "','" + lbl_productid.Text + "','" + txt_productname.Text + "','" + txt_productquantity.Text + "','" + txt_totalprice.Text + "')";

                                SqlCommand cmd = new SqlCommand(str, con);

                                cmd.ExecuteNonQuery();

                                String str2 = "Select max(invoid) From db_procards";

                                SqlCommand cmd2 = new SqlCommand(str2, con);

                                SqlDataReader dr = cmd2.ExecuteReader();

                                if (dr.Read())
                                {
                                    showdata();

                                    sum();

                                    txt_productname.Clear();
                                    txt_productprice.Clear();
                                    txt_productquantity.Clear();

                                    // MessageBox.Show("Product Created Successfull ....", "Thank You", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    con.Close();

                                }

                            }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void sum()
        {
            int A = 0, B = 0;
            for (A = 0; A < db_procardsDataGridView.Rows.Count; ++A)
            {
                B += Convert.ToInt32(db_procardsDataGridView.Rows[A].Cells[3].Value);
            }

            txt_grandtotal.Text = B.ToString();
        }

        private void showdata()
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=c:\users\hp\documents\visual studio 2010\Projects\IMS in Ms Access using csharp\IMS in Ms Access using csharp\IMS.mdf;Integrated Security=True;User Instance=True");

            con.Open();

            String str = "Select * From db_procards Where invoid = '" + txt_invoiceno.Text + "'";

            SqlCommand cmd = new SqlCommand(str, con);

            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);

            db_procardsDataGridView.DataSource = dt;

            con.Close();
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_productname.Text == "")
                {
                    MessageBox.Show("Please , Enter Product Name ", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    txt_productname.Focus();

                }
                else
                    if (txt_productprice.Text == "")
                    {
                        MessageBox.Show("Please , Enter Product Price", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        txt_productprice.Focus();

                    }
                    else

                        if (txt_productquantity.Text == "")
                        {
                            MessageBox.Show("Please , Enter Product Quantity", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            txt_productprice.Focus();

                        }

                        else
                        {
                            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=c:\users\hp\documents\visual studio 2010\Projects\IMS in Ms Access using csharp\IMS in Ms Access using csharp\IMS.mdf;Integrated Security=True;User Instance=True");

                            con.Open();

                            String str = "Delete From db_procards Where proname = '" + txt_productname.Text + "' and invoid = '" + txt_invoiceno.Text + "'";

                            SqlCommand cmd = new SqlCommand(str, con);

                            cmd.ExecuteNonQuery();

                            showdata();

                            txt_productname.Clear();
                            txt_productprice.Clear();
                            txt_productquantity.Clear();

                            con.Close();
                        }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void txt_customername_TextChanged(object sender, EventArgs e)
        {
            if (txt_customername.Text == "")
            {
                txt_contact.Clear();
                txt_address.Clear();
            }
            else
            {
                SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=c:\users\hp\documents\visual studio 2010\Projects\IMS in Ms Access using csharp\IMS in Ms Access using csharp\IMS.mdf;Integrated Security=True;User Instance=True");

                con.Open();

                String str = "Select cusid,cusname,cuscontact,cusaddress From db_customers Where cusname = '" + txt_customername.Text + "'";

                SqlCommand cmd = new SqlCommand(str, con);

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    lbl_customerid.Text = dr.GetValue(0).ToString();
                    txt_customername.Text = dr.GetValue(1).ToString();
                    txt_contact.Text = dr.GetValue(2).ToString();
                    txt_address.Text = dr.GetValue(3).ToString();

                }

                con.Close();

            }

        }

        private void txt_productname_TextChanged(object sender, EventArgs e)
        {
            if (txt_customername.Text == "" || txt_address.Text == "" || txt_contact.Text == "")
            {
                MessageBox.Show("Please , Enter Customer Details", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                if (txt_productname.Text == "")
                {
                    txt_productprice.Clear();
                    txt_productquantity.Clear();
                }
                else
                {
                    SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=c:\users\hp\documents\visual studio 2010\Projects\IMS in Ms Access using csharp\IMS in Ms Access using csharp\IMS.mdf;Integrated Security=True;User Instance=True");

                    con.Open();

                    String str = "Select proid,proname,proprice From db_product Where proname = '" + txt_productname.Text + "'";

                    SqlCommand cmd = new SqlCommand(str, con);

                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        lbl_productid.Text = dr.GetValue(0).ToString();
                        txt_productname.Text = dr.GetValue(1).ToString();
                        txt_productprice.Text = dr.GetValue(2).ToString();

                    }

                    con.Close();
                }

        }

        private void pcb_search_Click(object sender, EventArgs e)
        {
            showdata();
            load_order();
        }

        private void load_order()
        {

            try
            {
                if (txt_invoiceno.Text == "")
                {
                    MessageBox.Show("Please , Enter Invoice No.", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    txt_invoiceno.Focus();

                }
                else
                {
                    SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=c:\users\hp\documents\visual studio 2010\Projects\IMS in Ms Access using csharp\IMS in Ms Access using csharp\IMS.mdf;Integrated Security=True;User Instance=True");

                    con.Open();

                    String str = "Select invodate,cusid,cusname,contact,address,grandtotal From db_orders Where invono = '" + txt_invoiceno.Text + "'";

                    SqlCommand cmd = new SqlCommand(str, con);

                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        dtp_invoicedate.Text = dr.GetValue(0).ToString();
                        lbl_customerid.Text = dr.GetValue(1).ToString();
                        txt_customername.Text = dr.GetValue(2).ToString();
                        txt_contact.Text = dr.GetValue(3).ToString();
                        txt_address.Text = dr.GetValue(4).ToString();
                        txt_grandtotal.Text = dr.GetValue(5).ToString();
                    }

                    con.Close();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void txt_productquantity_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txt_productquantity.Text == "")
                {
                    txt_totalprice.Clear();
                }
                else if (txt_productname.Text == "")
                {
                    MessageBox.Show("Please , Enter Product Name ", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    txt_productname.Focus();

                }
                else
                {
                    double tprice;

                    tprice = double.Parse(txt_productprice.Text) * double.Parse(txt_productquantity.Text);

                    txt_totalprice.Text = tprice.ToString();
                }
            }
            catch (Exception)
            {

            }

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_invoiceno.Text == "")
                {
                    MessageBox.Show("Please , Enter Invoice No.", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    txt_invoiceno.Focus();

                }
                else
                    if (txt_customername.Text == "")
                    {
                        MessageBox.Show("Please , Enter Customer Name ", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        txt_customername.Focus();
                    }
                    else
                        if (txt_contact.Text == "")
                        {
                            MessageBox.Show("Please , Enter Customer Contact ", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            txt_contact.Focus();
                        }
                        else
                            if (txt_address.Text == "")
                            {
                                MessageBox.Show("Please , Enter Customer Address ", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }
                            else
                                if (txt_grandtotal.Text == "")
                                {
                                    MessageBox.Show("Please , Enter Product Grand Total ", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);

                                    txt_grandtotal.Focus();
                                }
                                else
                                {
                                    SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=c:\users\hp\documents\visual studio 2010\Projects\IMS in Ms Access using csharp\IMS in Ms Access using csharp\IMS.mdf;Integrated Security=True;User Instance=True");

                                    con.Open();

                                    String str = "Insert Into db_orders (invodate,invono,cusid,cusname,contact,address,grandtotal)Values('" + dtp_invoicedate.Text + "','" + txt_invoiceno.Text + "','" + lbl_customerid.Text + "','" + txt_customername.Text + "','" + txt_contact.Text + "','" + txt_address.Text + "','" + txt_grandtotal.Text + "')";

                                    SqlCommand cmd = new SqlCommand(str, con);

                                    cmd.ExecuteNonQuery();

                                    String str2 = "Select max(invono) From db_orders";

                                    SqlCommand cmd2 = new SqlCommand(str2, con);

                                    SqlDataReader dr = cmd2.ExecuteReader();

                                    if (dr.Read())
                                    {

                                        MessageBox.Show("Invoice Saved Successfull...", "Thank You", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                        //    auto();

                                        con.Close();

                                    }

                                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void loadinvoice()
        {
            invoiceid = txt_invoiceno.Text;
            frm_invoice fi = new frm_invoice();
            fi.ShowDialog();
        }

        private void Clearall()
        {
            txt_invoiceno.Clear();
            txt_customername.Clear();
            txt_address.Clear();
            txt_contact.Clear();
            txt_productname.Clear();
            txt_productprice.Clear();
            txt_productquantity.Clear();
            txt_totalprice.Clear();
            txt_grandtotal.Clear();
            showdata();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_invoiceno.Text == "")
                {
                    MessageBox.Show("Please , Enter Invoice No.", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    txt_invoiceno.Focus();

                }
                else
                    if (txt_customername.Text == "")
                    {
                        MessageBox.Show("Please , Enter Customer Name ", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        txt_customername.Focus();
                    }
                    else
                        if (txt_contact.Text == "")
                        {
                            MessageBox.Show("Please , Enter Customer Contact ", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            txt_contact.Focus();
                        }
                        else
                            if (txt_address.Text == "")
                            {
                                MessageBox.Show("Please , Enter Customer Address ", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }
                            else
                                if (txt_grandtotal.Text == "")
                                {
                                    MessageBox.Show("Please , Enter Product Grand Total ", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);

                                    txt_grandtotal.Focus();
                                }
                                else
                                {
                                    SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=c:\users\hp\documents\visual studio 2010\Projects\IMS in Ms Access using csharp\IMS in Ms Access using csharp\IMS.mdf;Integrated Security=True;User Instance=True");

                                    con.Open();

                                    String str = "Update db_orders Set invodate = '" + dtp_invoicedate.Text + "',cusname = '" + txt_customername.Text + "',contact = '" + txt_contact.Text + "',address = '" + txt_address.Text + "',grandtotal = '" + txt_grandtotal.Text + "' Where invono = '" + txt_invoiceno.Text + "' and cusid = '" + lbl_customerid.Text + "' ";

                                    SqlCommand cmd = new SqlCommand(str, con);

                                    cmd.ExecuteNonQuery();

                                    String str2 = "Select max(invono) From db_orders";

                                    SqlCommand cmd2 = new SqlCommand(str2, con);

                                    SqlDataReader dr = cmd2.ExecuteReader();

                                    if (dr.Read())
                                    {
                                        Clearall();

                                        MessageBox.Show("Invoice Updated Successfull...", "Thank You", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private void btn_remove__Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_invoiceno.Text == "")
                {
                    MessageBox.Show("Please , Enter Invoice No.", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    txt_invoiceno.Focus();

                }
                else
                    if (txt_customername.Text == "")
                    {
                        MessageBox.Show("Please , Enter Customer Name ", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        txt_customername.Focus();
                    }
                    else
                        if (txt_contact.Text == "")
                        {
                            MessageBox.Show("Please , Enter Customer Contact ", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            txt_contact.Focus();
                        }
                        else
                            if (txt_address.Text == "")
                            {
                                MessageBox.Show("Please , Enter Customer Address ", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }
                            else
                            {
                                SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=c:\users\hp\documents\visual studio 2010\Projects\IMS in Ms Access using csharp\IMS in Ms Access using csharp\IMS.mdf;Integrated Security=True;User Instance=True");

                                con.Open();

                                String str = "Delete From db_orders Where invono = '" + txt_invoiceno.Text + "' and cusid = '" + lbl_customerid.Text + "' ";

                                SqlCommand cmd = new SqlCommand(str, con);

                                cmd.ExecuteNonQuery();

                                String str2 = "Select max(invono) From db_orders";

                                SqlCommand cmd2 = new SqlCommand(str2, con);

                                SqlDataReader dr = cmd2.ExecuteReader();

                                if (dr.Read())
                                {
                                    Clearall();

                                    MessageBox.Show("Invoice Deleted Successfull...", "Thank You", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private void btn_print_Click(object sender, EventArgs e)
        {
            loadinvoice();
            Clearall();
        }

        private void db_procardsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index;

            index = e.RowIndex;

            DataGridViewRow dgvr = db_procardsDataGridView.Rows[index];

            txt_productname.Text = dgvr.Cells[1].Value.ToString();
            txt_productprice.Text = dgvr.Cells[2].Value.ToString();
            txt_productquantity.Text = dgvr.Cells[3].Value.ToString();
        }

    }
}
