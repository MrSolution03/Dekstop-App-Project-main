namespace IMS_in_Ms_Access_using_csharp
{
    partial class UC_products
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txt_categoriename = new System.Windows.Forms.ComboBox();
            this.btn_remove = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.pcb_search = new System.Windows.Forms.PictureBox();
            this.pcb_search1 = new System.Windows.Forms.PictureBox();
            this.txt_description = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_productquantity = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_productprice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_productname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_productid = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ds_product = new IMS_in_Ms_Access_using_csharp.ds_product();
            this.db_productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_productTableAdapter = new IMS_in_Ms_Access_using_csharp.ds_productTableAdapters.db_productTableAdapter();
            this.tableAdapterManager = new IMS_in_Ms_Access_using_csharp.ds_productTableAdapters.TableAdapterManager();
            this.db_productDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_search)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_search1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ds_product)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_productDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_categoriename
            // 
            this.txt_categoriename.Font = new System.Drawing.Font("Palatino Linotype", 16.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_categoriename.FormattingEnabled = true;
            this.txt_categoriename.Location = new System.Drawing.Point(554, 239);
            this.txt_categoriename.Name = "txt_categoriename";
            this.txt_categoriename.Size = new System.Drawing.Size(341, 46);
            this.txt_categoriename.TabIndex = 177;
            // 
            // btn_remove
            // 
            this.btn_remove.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_remove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_remove.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_remove.ForeColor = System.Drawing.Color.White;
            this.btn_remove.Location = new System.Drawing.Point(938, 234);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(167, 50);
            this.btn_remove.TabIndex = 176;
            this.btn_remove.Text = "Remove";
            this.btn_remove.UseVisualStyleBackColor = false;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_edit.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.ForeColor = System.Drawing.Color.White;
            this.btn_edit.Location = new System.Drawing.Point(938, 140);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(167, 50);
            this.btn_edit.TabIndex = 175;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = false;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_save
            // 
            this.btn_save.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.Color.White;
            this.btn_save.Location = new System.Drawing.Point(938, 47);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(167, 50);
            this.btn_save.TabIndex = 174;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // pcb_search
            // 
            this.pcb_search.Image = global::IMS_in_Ms_Access_using_csharp.Properties.Resources.icons8_search_96px;
            this.pcb_search.Location = new System.Drawing.Point(473, 52);
            this.pcb_search.Name = "pcb_search";
            this.pcb_search.Size = new System.Drawing.Size(45, 45);
            this.pcb_search.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcb_search.TabIndex = 173;
            this.pcb_search.TabStop = false;
            this.pcb_search.Click += new System.EventHandler(this.pcb_search_Click);
            // 
            // pcb_search1
            // 
            this.pcb_search1.Image = global::IMS_in_Ms_Access_using_csharp.Properties.Resources.icons8_search_96px;
            this.pcb_search1.Location = new System.Drawing.Point(473, 145);
            this.pcb_search1.Name = "pcb_search1";
            this.pcb_search1.Size = new System.Drawing.Size(45, 45);
            this.pcb_search1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcb_search1.TabIndex = 172;
            this.pcb_search1.TabStop = false;
            this.pcb_search1.Click += new System.EventHandler(this.pcb_search1_Click);
            // 
            // txt_description
            // 
            this.txt_description.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_description.BackColor = System.Drawing.Color.White;
            this.txt_description.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_description.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_description.ForeColor = System.Drawing.Color.Black;
            this.txt_description.Location = new System.Drawing.Point(554, 145);
            this.txt_description.Multiline = true;
            this.txt_description.Name = "txt_description";
            this.txt_description.Size = new System.Drawing.Size(341, 45);
            this.txt_description.TabIndex = 171;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(536, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(222, 28);
            this.label5.TabIndex = 169;
            this.label5.Text = "Categorie Name :";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(536, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(163, 28);
            this.label6.TabIndex = 170;
            this.label6.Text = "Description  :";
            // 
            // txt_productquantity
            // 
            this.txt_productquantity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_productquantity.BackColor = System.Drawing.Color.White;
            this.txt_productquantity.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_productquantity.ForeColor = System.Drawing.Color.Black;
            this.txt_productquantity.Location = new System.Drawing.Point(120, 239);
            this.txt_productquantity.Multiline = true;
            this.txt_productquantity.Name = "txt_productquantity";
            this.txt_productquantity.Size = new System.Drawing.Size(341, 45);
            this.txt_productquantity.TabIndex = 168;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(536, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 28);
            this.label1.TabIndex = 165;
            this.label1.Text = "Product Price :";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(102, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(219, 28);
            this.label4.TabIndex = 166;
            this.label4.Text = "Product Quantity :";
            // 
            // txt_productprice
            // 
            this.txt_productprice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_productprice.BackColor = System.Drawing.Color.White;
            this.txt_productprice.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_productprice.ForeColor = System.Drawing.Color.Black;
            this.txt_productprice.Location = new System.Drawing.Point(554, 52);
            this.txt_productprice.Multiline = true;
            this.txt_productprice.Name = "txt_productprice";
            this.txt_productprice.Size = new System.Drawing.Size(341, 45);
            this.txt_productprice.TabIndex = 167;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(102, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 28);
            this.label3.TabIndex = 161;
            this.label3.Text = "Product Name :";
            // 
            // txt_productname
            // 
            this.txt_productname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_productname.BackColor = System.Drawing.Color.White;
            this.txt_productname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_productname.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_productname.ForeColor = System.Drawing.Color.Black;
            this.txt_productname.Location = new System.Drawing.Point(120, 145);
            this.txt_productname.Multiline = true;
            this.txt_productname.Name = "txt_productname";
            this.txt_productname.Size = new System.Drawing.Size(341, 45);
            this.txt_productname.TabIndex = 163;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(102, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 28);
            this.label2.TabIndex = 162;
            this.label2.Text = "Product ID :";
            // 
            // txt_productid
            // 
            this.txt_productid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_productid.BackColor = System.Drawing.Color.White;
            this.txt_productid.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_productid.ForeColor = System.Drawing.Color.Black;
            this.txt_productid.Location = new System.Drawing.Point(120, 52);
            this.txt_productid.Multiline = true;
            this.txt_productid.Name = "txt_productid";
            this.txt_productid.Size = new System.Drawing.Size(341, 45);
            this.txt_productid.TabIndex = 164;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.db_productDataGridView);
            this.panel1.Location = new System.Drawing.Point(24, 305);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1210, 474);
            this.panel1.TabIndex = 178;
            // 
            // ds_product
            // 
            this.ds_product.DataSetName = "ds_product";
            this.ds_product.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // db_productBindingSource
            // 
            this.db_productBindingSource.DataMember = "db_product";
            this.db_productBindingSource.DataSource = this.ds_product;
            // 
            // db_productTableAdapter
            // 
            this.db_productTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.db_productTableAdapter = this.db_productTableAdapter;
            this.tableAdapterManager.UpdateOrder = IMS_in_Ms_Access_using_csharp.ds_productTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // db_productDataGridView
            // 
            this.db_productDataGridView.AllowUserToAddRows = false;
            this.db_productDataGridView.AutoGenerateColumns = false;
            this.db_productDataGridView.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.db_productDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.db_productDataGridView.ColumnHeadersHeight = 40;
            this.db_productDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.db_productDataGridView.DataSource = this.db_productBindingSource;
            this.db_productDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.db_productDataGridView.EnableHeadersVisualStyles = false;
            this.db_productDataGridView.GridColor = System.Drawing.Color.White;
            this.db_productDataGridView.Location = new System.Drawing.Point(0, 0);
            this.db_productDataGridView.Name = "db_productDataGridView";
            this.db_productDataGridView.RowHeadersVisible = false;
            this.db_productDataGridView.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.db_productDataGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.db_productDataGridView.RowTemplate.Height = 24;
            this.db_productDataGridView.Size = new System.Drawing.Size(1210, 474);
            this.db_productDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "proid";
            this.dataGridViewTextBoxColumn1.HeaderText = "Product ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "proname";
            this.dataGridViewTextBoxColumn2.HeaderText = "Product Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "proqut";
            this.dataGridViewTextBoxColumn3.HeaderText = "Product quantity";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "proprice";
            this.dataGridViewTextBoxColumn4.HeaderText = "Product Price";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "prodesc";
            this.dataGridViewTextBoxColumn5.HeaderText = "Product Description";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 300;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "procategorie";
            this.dataGridViewTextBoxColumn6.HeaderText = "Categorie Name";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 200;
            // 
            // UC_products
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txt_categoriename);
            this.Controls.Add(this.btn_remove);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.pcb_search);
            this.Controls.Add(this.pcb_search1);
            this.Controls.Add(this.txt_description);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_productquantity);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_productprice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_productname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_productid);
            this.Name = "UC_products";
            this.Size = new System.Drawing.Size(1237, 782);
            this.Load += new System.EventHandler(this.UC_products_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcb_search)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_search1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ds_product)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_productDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox txt_categoriename;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.PictureBox pcb_search;
        private System.Windows.Forms.PictureBox pcb_search1;
        private System.Windows.Forms.TextBox txt_description;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_productquantity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_productprice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_productname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_productid;
        private System.Windows.Forms.Panel panel1;
        private ds_product ds_product;
        private System.Windows.Forms.BindingSource db_productBindingSource;
        private ds_productTableAdapters.db_productTableAdapter db_productTableAdapter;
        private ds_productTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView db_productDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}
