namespace IMS_in_Ms_Access_using_csharp
{
    partial class frm_Home
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Home));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_users = new System.Windows.Forms.Button();
            this.btn_salesinvoice = new System.Windows.Forms.Button();
            this.btn_orders = new System.Windows.Forms.Button();
            this.btn_customers = new System.Windows.Forms.Button();
            this.btn_products = new System.Windows.Forms.Button();
            this.btn_home = new System.Windows.Forms.Button();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.btn_no = new System.Windows.Forms.Button();
            this.btn_categories = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.uC_Home1 = new IMS_in_Ms_Access_using_csharp.UC_Home();
            this.uC_user1 = new IMS_in_Ms_Access_using_csharp.UC_user();
            this.uC_sales_invoice1 = new IMS_in_Ms_Access_using_csharp.UC_sales_invoice();
            this.uC_Orders1 = new IMS_in_Ms_Access_using_csharp.UC_Orders();
            this.uC_customers1 = new IMS_in_Ms_Access_using_csharp.UC_customers();
            this.uC_products1 = new IMS_in_Ms_Access_using_csharp.UC_products();
            this.uC_categories1 = new IMS_in_Ms_Access_using_csharp.UC_categories();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.btn_exit);
            this.panel1.Controls.Add(this.btn_users);
            this.panel1.Controls.Add(this.btn_salesinvoice);
            this.panel1.Controls.Add(this.btn_orders);
            this.panel1.Controls.Add(this.btn_customers);
            this.panel1.Controls.Add(this.btn_products);
            this.panel1.Controls.Add(this.btn_home);
            this.panel1.Controls.Add(this.SidePanel);
            this.panel1.Controls.Add(this.btn_no);
            this.panel1.Controls.Add(this.btn_categories);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(282, 799);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(25, 13);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(222, 66);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // btn_exit
            // 
            this.btn_exit.FlatAppearance.BorderSize = 0;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Font = new System.Drawing.Font("Palatino Linotype", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.ForeColor = System.Drawing.Color.White;
            this.btn_exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_exit.Location = new System.Drawing.Point(25, 644);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(4);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(247, 66);
            this.btn_exit.TabIndex = 18;
            this.btn_exit.Text = "Exit";
            this.btn_exit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.button8_Click);
            // 
            // btn_users
            // 
            this.btn_users.FlatAppearance.BorderSize = 0;
            this.btn_users.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_users.Font = new System.Drawing.Font("Palatino Linotype", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_users.ForeColor = System.Drawing.Color.White;
            this.btn_users.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_users.Location = new System.Drawing.Point(25, 530);
            this.btn_users.Margin = new System.Windows.Forms.Padding(4);
            this.btn_users.Name = "btn_users";
            this.btn_users.Size = new System.Drawing.Size(247, 66);
            this.btn_users.TabIndex = 17;
            this.btn_users.Text = "Users";
            this.btn_users.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_users.UseVisualStyleBackColor = true;
            this.btn_users.Click += new System.EventHandler(this.btn_users_Click);
            // 
            // btn_salesinvoice
            // 
            this.btn_salesinvoice.FlatAppearance.BorderSize = 0;
            this.btn_salesinvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salesinvoice.Font = new System.Drawing.Font("Palatino Linotype", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salesinvoice.ForeColor = System.Drawing.Color.White;
            this.btn_salesinvoice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_salesinvoice.Location = new System.Drawing.Point(25, 456);
            this.btn_salesinvoice.Margin = new System.Windows.Forms.Padding(4);
            this.btn_salesinvoice.Name = "btn_salesinvoice";
            this.btn_salesinvoice.Size = new System.Drawing.Size(247, 66);
            this.btn_salesinvoice.TabIndex = 16;
            this.btn_salesinvoice.Text = "Sales Invoice";
            this.btn_salesinvoice.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_salesinvoice.UseVisualStyleBackColor = true;
            this.btn_salesinvoice.Click += new System.EventHandler(this.btn_salesinvoice_Click);
            // 
            // btn_orders
            // 
            this.btn_orders.FlatAppearance.BorderSize = 0;
            this.btn_orders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_orders.Font = new System.Drawing.Font("Palatino Linotype", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_orders.ForeColor = System.Drawing.Color.White;
            this.btn_orders.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_orders.Location = new System.Drawing.Point(25, 391);
            this.btn_orders.Margin = new System.Windows.Forms.Padding(4);
            this.btn_orders.Name = "btn_orders";
            this.btn_orders.Size = new System.Drawing.Size(247, 66);
            this.btn_orders.TabIndex = 15;
            this.btn_orders.Text = "Orders";
            this.btn_orders.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_orders.UseVisualStyleBackColor = true;
            this.btn_orders.Click += new System.EventHandler(this.btn_orders_Click);
            // 
            // btn_customers
            // 
            this.btn_customers.FlatAppearance.BorderSize = 0;
            this.btn_customers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_customers.Font = new System.Drawing.Font("Palatino Linotype", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_customers.ForeColor = System.Drawing.Color.White;
            this.btn_customers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_customers.Location = new System.Drawing.Point(25, 317);
            this.btn_customers.Margin = new System.Windows.Forms.Padding(4);
            this.btn_customers.Name = "btn_customers";
            this.btn_customers.Size = new System.Drawing.Size(247, 66);
            this.btn_customers.TabIndex = 14;
            this.btn_customers.Text = "Customers";
            this.btn_customers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_customers.UseVisualStyleBackColor = true;
            this.btn_customers.Click += new System.EventHandler(this.btn_customers_Click);
            // 
            // btn_products
            // 
            this.btn_products.FlatAppearance.BorderSize = 0;
            this.btn_products.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_products.Font = new System.Drawing.Font("Palatino Linotype", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_products.ForeColor = System.Drawing.Color.White;
            this.btn_products.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_products.Location = new System.Drawing.Point(25, 243);
            this.btn_products.Margin = new System.Windows.Forms.Padding(4);
            this.btn_products.Name = "btn_products";
            this.btn_products.Size = new System.Drawing.Size(247, 66);
            this.btn_products.TabIndex = 13;
            this.btn_products.Text = "Products";
            this.btn_products.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_products.UseVisualStyleBackColor = true;
            this.btn_products.Click += new System.EventHandler(this.btn_products_Click);
            // 
            // btn_home
            // 
            this.btn_home.FlatAppearance.BorderSize = 0;
            this.btn_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_home.Font = new System.Drawing.Font("Palatino Linotype", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_home.ForeColor = System.Drawing.Color.White;
            this.btn_home.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_home.Location = new System.Drawing.Point(25, 95);
            this.btn_home.Margin = new System.Windows.Forms.Padding(4);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(247, 66);
            this.btn_home.TabIndex = 12;
            this.btn_home.Text = "Home";
            this.btn_home.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_home.UseVisualStyleBackColor = true;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.White;
            this.SidePanel.Location = new System.Drawing.Point(0, 95);
            this.SidePanel.Margin = new System.Windows.Forms.Padding(4);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(17, 66);
            this.SidePanel.TabIndex = 11;
            // 
            // btn_no
            // 
            this.btn_no.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_no.FlatAppearance.BorderSize = 0;
            this.btn_no.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_no.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_no.ForeColor = System.Drawing.Color.White;
            this.btn_no.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_no.Location = new System.Drawing.Point(0, 753);
            this.btn_no.Margin = new System.Windows.Forms.Padding(4);
            this.btn_no.Name = "btn_no";
            this.btn_no.Size = new System.Drawing.Size(48, 42);
            this.btn_no.TabIndex = 5;
            this.btn_no.Text = "?";
            this.btn_no.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_no.UseVisualStyleBackColor = true;
            this.btn_no.Click += new System.EventHandler(this.button14_Click);
            // 
            // btn_categories
            // 
            this.btn_categories.FlatAppearance.BorderSize = 0;
            this.btn_categories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_categories.Font = new System.Drawing.Font("Palatino Linotype", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_categories.ForeColor = System.Drawing.Color.White;
            this.btn_categories.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_categories.Location = new System.Drawing.Point(25, 169);
            this.btn_categories.Margin = new System.Windows.Forms.Padding(4);
            this.btn_categories.Name = "btn_categories";
            this.btn_categories.Size = new System.Drawing.Size(247, 66);
            this.btn_categories.TabIndex = 8;
            this.btn_categories.Text = "Categories";
            this.btn_categories.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_categories.UseVisualStyleBackColor = true;
            this.btn_categories.Click += new System.EventHandler(this.btn_categories_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(282, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1237, 17);
            this.panel2.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.uC_Home1);
            this.panel3.Controls.Add(this.uC_user1);
            this.panel3.Controls.Add(this.uC_sales_invoice1);
            this.panel3.Controls.Add(this.uC_Orders1);
            this.panel3.Controls.Add(this.uC_customers1);
            this.panel3.Controls.Add(this.uC_products1);
            this.panel3.Controls.Add(this.uC_categories1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(282, 17);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1237, 782);
            this.panel3.TabIndex = 5;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // uC_Home1
            // 
            this.uC_Home1.BackColor = System.Drawing.Color.White;
            this.uC_Home1.Location = new System.Drawing.Point(0, 0);
            this.uC_Home1.Name = "uC_Home1";
            this.uC_Home1.Size = new System.Drawing.Size(1237, 782);
            this.uC_Home1.TabIndex = 7;
            // 
            // uC_user1
            // 
            this.uC_user1.BackColor = System.Drawing.Color.White;
            this.uC_user1.Location = new System.Drawing.Point(0, 0);
            this.uC_user1.Name = "uC_user1";
            this.uC_user1.Size = new System.Drawing.Size(1237, 782);
            this.uC_user1.TabIndex = 6;
            // 
            // uC_sales_invoice1
            // 
            this.uC_sales_invoice1.BackColor = System.Drawing.Color.White;
            this.uC_sales_invoice1.Location = new System.Drawing.Point(0, 0);
            this.uC_sales_invoice1.Name = "uC_sales_invoice1";
            this.uC_sales_invoice1.Size = new System.Drawing.Size(1237, 782);
            this.uC_sales_invoice1.TabIndex = 5;
            // 
            // uC_Orders1
            // 
            this.uC_Orders1.BackColor = System.Drawing.Color.White;
            this.uC_Orders1.Location = new System.Drawing.Point(0, 0);
            this.uC_Orders1.Name = "uC_Orders1";
            this.uC_Orders1.Size = new System.Drawing.Size(1237, 782);
            this.uC_Orders1.TabIndex = 4;
            // 
            // uC_customers1
            // 
            this.uC_customers1.BackColor = System.Drawing.Color.White;
            this.uC_customers1.Location = new System.Drawing.Point(0, 0);
            this.uC_customers1.Name = "uC_customers1";
            this.uC_customers1.Size = new System.Drawing.Size(1237, 782);
            this.uC_customers1.TabIndex = 3;
            // 
            // uC_products1
            // 
            this.uC_products1.BackColor = System.Drawing.Color.White;
            this.uC_products1.Location = new System.Drawing.Point(0, 0);
            this.uC_products1.Name = "uC_products1";
            this.uC_products1.Size = new System.Drawing.Size(1237, 782);
            this.uC_products1.TabIndex = 2;
            // 
            // uC_categories1
            // 
            this.uC_categories1.BackColor = System.Drawing.Color.White;
            this.uC_categories1.Location = new System.Drawing.Point(0, 0);
            this.uC_categories1.Name = "uC_categories1";
            this.uC_categories1.Size = new System.Drawing.Size(1237, 782);
            this.uC_categories1.TabIndex = 1;
            // 
            // frm_Home
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1519, 799);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_salesinvoice;
        private System.Windows.Forms.Button btn_orders;
        private System.Windows.Forms.Button btn_customers;
        private System.Windows.Forms.Button btn_products;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Button btn_no;
        private System.Windows.Forms.Button btn_categories;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private UC_categories uC_categories1;
        private UC_products uC_products1;
        private UC_customers uC_customers1;
        private UC_Orders uC_Orders1;
        private UC_sales_invoice uC_sales_invoice1;
        private UC_user uC_user1;
        private UC_Home uC_Home1;
        public System.Windows.Forms.Button btn_users;
    }
}