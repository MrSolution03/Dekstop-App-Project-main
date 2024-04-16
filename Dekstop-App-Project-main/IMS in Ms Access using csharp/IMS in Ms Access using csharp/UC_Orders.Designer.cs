namespace IMS_in_Ms_Access_using_csharp
{
    partial class UC_Orders
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pcb_search_by_customer_name = new System.Windows.Forms.PictureBox();
            this.txt_customername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pcb_search_by_invoiceno = new System.Windows.Forms.PictureBox();
            this.txt_invoiceno = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ds_orders = new IMS_in_Ms_Access_using_csharp.ds_orders();
            this.db_ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_ordersTableAdapter = new IMS_in_Ms_Access_using_csharp.ds_ordersTableAdapters.db_ordersTableAdapter();
            this.tableAdapterManager = new IMS_in_Ms_Access_using_csharp.ds_ordersTableAdapters.TableAdapterManager();
            this.db_ordersDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_search_by_customer_name)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_search_by_invoiceno)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ds_orders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_ordersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.btn_refresh);
            this.panel4.Location = new System.Drawing.Point(914, 57);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(228, 100);
            this.panel4.TabIndex = 15;
            // 
            // btn_refresh
            // 
            this.btn_refresh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_refresh.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_refresh.ForeColor = System.Drawing.Color.White;
            this.btn_refresh.Location = new System.Drawing.Point(13, 24);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(200, 50);
            this.btn_refresh.TabIndex = 139;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.UseVisualStyleBackColor = false;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.pcb_search_by_customer_name);
            this.panel2.Controls.Add(this.txt_customername);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(512, 57);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(396, 100);
            this.panel2.TabIndex = 14;
            // 
            // pcb_search_by_customer_name
            // 
            this.pcb_search_by_customer_name.Image = global::IMS_in_Ms_Access_using_csharp.Properties.Resources.icons8_search_96px;
            this.pcb_search_by_customer_name.Location = new System.Drawing.Point(346, 42);
            this.pcb_search_by_customer_name.Name = "pcb_search_by_customer_name";
            this.pcb_search_by_customer_name.Size = new System.Drawing.Size(45, 45);
            this.pcb_search_by_customer_name.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcb_search_by_customer_name.TabIndex = 138;
            this.pcb_search_by_customer_name.TabStop = false;
            this.pcb_search_by_customer_name.Click += new System.EventHandler(this.pcb_search_by_customer_name_Click);
            // 
            // txt_customername
            // 
            this.txt_customername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_customername.BackColor = System.Drawing.Color.White;
            this.txt_customername.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_customername.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_customername.ForeColor = System.Drawing.Color.Black;
            this.txt_customername.Location = new System.Drawing.Point(24, 42);
            this.txt_customername.Multiline = true;
            this.txt_customername.Name = "txt_customername";
            this.txt_customername.Size = new System.Drawing.Size(304, 45);
            this.txt_customername.TabIndex = 48;
            this.txt_customername.TextChanged += new System.EventHandler(this.txt_customername_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(3, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 28);
            this.label1.TabIndex = 46;
            this.label1.Text = "Customer Name :";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pcb_search_by_invoiceno);
            this.panel1.Controls.Add(this.txt_invoiceno);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(110, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(396, 100);
            this.panel1.TabIndex = 13;
            // 
            // pcb_search_by_invoiceno
            // 
            this.pcb_search_by_invoiceno.Image = global::IMS_in_Ms_Access_using_csharp.Properties.Resources.icons8_search_96px;
            this.pcb_search_by_invoiceno.Location = new System.Drawing.Point(336, 42);
            this.pcb_search_by_invoiceno.Name = "pcb_search_by_invoiceno";
            this.pcb_search_by_invoiceno.Size = new System.Drawing.Size(45, 45);
            this.pcb_search_by_invoiceno.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcb_search_by_invoiceno.TabIndex = 138;
            this.pcb_search_by_invoiceno.TabStop = false;
            this.pcb_search_by_invoiceno.Click += new System.EventHandler(this.pcb_search_by_invoiceno_Click);
            // 
            // txt_invoiceno
            // 
            this.txt_invoiceno.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_invoiceno.BackColor = System.Drawing.Color.White;
            this.txt_invoiceno.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_invoiceno.ForeColor = System.Drawing.Color.Black;
            this.txt_invoiceno.Location = new System.Drawing.Point(17, 42);
            this.txt_invoiceno.Multiline = true;
            this.txt_invoiceno.Name = "txt_invoiceno";
            this.txt_invoiceno.Size = new System.Drawing.Size(304, 45);
            this.txt_invoiceno.TabIndex = 47;
            this.txt_invoiceno.TextChanged += new System.EventHandler(this.txt_invoiceno_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(3, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 28);
            this.label2.TabIndex = 46;
            this.label2.Text = "Invoice No. :";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.Controls.Add(this.db_ordersDataGridView);
            this.panel3.Location = new System.Drawing.Point(14, 200);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1210, 618);
            this.panel3.TabIndex = 16;
            // 
            // ds_orders
            // 
            this.ds_orders.DataSetName = "ds_orders";
            this.ds_orders.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // db_ordersBindingSource
            // 
            this.db_ordersBindingSource.DataMember = "db_orders";
            this.db_ordersBindingSource.DataSource = this.ds_orders;
            // 
            // db_ordersTableAdapter
            // 
            this.db_ordersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.db_ordersTableAdapter = this.db_ordersTableAdapter;
            this.tableAdapterManager.UpdateOrder = IMS_in_Ms_Access_using_csharp.ds_ordersTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // db_ordersDataGridView
            // 
            this.db_ordersDataGridView.AllowUserToAddRows = false;
            this.db_ordersDataGridView.AutoGenerateColumns = false;
            this.db_ordersDataGridView.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.db_ordersDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.db_ordersDataGridView.ColumnHeadersHeight = 35;
            this.db_ordersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.db_ordersDataGridView.DataSource = this.db_ordersBindingSource;
            this.db_ordersDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.db_ordersDataGridView.EnableHeadersVisualStyles = false;
            this.db_ordersDataGridView.GridColor = System.Drawing.Color.White;
            this.db_ordersDataGridView.Location = new System.Drawing.Point(0, 0);
            this.db_ordersDataGridView.Name = "db_ordersDataGridView";
            this.db_ordersDataGridView.RowHeadersVisible = false;
            this.db_ordersDataGridView.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.db_ordersDataGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.db_ordersDataGridView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.db_ordersDataGridView.RowTemplate.Height = 30;
            this.db_ordersDataGridView.Size = new System.Drawing.Size(1210, 618);
            this.db_ordersDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "invodate";
            this.dataGridViewTextBoxColumn1.HeaderText = "Invoice Date";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "invono";
            this.dataGridViewTextBoxColumn2.HeaderText = "Invoice No.";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "cusid";
            this.dataGridViewTextBoxColumn3.HeaderText = "Customer ID";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "cusname";
            this.dataGridViewTextBoxColumn4.HeaderText = "Customer Name";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 200;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "contact";
            this.dataGridViewTextBoxColumn5.HeaderText = "Contact";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "address";
            this.dataGridViewTextBoxColumn6.HeaderText = "Address";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 150;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "grandtotal";
            this.dataGridViewTextBoxColumn7.HeaderText = "Grand Total";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 150;
            // 
            // UC_Orders
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UC_Orders";
            this.Size = new System.Drawing.Size(1237, 818);
            this.Load += new System.EventHandler(this.UC_Orders_Load);
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_search_by_customer_name)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_search_by_invoiceno)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ds_orders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_ordersDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pcb_search_by_customer_name;
        private System.Windows.Forms.TextBox txt_customername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pcb_search_by_invoiceno;
        private System.Windows.Forms.TextBox txt_invoiceno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private ds_orders ds_orders;
        private System.Windows.Forms.BindingSource db_ordersBindingSource;
        private ds_ordersTableAdapters.db_ordersTableAdapter db_ordersTableAdapter;
        private ds_ordersTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView db_ordersDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}
