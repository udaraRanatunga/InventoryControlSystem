namespace Inventory_Control_System
{
    partial class Reports
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reports));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mtBestSeller = new MetroFramework.Controls.MetroTile();
            this.mtPurch = new MetroFramework.Controls.MetroTile();
            this.mtDel = new MetroFramework.Controls.MetroTile();
            this.mtSales = new MetroFramework.Controls.MetroTile();
            this.mtStockStatus = new MetroFramework.Controls.MetroTile();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(24, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // mtBestSeller
            // 
            this.mtBestSeller.ActiveControl = null;
            this.mtBestSeller.Location = new System.Drawing.Point(251, 215);
            this.mtBestSeller.Name = "mtBestSeller";
            this.mtBestSeller.Size = new System.Drawing.Size(106, 102);
            this.mtBestSeller.Style = MetroFramework.MetroColorStyle.Red;
            this.mtBestSeller.TabIndex = 5;
            this.mtBestSeller.Text = "Best- Seller";
            this.mtBestSeller.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mtBestSeller.TileImage = global::Inventory_Control_System.Properties.Resources.badge1;
            this.mtBestSeller.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtBestSeller.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mtBestSeller.UseSelectable = true;
            this.mtBestSeller.UseStyleColors = true;
            this.mtBestSeller.UseTileImage = true;
            this.mtBestSeller.Click += new System.EventHandler(this.mtBestSeller_Click);
            // 
            // mtPurch
            // 
            this.mtPurch.ActiveControl = null;
            this.mtPurch.Location = new System.Drawing.Point(166, 343);
            this.mtPurch.Name = "mtPurch";
            this.mtPurch.Size = new System.Drawing.Size(106, 103);
            this.mtPurch.Style = MetroFramework.MetroColorStyle.Orange;
            this.mtPurch.TabIndex = 4;
            this.mtPurch.Text = "Purchases";
            this.mtPurch.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mtPurch.TileImage = global::Inventory_Control_System.Properties.Resources.package;
            this.mtPurch.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtPurch.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mtPurch.UseSelectable = true;
            this.mtPurch.UseTileImage = true;
            this.mtPurch.Click += new System.EventHandler(this.mtPurch_Click);
            // 
            // mtDel
            // 
            this.mtDel.ActiveControl = null;
            this.mtDel.Location = new System.Drawing.Point(68, 215);
            this.mtDel.Name = "mtDel";
            this.mtDel.Size = new System.Drawing.Size(113, 102);
            this.mtDel.Style = MetroFramework.MetroColorStyle.Yellow;
            this.mtDel.TabIndex = 2;
            this.mtDel.Text = "Delivery";
            this.mtDel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mtDel.TileImage = global::Inventory_Control_System.Properties.Resources.delivery_truck;
            this.mtDel.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtDel.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mtDel.UseSelectable = true;
            this.mtDel.UseTileImage = true;
            this.mtDel.Click += new System.EventHandler(this.metroTile3_Click);
            // 
            // mtSales
            // 
            this.mtSales.ActiveControl = null;
            this.mtSales.Location = new System.Drawing.Point(251, 82);
            this.mtSales.Name = "mtSales";
            this.mtSales.Size = new System.Drawing.Size(106, 103);
            this.mtSales.Style = MetroFramework.MetroColorStyle.Teal;
            this.mtSales.TabIndex = 1;
            this.mtSales.Text = "Sales";
            this.mtSales.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mtSales.TileImage = global::Inventory_Control_System.Properties.Resources.sale;
            this.mtSales.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtSales.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mtSales.UseSelectable = true;
            this.mtSales.UseTileImage = true;
            this.mtSales.Click += new System.EventHandler(this.mtSales_Click);
            // 
            // mtStockStatus
            // 
            this.mtStockStatus.ActiveControl = null;
            this.mtStockStatus.Location = new System.Drawing.Point(66, 82);
            this.mtStockStatus.Name = "mtStockStatus";
            this.mtStockStatus.Size = new System.Drawing.Size(115, 103);
            this.mtStockStatus.Style = MetroFramework.MetroColorStyle.Silver;
            this.mtStockStatus.TabIndex = 0;
            this.mtStockStatus.Text = "Stock Status ";
            this.mtStockStatus.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mtStockStatus.TileImage = global::Inventory_Control_System.Properties.Resources.shopping_bag;
            this.mtStockStatus.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtStockStatus.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mtStockStatus.UseSelectable = true;
            this.mtStockStatus.UseTileImage = true;
            this.mtStockStatus.Click += new System.EventHandler(this.mtStockStatus_Click);
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 481);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.mtBestSeller);
            this.Controls.Add(this.mtPurch);
            this.Controls.Add(this.mtDel);
            this.Controls.Add(this.mtSales);
            this.Controls.Add(this.mtStockStatus);
            this.MaximizeBox = false;
            this.Name = "Reports";
            this.Text = "Reports";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.Reports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile mtStockStatus;
        private MetroFramework.Controls.MetroTile mtSales;
        private MetroFramework.Controls.MetroTile mtDel;
        private MetroFramework.Controls.MetroTile mtPurch;
        private MetroFramework.Controls.MetroTile mtBestSeller;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}