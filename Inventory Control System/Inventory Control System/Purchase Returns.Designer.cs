namespace Inventory_Control_System
{
    partial class Purchase_Returns
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Purchase_Returns));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Item_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Item_Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sub_Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txtprice = new MetroFramework.Controls.MetroTextBox();
            this.txtdate = new MetroFramework.Controls.MetroTextBox();
            this.mtAdd = new MetroFramework.Controls.MetroTile();
            this.mtcancel = new MetroFramework.Controls.MetroTile();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.numQty = new System.Windows.Forms.NumericUpDown();
            this.btnadd = new MetroFramework.Controls.MetroButton();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.cmbporder = new MetroFramework.Controls.MetroComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbsupname = new MetroFramework.Controls.MetroComboBox();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txttotqty = new MetroFramework.Controls.MetroTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQty)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Item_No,
            this.Item_Qty,
            this.Sub_Total});
            this.dataGridView1.Location = new System.Drawing.Point(262, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(274, 161);
            this.dataGridView1.TabIndex = 0;
            // 
            // Item_No
            // 
            this.Item_No.HeaderText = "Item No";
            this.Item_No.Name = "Item_No";
            this.Item_No.ReadOnly = true;
            // 
            // Item_Qty
            // 
            this.Item_Qty.HeaderText = "Item Return Qty";
            this.Item_Qty.Name = "Item_Qty";
            this.Item_Qty.ReadOnly = true;
            // 
            // Sub_Total
            // 
            this.Sub_Total.HeaderText = "Sub Total";
            this.Sub_Total.Name = "Sub_Total";
            this.Sub_Total.ReadOnly = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(389, 114);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(123, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Purchase Order No";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(8, 66);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(58, 19);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "Quantity";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(23, 354);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(38, 19);
            this.metroLabel4.TabIndex = 5;
            this.metroLabel4.Text = "Price";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(392, 86);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(36, 19);
            this.metroLabel5.TabIndex = 6;
            this.metroLabel5.Text = "Date";
            this.metroLabel5.Click += new System.EventHandler(this.metroLabel5_Click);
            // 
            // txtprice
            // 
            // 
            // 
            // 
            this.txtprice.CustomButton.Image = null;
            this.txtprice.CustomButton.Location = new System.Drawing.Point(152, 1);
            this.txtprice.CustomButton.Name = "";
            this.txtprice.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtprice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtprice.CustomButton.TabIndex = 1;
            this.txtprice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtprice.CustomButton.UseSelectable = true;
            this.txtprice.CustomButton.Visible = false;
            this.txtprice.Lines = new string[0];
            this.txtprice.Location = new System.Drawing.Point(182, 350);
            this.txtprice.MaxLength = 32767;
            this.txtprice.Name = "txtprice";
            this.txtprice.PasswordChar = '\0';
            this.txtprice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtprice.SelectedText = "";
            this.txtprice.SelectionLength = 0;
            this.txtprice.SelectionStart = 0;
            this.txtprice.ShortcutsEnabled = true;
            this.txtprice.Size = new System.Drawing.Size(174, 23);
            this.txtprice.TabIndex = 9;
            this.txtprice.UseSelectable = true;
            this.txtprice.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtprice.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtdate
            // 
            // 
            // 
            // 
            this.txtdate.CustomButton.Image = null;
            this.txtdate.CustomButton.Location = new System.Drawing.Point(137, 1);
            this.txtdate.CustomButton.Name = "";
            this.txtdate.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtdate.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtdate.CustomButton.TabIndex = 1;
            this.txtdate.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtdate.CustomButton.UseSelectable = true;
            this.txtdate.CustomButton.Visible = false;
            this.txtdate.Lines = new string[0];
            this.txtdate.Location = new System.Drawing.Point(548, 82);
            this.txtdate.MaxLength = 32767;
            this.txtdate.Name = "txtdate";
            this.txtdate.PasswordChar = '\0';
            this.txtdate.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtdate.SelectedText = "";
            this.txtdate.SelectionLength = 0;
            this.txtdate.SelectionStart = 0;
            this.txtdate.ShortcutsEnabled = true;
            this.txtdate.Size = new System.Drawing.Size(159, 23);
            this.txtdate.TabIndex = 10;
            this.txtdate.UseSelectable = true;
            this.txtdate.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtdate.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtdate.Click += new System.EventHandler(this.txtdate_Click);
            // 
            // mtAdd
            // 
            this.mtAdd.ActiveControl = null;
            this.mtAdd.Location = new System.Drawing.Point(45, 433);
            this.mtAdd.Name = "mtAdd";
            this.mtAdd.Size = new System.Drawing.Size(75, 37);
            this.mtAdd.TabIndex = 11;
            this.mtAdd.Text = "Add";
            this.mtAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtAdd.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mtAdd.UseSelectable = true;
            this.mtAdd.Click += new System.EventHandler(this.mtAdd_Click);
            // 
            // mtcancel
            // 
            this.mtcancel.ActiveControl = null;
            this.mtcancel.Location = new System.Drawing.Point(180, 433);
            this.mtcancel.Name = "mtcancel";
            this.mtcancel.Size = new System.Drawing.Size(75, 37);
            this.mtcancel.TabIndex = 12;
            this.mtcancel.Text = "Clear";
            this.mtcancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtcancel.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mtcancel.UseSelectable = true;
            this.mtcancel.Click += new System.EventHandler(this.metroTile2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.metroTextBox1);
            this.groupBox1.Controls.Add(this.numQty);
            this.groupBox1.Controls.Add(this.btnadd);
            this.groupBox1.Controls.Add(this.metroLabel6);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(381, 161);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(542, 183);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Return Item";
            // 
            // metroTextBox1
            // 
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(145, 1);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.Lines = new string[0];
            this.metroTextBox1.Location = new System.Drawing.Point(89, 21);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.ShortcutsEnabled = true;
            this.metroTextBox1.Size = new System.Drawing.Size(167, 23);
            this.metroTextBox1.TabIndex = 40;
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // numQty
            // 
            this.numQty.Location = new System.Drawing.Point(88, 66);
            this.numQty.Name = "numQty";
            this.numQty.Size = new System.Drawing.Size(168, 20);
            this.numQty.TabIndex = 39;
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(86, 108);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 23);
            this.btnadd.TabIndex = 2;
            this.btnadd.Text = "Add";
            this.btnadd.UseSelectable = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(7, 26);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(75, 19);
            this.metroLabel6.TabIndex = 0;
            this.metroLabel6.Text = "Item Name";
            this.metroLabel6.Click += new System.EventHandler(this.metroLabel6_Click);
            // 
            // cmbporder
            // 
            this.cmbporder.FormattingEnabled = true;
            this.cmbporder.ItemHeight = 23;
            this.cmbporder.Items.AddRange(new object[] {
            "**Select**"});
            this.cmbporder.Location = new System.Drawing.Point(548, 114);
            this.cmbporder.Name = "cmbporder";
            this.cmbporder.Size = new System.Drawing.Size(159, 29);
            this.cmbporder.TabIndex = 14;
            this.cmbporder.UseSelectable = true;
            this.cmbporder.SelectedIndexChanged += new System.EventHandler(this.cmbporder_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbsupname);
            this.groupBox2.Controls.Add(this.metroButton2);
            this.groupBox2.Controls.Add(this.metroLabel8);
            this.groupBox2.Location = new System.Drawing.Point(24, 63);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(351, 92);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search Supplier";
            // 
            // cmbsupname
            // 
            this.cmbsupname.FormattingEnabled = true;
            this.cmbsupname.ItemHeight = 23;
            this.cmbsupname.Items.AddRange(new object[] {
            "**Select**"});
            this.cmbsupname.Location = new System.Drawing.Point(137, 19);
            this.cmbsupname.Name = "cmbsupname";
            this.cmbsupname.Size = new System.Drawing.Size(195, 29);
            this.cmbsupname.TabIndex = 33;
            this.cmbsupname.UseSelectable = true;
            this.cmbsupname.SelectedIndexChanged += new System.EventHandler(this.cmbsupname_SelectedIndexChanged);
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(86, 54);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(75, 23);
            this.metroButton2.TabIndex = 32;
            this.metroButton2.Text = "Search";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(7, 25);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(97, 19);
            this.metroLabel8.TabIndex = 30;
            this.metroLabel8.Text = "Supplier Name";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(24, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 390);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(89, 19);
            this.metroLabel1.TabIndex = 37;
            this.metroLabel1.Text = "Total Quantity";
            // 
            // txttotqty
            // 
            // 
            // 
            // 
            this.txttotqty.CustomButton.Image = null;
            this.txttotqty.CustomButton.Location = new System.Drawing.Point(154, 1);
            this.txttotqty.CustomButton.Name = "";
            this.txttotqty.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txttotqty.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txttotqty.CustomButton.TabIndex = 1;
            this.txttotqty.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txttotqty.CustomButton.UseSelectable = true;
            this.txttotqty.CustomButton.Visible = false;
            this.txttotqty.Lines = new string[0];
            this.txttotqty.Location = new System.Drawing.Point(180, 390);
            this.txttotqty.MaxLength = 32767;
            this.txttotqty.Name = "txttotqty";
            this.txttotqty.PasswordChar = '\0';
            this.txttotqty.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txttotqty.SelectedText = "";
            this.txttotqty.SelectionLength = 0;
            this.txttotqty.SelectionStart = 0;
            this.txttotqty.ShortcutsEnabled = true;
            this.txttotqty.Size = new System.Drawing.Size(176, 23);
            this.txttotqty.TabIndex = 38;
            this.txttotqty.UseSelectable = true;
            this.txttotqty.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txttotqty.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView2);
            this.groupBox3.Location = new System.Drawing.Point(23, 161);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(352, 183);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(8, 16);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(338, 161);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(153, 354);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "Rs.";
            // 
            // Purchase_Returns
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 493);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txttotqty);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.cmbporder);
            this.Controls.Add(this.mtcancel);
            this.Controls.Add(this.mtAdd);
            this.Controls.Add(this.txtdate);
            this.Controls.Add(this.txtprice);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Purchase_Returns";
            this.Text = "Purchase Returns";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.Purchase_Returns_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQty)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox txtprice;
        private MetroFramework.Controls.MetroTextBox txtdate;
        private MetroFramework.Controls.MetroTile mtAdd;
        private MetroFramework.Controls.MetroTile mtcancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroButton btnadd;
        private MetroFramework.Controls.MetroComboBox cmbporder;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroComboBox cmbsupname;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txttotqty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item_No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item_Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sub_Total;
        private System.Windows.Forms.NumericUpDown numQty;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private System.Windows.Forms.Label label2;
    }
}