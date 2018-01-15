namespace Inventory_Control_System
{
    partial class Customer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customer));
            this.mtCancel = new MetroFramework.Controls.MetroTile();
            this.lbltele = new MetroFramework.Controls.MetroLabel();
            this.lblsupadd = new MetroFramework.Controls.MetroLabel();
            this.lblname = new MetroFramework.Controls.MetroLabel();
            this.txtadd = new MetroFramework.Controls.MetroTextBox();
            this.txtname = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnadd = new MetroFramework.Controls.MetroTile();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txttele = new System.Windows.Forms.MaskedTextBox();
            this.txtnic = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mtCancel
            // 
            this.mtCancel.ActiveControl = null;
            this.mtCancel.Location = new System.Drawing.Point(176, 298);
            this.mtCancel.Name = "mtCancel";
            this.mtCancel.Size = new System.Drawing.Size(107, 36);
            this.mtCancel.TabIndex = 33;
            this.mtCancel.Text = "Clear";
            this.mtCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtCancel.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mtCancel.UseSelectable = true;
            this.mtCancel.Click += new System.EventHandler(this.mtCancel_Click);
            // 
            // lbltele
            // 
            this.lbltele.AutoSize = true;
            this.lbltele.Location = new System.Drawing.Point(24, 183);
            this.lbltele.Name = "lbltele";
            this.lbltele.Size = new System.Drawing.Size(79, 19);
            this.lbltele.TabIndex = 28;
            this.lbltele.Text = "Contact No.";
            // 
            // lblsupadd
            // 
            this.lblsupadd.AutoSize = true;
            this.lblsupadd.Location = new System.Drawing.Point(24, 143);
            this.lblsupadd.Name = "lblsupadd";
            this.lblsupadd.Size = new System.Drawing.Size(56, 19);
            this.lblsupadd.TabIndex = 27;
            this.lblsupadd.Text = "Address";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(24, 99);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(45, 19);
            this.lblname.TabIndex = 25;
            this.lblname.Text = "Name";
            // 
            // txtadd
            // 
            // 
            // 
            // 
            this.txtadd.CustomButton.Image = null;
            this.txtadd.CustomButton.Location = new System.Drawing.Point(105, 1);
            this.txtadd.CustomButton.Name = "";
            this.txtadd.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtadd.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtadd.CustomButton.TabIndex = 1;
            this.txtadd.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtadd.CustomButton.UseSelectable = true;
            this.txtadd.CustomButton.Visible = false;
            this.txtadd.Lines = new string[0];
            this.txtadd.Location = new System.Drawing.Point(170, 139);
            this.txtadd.MaxLength = 32767;
            this.txtadd.Name = "txtadd";
            this.txtadd.PasswordChar = '\0';
            this.txtadd.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtadd.SelectedText = "";
            this.txtadd.SelectionLength = 0;
            this.txtadd.SelectionStart = 0;
            this.txtadd.ShortcutsEnabled = true;
            this.txtadd.Size = new System.Drawing.Size(127, 23);
            this.txtadd.TabIndex = 22;
            this.txtadd.UseSelectable = true;
            this.txtadd.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtadd.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtname
            // 
            // 
            // 
            // 
            this.txtname.CustomButton.Image = null;
            this.txtname.CustomButton.Location = new System.Drawing.Point(105, 1);
            this.txtname.CustomButton.Name = "";
            this.txtname.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtname.CustomButton.TabIndex = 1;
            this.txtname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtname.CustomButton.UseSelectable = true;
            this.txtname.CustomButton.Visible = false;
            this.txtname.Lines = new string[0];
            this.txtname.Location = new System.Drawing.Point(170, 99);
            this.txtname.MaxLength = 32767;
            this.txtname.Name = "txtname";
            this.txtname.PasswordChar = '\0';
            this.txtname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtname.SelectedText = "";
            this.txtname.SelectionLength = 0;
            this.txtname.SelectionStart = 0;
            this.txtname.ShortcutsEnabled = true;
            this.txtname.Size = new System.Drawing.Size(127, 23);
            this.txtname.TabIndex = 20;
            this.txtname.UseSelectable = true;
            this.txtname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(24, 228);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(92, 19);
            this.metroLabel1.TabIndex = 35;
            this.metroLabel1.Text = "Customer NIC";
            // 
            // btnadd
            // 
            this.btnadd.ActiveControl = null;
            this.btnadd.Location = new System.Drawing.Point(33, 298);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(121, 36);
            this.btnadd.TabIndex = 36;
            this.btnadd.Text = "Add \r\nCustomer";
            this.btnadd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnadd.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnadd.UseSelectable = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(10, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 52;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txttele
            // 
            this.txttele.Location = new System.Drawing.Point(170, 182);
            this.txttele.Mask = "9990000000";
            this.txttele.Name = "txttele";
            this.txttele.Size = new System.Drawing.Size(127, 20);
            this.txttele.TabIndex = 53;
            // 
            // txtnic
            // 
            this.txtnic.Location = new System.Drawing.Point(170, 228);
            this.txtnic.Mask = "000000000V";
            this.txtnic.Name = "txtnic";
            this.txtnic.Size = new System.Drawing.Size(127, 20);
            this.txtnic.TabIndex = 54;
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 377);
            this.ControlBox = false;
            this.Controls.Add(this.txtnic);
            this.Controls.Add(this.txttele);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.mtCancel);
            this.Controls.Add(this.lbltele);
            this.Controls.Add(this.lblsupadd);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.txtadd);
            this.Controls.Add(this.txtname);
            this.Name = "Customer";
            this.Text = "Create New Customer";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.Customer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTile mtCancel;
        private MetroFramework.Controls.MetroLabel lbltele;
        private MetroFramework.Controls.MetroLabel lblsupadd;
        private MetroFramework.Controls.MetroLabel lblname;
        private MetroFramework.Controls.MetroTextBox txtadd;
        private MetroFramework.Controls.MetroTextBox txtname;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTile btnadd;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MaskedTextBox txttele;
        private System.Windows.Forms.MaskedTextBox txtnic;
    }
}