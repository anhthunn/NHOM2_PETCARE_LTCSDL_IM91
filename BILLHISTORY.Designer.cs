
namespace PetCareProject
{
    partial class BILLHISTORY
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BILLHISTORY));
            this.label1 = new System.Windows.Forms.Label();
            this.listHistory = new System.Windows.Forms.ListView();
            this.colbillID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colpetID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colpetname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colcustomername = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colproduct = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colService = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.coltotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colStaff = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btClose = new System.Windows.Forms.Button();
            this.colDatetime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.LavenderBlush;
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB Demi", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(324, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(525, 91);
            this.label1.TabIndex = 18;
            this.label1.Text = "BILL HISTORY";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // listHistory
            // 
            this.listHistory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listHistory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colbillID,
            this.colpetID,
            this.colpetname,
            this.colcustomername,
            this.colproduct,
            this.colService,
            this.coltotal,
            this.colStaff,
            this.colDatetime});
            this.listHistory.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listHistory.FullRowSelect = true;
            this.listHistory.GridLines = true;
            this.listHistory.HideSelection = false;
            this.listHistory.HoverSelection = true;
            this.listHistory.Location = new System.Drawing.Point(41, 241);
            this.listHistory.Name = "listHistory";
            this.listHistory.Size = new System.Drawing.Size(1037, 316);
            this.listHistory.TabIndex = 17;
            this.listHistory.UseCompatibleStateImageBehavior = false;
            this.listHistory.View = System.Windows.Forms.View.Details;
            // 
            // colbillID
            // 
            this.colbillID.Text = "Bill ID";
            this.colbillID.Width = 48;
            // 
            // colpetID
            // 
            this.colpetID.Text = "Pet ID";
            this.colpetID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colpetID.Width = 64;
            // 
            // colpetname
            // 
            this.colpetname.Text = "Pet Name";
            this.colpetname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colpetname.Width = 72;
            // 
            // colcustomername
            // 
            this.colcustomername.Text = "Customer Name";
            this.colcustomername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colcustomername.Width = 115;
            // 
            // colproduct
            // 
            this.colproduct.Text = "Product";
            this.colproduct.Width = 195;
            // 
            // colService
            // 
            this.colService.Text = "Service";
            this.colService.Width = 178;
            // 
            // coltotal
            // 
            this.coltotal.Text = "Total";
            this.coltotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.coltotal.Width = 81;
            // 
            // colStaff
            // 
            this.colStaff.Text = "Staff";
            this.colStaff.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colStaff.Width = 142;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LavenderBlush;
            this.pictureBox1.Image = global::PetCareProject.Properties.Resources.PikPng_com_history_icon_png_5899802;
            this.pictureBox1.Location = new System.Drawing.Point(754, 94);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(79, 81);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // btClose
            // 
            this.btClose.BackgroundImage = global::PetCareProject.Properties.Resources.PikPng_com_clear_button_png_3492816;
            this.btClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btClose.Location = new System.Drawing.Point(12, 21);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(33, 32);
            this.btClose.TabIndex = 26;
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // colDatetime
            // 
            this.colDatetime.Text = "Date Time";
            this.colDatetime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colDatetime.Width = 139;
            // 
            // BILLHISTORY
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PetCareProject.Properties.Resources.paw;
            this.ClientSize = new System.Drawing.Size(1117, 612);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listHistory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BILLHISTORY";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BILLHISTORY";
            this.Load += new System.EventHandler(this.BILLHISTORY_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listHistory;
        private System.Windows.Forms.ColumnHeader colbillID;
        private System.Windows.Forms.ColumnHeader colpetID;
        private System.Windows.Forms.ColumnHeader colpetname;
        private System.Windows.Forms.ColumnHeader colcustomername;
        private System.Windows.Forms.ColumnHeader colproduct;
        private System.Windows.Forms.ColumnHeader coltotal;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.ColumnHeader colService;
        private System.Windows.Forms.ColumnHeader colStaff;
        private System.Windows.Forms.ColumnHeader colDatetime;
    }
}