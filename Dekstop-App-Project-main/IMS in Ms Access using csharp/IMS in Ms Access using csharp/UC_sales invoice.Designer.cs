namespace IMS_in_Ms_Access_using_csharp
{
    partial class UC_sales_invoice
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
            this.btn_print = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.txt_grandtotal = new System.Windows.Forms.TextBox();
            this.btn_remove_ = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_update = new System.Windows.Forms.Button();
            this.txt_totalprice = new System.Windows.Forms.TextBox();
            this.txt_productquantity = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_remove = new System.Windows.Forms.Button();
            this.btn_addtocard = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lbl_productid = new System.Windows.Forms.Label();
            this.lbl_customerid = new System.Windows.Forms.Label();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pcb_search = new System.Windows.Forms.PictureBox();
            this.dtp_invoicedate = new System.Windows.Forms.DateTimePicker();
            this.txt_productprice = new System.Windows.Forms.TextBox();
            this.txt_invoiceno = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_contact = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_productname = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_customername = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ds_procard = new IMS_in_Ms_Access_using_csharp.ds_procard();
            this.db_procardsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_procardsTableAdapter = new IMS_in_Ms_Access_using_csharp.ds_procardTableAdapters.db_procardsTableAdapter();
            this.tableAdapterManager = new IMS_in_Ms_Access_using_csharp.ds_procardTableAdapters.TableAdapterManager();
            this.panel3 = new System.Windows.Forms.Panel();
            this.db_procardsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_search)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_procard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_procardsBindingSource)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.db_procardsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_print
            // 
            this.btn_print.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_print.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_print.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_print.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_print.ForeColor = System.Drawing.Color.White;
            this.btn_print.Location = new System.Drawing.Point(844, 676);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(200, 50);
            this.btn_print.TabIndex = 180;
            this.btn_print.Text = "Print";
            this.btn_print.UseVisualStyleBackColor = false;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // btn_save
            // 
            this.btn_save.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.Color.White;
            this.btn_save.Location = new System.Drawing.Point(174, 676);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(200, 50);
            this.btn_save.TabIndex = 176;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // txt_grandtotal
            // 
            this.txt_grandtotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_grandtotal.BackColor = System.Drawing.Color.White;
            this.txt_grandtotal.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_grandtotal.ForeColor = System.Drawing.Color.Black;
            this.txt_grandtotal.Location = new System.Drawing.Point(844, 569);
            this.txt_grandtotal.Multiline = true;
            this.txt_grandtotal.Name = "txt_grandtotal";
            this.txt_grandtotal.Size = new System.Drawing.Size(303, 45);
            this.txt_grandtotal.TabIndex = 190;
            // 
            // btn_remove_
            // 
            this.btn_remove_.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_remove_.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_remove_.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_remove_.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_remove_.ForeColor = System.Drawing.Color.White;
            this.btn_remove_.Location = new System.Drawing.Point(619, 676);
            this.btn_remove_.Name = "btn_remove_";
            this.btn_remove_.Size = new System.Drawing.Size(200, 50);
            this.btn_remove_.TabIndex = 178;
            this.btn_remove_.Text = "Remove";
            this.btn_remove_.UseVisualStyleBackColor = false;
            this.btn_remove_.Click += new System.EventHandler(this.btn_remove__Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(826, 538);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 28);
            this.label4.TabIndex = 189;
            this.label4.Text = "Grand Total :";
            // 
            // btn_update
            // 
            this.btn_update.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.ForeColor = System.Drawing.Color.White;
            this.btn_update.Location = new System.Drawing.Point(397, 676);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(200, 50);
            this.btn_update.TabIndex = 177;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // txt_totalprice
            // 
            this.txt_totalprice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_totalprice.BackColor = System.Drawing.Color.White;
            this.txt_totalprice.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_totalprice.ForeColor = System.Drawing.Color.Black;
            this.txt_totalprice.Location = new System.Drawing.Point(99, 569);
            this.txt_totalprice.Multiline = true;
            this.txt_totalprice.Name = "txt_totalprice";
            this.txt_totalprice.Size = new System.Drawing.Size(303, 45);
            this.txt_totalprice.TabIndex = 192;
            // 
            // txt_productquantity
            // 
            this.txt_productquantity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_productquantity.BackColor = System.Drawing.Color.White;
            this.txt_productquantity.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_productquantity.ForeColor = System.Drawing.Color.Black;
            this.txt_productquantity.Location = new System.Drawing.Point(844, 458);
            this.txt_productquantity.Multiline = true;
            this.txt_productquantity.Name = "txt_productquantity";
            this.txt_productquantity.Size = new System.Drawing.Size(303, 45);
            this.txt_productquantity.TabIndex = 186;
            this.txt_productquantity.TextChanged += new System.EventHandler(this.txt_productquantity_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(78, 538);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 28);
            this.label3.TabIndex = 191;
            this.label3.Text = "Total Price :";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(826, 427);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 28);
            this.label2.TabIndex = 184;
            this.label2.Text = "Product Quantity :";
            // 
            // btn_remove
            // 
            this.btn_remove.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_remove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_remove.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_remove.ForeColor = System.Drawing.Color.White;
            this.btn_remove.Location = new System.Drawing.Point(648, 564);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(142, 50);
            this.btn_remove.TabIndex = 188;
            this.btn_remove.Text = "Remove";
            this.btn_remove.UseVisualStyleBackColor = false;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // btn_addtocard
            // 
            this.btn_addtocard.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_addtocard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_addtocard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addtocard.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addtocard.ForeColor = System.Drawing.Color.White;
            this.btn_addtocard.Location = new System.Drawing.Point(466, 564);
            this.btn_addtocard.Name = "btn_addtocard";
            this.btn_addtocard.Size = new System.Drawing.Size(175, 50);
            this.btn_addtocard.TabIndex = 187;
            this.btn_addtocard.Text = "Add To Card";
            this.btn_addtocard.UseVisualStyleBackColor = false;
            this.btn_addtocard.Click += new System.EventHandler(this.btn_addtocard_Click);
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.lbl_productid);
            this.panel6.Controls.Add(this.lbl_customerid);
            this.panel6.Location = new System.Drawing.Point(402, 63);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(80, 47);
            this.panel6.TabIndex = 173;
            this.panel6.Visible = false;
            // 
            // lbl_productid
            // 
            this.lbl_productid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_productid.AutoSize = true;
            this.lbl_productid.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_productid.ForeColor = System.Drawing.Color.Indigo;
            this.lbl_productid.Location = new System.Drawing.Point(60, 8);
            this.lbl_productid.Name = "lbl_productid";
            this.lbl_productid.Size = new System.Drawing.Size(0, 28);
            this.lbl_productid.TabIndex = 133;
            // 
            // lbl_customerid
            // 
            this.lbl_customerid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_customerid.AutoSize = true;
            this.lbl_customerid.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_customerid.ForeColor = System.Drawing.Color.Indigo;
            this.lbl_customerid.Location = new System.Drawing.Point(19, 8);
            this.lbl_customerid.Name = "lbl_customerid";
            this.lbl_customerid.Size = new System.Drawing.Size(0, 28);
            this.lbl_customerid.TabIndex = 132;
            // 
            // txt_address
            // 
            this.txt_address.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_address.BackColor = System.Drawing.Color.White;
            this.txt_address.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_address.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_address.ForeColor = System.Drawing.Color.Black;
            this.txt_address.Location = new System.Drawing.Point(844, 342);
            this.txt_address.Multiline = true;
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(303, 45);
            this.txt_address.TabIndex = 175;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(463, 427);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 28);
            this.label1.TabIndex = 183;
            this.label1.Text = "Product Price :";
            // 
            // pcb_search
            // 
            this.pcb_search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pcb_search.Image = global::IMS_in_Ms_Access_using_csharp.Properties.Resources.icons8_search_96px;
            this.pcb_search.Location = new System.Drawing.Point(427, 229);
            this.pcb_search.Name = "pcb_search";
            this.pcb_search.Size = new System.Drawing.Size(45, 45);
            this.pcb_search.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcb_search.TabIndex = 170;
            this.pcb_search.TabStop = false;
            this.pcb_search.Click += new System.EventHandler(this.pcb_search_Click);
            // 
            // dtp_invoicedate
            // 
            this.dtp_invoicedate.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_invoicedate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_invoicedate.Location = new System.Drawing.Point(99, 124);
            this.dtp_invoicedate.Name = "dtp_invoicedate";
            this.dtp_invoicedate.Size = new System.Drawing.Size(302, 48);
            this.dtp_invoicedate.TabIndex = 171;
            // 
            // txt_productprice
            // 
            this.txt_productprice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_productprice.BackColor = System.Drawing.Color.White;
            this.txt_productprice.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_productprice.ForeColor = System.Drawing.Color.Black;
            this.txt_productprice.Location = new System.Drawing.Point(484, 458);
            this.txt_productprice.Multiline = true;
            this.txt_productprice.Name = "txt_productprice";
            this.txt_productprice.Size = new System.Drawing.Size(303, 45);
            this.txt_productprice.TabIndex = 185;
            // 
            // txt_invoiceno
            // 
            this.txt_invoiceno.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_invoiceno.BackColor = System.Drawing.Color.White;
            this.txt_invoiceno.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_invoiceno.ForeColor = System.Drawing.Color.Black;
            this.txt_invoiceno.Location = new System.Drawing.Point(99, 229);
            this.txt_invoiceno.Multiline = true;
            this.txt_invoiceno.Name = "txt_invoiceno";
            this.txt_invoiceno.Size = new System.Drawing.Size(302, 45);
            this.txt_invoiceno.TabIndex = 167;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label9.Location = new System.Drawing.Point(81, 198);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(158, 28);
            this.label9.TabIndex = 165;
            this.label9.Text = "Invoice No. :";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(826, 311);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 28);
            this.label6.TabIndex = 169;
            this.label6.Text = "Address :";
            // 
            // txt_contact
            // 
            this.txt_contact.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_contact.BackColor = System.Drawing.Color.White;
            this.txt_contact.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_contact.ForeColor = System.Drawing.Color.Black;
            this.txt_contact.Location = new System.Drawing.Point(484, 342);
            this.txt_contact.Multiline = true;
            this.txt_contact.Name = "txt_contact";
            this.txt_contact.Size = new System.Drawing.Size(303, 45);
            this.txt_contact.TabIndex = 174;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(81, 427);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(193, 28);
            this.label5.TabIndex = 181;
            this.label5.Text = "Product Name :";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label10.Location = new System.Drawing.Point(81, 93);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(173, 28);
            this.label10.TabIndex = 164;
            this.label10.Text = "Invoice Date :";
            // 
            // txt_productname
            // 
            this.txt_productname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_productname.BackColor = System.Drawing.Color.White;
            this.txt_productname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_productname.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_productname.ForeColor = System.Drawing.Color.Black;
            this.txt_productname.Location = new System.Drawing.Point(99, 458);
            this.txt_productname.Multiline = true;
            this.txt_productname.Name = "txt_productname";
            this.txt_productname.Size = new System.Drawing.Size(303, 45);
            this.txt_productname.TabIndex = 182;
            this.txt_productname.TextChanged += new System.EventHandler(this.txt_productname_TextChanged);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(463, 311);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 28);
            this.label7.TabIndex = 172;
            this.label7.Text = "Contact :";
            // 
            // txt_customername
            // 
            this.txt_customername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_customername.BackColor = System.Drawing.Color.White;
            this.txt_customername.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_customername.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_customername.ForeColor = System.Drawing.Color.Black;
            this.txt_customername.Location = new System.Drawing.Point(99, 342);
            this.txt_customername.Multiline = true;
            this.txt_customername.Name = "txt_customername";
            this.txt_customername.Size = new System.Drawing.Size(303, 45);
            this.txt_customername.TabIndex = 168;
            this.txt_customername.TextChanged += new System.EventHandler(this.txt_customername_TextChanged);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(81, 311);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(217, 28);
            this.label8.TabIndex = 166;
            this.label8.Text = "Customer Name :";
            // 
            // ds_procard
            // 
            this.ds_procard.DataSetName = "ds_procard";
            this.ds_procard.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // db_procardsBindingSource
            // 
            this.db_procardsBindingSource.DataMember = "db_procards";
            this.db_procardsBindingSource.DataSource = this.ds_procard;
            // 
            // db_procardsTableAdapter
            // 
            this.db_procardsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.db_procardsTableAdapter = this.db_procardsTableAdapter;
            this.tableAdapterManager.UpdateOrder = IMS_in_Ms_Access_using_csharp.ds_procardTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gray;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.db_procardsDataGridView);
            this.panel3.Location = new System.Drawing.Point(503, 63);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(661, 232);
            this.panel3.TabIndex = 193;
            // 
            // db_procardsDataGridView
            // 
            this.db_procardsDataGridView.AllowUserToAddRows = false;
            this.db_procardsDataGridView.AutoGenerateColumns = false;
            this.db_procardsDataGridView.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.db_procardsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.db_procardsDataGridView.ColumnHeadersHeight = 40;
            this.db_procardsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.db_procardsDataGridView.DataSource = this.db_procardsBindingSource;
            this.db_procardsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.db_procardsDataGridView.EnableHeadersVisualStyles = false;
            this.db_procardsDataGridView.GridColor = System.Drawing.Color.White;
            this.db_procardsDataGridView.Location = new System.Drawing.Point(0, 0);
            this.db_procardsDataGridView.Name = "db_procardsDataGridView";
            this.db_procardsDataGridView.RowHeadersVisible = false;
            this.db_procardsDataGridView.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.db_procardsDataGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.db_procardsDataGridView.RowTemplate.Height = 24;
            this.db_procardsDataGridView.Size = new System.Drawing.Size(659, 230);
            this.db_procardsDataGridView.TabIndex = 1;
            this.db_procardsDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.db_procardsDataGridView_CellClick);
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "proid";
            this.dataGridViewTextBoxColumn3.HeaderText = "ID";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "proname";
            this.dataGridViewTextBoxColumn4.HeaderText = "Product";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 200;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "proqut";
            this.dataGridViewTextBoxColumn5.HeaderText = "Quantity";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "proprice";
            this.dataGridViewTextBoxColumn6.HeaderText = "Price";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 150;
            // 
            // UC_sales_invoice
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btn_print);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.txt_grandtotal);
            this.Controls.Add(this.btn_remove_);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.txt_totalprice);
            this.Controls.Add(this.txt_productquantity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_remove);
            this.Controls.Add(this.btn_addtocard);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.txt_address);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pcb_search);
            this.Controls.Add(this.dtp_invoicedate);
            this.Controls.Add(this.txt_productprice);
            this.Controls.Add(this.txt_invoiceno);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_contact);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_productname);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_customername);
            this.Controls.Add(this.label8);
            this.Name = "UC_sales_invoice";
            this.Size = new System.Drawing.Size(1237, 782);
            this.Load += new System.EventHandler(this.UC_sales_invoice_Load);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_search)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_procard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_procardsBindingSource)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.db_procardsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_print;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.TextBox txt_grandtotal;
        private System.Windows.Forms.Button btn_remove_;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.TextBox txt_totalprice;
        private System.Windows.Forms.TextBox txt_productquantity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.Button btn_addtocard;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lbl_productid;
        private System.Windows.Forms.Label lbl_customerid;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pcb_search;
        private System.Windows.Forms.DateTimePicker dtp_invoicedate;
        private System.Windows.Forms.TextBox txt_productprice;
        private System.Windows.Forms.TextBox txt_invoiceno;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_contact;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_productname;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_customername;
        private System.Windows.Forms.Label label8;
        private ds_procard ds_procard;
        private System.Windows.Forms.BindingSource db_procardsBindingSource;
        private ds_procardTableAdapters.db_procardsTableAdapter db_procardsTableAdapter;
        private ds_procardTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView db_procardsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}
