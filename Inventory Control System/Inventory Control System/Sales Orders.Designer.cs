namespace Inventory_Control_System
{
    partial class Sales_Orders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sales_Orders));
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtstatus = new MetroFramework.Controls.MetroTextBox();
            this.txtprice = new MetroFramework.Controls.MetroTextBox();
            this.txtdate = new MetroFramework.Controls.MetroTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.itemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdd = new MetroFramework.Controls.MetroButton();
            this.cmbitemname = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.txtqty = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mtview = new MetroFramework.Controls.MetroTile();
            this.mtcancel = new MetroFramework.Controls.MetroTile();
            this.mtadd = new MetroFramework.Controls.MetroTile();
            this.txttotqty = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(30, 383);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(43, 19);
            this.metroLabel6.TabIndex = 26;
            this.metroLabel6.Text = "Status";
            this.metroLabel6.Click += new System.EventHandler(this.metroLabel6_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(30, 351);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(69, 19);
            this.metroLabel3.TabIndex = 24;
            this.metroLabel3.Text = "Total Price";
            this.metroLabel3.Click += new System.EventHandler(this.metroLabel3_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(30, 88);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(36, 19);
            this.metroLabel2.TabIndex = 23;
            this.metroLabel2.Text = "Date";
            this.metroLabel2.Click += new System.EventHandler(this.metroLabel2_Click);
            // 
            // txtstatus
            // 
            // 
            // 
            // 
            this.txtstatus.CustomButton.Image = null;
            this.txtstatus.CustomButton.Location = new System.Drawing.Point(149, 1);
            this.txtstatus.CustomButton.Name = "";
            this.txtstatus.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtstatus.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtstatus.CustomButton.TabIndex = 1;
            this.txtstatus.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtstatus.CustomButton.UseSelectable = true;
            this.txtstatus.CustomButton.Visible = false;
            this.txtstatus.Lines = new string[0];
            this.txtstatus.Location = new System.Drawing.Point(142, 379);
            this.txtstatus.MaxLength = 32767;
            this.txtstatus.Name = "txtstatus";
            this.txtstatus.PasswordChar = '\0';
            this.txtstatus.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtstatus.SelectedText = "";
            this.txtstatus.SelectionLength = 0;
            this.txtstatus.SelectionStart = 0;
            this.txtstatus.ShortcutsEnabled = true;
            this.txtstatus.Size = new System.Drawing.Size(171, 23);
            this.txtstatus.TabIndex = 22;
            this.txtstatus.UseSelectable = true;
            this.txtstatus.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtstatus.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtstatus.Click += new System.EventHandler(this.txtstatus_Click);
            // 
            // txtprice
            // 
            // 
            // 
            // 
            this.txtprice.CustomButton.Image = null;
            this.txtprice.CustomButton.Location = new System.Drawing.Point(149, 1);
            this.txtprice.CustomButton.Name = "";
            this.txtprice.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtprice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtprice.CustomButton.TabIndex = 1;
            this.txtprice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtprice.CustomButton.UseSelectable = true;
            this.txtprice.CustomButton.Visible = false;
            this.txtprice.Lines = new string[0];
            this.txtprice.Location = new System.Drawing.Point(142, 347);
            this.txtprice.MaxLength = 32767;
            this.txtprice.Name = "txtprice";
            this.txtprice.PasswordChar = '\0';
            this.txtprice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtprice.SelectedText = "";
            this.txtprice.SelectionLength = 0;
            this.txtprice.SelectionStart = 0;
            this.txtprice.ShortcutsEnabled = true;
            this.txtprice.Size = new System.Drawing.Size(171, 23);
            this.txtprice.TabIndex = 20;
            this.txtprice.UseSelectable = true;
            this.txtprice.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtprice.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtprice.Click += new System.EventHandler(this.txtprice_Click);
            // 
            // txtdate
            // 
            // 
            // 
            // 
            this.txtdate.CustomButton.Image = null;
            this.txtdate.CustomButton.Location = new System.Drawing.Point(149, 1);
            this.txtdate.CustomButton.Name = "";
            this.txtdate.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtdate.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtdate.CustomButton.TabIndex = 1;
            this.txtdate.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtdate.CustomButton.UseSelectable = true;
            this.txtdate.CustomButton.Visible = false;
            this.txtdate.Lines = new string[0];
            this.txtdate.Location = new System.Drawing.Point(142, 84);
            this.txtdate.MaxLength = 32767;
            this.txtdate.Name = "txtdate";
            this.txtdate.PasswordChar = '\0';
            this.txtdate.ReadOnly = true;
            this.txtdate.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtdate.SelectedText = "";
            this.txtdate.SelectionLength = 0;
            this.txtdate.SelectionStart = 0;
            this.txtdate.ShortcutsEnabled = true;
            this.txtdate.Size = new System.Drawing.Size(171, 23);
            this.txtdate.TabIndex = 19;
            this.txtdate.UseSelectable = true;
            this.txtdate.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtdate.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtdate.Click += new System.EventHandler(this.txtdate_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.cmbitemname);
            this.groupBox1.Controls.Add(this.metroLabel8);
            this.groupBox1.Controls.Add(this.txtqty);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Location = new System.Drawing.Point(30, 117);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(660, 187);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ADD ITEM";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemName,
            this.itemQty,
            this.itemPrice});
            this.dataGridView1.Location = new System.Drawing.Point(313, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(339, 168);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // itemName
            // 
            this.itemName.HeaderText = "Item Name";
            this.itemName.Name = "itemName";
            // 
            // itemQty
            // 
            this.itemQty.HeaderText = "Item Quantity";
            this.itemQty.Name = "itemQty";
            // 
            // itemPrice
            // 
            this.itemPrice.HeaderText = "Total Price";
            this.itemPrice.Name = "itemPrice";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(98, 102);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseSelectable = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cmbitemname
            // 
            this.cmbitemname.FormattingEnabled = true;
            this.cmbitemname.ItemHeight = 23;
            this.cmbitemname.Items.AddRange(new object[] {
            "Select Item"});
            this.cmbitemname.Location = new System.Drawing.Point(112, 18);
            this.cmbitemname.Name = "cmbitemname";
            this.cmbitemname.Size = new System.Drawing.Size(172, 29);
            this.cmbitemname.TabIndex = 14;
            this.cmbitemname.UseSelectable = true;
            this.cmbitemname.SelectedIndexChanged += new System.EventHandler(this.cmbitemname_SelectedIndexChanged);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(6, 28);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(75, 19);
            this.metroLabel8.TabIndex = 12;
            this.metroLabel8.Text = "Item Name";
            this.metroLabel8.Click += new System.EventHandler(this.metroLabel8_Click);
            // 
            // txtqty
            // 
            // 
            // 
            // 
            this.txtqty.CustomButton.Image = null;
            this.txtqty.CustomButton.Location = new System.Drawing.Point(149, 1);
            this.txtqty.CustomButton.Name = "";
            this.txtqty.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtqty.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtqty.CustomButton.TabIndex = 1;
            this.txtqty.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtqty.CustomButton.UseSelectable = true;
            this.txtqty.CustomButton.Visible = false;
            this.txtqty.Lines = new string[0];
            this.txtqty.Location = new System.Drawing.Point(112, 57);
            this.txtqty.MaxLength = 32767;
            this.txtqty.Name = "txtqty";
            this.txtqty.PasswordChar = '\0';
            this.txtqty.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtqty.SelectedText = "";
            this.txtqty.SelectionLength = 0;
            this.txtqty.SelectionStart = 0;
            this.txtqty.ShortcutsEnabled = true;
            this.txtqty.Size = new System.Drawing.Size(171, 23);
            this.txtqty.TabIndex = 4;
            this.txtqty.UseSelectable = true;
            this.txtqty.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtqty.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtqty.Click += new System.EventHandler(this.txtqty_Click);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(6, 61);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(58, 19);
            this.metroLabel4.TabIndex = 9;
            this.metroLabel4.Text = "Quantity";
            this.metroLabel4.Click += new System.EventHandler(this.metroLabel4_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(24, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // mtview
            // 
            this.mtview.ActiveControl = null;
            this.mtview.Location = new System.Drawing.Point(155, 426);
            this.mtview.Name = "mtview";
            this.mtview.Size = new System.Drawing.Size(95, 37);
            this.mtview.TabIndex = 37;
            this.mtview.Text = "View Order";
            this.mtview.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtview.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mtview.UseSelectable = true;
            this.mtview.Click += new System.EventHandler(this.mtview_Click);
            // 
            // mtcancel
            // 
            this.mtcancel.ActiveControl = null;
            this.mtcancel.Location = new System.Drawing.Point(279, 426);
            this.mtcancel.Name = "mtcancel";
            this.mtcancel.Size = new System.Drawing.Size(67, 37);
            this.mtcancel.TabIndex = 36;
            this.mtcancel.Text = "Clear";
            this.mtcancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtcancel.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mtcancel.UseSelectable = true;
            this.mtcancel.Click += new System.EventHandler(this.mtcancel_Click_1);
            // 
            // mtadd
            // 
            this.mtadd.ActiveControl = null;
            this.mtadd.Location = new System.Drawing.Point(32, 426);
            this.mtadd.Name = "mtadd";
            this.mtadd.Size = new System.Drawing.Size(92, 37);
            this.mtadd.TabIndex = 34;
            this.mtadd.Text = "Add Order";
            this.mtadd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtadd.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mtadd.UseSelectable = true;
            this.mtadd.Click += new System.EventHandler(this.mtadd_Click_1);
            // 
            // txttotqty
            // 
            // 
            // 
            // 
            this.txttotqty.CustomButton.Image = null;
            this.txttotqty.CustomButton.Location = new System.Drawing.Point(150, 1);
            this.txttotqty.CustomButton.Name = "";
            this.txttotqty.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txttotqty.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txttotqty.CustomButton.TabIndex = 1;
            this.txttotqty.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txttotqty.CustomButton.UseSelectable = true;
            this.txttotqty.CustomButton.Visible = false;
            this.txttotqty.Lines = new string[0];
            this.txttotqty.Location = new System.Drawing.Point(142, 310);
            this.txttotqty.MaxLength = 32767;
            this.txttotqty.Name = "txttotqty";
            this.txttotqty.PasswordChar = '\0';
            this.txttotqty.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txttotqty.SelectedText = "";
            this.txttotqty.SelectionLength = 0;
            this.txttotqty.SelectionStart = 0;
            this.txttotqty.ShortcutsEnabled = true;
            this.txttotqty.Size = new System.Drawing.Size(172, 23);
            this.txttotqty.TabIndex = 38;
            this.txttotqty.UseSelectable = true;
            this.txttotqty.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txttotqty.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(30, 314);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(58, 19);
            this.metroLabel1.TabIndex = 39;
            this.metroLabel1.Text = "Quantity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 357);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "Rs.";
            // 
            // Sales_Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 486);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txttotqty);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.mtview);
            this.Controls.Add(this.mtcancel);
            this.Controls.Add(this.mtadd);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txtstatus);
            this.Controls.Add(this.txtprice);
            this.Controls.Add(this.txtdate);
            this.Controls.Add(this.groupBox1);
            this.Name = "Sales_Orders";
            this.Resizable = false;
            this.Text = "Sales Order";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.Sales_Orders_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtstatus;
        private MetroFramework.Controls.MetroTextBox txtprice;
        private MetroFramework.Controls.MetroTextBox txtdate;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroButton btnAdd;
        private MetroFramework.Controls.MetroComboBox cmbitemname;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroTextBox txtqty;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroTile mtview;
        private MetroFramework.Controls.MetroTile mtcancel;
        private MetroFramework.Controls.MetroTile mtadd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemPrice;
        private MetroFramework.Controls.MetroTextBox txttotqty;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.Label label2;
    }
}