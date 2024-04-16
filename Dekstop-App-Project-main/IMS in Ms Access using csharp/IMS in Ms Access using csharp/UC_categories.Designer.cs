namespace IMS_in_Ms_Access_using_csharp
{
    partial class UC_categories
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_remove = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.pcb_serch = new System.Windows.Forms.PictureBox();
            this.pcb_search1 = new System.Windows.Forms.PictureBox();
            this.txt_categorieid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_categoriename = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.db_categories = new IMS_in_Ms_Access_using_csharp.db_categories();
            this.db_categoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_categoriesTableAdapter = new IMS_in_Ms_Access_using_csharp.db_categoriesTableAdapters.db_categoriesTableAdapter();
            this.tableAdapterManager = new IMS_in_Ms_Access_using_csharp.db_categoriesTableAdapters.TableAdapterManager();
            this.db_categoriesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_serch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_search1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.db_categories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_categoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_categoriesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_remove
            // 
            this.btn_remove.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_remove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_remove.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_remove.ForeColor = System.Drawing.Color.White;
            this.btn_remove.Location = new System.Drawing.Point(707, 154);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(154, 50);
            this.btn_remove.TabIndex = 126;
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
            this.btn_edit.Location = new System.Drawing.Point(526, 154);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(154, 50);
            this.btn_edit.TabIndex = 125;
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
            this.btn_save.Location = new System.Drawing.Point(348, 154);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(154, 50);
            this.btn_save.TabIndex = 124;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // pcb_serch
            // 
            this.pcb_serch.Image = global::IMS_in_Ms_Access_using_csharp.Properties.Resources.icons8_search_96px;
            this.pcb_serch.Location = new System.Drawing.Point(554, 71);
            this.pcb_serch.Name = "pcb_serch";
            this.pcb_serch.Size = new System.Drawing.Size(45, 45);
            this.pcb_serch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcb_serch.TabIndex = 123;
            this.pcb_serch.TabStop = false;
            this.pcb_serch.Click += new System.EventHandler(this.pcb_serch_Click);
            // 
            // pcb_search1
            // 
            this.pcb_search1.Image = global::IMS_in_Ms_Access_using_csharp.Properties.Resources.icons8_search_96px;
            this.pcb_search1.Location = new System.Drawing.Point(980, 71);
            this.pcb_search1.Name = "pcb_search1";
            this.pcb_search1.Size = new System.Drawing.Size(45, 45);
            this.pcb_search1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcb_search1.TabIndex = 122;
            this.pcb_search1.TabStop = false;
            this.pcb_search1.Click += new System.EventHandler(this.pcb_search1_Click);
            // 
            // txt_categorieid
            // 
            this.txt_categorieid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_categorieid.BackColor = System.Drawing.Color.White;
            this.txt_categorieid.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_categorieid.ForeColor = System.Drawing.Color.Black;
            this.txt_categorieid.Location = new System.Drawing.Point(201, 74);
            this.txt_categorieid.Multiline = true;
            this.txt_categorieid.Name = "txt_categorieid";
            this.txt_categorieid.Size = new System.Drawing.Size(341, 45);
            this.txt_categorieid.TabIndex = 121;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(609, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(222, 28);
            this.label3.TabIndex = 118;
            this.label3.Text = "Categorie Name :";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(183, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 28);
            this.label2.TabIndex = 119;
            this.label2.Text = "Categorie ID  :";
            // 
            // txt_categoriename
            // 
            this.txt_categoriename.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_categoriename.BackColor = System.Drawing.Color.White;
            this.txt_categoriename.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_categoriename.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_categoriename.ForeColor = System.Drawing.Color.Black;
            this.txt_categoriename.Location = new System.Drawing.Point(627, 74);
            this.txt_categoriename.Multiline = true;
            this.txt_categoriename.Name = "txt_categoriename";
            this.txt_categoriename.Size = new System.Drawing.Size(341, 45);
            this.txt_categoriename.TabIndex = 120;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.db_categoriesDataGridView);
            this.panel1.Location = new System.Drawing.Point(23, 243);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1201, 546);
            this.panel1.TabIndex = 127;
            // 
            // db_categories
            // 
            this.db_categories.DataSetName = "db_categories";
            this.db_categories.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // db_categoriesBindingSource
            // 
            this.db_categoriesBindingSource.DataMember = "db_categories";
            this.db_categoriesBindingSource.DataSource = this.db_categories;
            // 
            // db_categoriesTableAdapter
            // 
            this.db_categoriesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.db_categoriesTableAdapter = this.db_categoriesTableAdapter;
            this.tableAdapterManager.UpdateOrder = IMS_in_Ms_Access_using_csharp.db_categoriesTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // db_categoriesDataGridView
            // 
            this.db_categoriesDataGridView.AutoGenerateColumns = false;
            this.db_categoriesDataGridView.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.db_categoriesDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.db_categoriesDataGridView.ColumnHeadersHeight = 40;
            this.db_categoriesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.db_categoriesDataGridView.DataSource = this.db_categoriesBindingSource;
            this.db_categoriesDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.db_categoriesDataGridView.EnableHeadersVisualStyles = false;
            this.db_categoriesDataGridView.GridColor = System.Drawing.Color.White;
            this.db_categoriesDataGridView.Location = new System.Drawing.Point(0, 0);
            this.db_categoriesDataGridView.Name = "db_categoriesDataGridView";
            this.db_categoriesDataGridView.RowHeadersVisible = false;
            this.db_categoriesDataGridView.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.db_categoriesDataGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.db_categoriesDataGridView.RowTemplate.Height = 35;
            this.db_categoriesDataGridView.Size = new System.Drawing.Size(1201, 546);
            this.db_categoriesDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "catid";
            this.dataGridViewTextBoxColumn1.HeaderText = "Categories ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 200;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "catname";
            this.dataGridViewTextBoxColumn2.HeaderText = "Categories Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // UC_categories
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_remove);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.pcb_serch);
            this.Controls.Add(this.pcb_search1);
            this.Controls.Add(this.txt_categorieid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_categoriename);
            this.Name = "UC_categories";
            this.Size = new System.Drawing.Size(1237, 789);
            this.Load += new System.EventHandler(this.UC_categories_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcb_serch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_search1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.db_categories)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_categoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_categoriesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.PictureBox pcb_serch;
        private System.Windows.Forms.PictureBox pcb_search1;
        private System.Windows.Forms.TextBox txt_categorieid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_categoriename;
        private System.Windows.Forms.Panel panel1;
        private db_categories db_categories;
        private System.Windows.Forms.BindingSource db_categoriesBindingSource;
        private db_categoriesTableAdapters.db_categoriesTableAdapter db_categoriesTableAdapter;
        private db_categoriesTableAdapters.TableAdapterManager tableAdapterManager;
        public System.Windows.Forms.DataGridView db_categoriesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}
