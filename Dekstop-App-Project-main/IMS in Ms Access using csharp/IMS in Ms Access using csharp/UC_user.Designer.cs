namespace IMS_in_Ms_Access_using_csharp
{
    partial class UC_user
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
            this.pcb_serchbyname = new System.Windows.Forms.PictureBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_mobailno = new System.Windows.Forms.TextBox();
            this.txt_Username = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_fullname = new System.Windows.Forms.TextBox();
            this.btn_remove = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.pcb_serchbyfullname = new System.Windows.Forms.PictureBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.db_userDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.db_userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ds_user = new IMS_in_Ms_Access_using_csharp.ds_user();
            this.db_userTableAdapter = new IMS_in_Ms_Access_using_csharp.ds_userTableAdapters.db_userTableAdapter();
            this.tableAdapterManager = new IMS_in_Ms_Access_using_csharp.ds_userTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_serchbyname)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_serchbyfullname)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.db_userDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_user)).BeginInit();
            this.SuspendLayout();
            // 
            // pcb_serchbyname
            // 
            this.pcb_serchbyname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pcb_serchbyname.Image = global::IMS_in_Ms_Access_using_csharp.Properties.Resources.icons8_search_96px;
            this.pcb_serchbyname.Location = new System.Drawing.Point(513, 68);
            this.pcb_serchbyname.Name = "pcb_serchbyname";
            this.pcb_serchbyname.Size = new System.Drawing.Size(45, 45);
            this.pcb_serchbyname.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcb_serchbyname.TabIndex = 110;
            this.pcb_serchbyname.TabStop = false;
            this.pcb_serchbyname.Click += new System.EventHandler(this.pcb_serchbyname_Click);
            // 
            // txt_Password
            // 
            this.txt_Password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Password.BackColor = System.Drawing.Color.White;
            this.txt_Password.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Password.ForeColor = System.Drawing.Color.Black;
            this.txt_Password.Location = new System.Drawing.Point(582, 68);
            this.txt_Password.Multiline = true;
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(341, 45);
            this.txt_Password.TabIndex = 105;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(564, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 28);
            this.label1.TabIndex = 102;
            this.label1.Text = "Mobail No. :";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(564, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 28);
            this.label4.TabIndex = 103;
            this.label4.Text = "Password :";
            // 
            // txt_mobailno
            // 
            this.txt_mobailno.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_mobailno.BackColor = System.Drawing.Color.White;
            this.txt_mobailno.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mobailno.ForeColor = System.Drawing.Color.Black;
            this.txt_mobailno.Location = new System.Drawing.Point(582, 161);
            this.txt_mobailno.Multiline = true;
            this.txt_mobailno.Name = "txt_mobailno";
            this.txt_mobailno.Size = new System.Drawing.Size(341, 45);
            this.txt_mobailno.TabIndex = 104;
            // 
            // txt_Username
            // 
            this.txt_Username.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Username.BackColor = System.Drawing.Color.White;
            this.txt_Username.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Username.ForeColor = System.Drawing.Color.Black;
            this.txt_Username.Location = new System.Drawing.Point(160, 68);
            this.txt_Username.Multiline = true;
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.Size = new System.Drawing.Size(341, 45);
            this.txt_Username.TabIndex = 101;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(142, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 28);
            this.label3.TabIndex = 98;
            this.label3.Text = "Full Name :";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(142, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 28);
            this.label2.TabIndex = 99;
            this.label2.Text = "User Name :";
            // 
            // txt_fullname
            // 
            this.txt_fullname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_fullname.BackColor = System.Drawing.Color.White;
            this.txt_fullname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_fullname.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fullname.ForeColor = System.Drawing.Color.Black;
            this.txt_fullname.Location = new System.Drawing.Point(160, 161);
            this.txt_fullname.Multiline = true;
            this.txt_fullname.Name = "txt_fullname";
            this.txt_fullname.Size = new System.Drawing.Size(341, 45);
            this.txt_fullname.TabIndex = 100;
            // 
            // btn_remove
            // 
            this.btn_remove.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_remove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_remove.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_remove.ForeColor = System.Drawing.Color.White;
            this.btn_remove.Location = new System.Drawing.Point(948, 156);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(191, 50);
            this.btn_remove.TabIndex = 108;
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
            this.btn_edit.Location = new System.Drawing.Point(948, 100);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(191, 50);
            this.btn_edit.TabIndex = 107;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = false;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // pcb_serchbyfullname
            // 
            this.pcb_serchbyfullname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pcb_serchbyfullname.Image = global::IMS_in_Ms_Access_using_csharp.Properties.Resources.icons8_search_96px;
            this.pcb_serchbyfullname.Location = new System.Drawing.Point(513, 161);
            this.pcb_serchbyfullname.Name = "pcb_serchbyfullname";
            this.pcb_serchbyfullname.Size = new System.Drawing.Size(45, 45);
            this.pcb_serchbyfullname.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcb_serchbyfullname.TabIndex = 109;
            this.pcb_serchbyfullname.TabStop = false;
            this.pcb_serchbyfullname.Click += new System.EventHandler(this.pcb_serchbyfullname_Click);
            // 
            // btn_login
            // 
            this.btn_login.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.ForeColor = System.Drawing.Color.White;
            this.btn_login.Location = new System.Drawing.Point(948, 44);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(191, 50);
            this.btn_login.TabIndex = 106;
            this.btn_login.Text = "Save";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.db_userDataGridView);
            this.panel1.Location = new System.Drawing.Point(27, 224);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1184, 555);
            this.panel1.TabIndex = 111;
            // 
            // db_userDataGridView
            // 
            this.db_userDataGridView.AllowUserToAddRows = false;
            this.db_userDataGridView.AutoGenerateColumns = false;
            this.db_userDataGridView.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.db_userDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.db_userDataGridView.ColumnHeadersHeight = 40;
            this.db_userDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.db_userDataGridView.DataSource = this.db_userBindingSource;
            this.db_userDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.db_userDataGridView.EnableHeadersVisualStyles = false;
            this.db_userDataGridView.GridColor = System.Drawing.Color.White;
            this.db_userDataGridView.Location = new System.Drawing.Point(0, 0);
            this.db_userDataGridView.Name = "db_userDataGridView";
            this.db_userDataGridView.RowHeadersVisible = false;
            this.db_userDataGridView.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.db_userDataGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.db_userDataGridView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.db_userDataGridView.RowTemplate.Height = 35;
            this.db_userDataGridView.Size = new System.Drawing.Size(1184, 555);
            this.db_userDataGridView.TabIndex = 2;
            this.db_userDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.db_userDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "uid";
            this.dataGridViewTextBoxColumn1.HeaderText = "User ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "username";
            this.dataGridViewTextBoxColumn2.HeaderText = "User Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ufullname";
            this.dataGridViewTextBoxColumn3.HeaderText = "Full Name";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 300;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "upassword";
            this.dataGridViewTextBoxColumn4.HeaderText = "Password";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 200;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "umobailno";
            this.dataGridViewTextBoxColumn5.HeaderText = "Mobailno";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // db_userBindingSource
            // 
            this.db_userBindingSource.DataMember = "db_user";
            this.db_userBindingSource.DataSource = this.ds_user;
            // 
            // ds_user
            // 
            this.ds_user.DataSetName = "ds_user";
            this.ds_user.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // db_userTableAdapter
            // 
            this.db_userTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.db_userTableAdapter = this.db_userTableAdapter;
            this.tableAdapterManager.UpdateOrder = IMS_in_Ms_Access_using_csharp.ds_userTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // UC_user
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pcb_serchbyname);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_mobailno);
            this.Controls.Add(this.txt_Username);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_fullname);
            this.Controls.Add(this.btn_remove);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.pcb_serchbyfullname);
            this.Controls.Add(this.btn_login);
            this.Name = "UC_user";
            this.Size = new System.Drawing.Size(1237, 782);
            this.Load += new System.EventHandler(this.UC_user_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcb_serchbyname)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_serchbyfullname)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.db_userDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_user)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcb_serchbyname;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_mobailno;
        private System.Windows.Forms.TextBox txt_Username;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_fullname;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.PictureBox pcb_serchbyfullname;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Panel panel1;
        private ds_user ds_user;
        private System.Windows.Forms.BindingSource db_userBindingSource;
        private ds_userTableAdapters.db_userTableAdapter db_userTableAdapter;
        private ds_userTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView db_userDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}
