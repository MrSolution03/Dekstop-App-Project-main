using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace IMS_in_Ms_Access_using_csharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=c:\users\hp\documents\visual studio 2010\Projects\IMS in Ms Access using csharp\IMS in Ms Access using csharp\IMS.mdf;Integrated Security=True;User Instance=True");

        SqlCommand cmd;

        DataTable dt = new DataTable();

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txt_Username.Focus();
            lbl_admin.Visible = false;
            lbl_userlogin.Visible = false;
            btn_login_2.Visible = false;
        }

        private void btn_login_2_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_Username.Text == "admin" || txt_Password.Text == "admin")
                {
                    this.Hide();
                    frm_Home fh = new frm_Home();
                    fh.ShowDialog();

                }
                else
                {
                    MessageBox.Show("Yor are Loggin Detail Is Invalied", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
         
        }

        private void lbl_userlogin_Click(object sender, EventArgs e)
        {
            lbl_admin.Visible = false;
            lbl_userlogin.Visible = false;
            btn_login_2.Visible = false;
            lbl_adminlogin.Visible = true;
        }

        private void lbl_adminlogin_Click(object sender, EventArgs e)
        {
            lbl_admin.Visible = true;
            lbl_userlogin.Visible = true;
            btn_login_2.Visible = true;
            lbl_adminlogin.Visible = false;
        }

        private void cbshowpassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cbshowpassword.Checked)
            {
                txt_Password.UseSystemPasswordChar = true;
            }
            else
            {
                txt_Password.UseSystemPasswordChar = false;
            }
     
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_Username.Text == "" || txt_Password.Text == "")
                {
                    MessageBox.Show("Yor are Loggin Detail Is Invalied", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    con.Open();

                    cmd = con.CreateCommand();

                    cmd.CommandType = CommandType.Text;

                    cmd.CommandText = "Select * From db_user Where username = '" + txt_Username.Text + "' and upassword = '" + txt_Password.Text + "'";

                    cmd.ExecuteNonQuery();

                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        this.Hide();
                        frm_Home fh = new frm_Home();
                        fh.btn_users.Visible = false;
                        fh.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Yor are Loggin Detail Is Invalied", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                    con.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
      
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
