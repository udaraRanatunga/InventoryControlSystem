namespace Inventory_Control_System
{
    partial class Suppliers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Suppliers));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtname = new MetroFramework.Controls.MetroTextBox();
            this.txtadd = new MetroFramework.Controls.MetroTextBox();
            this.lblname = new MetroFramework.Controls.MetroLabel();
            this.lblsupadd = new MetroFramework.Controls.MetroLabel();
            this.lbltele = new MetroFramework.Controls.MetroLabel();
            this.lblstatus = new MetroFramework.Controls.MetroLabel();
            this.mtClear = new MetroFramework.Controls.MetroTile();
            this.mtUpdate = new MetroFramework.Controls.MetroTile();
            this.mtAdd = new MetroFramework.Controls.MetroTile();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtstatus = new MetroFramework.Controls.MetroTextBox();
            this.txttele = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(365, 82);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(433, 229);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txtname
            // 
            // 
            // 
            // 
            this.txtname.CustomButton.Image = null;
            this.txtname.CustomButton.Location = new System.Drawing.Point(158, 1);
            this.txtname.CustomButton.Name = "";
            this.txtname.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtname.CustomButton.TabIndex = 1;
            this.txtname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtname.CustomButton.UseSelectable = true;
            this.txtname.CustomButton.Visible = false;
            this.txtname.Lines = new string[0];
            this.txtname.Location = new System.Drawing.Point(146, 80);
            this.txtname.MaxLength = 32767;
            this.txtname.Name = "txtname";
            this.txtname.PasswordChar = '\0';
            this.txtname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtname.SelectedText = "";
            this.txtname.SelectionLength = 0;
            this.txtname.SelectionStart = 0;
            this.txtname.ShortcutsEnabled = true;
            this.txtname.Size = new System.Drawing.Size(180, 23);
            this.txtname.TabIndex = 1;
            this.txtname.UseSelectable = true;
            this.txtname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtname.Click += new System.EventHandler(this.txtname_Click);
            // 
            // txtadd
            // 
            // 
            // 
            // 
            this.txtadd.CustomButton.Image = null;
            this.txtadd.CustomButton.Location = new System.Drawing.Point(134, 1);
            this.txtadd.CustomButton.Name = "";
            this.txtadd.CustomButton.Size = new System.Drawing.Size(45, 45);
            this.txtadd.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtadd.CustomButton.TabIndex = 1;
            this.txtadd.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtadd.CustomButton.UseSelectable = true;
            this.txtadd.CustomButton.Visible = false;
            this.txtadd.Lines = new string[0];
            this.txtadd.Location = new System.Drawing.Point(146, 145);
            this.txtadd.MaxLength = 32767;
            this.txtadd.Multiline = true;
            this.txtadd.Name = "txtadd";
            this.txtadd.PasswordChar = '\0';
            this.txtadd.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtadd.SelectedText = "";
            this.txtadd.SelectionLength = 0;
            this.txtadd.SelectionStart = 0;
            this.txtadd.ShortcutsEnabled = true;
            this.txtadd.Size = new System.Drawing.Size(180, 47);
            this.txtadd.TabIndex = 3;
            this.txtadd.UseSelectable = true;
            this.txtadd.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtadd.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(23, 84);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(45, 19);
            this.lblname.TabIndex = 6;
            this.lblname.Text = "Name";
            // 
            // lblsupadd
            // 
            this.lblsupadd.AutoSize = true;
            this.lblsupadd.Location = new System.Drawing.Point(23, 149);
            this.lblsupadd.Name = "lblsupadd";
            this.lblsupadd.Size = new System.Drawing.Size(56, 19);
            this.lblsupadd.TabIndex = 8;
            this.lblsupadd.Text = "Address";
            // 
            // lbltele
            // 
            this.lbltele.AutoSize = true;
            this.lbltele.Location = new System.Drawing.Point(23, 214);
            this.lbltele.Name = "lbltele";
            this.lbltele.Size = new System.Drawing.Size(79, 19);
            this.lbltele.TabIndex = 9;
            this.lbltele.Text = "Contact No.";
            // 
            // lblstatus
            // 
            this.lblstatus.AutoSize = true;
            this.lblstatus.Location = new System.Drawing.Point(23, 270);
            this.lblstatus.Name = "lblstatus";
            this.lblstatus.Size = new System.Drawing.Size(43, 19);
            this.lblstatus.TabIndex = 10;
            this.lblstatus.Text = "Status";
            // 
            // mtClear
            // 
            this.mtClear.ActiveControl = null;
            this.mtClear.Location = new System.Drawing.Point(299, 342);
            this.mtClear.Name = "mtClear";
            this.mtClear.Size = new System.Drawing.Size(64, 45);
            this.mtClear.TabIndex = 18;
            this.mtClear.Text = "Clear";
            this.mtClear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtClear.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mtClear.UseSelectable = true;
            this.mtClear.Click += new System.EventHandler(this.mtCancel_Click);
            // 
            // mtUpdate
            // 
            this.mtUpdate.ActiveControl = null;
            this.mtUpdate.Location = new System.Drawing.Point(157, 343);
            this.mtUpdate.Name = "mtUpdate";
            this.mtUpdate.Size = new System.Drawing.Size(129, 45);
            this.mtUpdate.TabIndex = 16;
            this.mtUpdate.Text = "Update Supplier";
            this.mtUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtUpdate.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mtUpdate.UseSelectable = true;
            this.mtUpdate.Click += new System.EventHandler(this.mtUpdate_Click);
            // 
            // mtAdd
            // 
            this.mtAdd.ActiveControl = null;
            this.mtAdd.Location = new System.Drawing.Point(30, 342);
            this.mtAdd.Name = "mtAdd";
            this.mtAdd.Size = new System.Drawing.Size(109, 46);
            this.mtAdd.TabIndex = 15;
            this.mtAdd.Text = "Add Supplier";
            this.mtAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtAdd.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mtAdd.UseSelectable = true;
            this.mtAdd.Click += new System.EventHandler(this.mtAdd_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(24, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txtstatus
            // 
            // 
            // 
            // 
            this.txtstatus.CustomButton.Image = null;
            this.txtstatus.CustomButton.Location = new System.Drawing.Point(157, 1);
            this.txtstatus.CustomButton.Name = "";
            this.txtstatus.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtstatus.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtstatus.CustomButton.TabIndex = 1;
            this.txtstatus.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtstatus.CustomButton.UseSelectable = true;
            this.txtstatus.CustomButton.Visible = false;
            this.txtstatus.Lines = new string[0];
            this.txtstatus.Location = new System.Drawing.Point(147, 270);
            this.txtstatus.MaxLength = 32767;
            this.txtstatus.Name = "txtstatus";
            this.txtstatus.PasswordChar = '\0';
            this.txtstatus.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtstatus.SelectedText = "";
            this.txtstatus.SelectionLength = 0;
            this.txtstatus.SelectionStart = 0;
            this.txtstatus.ShortcutsEnabled = true;
            this.txtstatus.Size = new System.Drawing.Size(179, 23);
            this.txtstatus.TabIndex = 20;
            this.txtstatus.UseSelectable = true;
            this.txtstatus.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtstatus.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txttele
            // 
            this.txttele.Location = new System.Drawing.Point(146, 214);
            this.txttele.Mask = "9990000000";
            this.txttele.Name = "txttele";
            this.txttele.Size = new System.Drawing.Size(180, 20);
            this.txttele.TabIndex = 21;
            // 
            // Suppliers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 416);
            this.ControlBox = false;
            this.Controls.Add(this.txttele);
            this.Controls.Add(this.txtstatus);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.mtClear);
            this.Controls.Add(this.mtUpdate);
            this.Controls.Add(this.mtAdd);
            this.Controls.Add(this.lblstatus);
            this.Controls.Add(this.lbltele);
            this.Controls.Add(this.lblsupadd);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.txtadd);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.Name = "Suppliers";
            this.Text = "Suppliers";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.Suppliers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private MetroFramework.Controls.MetroTextBox txtname;
        private MetroFramework.Controls.MetroTextBox txtadd;
        private MetroFramework.Controls.MetroLabel lblname;
        private MetroFramework.Controls.MetroLabel lblsupadd;
        private MetroFramework.Controls.MetroLabel lbltele;
        private MetroFramework.Controls.MetroLabel lblstatus;
        private MetroFramework.Controls.MetroTile mtClear;
        private MetroFramework.Controls.MetroTile mtUpdate;
        private MetroFramework.Controls.MetroTile mtAdd;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroTextBox txtstatus;
        private System.Windows.Forms.MaskedTextBox txttele;
    }
}