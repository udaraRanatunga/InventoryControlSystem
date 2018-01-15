namespace Inventory_Control_System
{
    partial class Items
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Items));
            this.mtCancel = new MetroFramework.Controls.MetroTile();
            this.mtUpdate = new MetroFramework.Controls.MetroTile();
            this.mtAdd = new MetroFramework.Controls.MetroTile();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbldes = new MetroFramework.Controls.MetroLabel();
            this.lblprice = new MetroFramework.Controls.MetroLabel();
            this.lblqty = new MetroFramework.Controls.MetroLabel();
            this.lblname = new MetroFramework.Controls.MetroLabel();
            this.txtdes = new MetroFramework.Controls.MetroTextBox();
            this.txtprice = new MetroFramework.Controls.MetroTextBox();
            this.txtqty = new MetroFramework.Controls.MetroTextBox();
            this.txtname = new MetroFramework.Controls.MetroTextBox();
            this.lblstatus = new MetroFramework.Controls.MetroLabel();
            this.txtstatus = new MetroFramework.Controls.MetroTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mtCancel
            // 
            this.mtCancel.ActiveControl = null;
            this.mtCancel.Location = new System.Drawing.Point(263, 356);
            this.mtCancel.Name = "mtCancel";
            this.mtCancel.Size = new System.Drawing.Size(61, 39);
            this.mtCancel.TabIndex = 23;
            this.mtCancel.Text = "Clear";
            this.mtCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtCancel.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mtCancel.UseSelectable = true;
            this.mtCancel.Click += new System.EventHandler(this.mtCancel_Click);
            // 
            // mtUpdate
            // 
            this.mtUpdate.ActiveControl = null;
            this.mtUpdate.Location = new System.Drawing.Point(136, 356);
            this.mtUpdate.Name = "mtUpdate";
            this.mtUpdate.Size = new System.Drawing.Size(108, 39);
            this.mtUpdate.TabIndex = 21;
            this.mtUpdate.Text = "Update Item";
            this.mtUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtUpdate.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mtUpdate.UseSelectable = true;
            this.mtUpdate.Click += new System.EventHandler(this.mtUpdate_Click);
            // 
            // mtAdd
            // 
            this.mtAdd.ActiveControl = null;
            this.mtAdd.Location = new System.Drawing.Point(24, 355);
            this.mtAdd.Name = "mtAdd";
            this.mtAdd.Size = new System.Drawing.Size(92, 40);
            this.mtAdd.TabIndex = 20;
            this.mtAdd.Text = "Add Item";
            this.mtAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtAdd.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mtAdd.UseSelectable = true;
            this.mtAdd.Click += new System.EventHandler(this.mtAdd_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(334, 75);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(455, 261);
            this.dataGridView1.TabIndex = 19;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lbldes
            // 
            this.lbldes.AutoSize = true;
            this.lbldes.Location = new System.Drawing.Point(23, 195);
            this.lbldes.Name = "lbldes";
            this.lbldes.Size = new System.Drawing.Size(74, 19);
            this.lbldes.TabIndex = 33;
            this.lbldes.Text = "Description";
            // 
            // lblprice
            // 
            this.lblprice.AutoSize = true;
            this.lblprice.Location = new System.Drawing.Point(23, 154);
            this.lblprice.Name = "lblprice";
            this.lblprice.Size = new System.Drawing.Size(38, 19);
            this.lblprice.TabIndex = 32;
            this.lblprice.Text = "Price";
            // 
            // lblqty
            // 
            this.lblqty.AutoSize = true;
            this.lblqty.Location = new System.Drawing.Point(23, 113);
            this.lblqty.Name = "lblqty";
            this.lblqty.Size = new System.Drawing.Size(58, 19);
            this.lblqty.TabIndex = 31;
            this.lblqty.Text = "Quantity";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(23, 79);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(45, 19);
            this.lblname.TabIndex = 29;
            this.lblname.Text = "Name";
            // 
            // txtdes
            // 
            // 
            // 
            // 
            this.txtdes.CustomButton.Image = null;
            this.txtdes.CustomButton.Location = new System.Drawing.Point(115, 1);
            this.txtdes.CustomButton.Name = "";
            this.txtdes.CustomButton.Size = new System.Drawing.Size(47, 47);
            this.txtdes.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtdes.CustomButton.TabIndex = 1;
            this.txtdes.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtdes.CustomButton.UseSelectable = true;
            this.txtdes.CustomButton.Visible = false;
            this.txtdes.Lines = new string[0];
            this.txtdes.Location = new System.Drawing.Point(146, 191);
            this.txtdes.MaxLength = 32767;
            this.txtdes.Multiline = true;
            this.txtdes.Name = "txtdes";
            this.txtdes.PasswordChar = '\0';
            this.txtdes.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtdes.SelectedText = "";
            this.txtdes.SelectionLength = 0;
            this.txtdes.SelectionStart = 0;
            this.txtdes.ShortcutsEnabled = true;
            this.txtdes.Size = new System.Drawing.Size(163, 49);
            this.txtdes.TabIndex = 28;
            this.txtdes.UseSelectable = true;
            this.txtdes.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtdes.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtprice
            // 
            // 
            // 
            // 
            this.txtprice.CustomButton.Image = null;
            this.txtprice.CustomButton.Location = new System.Drawing.Point(141, 1);
            this.txtprice.CustomButton.Name = "";
            this.txtprice.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtprice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtprice.CustomButton.TabIndex = 1;
            this.txtprice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtprice.CustomButton.UseSelectable = true;
            this.txtprice.CustomButton.Visible = false;
            this.txtprice.Lines = new string[0];
            this.txtprice.Location = new System.Drawing.Point(146, 150);
            this.txtprice.MaxLength = 32767;
            this.txtprice.Name = "txtprice";
            this.txtprice.PasswordChar = '\0';
            this.txtprice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtprice.SelectedText = "";
            this.txtprice.SelectionLength = 0;
            this.txtprice.SelectionStart = 0;
            this.txtprice.ShortcutsEnabled = true;
            this.txtprice.Size = new System.Drawing.Size(163, 23);
            this.txtprice.TabIndex = 27;
            this.txtprice.UseSelectable = true;
            this.txtprice.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtprice.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtqty
            // 
            // 
            // 
            // 
            this.txtqty.CustomButton.Image = null;
            this.txtqty.CustomButton.Location = new System.Drawing.Point(141, 1);
            this.txtqty.CustomButton.Name = "";
            this.txtqty.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtqty.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtqty.CustomButton.TabIndex = 1;
            this.txtqty.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtqty.CustomButton.UseSelectable = true;
            this.txtqty.CustomButton.Visible = false;
            this.txtqty.Lines = new string[0];
            this.txtqty.Location = new System.Drawing.Point(146, 109);
            this.txtqty.MaxLength = 32767;
            this.txtqty.Name = "txtqty";
            this.txtqty.PasswordChar = '\0';
            this.txtqty.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtqty.SelectedText = "";
            this.txtqty.SelectionLength = 0;
            this.txtqty.SelectionStart = 0;
            this.txtqty.ShortcutsEnabled = true;
            this.txtqty.Size = new System.Drawing.Size(163, 23);
            this.txtqty.TabIndex = 26;
            this.txtqty.UseSelectable = true;
            this.txtqty.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtqty.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtname
            // 
            // 
            // 
            // 
            this.txtname.CustomButton.Image = null;
            this.txtname.CustomButton.Location = new System.Drawing.Point(141, 1);
            this.txtname.CustomButton.Name = "";
            this.txtname.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtname.CustomButton.TabIndex = 1;
            this.txtname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtname.CustomButton.UseSelectable = true;
            this.txtname.CustomButton.Visible = false;
            this.txtname.Lines = new string[0];
            this.txtname.Location = new System.Drawing.Point(146, 75);
            this.txtname.MaxLength = 32767;
            this.txtname.Name = "txtname";
            this.txtname.PasswordChar = '\0';
            this.txtname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtname.SelectedText = "";
            this.txtname.SelectionLength = 0;
            this.txtname.SelectionStart = 0;
            this.txtname.ShortcutsEnabled = true;
            this.txtname.Size = new System.Drawing.Size(163, 23);
            this.txtname.TabIndex = 24;
            this.txtname.UseSelectable = true;
            this.txtname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblstatus
            // 
            this.lblstatus.AutoSize = true;
            this.lblstatus.Location = new System.Drawing.Point(24, 259);
            this.lblstatus.Name = "lblstatus";
            this.lblstatus.Size = new System.Drawing.Size(43, 19);
            this.lblstatus.TabIndex = 34;
            this.lblstatus.Text = "Status";
            // 
            // txtstatus
            // 
            // 
            // 
            // 
            this.txtstatus.CustomButton.Image = null;
            this.txtstatus.CustomButton.Location = new System.Drawing.Point(141, 1);
            this.txtstatus.CustomButton.Name = "";
            this.txtstatus.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtstatus.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtstatus.CustomButton.TabIndex = 1;
            this.txtstatus.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtstatus.CustomButton.UseSelectable = true;
            this.txtstatus.CustomButton.Visible = false;
            this.txtstatus.Lines = new string[0];
            this.txtstatus.Location = new System.Drawing.Point(146, 259);
            this.txtstatus.MaxLength = 32767;
            this.txtstatus.Name = "txtstatus";
            this.txtstatus.PasswordChar = '\0';
            this.txtstatus.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtstatus.SelectedText = "";
            this.txtstatus.SelectionLength = 0;
            this.txtstatus.SelectionStart = 0;
            this.txtstatus.ShortcutsEnabled = true;
            this.txtstatus.Size = new System.Drawing.Size(163, 23);
            this.txtstatus.TabIndex = 35;
            this.txtstatus.UseSelectable = true;
            this.txtstatus.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtstatus.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(24, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 54;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(24, 297);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(97, 19);
            this.metroLabel1.TabIndex = 55;
            this.metroLabel1.Text = "Supplier Name";
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Select Supplier"});
            this.comboBox1.Location = new System.Drawing.Point(146, 297);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(163, 21);
            this.comboBox1.TabIndex = 57;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Items
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 418);
            this.ControlBox = false;
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtstatus);
            this.Controls.Add(this.lblstatus);
            this.Controls.Add(this.lbldes);
            this.Controls.Add(this.lblprice);
            this.Controls.Add(this.lblqty);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.txtdes);
            this.Controls.Add(this.txtprice);
            this.Controls.Add(this.txtqty);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.mtCancel);
            this.Controls.Add(this.mtUpdate);
            this.Controls.Add(this.mtAdd);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.Name = "Items";
            this.Text = "Items";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.Items_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTile mtCancel;
        private MetroFramework.Controls.MetroTile mtUpdate;
        private MetroFramework.Controls.MetroTile mtAdd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MetroFramework.Controls.MetroLabel lbldes;
        private MetroFramework.Controls.MetroLabel lblprice;
        private MetroFramework.Controls.MetroLabel lblqty;
        private MetroFramework.Controls.MetroLabel lblname;
        private MetroFramework.Controls.MetroTextBox txtdes;
        private MetroFramework.Controls.MetroTextBox txtprice;
        private MetroFramework.Controls.MetroTextBox txtqty;
        private MetroFramework.Controls.MetroTextBox txtname;
        private MetroFramework.Controls.MetroLabel lblstatus;
        private MetroFramework.Controls.MetroTextBox txtstatus;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.ComboBox comboBox1;
      //  private DataBase.InventoryDataSet inventoryDataSet1;
    }
}