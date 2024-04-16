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
    public partial class UC_user : UserControl
    {
        public UC_user()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (txt_Username.Text == "" || txt_Password.Text == "" || txt_fullname.Text == "" || txt_mobailno.Text == "")
                {
                    MessageBox.Show("Please , Insert all Information ... ", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=c:\users\hp\documents\visual studio 2010\Projects\IMS in Ms Access using csharp\IMS in Ms Access using csharp\IMS.mdf;Integrated Security=True;User Instance=True");
    
                    con.Open();

                    String str = "Insert Into db_user (username,ufullname,upassword,umobailno)Values('" + txt_Username.Text + "','" + txt_fullname.Text + "','" + txt_Password.Text + "','" + txt_mobailno.Text + "')";

                    SqlCommand cmd = new SqlCommand(str, con);

                    cmd.ExecuteNonQuery();

                    String str2 = "Select max(username) From db_user";

                    SqlCommand cmd2 = new SqlCommand(str2, con);

                    SqlDataReader dr = cmd2.ExecuteReader();

                    if (dr.Read())
                    {
                        showdata();

                        MessageBox.Show("User Created Successfull ....", "Thank You", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        clear();

                        con.Close();

                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    
        private void db_userBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.db_userBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ds_user);

        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_Username.Text == "" || txt_Password.Text == "" || txt_fullname.Text == "" || txt_mobailno.Text == "")
                {
                    MessageBox.Show("Please , Insert all Information ... ", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=c:\users\hp\documents\visual studio 2010\Projects\IMS in Ms Access using csharp\IMS in Ms Access using csharp\IMS.mdf;Integrated Security=True;User Instance=True");

                    con.Open();

                    String str = "Update db_user Set ufullname = '" + txt_fullname.Text + "',upassword = '" + txt_Password.Text + "',umobailno = '" + txt_mobailno.Text + "' Where username = '" + txt_Username.Text + "'";

                    SqlCommand cmd = new SqlCommand(str, con);

                    cmd.ExecuteNonQuery();

                    String str2 = "Select max(username) From db_user";

                    SqlCommand cmd2 = new SqlCommand(str2, con);

                    SqlDataReader dr = cmd2.ExecuteReader();

                    if (dr.Read())
                    {
                        showdata();

                        MessageBox.Show("User Updated Successfull ....", "Thank You", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        clear();

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
                if (txt_Username.Text == "" || txt_Password.Text == "" || txt_fullname.Text == "" || txt_mobailno.Text == "")
                {
                    MessageBox.Show("Please , Insert all Information ... ", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=c:\users\hp\documents\visual studio 2010\Projects\IMS in Ms Access using csharp\IMS in Ms Access using csharp\IMS.mdf;Integrated Security=True;User Instance=True");

                    con.Open();

                    String str = "Delete From db_user Where username = '" + txt_Username.Text + "'";

                    SqlCommand cmd = new SqlCommand(str, con);

                    cmd.ExecuteNonQuery();

                    showdata();

                    MessageBox.Show("User Delete Successfull ....", "Thank You", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    clear();

                    con.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
      
        }

        private void pcb_serchbyname_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=c:\users\hp\documents\visual studio 2010\Projects\IMS in Ms Access using csharp\IMS in Ms Access using csharp\IMS.mdf;Integrated Security=True;User Instance=True");

            con.Open();

            String str = "Select username,ufullname,upassword,umobailno From db_user Where username = '" + txt_Username.Text + "'";

            SqlCommand cmd = new SqlCommand(str, con);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                txt_Username.Text = dr.GetValue(0).ToString();
                txt_fullname.Text = dr.GetValue(1).ToString();
                txt_Password.Text = dr.GetValue(2).ToString();
                txt_mobailno.Text = dr.GetValue(3).ToString();
            }

            con.Close();
        
        }

        private void pcb_serchbyfullname_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=c:\users\hp\documents\visual studio 2010\Projects\IMS in Ms Access using csharp\IMS in Ms Access using csharp\IMS.mdf;Integrated Security=True;User Instance=True");

            con.Open();

            String str = "Select username,ufullname,upassword,umobailno From db_user Where ufullname = '" + txt_fullname.Text + "'";

            SqlCommand cmd = new SqlCommand(str, con);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                txt_Username.Text = dr.GetValue(0).ToString();
                txt_fullname.Text = dr.GetValue(1).ToString();
                txt_Password.Text = dr.GetValue(2).ToString();
                txt_mobailno.Text = dr.GetValue(3).ToString();
            }

            con.Close();
      
        }

        private void showdata()
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=c:\users\hp\documents\visual studio 2010\Projects\IMS in Ms Access using csharp\IMS in Ms Access using csharp\IMS.mdf;Integrated Security=True;User Instance=True");

            con.Open();

            String str = "Select * From db_user";

            SqlCommand cmd = new SqlCommand(str, con);

            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);

            db_userDataGridView.DataSource = dt;

            con.Close();
        }

        private void clear()
        {
            txt_fullname.Clear();
            txt_mobailno.Clear();
            txt_Password.Clear();
            txt_Username.Clear();
        }

        private void UC_user_Load(object sender, EventArgs e)
        {
            showdata();
        }

        private void db_userDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
