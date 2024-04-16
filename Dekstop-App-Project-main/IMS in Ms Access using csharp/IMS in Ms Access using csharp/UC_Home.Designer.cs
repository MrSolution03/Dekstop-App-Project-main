namespace IMS_in_Ms_Access_using_csharp
{
    partial class UC_Home
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
            this.btn_Load = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.lbl_product_count = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl_total_amount = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_orders_count = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lbl_customer_count = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lbl_user_count = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
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
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ds_orders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_ordersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Load
            // 
            this.btn_Load.FlatAppearance.BorderSize = 3;
            this.btn_Load.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Load.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Load.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Load.Location = new System.Drawing.Point(488, 634);
            this.btn_Load.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Load.Name = "btn_Load";
            this.btn_Load.Size = new System.Drawing.Size(259, 58);
            this.btn_Load.TabIndex = 36;
            this.btn_Load.Text = "Refresh";
            this.btn_Load.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Load.UseVisualStyleBackColor = true;
            this.btn_Load.Click += new System.EventHandler(this.btn_Load_Click);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel9.Controls.Add(this.lbl_product_count);
            this.panel9.Controls.Add(this.label14);
            this.panel9.Controls.Add(this.panel10);
            this.panel9.Location = new System.Drawing.Point(791, 90);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(258, 148);
            this.panel9.TabIndex = 35;
            // 
            // lbl_product_count
            // 
            this.lbl_product_count.AutoSize = true;
            this.lbl_product_count.Font = new System.Drawing.Font("Palatino Linotype", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_product_count.ForeColor = System.Drawing.Color.White;
            this.lbl_product_count.Location = new System.Drawing.Point(99, 49);
            this.lbl_product_count.Name = "lbl_product_count";
            this.lbl_product_count.Size = new System.Drawing.Size(60, 51);
            this.lbl_product_count.TabIndex = 23;
            this.lbl_product_count.Text = "00";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(19, 9);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(218, 25);
            this.label14.TabIndex = 22;
            this.label14.Text = "Total Product Count :";
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.Gold;
            this.panel10.Controls.Add(this.label15);
            this.panel10.Location = new System.Drawing.Point(3, 105);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(252, 40);
            this.panel10.TabIndex = 19;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(57, 8);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(152, 25);
            this.label15.TabIndex = 22;
            this.label15.Text = "Total Products";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel3.Controls.Add(this.lbl_total_amount);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(488, 243);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(258, 148);
            this.panel3.TabIndex = 32;
            // 
            // lbl_total_amount
            // 
            this.lbl_total_amount.AutoSize = true;
            this.lbl_total_amount.Font = new System.Drawing.Font("Palatino Linotype", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total_amount.ForeColor = System.Drawing.Color.White;
            this.lbl_total_amount.Location = new System.Drawing.Point(99, 49);
            this.lbl_total_amount.Name = "lbl_total_amount";
            this.lbl_total_amount.Size = new System.Drawing.Size(60, 51);
            this.lbl_total_amount.TabIndex = 23;
            this.lbl_total_amount.Text = "00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(19, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(226, 25);
            this.label5.TabIndex = 22;
            this.label5.Text = "Total Orders Amount :";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gold;
            this.panel4.Controls.Add(this.label6);
            this.panel4.Location = new System.Drawing.Point(3, 105);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(252, 40);
            this.panel4.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(57, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 25);
            this.label6.TabIndex = 22;
            this.label6.Text = "Total Amount";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.lbl_orders_count);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(187, 90);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(258, 148);
            this.panel1.TabIndex = 31;
            // 
            // lbl_orders_count
            // 
            this.lbl_orders_count.AutoSize = true;
            this.lbl_orders_count.Font = new System.Drawing.Font("Palatino Linotype", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_orders_count.ForeColor = System.Drawing.Color.White;
            this.lbl_orders_count.Location = new System.Drawing.Point(99, 49);
            this.lbl_orders_count.Name = "lbl_orders_count";
            this.lbl_orders_count.Size = new System.Drawing.Size(60, 51);
            this.lbl_orders_count.TabIndex = 23;
            this.lbl_orders_count.Text = "00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(19, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 25);
            this.label3.TabIndex = 22;
            this.label3.Text = "Total Orders Count :";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gold;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(3, 105);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(252, 40);
            this.panel2.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(57, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 25);
            this.label1.TabIndex = 22;
            this.label1.Text = "Total Orders ";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel7.Controls.Add(this.lbl_customer_count);
            this.panel7.Controls.Add(this.label11);
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Location = new System.Drawing.Point(187, 397);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(258, 148);
            this.panel7.TabIndex = 34;
            // 
            // lbl_customer_count
            // 
            this.lbl_customer_count.AutoSize = true;
            this.lbl_customer_count.Font = new System.Drawing.Font("Palatino Linotype", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_customer_count.ForeColor = System.Drawing.Color.White;
            this.lbl_customer_count.Location = new System.Drawing.Point(99, 49);
            this.lbl_customer_count.Name = "lbl_customer_count";
            this.lbl_customer_count.Size = new System.Drawing.Size(60, 51);
            this.lbl_customer_count.TabIndex = 23;
            this.lbl_customer_count.Text = "00";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(19, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(237, 25);
            this.label11.TabIndex = 22;
            this.label11.Text = "Total Customer Count :";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Gold;
            this.panel8.Controls.Add(this.label12);
            this.panel8.Location = new System.Drawing.Point(3, 105);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(252, 40);
            this.panel8.TabIndex = 19;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(57, 8);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(160, 25);
            this.label12.TabIndex = 22;
            this.label12.Text = "Total Customer";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel5.Controls.Add(this.lbl_user_count);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Location = new System.Drawing.Point(791, 397);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(258, 148);
            this.panel5.TabIndex = 33;
            // 
            // lbl_user_count
            // 
            this.lbl_user_count.AutoSize = true;
            this.lbl_user_count.Font = new System.Drawing.Font("Palatino Linotype", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_user_count.ForeColor = System.Drawing.Color.White;
            this.lbl_user_count.Location = new System.Drawing.Point(99, 49);
            this.lbl_user_count.Name = "lbl_user_count";
            this.lbl_user_count.Size = new System.Drawing.Size(60, 51);
            this.lbl_user_count.TabIndex = 23;
            this.lbl_user_count.Text = "00";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(19, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(211, 25);
            this.label8.TabIndex = 22;
            this.label8.Text = "Total Sellers Count :";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Gold;
            this.panel6.Controls.Add(this.label9);
            this.panel6.Location = new System.Drawing.Point(3, 105);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(252, 40);
            this.panel6.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(57, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(134, 25);
            this.label9.TabIndex = 22;
            this.label9.Text = "Total Sellers";
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
            this.db_ordersDataGridView.AutoGenerateColumns = false;
            this.db_ordersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.db_ordersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.db_ordersDataGridView.DataSource = this.db_ordersBindingSource;
            this.db_ordersDataGridView.Location = new System.Drawing.Point(116, 772);
            this.db_ordersDataGridView.Name = "db_ordersDataGridView";
            this.db_ordersDataGridView.RowTemplate.Height = 24;
            this.db_ordersDataGridView.Size = new System.Drawing.Size(300, 10);
            this.db_ordersDataGridView.TabIndex = 37;
            this.db_ordersDataGridView.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "invodate";
            this.dataGridViewTextBoxColumn1.HeaderText = "invodate";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "invono";
            this.dataGridViewTextBoxColumn2.HeaderText = "invono";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "cusid";
            this.dataGridViewTextBoxColumn3.HeaderText = "cusid";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "cusname";
            this.dataGridViewTextBoxColumn4.HeaderText = "cusname";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "contact";
            this.dataGridViewTextBoxColumn5.HeaderText = "contact";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "address";
            this.dataGridViewTextBoxColumn6.HeaderText = "address";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "grandtotal";
            this.dataGridViewTextBoxColumn7.HeaderText = "grandtotal";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // UC_Home
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.db_ordersDataGridView);
            this.Controls.Add(this.btn_Load);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel5);
            this.Name = "UC_Home";
            this.Size = new System.Drawing.Size(1237, 782);
            this.Load += new System.EventHandler(this.UC_Home_Load);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ds_orders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_ordersDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Load;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label lbl_product_count;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbl_total_amount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_orders_count;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label lbl_customer_count;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lbl_user_count;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label9;
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
