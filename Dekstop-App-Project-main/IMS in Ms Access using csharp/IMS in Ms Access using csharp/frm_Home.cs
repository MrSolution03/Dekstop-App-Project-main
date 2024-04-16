using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IMS_in_Ms_Access_using_csharp
{
    public partial class frm_Home : Form
    {
        public frm_Home()
        {
            InitializeComponent();
        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btn_exit.Height;
            SidePanel.Top = btn_exit.Top;

            Application.Exit();
           

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form1 fh = new Form1();
            fh.ShowDialog();

        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel12_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btn_home.Height;
            SidePanel.Top = btn_home.Top;
            uC_Home1.BringToFront();
        }

        private void btn_categories_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btn_categories.Height;
            SidePanel.Top = btn_categories.Top;
            uC_categories1.BringToFront();
        }

        private void btn_products_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btn_products.Height;
            SidePanel.Top = btn_products.Top;
            uC_products1.BringToFront();
        }

        private void btn_customers_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btn_customers.Height;
            SidePanel.Top = btn_customers.Top;
            uC_customers1.BringToFront();
        }

        private void btn_orders_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btn_orders.Height;
            SidePanel.Top = btn_orders.Top;
            uC_Orders1.BringToFront();
        }

        private void btn_salesinvoice_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btn_salesinvoice.Height;
            SidePanel.Top = btn_salesinvoice.Top;
            uC_sales_invoice1.BringToFront();
        }

        private void btn_users_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btn_users.Height;
            SidePanel.Top = btn_users.Top;
            uC_user1.BringToFront();
        }
    }
}
