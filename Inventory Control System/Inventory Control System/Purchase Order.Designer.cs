namespace Inventory_Control_System
{
    partial class Purchase_Order
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Purchase_Order));
            this.mtadd = new MetroFramework.Controls.MetroTile();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtstatus = new MetroFramework.Controls.MetroTextBox();
            this.txtprice = new MetroFramework.Controls.MetroTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Item_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Item_Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sub_Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdd = new MetroFramework.Controls.MetroButton();
            this.cmbitemname = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.txtqty = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.mtclear = new MetroFramework.Controls.MetroTile();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.cmbsupname = new MetroFramework.Controls.MetroComboBox();
            this.mtview = new MetroFramework.Controls.MetroTile();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtdate = new MetroFramework.Controls.MetroTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mtadd
            // 
            this.mtadd.ActiveControl = null;
            this.mtadd.Location = new System.Drawing.Point(55, 418);
            this.mtadd.Name = "mtadd";
            this.mtadd.Size = new System.Drawing.Size(94, 44);
            this.mtadd.TabIndex = 40;
            this.mtadd.Text = "Add Order";
            this.mtadd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtadd.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mtadd.UseSelectable = true;
            this.mtadd.Click += new System.EventHandler(this.mtadd_Click);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(60, 379);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(43, 19);
            this.metroLabel6.TabIndex = 39;
            this.metroLabel6.Text = "Status";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(60, 347);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(69, 19);
            this.metroLabel3.TabIndex = 38;
            this.metroLabel3.Text = "Total Price";
            // 
            // txtstatus
            // 
            // 
            // 
            // 
            this.txtstatus.CustomButton.Image = null;
            this.txtstatus.CustomButton.Location = new System.Drawing.Point(123, 1);
            this.txtstatus.CustomButton.Name = "";
            this.txtstatus.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtstatus.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtstatus.CustomButton.TabIndex = 1;
            this.txtstatus.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtstatus.CustomButton.UseSelectable = true;
            this.txtstatus.CustomButton.Visible = false;
            this.txtstatus.Lines = new string[0];
            this.txtstatus.Location = new System.Drawing.Point(207, 375);
            this.txtstatus.MaxLength = 32767;
            this.txtstatus.Name = "txtstatus";
            this.txtstatus.PasswordChar = '\0';
            this.txtstatus.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtstatus.SelectedText = "";
            this.txtstatus.SelectionLength = 0;
            this.txtstatus.SelectionStart = 0;
            this.txtstatus.ShortcutsEnabled = true;
            this.txtstatus.Size = new System.Drawing.Size(145, 23);
            this.txtstatus.TabIndex = 36;
            this.txtstatus.UseSelectable = true;
            this.txtstatus.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtstatus.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtprice
            // 
            // 
            // 
            // 
            this.txtprice.CustomButton.Image = null;
            this.txtprice.CustomButton.Location = new System.Drawing.Point(123, 1);
            this.txtprice.CustomButton.Name = "";
            this.txtprice.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtprice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtprice.CustomButton.TabIndex = 1;
            this.txtprice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtprice.CustomButton.UseSelectable = true;
            this.txtprice.CustomButton.Visible = false;
            this.txtprice.Lines = new string[0];
            this.txtprice.Location = new System.Drawing.Point(207, 343);
            this.txtprice.MaxLength = 32767;
            this.txtprice.Name = "txtprice";
            this.txtprice.PasswordChar = '\0';
            this.txtprice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtprice.SelectedText = "";
            this.txtprice.SelectionLength = 0;
            this.txtprice.SelectionStart = 0;
            this.txtprice.ShortcutsEnabled = true;
            this.txtprice.Size = new System.Drawing.Size(145, 23);
            this.txtprice.TabIndex = 35;
            this.txtprice.UseSelectable = true;
            this.txtprice.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtprice.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.cmbitemname);
            this.groupBox1.Controls.Add(this.metroLabel8);
            this.groupBox1.Controls.Add(this.txtqty);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Location = new System.Drawing.Point(52, 131);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(649, 200);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ADD ITEM";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Item_Name,
            this.Item_Qty,
            this.Sub_Total});
            this.dataGridView1.Location = new System.Drawing.Point(327, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(316, 171);
            this.dataGridView1.TabIndex = 18;
            // 
            // Item_Name
            // 
            this.Item_Name.HeaderText = "Item Name";
            this.Item_Name.Name = "Item_Name";
            // 
            // Item_Qty
            // 
            this.Item_Qty.HeaderText = "Item Qty";
            this.Item_Qty.Name = "Item_Qty";
            // 
            // Sub_Total
            // 
            this.Sub_Total.HeaderText = "Sub Total";
            this.Sub_Total.Name = "Sub_Total";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(105, 119);
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
            "**Select**"});
            this.cmbitemname.Location = new System.Drawing.Point(156, 32);
            this.cmbitemname.Name = "cmbitemname";
            this.cmbitemname.Size = new System.Drawing.Size(145, 29);
            this.cmbitemname.TabIndex = 14;
            this.cmbitemname.UseSelectable = true;
            this.cmbitemname.SelectedIndexChanged += new System.EventHandler(this.cmbitemname_SelectedIndexChanged);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(15, 42);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(75, 19);
            this.metroLabel8.TabIndex = 12;
            this.metroLabel8.Text = "Item Name";
            // 
            // txtqty
            // 
            // 
            // 
            // 
            this.txtqty.CustomButton.Image = null;
            this.txtqty.CustomButton.Location = new System.Drawing.Point(123, 1);
            this.txtqty.CustomButton.Name = "";
            this.txtqty.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtqty.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtqty.CustomButton.TabIndex = 1;
            this.txtqty.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtqty.CustomButton.UseSelectable = true;
            this.txtqty.CustomButton.Visible = false;
            this.txtqty.Lines = new string[0];
            this.txtqty.Location = new System.Drawing.Point(156, 78);
            this.txtqty.MaxLength = 32767;
            this.txtqty.Name = "txtqty";
            this.txtqty.PasswordChar = '\0';
            this.txtqty.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtqty.SelectedText = "";
            this.txtqty.SelectionLength = 0;
            this.txtqty.SelectionStart = 0;
            this.txtqty.ShortcutsEnabled = true;
            this.txtqty.Size = new System.Drawing.Size(145, 23);
            this.txtqty.TabIndex = 4;
            this.txtqty.UseSelectable = true;
            this.txtqty.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtqty.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(15, 82);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(58, 19);
            this.metroLabel4.TabIndex = 9;
            this.metroLabel4.Text = "Quantity";
            // 
            // mtclear
            // 
            this.mtclear.ActiveControl = null;
            this.mtclear.Location = new System.Drawing.Point(264, 418);
            this.mtclear.Name = "mtclear";
            this.mtclear.Size = new System.Drawing.Size(62, 44);
            this.mtclear.TabIndex = 41;
            this.mtclear.Text = "Clear";
            this.mtclear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtclear.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mtclear.UseSelectable = true;
            this.mtclear.Click += new System.EventHandler(this.mtclear_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(52, 73);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(36, 19);
            this.metroLabel2.TabIndex = 37;
            this.metroLabel2.Text = "Date";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(52, 99);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(97, 19);
            this.metroLabel7.TabIndex = 44;
            this.metroLabel7.Text = "Supplier Name";
            // 
            // cmbsupname
            // 
            this.cmbsupname.FormattingEnabled = true;
            this.cmbsupname.ItemHeight = 23;
            this.cmbsupname.Items.AddRange(new object[] {
            "**Select**"});
            this.cmbsupname.Location = new System.Drawing.Point(207, 96);
            this.cmbsupname.Name = "cmbsupname";
            this.cmbsupname.Size = new System.Drawing.Size(145, 29);
            this.cmbsupname.TabIndex = 45;
            this.cmbsupname.UseSelectable = true;
            this.cmbsupname.SelectedIndexChanged += new System.EventHandler(this.cmbsupname_SelectedIndexChanged);
            // 
            // mtview
            // 
            this.mtview.ActiveControl = null;
            this.mtview.Location = new System.Drawing.Point(160, 418);
            this.mtview.Name = "mtview";
            this.mtview.Size = new System.Drawing.Size(95, 44);
            this.mtview.TabIndex = 46;
            this.mtview.Text = "View Order";
            this.mtview.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtview.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mtview.UseSelectable = true;
            this.mtview.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(24, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 47;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txtdate
            // 
            // 
            // 
            // 
            this.txtdate.CustomButton.Image = null;
            this.txtdate.CustomButton.Location = new System.Drawing.Point(123, 1);
            this.txtdate.CustomButton.Name = "";
            this.txtdate.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtdate.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtdate.CustomButton.TabIndex = 1;
            this.txtdate.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtdate.CustomButton.UseSelectable = true;
            this.txtdate.CustomButton.Visible = false;
            this.txtdate.Lines = new string[0];
            this.txtdate.Location = new System.Drawing.Point(207, 69);
            this.txtdate.MaxLength = 32767;
            this.txtdate.Name = "txtdate";
            this.txtdate.PasswordChar = '\0';
            this.txtdate.ReadOnly = true;
            this.txtdate.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtdate.SelectedText = "";
            this.txtdate.SelectionLength = 0;
            this.txtdate.SelectionStart = 0;
            this.txtdate.ShortcutsEnabled = true;
            this.txtdate.Size = new System.Drawing.Size(145, 23);
            this.txtdate.TabIndex = 34;
            this.txtdate.UseSelectable = true;
            this.txtdate.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtdate.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtdate.Click += new System.EventHandler(this.txtdate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(178, 347);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 48;
            this.label2.Text = "Rs.";
            // 
            // Purchase_Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 485);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.mtview);
            this.Controls.Add(this.cmbsupname);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.mtadd);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.txtstatus);
            this.Controls.Add(this.txtprice);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.mtclear);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txtdate);
            this.Name = "Purchase_Order";
            this.Text = "Purchase Order";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.Purchase_Order_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroTile mtadd;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtstatus;
        private MetroFramework.Controls.MetroTextBox txtprice;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroButton btnAdd;
        private MetroFramework.Controls.MetroComboBox cmbitemname;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroTextBox txtqty;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTile mtclear;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroComboBox cmbsupname;
        private MetroFramework.Controls.MetroTile mtview;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item_Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sub_Total;
        private MetroFramework.Controls.MetroTextBox txtdate;
        private System.Windows.Forms.Label label2;
    }
}