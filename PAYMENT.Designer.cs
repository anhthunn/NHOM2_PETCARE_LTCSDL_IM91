
namespace PetCareProject
{
    partial class PAYMENT
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PAYMENT));
            this.lbDateTime = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listDetail = new System.Windows.Forms.ListView();
            this.colProduct = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colService = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colQuantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtPetID = new System.Windows.Forms.TextBox();
            this.txtPetName = new System.Windows.Forms.TextBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btX = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.numProduct = new System.Windows.Forms.NumericUpDown();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.listUnpaid = new System.Windows.Forms.ListView();
            this.colpetID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colpetname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colcustomername = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colcontact = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btAddPet = new System.Windows.Forms.Button();
            this.grbx = new System.Windows.Forms.GroupBox();
            this.cbbProduct = new System.Windows.Forms.ComboBox();
            this.tblProductsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet = new PetCareProject.DataSet();
            this.cbbService = new System.Windows.Forms.ComboBox();
            this.tblServicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.numService = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btCancel1 = new System.Windows.Forms.Button();
            this.btCancel2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btClose = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.lbStaff = new System.Windows.Forms.Label();
            this.tblServicesTableAdapter = new PetCareProject.DataSetTableAdapters.tblServicesTableAdapter();
            this.tblProductsTableAdapter = new PetCareProject.DataSetTableAdapters.tblProductsTableAdapter();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numProduct)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.grbx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblProductsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblServicesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numService)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // lbDateTime
            // 
            this.lbDateTime.AutoSize = true;
            this.lbDateTime.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDateTime.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbDateTime.Location = new System.Drawing.Point(986, 86);
            this.lbDateTime.Name = "lbDateTime";
            this.lbDateTime.Size = new System.Drawing.Size(73, 18);
            this.lbDateTime.TabIndex = 26;
            this.lbDateTime.Text = "DateTime";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.lbTotal);
            this.groupBox3.Controls.Add(this.pictureBox2);
            this.groupBox3.Location = new System.Drawing.Point(602, 442);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(591, 138);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Berlin Sans FB Demi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(266, 73);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(275, 48);
            this.button1.TabIndex = 4;
            this.button1.Text = "Confirm";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btConfirm_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Berlin Sans FB Demi", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(256, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 31);
            this.label5.TabIndex = 1;
            this.label5.Text = "TOTAL";
            // 
            // lbTotal
            // 
            this.lbTotal.BackColor = System.Drawing.Color.LavenderBlush;
            this.lbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.ForeColor = System.Drawing.Color.Red;
            this.lbTotal.Location = new System.Drawing.Point(362, 16);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(179, 42);
            this.lbTotal.TabIndex = 5;
            this.lbTotal.Text = "0";
            this.lbTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PetCareProject.Properties.Resources.PikPng_com_cash_icon_png_1544979;
            this.pictureBox2.Location = new System.Drawing.Point(19, 16);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(156, 113);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listDetail);
            this.groupBox2.Controls.Add(this.txtPetID);
            this.groupBox2.Controls.Add(this.txtPetName);
            this.groupBox2.Controls.Add(this.txtCustomerName);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btX);
            this.groupBox2.Font = new System.Drawing.Font("Berlin Sans FB Demi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox2.Location = new System.Drawing.Point(602, 99);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(591, 338);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Payment Details";
            // 
            // listDetail
            // 
            this.listDetail.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colProduct,
            this.colService,
            this.colQuantity,
            this.colPrice,
            this.colTotal});
            this.listDetail.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listDetail.FullRowSelect = true;
            this.listDetail.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listDetail.HideSelection = false;
            this.listDetail.Location = new System.Drawing.Point(19, 187);
            this.listDetail.Name = "listDetail";
            this.listDetail.Size = new System.Drawing.Size(522, 135);
            this.listDetail.TabIndex = 19;
            this.listDetail.UseCompatibleStateImageBehavior = false;
            this.listDetail.View = System.Windows.Forms.View.Details;
            // 
            // colProduct
            // 
            this.colProduct.Text = "Product";
            this.colProduct.Width = 134;
            // 
            // colService
            // 
            this.colService.Text = "Service";
            this.colService.Width = 107;
            // 
            // colQuantity
            // 
            this.colQuantity.Text = "Quantity";
            this.colQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colQuantity.Width = 95;
            // 
            // colPrice
            // 
            this.colPrice.Text = "Price";
            this.colPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // colTotal
            // 
            this.colTotal.Text = "Total";
            this.colTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colTotal.Width = 88;
            // 
            // txtPetID
            // 
            this.txtPetID.BackColor = System.Drawing.Color.LavenderBlush;
            this.txtPetID.Enabled = false;
            this.txtPetID.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPetID.Location = new System.Drawing.Point(154, 128);
            this.txtPetID.Name = "txtPetID";
            this.txtPetID.Size = new System.Drawing.Size(387, 26);
            this.txtPetID.TabIndex = 0;
            // 
            // txtPetName
            // 
            this.txtPetName.BackColor = System.Drawing.Color.LavenderBlush;
            this.txtPetName.Enabled = false;
            this.txtPetName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPetName.Location = new System.Drawing.Point(154, 84);
            this.txtPetName.Name = "txtPetName";
            this.txtPetName.Size = new System.Drawing.Size(387, 26);
            this.txtPetName.TabIndex = 0;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.BackColor = System.Drawing.Color.LavenderBlush;
            this.txtCustomerName.Enabled = false;
            this.txtCustomerName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerName.Location = new System.Drawing.Point(154, 40);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(387, 26);
            this.txtCustomerName.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(15, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Pet ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(14, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Pet Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(13, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Customer Name";
            // 
            // btX
            // 
            this.btX.BackColor = System.Drawing.Color.Black;
            this.btX.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btX.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btX.Font = new System.Drawing.Font("Arial Unicode MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btX.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btX.Location = new System.Drawing.Point(547, 187);
            this.btX.Name = "btX";
            this.btX.Size = new System.Drawing.Size(23, 31);
            this.btX.TabIndex = 18;
            this.btX.Text = "-";
            this.btX.UseVisualStyleBackColor = false;
            this.btX.Click += new System.EventHandler(this.btX_Click);
            // 
            // btAdd
            // 
            this.btAdd.BackColor = System.Drawing.Color.Black;
            this.btAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btAdd.Font = new System.Drawing.Font("Berlin Sans FB Demi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdd.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btAdd.Location = new System.Drawing.Point(425, 561);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(98, 37);
            this.btAdd.TabIndex = 18;
            this.btAdd.Text = "Add";
            this.btAdd.UseVisualStyleBackColor = false;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // numProduct
            // 
            this.numProduct.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numProduct.Location = new System.Drawing.Point(428, 120);
            this.numProduct.Name = "numProduct";
            this.numProduct.Size = new System.Drawing.Size(52, 29);
            this.numProduct.TabIndex = 2;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.listUnpaid);
            this.groupBox4.Font = new System.Drawing.Font("Berlin Sans FB Demi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox4.Location = new System.Drawing.Point(43, 99);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(544, 250);
            this.groupBox4.TabIndex = 24;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Unpaid Customers";
            // 
            // listUnpaid
            // 
            this.listUnpaid.BackColor = System.Drawing.Color.Black;
            this.listUnpaid.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colpetID,
            this.colpetname,
            this.colcustomername,
            this.colcontact});
            this.listUnpaid.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listUnpaid.ForeColor = System.Drawing.SystemColors.Menu;
            this.listUnpaid.FullRowSelect = true;
            this.listUnpaid.GridLines = true;
            this.listUnpaid.HideSelection = false;
            this.listUnpaid.Location = new System.Drawing.Point(6, 28);
            this.listUnpaid.Name = "listUnpaid";
            this.listUnpaid.Size = new System.Drawing.Size(531, 187);
            this.listUnpaid.TabIndex = 5;
            this.listUnpaid.UseCompatibleStateImageBehavior = false;
            this.listUnpaid.View = System.Windows.Forms.View.Details;
            this.listUnpaid.SelectedIndexChanged += new System.EventHandler(this.listPaymentDetail_SelectedIndexChanged);
            // 
            // colpetID
            // 
            this.colpetID.Text = "Pet ID";
            this.colpetID.Width = 80;
            // 
            // colpetname
            // 
            this.colpetname.Text = "Pet Name";
            this.colpetname.Width = 100;
            // 
            // colcustomername
            // 
            this.colcustomername.Text = "Customer Name";
            this.colcustomername.Width = 200;
            // 
            // colcontact
            // 
            this.colcontact.Text = "Contact";
            this.colcontact.Width = 150;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font(".VnRevue", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(450, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 28);
            this.label8.TabIndex = 15;
            this.label8.Text = "PETCARE";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Curlz MT", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(397, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(221, 43);
            this.label7.TabIndex = 16;
            this.label7.Text = "HAPPY PAWS";
            // 
            // btAddPet
            // 
            this.btAddPet.BackColor = System.Drawing.Color.Black;
            this.btAddPet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAddPet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btAddPet.Font = new System.Drawing.Font("Berlin Sans FB Demi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAddPet.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btAddPet.Location = new System.Drawing.Point(213, 333);
            this.btAddPet.Name = "btAddPet";
            this.btAddPet.Size = new System.Drawing.Size(243, 37);
            this.btAddPet.TabIndex = 19;
            this.btAddPet.Text = "Add New Pets";
            this.btAddPet.UseVisualStyleBackColor = false;
            this.btAddPet.Click += new System.EventHandler(this.btAddPet_Click);
            // 
            // grbx
            // 
            this.grbx.Controls.Add(this.cbbProduct);
            this.grbx.Controls.Add(this.cbbService);
            this.grbx.Controls.Add(this.pictureBox3);
            this.grbx.Controls.Add(this.numProduct);
            this.grbx.Controls.Add(this.pictureBox1);
            this.grbx.Controls.Add(this.numService);
            this.grbx.Controls.Add(this.label1);
            this.grbx.Controls.Add(this.btCancel1);
            this.grbx.Controls.Add(this.btCancel2);
            this.grbx.Controls.Add(this.label2);
            this.grbx.Location = new System.Drawing.Point(43, 376);
            this.grbx.Name = "grbx";
            this.grbx.Size = new System.Drawing.Size(544, 204);
            this.grbx.TabIndex = 17;
            this.grbx.TabStop = false;
            // 
            // cbbProduct
            // 
            this.cbbProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbbProduct.DataSource = this.tblProductsBindingSource;
            this.cbbProduct.DisplayMember = "productname";
            this.cbbProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbProduct.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbProduct.FormattingEnabled = true;
            this.cbbProduct.Location = new System.Drawing.Point(199, 121);
            this.cbbProduct.Name = "cbbProduct";
            this.cbbProduct.Size = new System.Drawing.Size(223, 24);
            this.cbbProduct.TabIndex = 0;
            // 
            // tblProductsBindingSource
            // 
            this.tblProductsBindingSource.DataMember = "tblProducts";
            this.tblProductsBindingSource.DataSource = this.dataSet;
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "DataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbbService
            // 
            this.cbbService.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbbService.DataSource = this.tblServicesBindingSource;
            this.cbbService.DisplayMember = "servicename";
            this.cbbService.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbService.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbService.FormattingEnabled = true;
            this.cbbService.Location = new System.Drawing.Point(199, 49);
            this.cbbService.Name = "cbbService";
            this.cbbService.Size = new System.Drawing.Size(223, 24);
            this.cbbService.TabIndex = 0;
            // 
            // tblServicesBindingSource
            // 
            this.tblServicesBindingSource.DataMember = "tblServices";
            this.tblServicesBindingSource.DataSource = this.dataSet;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::PetCareProject.Properties.Resources.PikPng_com_add_to_cart_png_5457299;
            this.pictureBox3.Location = new System.Drawing.Point(26, 105);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(63, 44);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PetCareProject.Properties.Resources.PikPng_com_dog_face_png_771547;
            this.pictureBox1.Location = new System.Drawing.Point(22, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 47);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // numService
            // 
            this.numService.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numService.Location = new System.Drawing.Point(428, 46);
            this.numService.Name = "numService";
            this.numService.Size = new System.Drawing.Size(52, 29);
            this.numService.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB Demi", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(99, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Services";
            // 
            // btCancel1
            // 
            this.btCancel1.BackColor = System.Drawing.Color.Black;
            this.btCancel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCancel1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btCancel1.Font = new System.Drawing.Font("Arial Unicode MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancel1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btCancel1.Location = new System.Drawing.Point(501, 44);
            this.btCancel1.Name = "btCancel1";
            this.btCancel1.Size = new System.Drawing.Size(23, 32);
            this.btCancel1.TabIndex = 18;
            this.btCancel1.Text = "x";
            this.btCancel1.UseVisualStyleBackColor = false;
            this.btCancel1.Click += new System.EventHandler(this.btCancel1_Click);
            // 
            // btCancel2
            // 
            this.btCancel2.BackColor = System.Drawing.Color.Black;
            this.btCancel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCancel2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btCancel2.Font = new System.Drawing.Font("Arial Unicode MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancel2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btCancel2.Location = new System.Drawing.Point(501, 115);
            this.btCancel2.Name = "btCancel2";
            this.btCancel2.Size = new System.Drawing.Size(23, 32);
            this.btCancel2.TabIndex = 18;
            this.btCancel2.Text = "x";
            this.btCancel2.UseVisualStyleBackColor = false;
            this.btCancel2.Click += new System.EventHandler(this.btCancel2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Berlin Sans FB Demi", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(100, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Products";
            // 
            // btClose
            // 
            this.btClose.BackgroundImage = global::PetCareProject.Properties.Resources.PikPng_com_clear_button_png_3492816;
            this.btClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btClose.Location = new System.Drawing.Point(12, 12);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(33, 32);
            this.btClose.TabIndex = 25;
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::PetCareProject.Properties.Resources.PikPng_com_cat_paw_print_png_2538733;
            this.pictureBox4.Location = new System.Drawing.Point(619, 18);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(50, 41);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 21;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::PetCareProject.Properties.Resources.PikPng_com_cat_paw_print_png_2538733;
            this.pictureBox5.Location = new System.Drawing.Point(341, 43);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(50, 41);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 21;
            this.pictureBox5.TabStop = false;
            // 
            // lbStaff
            // 
            this.lbStaff.AutoSize = true;
            this.lbStaff.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStaff.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbStaff.Location = new System.Drawing.Point(986, 64);
            this.lbStaff.Name = "lbStaff";
            this.lbStaff.Size = new System.Drawing.Size(40, 18);
            this.lbStaff.TabIndex = 26;
            this.lbStaff.Text = "Staff";
            // 
            // tblServicesTableAdapter
            // 
            this.tblServicesTableAdapter.ClearBeforeFill = true;
            // 
            // tblProductsTableAdapter
            // 
            this.tblProductsTableAdapter.ClearBeforeFill = true;
            // 
            // PAYMENT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleVioletRed;
            this.ClientSize = new System.Drawing.Size(1238, 624);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.btAddPet);
            this.Controls.Add(this.lbStaff);
            this.Controls.Add(this.lbDateTime);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.grbx);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PAYMENT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PAYMENT";
            this.Load += new System.EventHandler(this.PAYMENT_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numProduct)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.grbx.ResumeLayout(false);
            this.grbx.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblProductsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblServicesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numService)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbDateTime;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtPetID;
        private System.Windows.Forms.TextBox txtPetName;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.NumericUpDown numProduct;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListView listUnpaid;
        private System.Windows.Forms.ColumnHeader colpetID;
        private System.Windows.Forms.ColumnHeader colpetname;
        private System.Windows.Forms.ColumnHeader colcustomername;
        private System.Windows.Forms.ColumnHeader colcontact;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btAddPet;
        private System.Windows.Forms.GroupBox grbx;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.NumericUpDown numService;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.PictureBox pictureBox4;
      
        private System.Windows.Forms.Button btX;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listDetail;
        private System.Windows.Forms.ColumnHeader colProduct;
        private System.Windows.Forms.ColumnHeader colQuantity;
        private System.Windows.Forms.ColumnHeader colPrice;
        private System.Windows.Forms.ColumnHeader colTotal;
        
        private System.Windows.Forms.ColumnHeader colService;
        private System.Windows.Forms.Label lbStaff;
        private System.Windows.Forms.ComboBox cbbProduct;
        private System.Windows.Forms.ComboBox cbbService;
        private System.Windows.Forms.Button btCancel1;
        private System.Windows.Forms.Button btCancel2;
        private DataSet dataSet;
        private System.Windows.Forms.BindingSource tblServicesBindingSource;
        private DataSetTableAdapters.tblServicesTableAdapter tblServicesTableAdapter;
        private System.Windows.Forms.BindingSource tblProductsBindingSource;
        private DataSetTableAdapters.tblProductsTableAdapter tblProductsTableAdapter;
    }
}