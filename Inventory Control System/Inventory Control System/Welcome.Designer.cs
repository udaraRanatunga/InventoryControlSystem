namespace Inventory_Control_System
{
    partial class Welcome
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mtexit = new MetroFramework.Controls.MetroTile();
            this.mtl_cus = new MetroFramework.Controls.MetroTile();
            this.mtl_user = new MetroFramework.Controls.MetroTile();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Inventory_Control_System.Properties.Resources.logo2__2_;
            this.pictureBox1.InitialImage = global::Inventory_Control_System.Properties.Resources.logo1;
            this.pictureBox1.Location = new System.Drawing.Point(23, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(220, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // mtexit
            // 
            this.mtexit.ActiveControl = null;
            this.mtexit.Location = new System.Drawing.Point(397, 108);
            this.mtexit.Name = "mtexit";
            this.mtexit.Size = new System.Drawing.Size(119, 104);
            this.mtexit.Style = MetroFramework.MetroColorStyle.Silver;
            this.mtexit.TabIndex = 3;
            this.mtexit.Text = "Exit";
            this.mtexit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mtexit.TileImage = global::Inventory_Control_System.Properties.Resources.icons8_cancel;
            this.mtexit.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtexit.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mtexit.UseSelectable = true;
            this.mtexit.UseTileImage = true;
            this.mtexit.Click += new System.EventHandler(this.mtexit_Click);
            // 
            // mtl_cus
            // 
            this.mtl_cus.ActiveControl = null;
            this.mtl_cus.ForeColor = System.Drawing.SystemColors.Control;
            this.mtl_cus.Location = new System.Drawing.Point(235, 108);
            this.mtl_cus.Name = "mtl_cus";
            this.mtl_cus.Size = new System.Drawing.Size(116, 104);
            this.mtl_cus.Style = MetroFramework.MetroColorStyle.Orange;
            this.mtl_cus.TabIndex = 2;
            this.mtl_cus.Text = "Customer";
            this.mtl_cus.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mtl_cus.TileImage = global::Inventory_Control_System.Properties.Resources.icons8_user;
            this.mtl_cus.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtl_cus.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mtl_cus.UseSelectable = true;
            this.mtl_cus.UseTileImage = true;
            this.mtl_cus.Click += new System.EventHandler(this.metroTile3_Click);
            // 
            // mtl_user
            // 
            this.mtl_user.ActiveControl = null;
            this.mtl_user.Location = new System.Drawing.Point(71, 108);
            this.mtl_user.Name = "mtl_user";
            this.mtl_user.Size = new System.Drawing.Size(119, 104);
            this.mtl_user.Style = MetroFramework.MetroColorStyle.Yellow;
            this.mtl_user.TabIndex = 1;
            this.mtl_user.Text = "Login";
            this.mtl_user.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mtl_user.TileImage = global::Inventory_Control_System.Properties.Resources.if_Key_379460__2_;
            this.mtl_user.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtl_user.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mtl_user.UseSelectable = true;
            this.mtl_user.UseTileImage = true;
            this.mtl_user.Click += new System.EventHandler(this.mtl_user_Click);
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 273);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.mtexit);
            this.Controls.Add(this.mtl_cus);
            this.Controls.Add(this.mtl_user);
            this.MaximizeBox = false;
            this.Name = "Welcome";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroTile mtl_user;
        private MetroFramework.Controls.MetroTile mtl_cus;
        private MetroFramework.Controls.MetroTile mtexit;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

