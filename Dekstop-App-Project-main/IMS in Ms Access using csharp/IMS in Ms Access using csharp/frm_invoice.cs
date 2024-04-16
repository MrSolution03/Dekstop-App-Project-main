using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Reporting.WinForms;

namespace IMS_in_Ms_Access_using_csharp
{
    public partial class frm_invoice : Form
    {
        public static string invoice_id;

        public frm_invoice()
        {
            InitializeComponent();
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frm_invoice_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ds_print.order_view' table. You can move, or remove it, as needed.
            this.order_viewTableAdapter.Fill(this.ds_print.order_view);
            invoice_id = UC_sales_invoice.invoiceid;

            txt_invoiceid.Text = invoice_id;

            this.reportViewer1.RefreshReport();
        }

        private void txt_invoiceid_TextChanged(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=c:\users\hp\documents\visual studio 2010\Projects\IMS in Ms Access using csharp\IMS in Ms Access using csharp\IMS.mdf;Integrated Security=True;User Instance=True");

            con.Open();

            SqlDataAdapter da = new SqlDataAdapter("Select * From order_view Where invono = '" + txt_invoiceid.Text + "'", con);

            ds_print dsr = new ds_print();

            da.Fill(dsr, "order_view");

            ReportDataSource datasource = new ReportDataSource("DS_Invoice", dsr.Tables[0]);

            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(datasource);
            this.reportViewer1.RefreshReport();

            con.Close();
        }
    }
}
