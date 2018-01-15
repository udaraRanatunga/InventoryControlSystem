namespace Inventory_Control_System
{
    partial class Delivery
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Delivery));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtstatus = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.mtadd = new MetroFramework.Controls.MetroTile();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.cmbsalesorder = new MetroFramework.Controls.MetroComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.txtdate = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(311, 89);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(354, 188);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txtstatus
            // 
            // 
            // 
            // 
            this.txtstatus.CustomButton.Image = null;
            this.txtstatus.CustomButton.Location = new System.Drawing.Point(91, 1);
            this.txtstatus.CustomButton.Name = "";
            this.txtstatus.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtstatus.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtstatus.CustomButton.TabIndex = 1;
            this.txtstatus.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtstatus.CustomButton.UseSelectable = true;
            this.txtstatus.CustomButton.Visible = false;
            this.txtstatus.Lines = new string[0];
            this.txtstatus.Location = new System.Drawing.Point(158, 136);
            this.txtstatus.MaxLength = 32767;
            this.txtstatus.Name = "txtstatus";
            this.txtstatus.PasswordChar = '\0';
            this.txtstatus.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtstatus.SelectedText = "";
            this.txtstatus.SelectionLength = 0;
            this.txtstatus.SelectionStart = 0;
            this.txtstatus.ShortcutsEnabled = true;
            this.txtstatus.Size = new System.Drawing.Size(113, 23);
            this.txtstatus.TabIndex = 3;
            this.txtstatus.UseSelectable = true;
            this.txtstatus.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtstatus.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(38, 89);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(87, 19);
            this.metroLabel2.TabIndex = 6;
            this.metroLabel2.Text = "Delivery Date";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(38, 140);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(43, 19);
            this.metroLabel3.TabIndex = 7;
            this.metroLabel3.Text = "Status";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(38, 192);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(100, 19);
            this.metroLabel4.TabIndex = 8;
            this.metroLabel4.Text = "Sales Order No";
            // 
            // mtadd
            // 
            this.mtadd.ActiveControl = null;
            this.mtadd.Location = new System.Drawing.Point(29, 288);
            this.mtadd.Name = "mtadd";
            this.mtadd.Size = new System.Drawing.Size(75, 40);
            this.mtadd.TabIndex = 9;
            this.mtadd.Text = "Add \r\nDelivery";
            this.mtadd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtadd.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mtadd.UseSelectable = true;
            this.mtadd.Click += new System.EventHandler(this.mtadd_Click);
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.Location = new System.Drawing.Point(219, 288);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(72, 40);
            this.metroTile2.TabIndex = 10;
            this.metroTile2.Text = "Clear";
            this.metroTile2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile2.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile2.UseSelectable = true;
            this.metroTile2.Click += new System.EventHandler(this.metroTile2_Click);
            // 
            // cmbsalesorder
            // 
            this.cmbsalesorder.FormattingEnabled = true;
            this.cmbsalesorder.ItemHeight = 23;
            this.cmbsalesorder.Items.AddRange(new object[] {
            "**Select**"});
            this.cmbsalesorder.Location = new System.Drawing.Point(158, 192);
            this.cmbsalesorder.Name = "cmbsalesorder";
            this.cmbsalesorder.Size = new System.Drawing.Size(121, 29);
            this.cmbsalesorder.TabIndex = 55;
            this.cmbsalesorder.UseSelectable = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(23, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 53;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(123, 288);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(77, 40);
            this.metroTile1.TabIndex = 56;
            this.metroTile1.Text = "Update";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile1.UseSelectable = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // txtdate
            // 
            // 
            // 
            // 
            this.txtdate.CustomButton.Image = null;
            this.txtdate.CustomButton.Location = new System.Drawing.Point(91, 1);
            this.txtdate.CustomButton.Name = "";
            this.txtdate.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtdate.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtdate.CustomButton.TabIndex = 1;
            this.txtdate.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtdate.CustomButton.UseSelectable = true;
            this.txtdate.CustomButton.Visible = false;
            this.txtdate.Lines = new string[0];
            this.txtdate.Location = new System.Drawing.Point(158, 89);
            this.txtdate.MaxLength = 32767;
            this.txtdate.Name = "txtdate";
            this.txtdate.PasswordChar = '\0';
            this.txtdate.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtdate.SelectedText = "";
            this.txtdate.SelectionLength = 0;
            this.txtdate.SelectionStart = 0;
            this.txtdate.ShortcutsEnabled = true;
            this.txtdate.Size = new System.Drawing.Size(113, 23);
            this.txtdate.TabIndex = 2;
            this.txtdate.UseSelectable = true;
            this.txtdate.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtdate.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtdate.Click += new System.EventHandler(this.txtdate_Click);
            // 
            // Delivery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 351);
            this.ControlBox = false;
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.cmbsalesorder);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.metroTile2);
            this.Controls.Add(this.mtadd);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txtstatus);
            this.Controls.Add(this.txtdate);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Delivery";
            this.Text = "Delivery";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.Delivery_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private MetroFramework.Controls.MetroTextBox txtstatus;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTile mtadd;
        private MetroFramework.Controls.MetroTile metroTile2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroComboBox cmbsalesorder;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroTextBox txtdate;
    }
}