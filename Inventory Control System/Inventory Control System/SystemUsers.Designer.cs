namespace Inventory_Control_System
{
    partial class SystemUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SystemUsers));
            this.mtAdd = new MetroFramework.Controls.MetroTile();
            this.mtUpdate = new MetroFramework.Controls.MetroTile();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblname = new MetroFramework.Controls.MetroLabel();
            this.lblAdd = new MetroFramework.Controls.MetroLabel();
            this.lblTele = new MetroFramework.Controls.MetroLabel();
            this.lblStatus = new MetroFramework.Controls.MetroLabel();
            this.txtname = new MetroFramework.Controls.MetroTextBox();
            this.txtadd = new MetroFramework.Controls.MetroTextBox();
            this.txtstatus = new MetroFramework.Controls.MetroTextBox();
            this.mtCancel = new MetroFramework.Controls.MetroTile();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtpw = new MetroFramework.Controls.MetroTextBox();
            this.txttele = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mtAdd
            // 
            this.mtAdd.ActiveControl = null;
            this.mtAdd.Location = new System.Drawing.Point(39, 270);
            this.mtAdd.Name = "mtAdd";
            this.mtAdd.Size = new System.Drawing.Size(89, 39);
            this.mtAdd.TabIndex = 0;
            this.mtAdd.Text = "Add User";
            this.mtAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtAdd.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mtAdd.UseSelectable = true;
            this.mtAdd.Click += new System.EventHandler(this.mtAdd_Click);
            // 
            // mtUpdate
            // 
            this.mtUpdate.ActiveControl = null;
            this.mtUpdate.Location = new System.Drawing.Point(142, 270);
            this.mtUpdate.Name = "mtUpdate";
            this.mtUpdate.Size = new System.Drawing.Size(106, 38);
            this.mtUpdate.TabIndex = 1;
            this.mtUpdate.Text = "Update User";
            this.mtUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtUpdate.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mtUpdate.UseSelectable = true;
            this.mtUpdate.Click += new System.EventHandler(this.mtUpdate_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(358, 92);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(459, 168);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(54, 96);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(45, 19);
            this.lblname.TabIndex = 4;
            this.lblname.Text = "Name";
            // 
            // lblAdd
            // 
            this.lblAdd.AutoSize = true;
            this.lblAdd.Location = new System.Drawing.Point(54, 133);
            this.lblAdd.Name = "lblAdd";
            this.lblAdd.Size = new System.Drawing.Size(56, 19);
            this.lblAdd.TabIndex = 5;
            this.lblAdd.Text = "Address";
            // 
            // lblTele
            // 
            this.lblTele.AutoSize = true;
            this.lblTele.Location = new System.Drawing.Point(54, 169);
            this.lblTele.Name = "lblTele";
            this.lblTele.Size = new System.Drawing.Size(79, 19);
            this.lblTele.TabIndex = 6;
            this.lblTele.Text = "Contact No.";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(54, 207);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(43, 19);
            this.lblStatus.TabIndex = 7;
            this.lblStatus.Text = "Status";
            // 
            // txtname
            // 
            // 
            // 
            // 
            this.txtname.CustomButton.Image = null;
            this.txtname.CustomButton.Location = new System.Drawing.Point(97, 1);
            this.txtname.CustomButton.Name = "";
            this.txtname.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtname.CustomButton.TabIndex = 1;
            this.txtname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtname.CustomButton.UseSelectable = true;
            this.txtname.CustomButton.Visible = false;
            this.txtname.Lines = new string[0];
            this.txtname.Location = new System.Drawing.Point(220, 92);
            this.txtname.MaxLength = 32767;
            this.txtname.Name = "txtname";
            this.txtname.PasswordChar = '\0';
            this.txtname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtname.SelectedText = "";
            this.txtname.SelectionLength = 0;
            this.txtname.SelectionStart = 0;
            this.txtname.ShortcutsEnabled = true;
            this.txtname.Size = new System.Drawing.Size(119, 23);
            this.txtname.TabIndex = 8;
            this.txtname.UseSelectable = true;
            this.txtname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtadd
            // 
            // 
            // 
            // 
            this.txtadd.CustomButton.Image = null;
            this.txtadd.CustomButton.Location = new System.Drawing.Point(97, 1);
            this.txtadd.CustomButton.Name = "";
            this.txtadd.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtadd.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtadd.CustomButton.TabIndex = 1;
            this.txtadd.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtadd.CustomButton.UseSelectable = true;
            this.txtadd.CustomButton.Visible = false;
            this.txtadd.Lines = new string[0];
            this.txtadd.Location = new System.Drawing.Point(220, 129);
            this.txtadd.MaxLength = 32767;
            this.txtadd.Name = "txtadd";
            this.txtadd.PasswordChar = '\0';
            this.txtadd.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtadd.SelectedText = "";
            this.txtadd.SelectionLength = 0;
            this.txtadd.SelectionStart = 0;
            this.txtadd.ShortcutsEnabled = true;
            this.txtadd.Size = new System.Drawing.Size(119, 23);
            this.txtadd.TabIndex = 9;
            this.txtadd.UseSelectable = true;
            this.txtadd.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtadd.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtstatus
            // 
            // 
            // 
            // 
            this.txtstatus.CustomButton.Image = null;
            this.txtstatus.CustomButton.Location = new System.Drawing.Point(97, 1);
            this.txtstatus.CustomButton.Name = "";
            this.txtstatus.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtstatus.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtstatus.CustomButton.TabIndex = 1;
            this.txtstatus.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtstatus.CustomButton.UseSelectable = true;
            this.txtstatus.CustomButton.Visible = false;
            this.txtstatus.Lines = new string[0];
            this.txtstatus.Location = new System.Drawing.Point(220, 203);
            this.txtstatus.MaxLength = 32767;
            this.txtstatus.Name = "txtstatus";
            this.txtstatus.PasswordChar = '\0';
            this.txtstatus.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtstatus.SelectedText = "";
            this.txtstatus.SelectionLength = 0;
            this.txtstatus.SelectionStart = 0;
            this.txtstatus.ShortcutsEnabled = true;
            this.txtstatus.Size = new System.Drawing.Size(119, 23);
            this.txtstatus.TabIndex = 11;
            this.txtstatus.UseSelectable = true;
            this.txtstatus.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtstatus.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mtCancel
            // 
            this.mtCancel.ActiveControl = null;
            this.mtCancel.Location = new System.Drawing.Point(263, 270);
            this.mtCancel.Name = "mtCancel";
            this.mtCancel.Size = new System.Drawing.Size(65, 38);
            this.mtCancel.TabIndex = 14;
            this.mtCancel.Text = "Clear";
            this.mtCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtCancel.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mtCancel.UseSelectable = true;
            this.mtCancel.Click += new System.EventHandler(this.mtCancel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(24, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(54, 240);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(63, 19);
            this.metroLabel1.TabIndex = 16;
            this.metroLabel1.Text = "Password";
            this.metroLabel1.Click += new System.EventHandler(this.metroLabel1_Click_1);
            // 
            // txtpw
            // 
            // 
            // 
            // 
            this.txtpw.CustomButton.Image = null;
            this.txtpw.CustomButton.Location = new System.Drawing.Point(97, 1);
            this.txtpw.CustomButton.Name = "";
            this.txtpw.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtpw.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtpw.CustomButton.TabIndex = 1;
            this.txtpw.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtpw.CustomButton.UseSelectable = true;
            this.txtpw.CustomButton.Visible = false;
            this.txtpw.Lines = new string[0];
            this.txtpw.Location = new System.Drawing.Point(220, 236);
            this.txtpw.MaxLength = 32767;
            this.txtpw.Name = "txtpw";
            this.txtpw.PasswordChar = '\0';
            this.txtpw.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtpw.SelectedText = "";
            this.txtpw.SelectionLength = 0;
            this.txtpw.SelectionStart = 0;
            this.txtpw.ShortcutsEnabled = true;
            this.txtpw.Size = new System.Drawing.Size(119, 23);
            this.txtpw.TabIndex = 17;
            this.txtpw.UseSelectable = true;
            this.txtpw.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtpw.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txttele
            // 
            this.txttele.Location = new System.Drawing.Point(220, 167);
            this.txttele.Mask = "9990000000";
            this.txttele.Name = "txttele";
            this.txttele.Size = new System.Drawing.Size(119, 20);
            this.txttele.TabIndex = 18;
            // 
            // SystemUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 347);
            this.ControlBox = false;
            this.Controls.Add(this.txttele);
            this.Controls.Add(this.txtpw);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.mtCancel);
            this.Controls.Add(this.txtstatus);
            this.Controls.Add(this.txtadd);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblTele);
            this.Controls.Add(this.lblAdd);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.mtUpdate);
            this.Controls.Add(this.mtAdd);
            this.MaximizeBox = false;
            this.Name = "SystemUsers";
            this.Text = "System Users";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTile mtAdd;
        private MetroFramework.Controls.MetroTile mtUpdate;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MetroFramework.Controls.MetroLabel lblname;
        private MetroFramework.Controls.MetroLabel lblAdd;
        private MetroFramework.Controls.MetroLabel lblTele;
        private MetroFramework.Controls.MetroLabel lblStatus;
        private MetroFramework.Controls.MetroTextBox txtname;
        private MetroFramework.Controls.MetroTextBox txtadd;
        private MetroFramework.Controls.MetroTextBox txtstatus;
        private MetroFramework.Controls.MetroTile mtCancel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtpw;
        private System.Windows.Forms.MaskedTextBox txttele;
    }
}