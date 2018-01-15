namespace Inventory_Control_System
{
    partial class UserMenu
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
            this.metroLink1 = new MetroFramework.Controls.MetroLink();
            this.mtGrn = new MetroFramework.Controls.MetroTile();
            this.mtSalesRet = new MetroFramework.Controls.MetroTile();
            this.mtPurchRet = new MetroFramework.Controls.MetroTile();
            this.mtPurchOrd = new MetroFramework.Controls.MetroTile();
            this.mtSalesOrd = new MetroFramework.Controls.MetroTile();
            this.mtDelivery = new MetroFramework.Controls.MetroTile();
            this.mtItems = new MetroFramework.Controls.MetroTile();
            this.mtCus = new MetroFramework.Controls.MetroTile();
            this.mtSup = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // metroLink1
            // 
            this.metroLink1.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.metroLink1.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.metroLink1.Location = new System.Drawing.Point(334, 27);
            this.metroLink1.Name = "metroLink1";
            this.metroLink1.Size = new System.Drawing.Size(75, 23);
            this.metroLink1.TabIndex = 9;
            this.metroLink1.Text = "Logout";
            this.metroLink1.UseSelectable = true;
            this.metroLink1.Click += new System.EventHandler(this.metroLink1_Click);
            // 
            // mtGrn
            // 
            this.mtGrn.ActiveControl = null;
            this.mtGrn.Location = new System.Drawing.Point(307, 300);
            this.mtGrn.Name = "mtGrn";
            this.mtGrn.Size = new System.Drawing.Size(128, 91);
            this.mtGrn.Style = MetroFramework.MetroColorStyle.Green;
            this.mtGrn.TabIndex = 8;
            this.mtGrn.Text = "Generate a GRN";
            this.mtGrn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mtGrn.TileImage = global::Inventory_Control_System.Properties.Resources.icons8_create_document;
            this.mtGrn.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtGrn.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mtGrn.UseSelectable = true;
            this.mtGrn.UseTileImage = true;
            this.mtGrn.Click += new System.EventHandler(this.mtGrn_Click);
            // 
            // mtSalesRet
            // 
            this.mtSalesRet.ActiveControl = null;
            this.mtSalesRet.Location = new System.Drawing.Point(320, 91);
            this.mtSalesRet.Name = "mtSalesRet";
            this.mtSalesRet.Size = new System.Drawing.Size(115, 101);
            this.mtSalesRet.Style = MetroFramework.MetroColorStyle.Lime;
            this.mtSalesRet.TabIndex = 7;
            this.mtSalesRet.Text = "Sales Return";
            this.mtSalesRet.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mtSalesRet.TileImage = global::Inventory_Control_System.Properties.Resources.icons8_return_purchase;
            this.mtSalesRet.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtSalesRet.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mtSalesRet.UseSelectable = true;
            this.mtSalesRet.UseTileImage = true;
            this.mtSalesRet.Click += new System.EventHandler(this.mtSalesRet_Click);
            // 
            // mtPurchRet
            // 
            this.mtPurchRet.ActiveControl = null;
            this.mtPurchRet.Location = new System.Drawing.Point(41, 300);
            this.mtPurchRet.Name = "mtPurchRet";
            this.mtPurchRet.Size = new System.Drawing.Size(130, 91);
            this.mtPurchRet.Style = MetroFramework.MetroColorStyle.Purple;
            this.mtPurchRet.TabIndex = 6;
            this.mtPurchRet.Text = "Purchase Return";
            this.mtPurchRet.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mtPurchRet.TileImage = global::Inventory_Control_System.Properties.Resources.icons8_product;
            this.mtPurchRet.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtPurchRet.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mtPurchRet.UseSelectable = true;
            this.mtPurchRet.UseTileImage = true;
            this.mtPurchRet.Click += new System.EventHandler(this.mtPurchRet_Click);
            // 
            // mtPurchOrd
            // 
            this.mtPurchOrd.ActiveControl = null;
            this.mtPurchOrd.Location = new System.Drawing.Point(301, 198);
            this.mtPurchOrd.Name = "mtPurchOrd";
            this.mtPurchOrd.Size = new System.Drawing.Size(134, 96);
            this.mtPurchOrd.Style = MetroFramework.MetroColorStyle.Yellow;
            this.mtPurchOrd.TabIndex = 5;
            this.mtPurchOrd.Text = "Purchase Order";
            this.mtPurchOrd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mtPurchOrd.TileImage = global::Inventory_Control_System.Properties.Resources.if_Checklist_clipboard_inventory_list_report_tasks_todo_1886533;
            this.mtPurchOrd.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtPurchOrd.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mtPurchOrd.UseSelectable = true;
            this.mtPurchOrd.UseTileImage = true;
            this.mtPurchOrd.Click += new System.EventHandler(this.mtPurchOrd_Click);
            // 
            // mtSalesOrd
            // 
            this.mtSalesOrd.ActiveControl = null;
            this.mtSalesOrd.Location = new System.Drawing.Point(177, 300);
            this.mtSalesOrd.Name = "mtSalesOrd";
            this.mtSalesOrd.Size = new System.Drawing.Size(124, 91);
            this.mtSalesOrd.Style = MetroFramework.MetroColorStyle.Brown;
            this.mtSalesOrd.TabIndex = 4;
            this.mtSalesOrd.Text = "Place an Order";
            this.mtSalesOrd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mtSalesOrd.TileImage = global::Inventory_Control_System.Properties.Resources.if_Cart_ecommerce_shop_commerce_supermarket_trolley_shopping_1886549;
            this.mtSalesOrd.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtSalesOrd.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mtSalesOrd.UseSelectable = true;
            this.mtSalesOrd.UseTileImage = true;
            this.mtSalesOrd.Click += new System.EventHandler(this.mtSalesOrd_Click);
            // 
            // mtDelivery
            // 
            this.mtDelivery.ActiveControl = null;
            this.mtDelivery.Location = new System.Drawing.Point(41, 198);
            this.mtDelivery.Name = "mtDelivery";
            this.mtDelivery.Size = new System.Drawing.Size(136, 96);
            this.mtDelivery.Style = MetroFramework.MetroColorStyle.Orange;
            this.mtDelivery.TabIndex = 3;
            this.mtDelivery.Text = "Delivery";
            this.mtDelivery.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mtDelivery.TileImage = global::Inventory_Control_System.Properties.Resources.icons8_delivered;
            this.mtDelivery.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtDelivery.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mtDelivery.UseSelectable = true;
            this.mtDelivery.UseTileImage = true;
            this.mtDelivery.Click += new System.EventHandler(this.mtDelivery_Click);
            // 
            // mtItems
            // 
            this.mtItems.ActiveControl = null;
            this.mtItems.Location = new System.Drawing.Point(183, 198);
            this.mtItems.Name = "mtItems";
            this.mtItems.Size = new System.Drawing.Size(112, 96);
            this.mtItems.Style = MetroFramework.MetroColorStyle.Red;
            this.mtItems.TabIndex = 2;
            this.mtItems.Text = "Add Items";
            this.mtItems.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mtItems.TileImage = global::Inventory_Control_System.Properties.Resources.if_Change_edit_options_pencil_settings_tools_write_1886543;
            this.mtItems.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtItems.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mtItems.UseSelectable = true;
            this.mtItems.UseTileImage = true;
            this.mtItems.Click += new System.EventHandler(this.mtItems_Click);
            // 
            // mtCus
            // 
            this.mtCus.ActiveControl = null;
            this.mtCus.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mtCus.Location = new System.Drawing.Point(167, 91);
            this.mtCus.Name = "mtCus";
            this.mtCus.Size = new System.Drawing.Size(147, 101);
            this.mtCus.Style = MetroFramework.MetroColorStyle.Silver;
            this.mtCus.TabIndex = 1;
            this.mtCus.Text = "Update Customer";
            this.mtCus.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mtCus.TileImage = global::Inventory_Control_System.Properties.Resources.if_Check_interface_ui_Mark_Ok_user_web_1886534;
            this.mtCus.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtCus.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mtCus.UseSelectable = true;
            this.mtCus.UseTileImage = true;
            this.mtCus.Click += new System.EventHandler(this.mtCus_Click);
            // 
            // mtSup
            // 
            this.mtSup.ActiveControl = null;
            this.mtSup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mtSup.Location = new System.Drawing.Point(41, 91);
            this.mtSup.Name = "mtSup";
            this.mtSup.Size = new System.Drawing.Size(120, 101);
            this.mtSup.TabIndex = 0;
            this.mtSup.Text = "Add Supplier";
            this.mtSup.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mtSup.TileImage = global::Inventory_Control_System.Properties.Resources.icons8_supplier;
            this.mtSup.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtSup.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mtSup.UseSelectable = true;
            this.mtSup.UseTileImage = true;
            this.mtSup.Click += new System.EventHandler(this.mtSup_Click);
            // 
            // UserMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 460);
            this.ControlBox = false;
            this.Controls.Add(this.metroLink1);
            this.Controls.Add(this.mtGrn);
            this.Controls.Add(this.mtSalesRet);
            this.Controls.Add(this.mtPurchRet);
            this.Controls.Add(this.mtPurchOrd);
            this.Controls.Add(this.mtSalesOrd);
            this.Controls.Add(this.mtDelivery);
            this.Controls.Add(this.mtItems);
            this.Controls.Add(this.mtCus);
            this.Controls.Add(this.mtSup);
            this.MaximizeBox = false;
            this.Name = "UserMenu";
            this.Resizable = false;
            this.Text = "MENU";
            this.Load += new System.EventHandler(this.UserMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile mtSup;
        private MetroFramework.Controls.MetroTile mtCus;
        private MetroFramework.Controls.MetroTile mtItems;
        private MetroFramework.Controls.MetroTile mtDelivery;
        private MetroFramework.Controls.MetroTile mtSalesOrd;
        private MetroFramework.Controls.MetroTile mtPurchOrd;
        private MetroFramework.Controls.MetroTile mtPurchRet;
        private MetroFramework.Controls.MetroTile mtSalesRet;
        private MetroFramework.Controls.MetroTile mtGrn;
        private MetroFramework.Controls.MetroLink metroLink1;
    }
}