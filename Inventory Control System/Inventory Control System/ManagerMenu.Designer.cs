namespace Inventory_Control_System
{
    partial class ManagerMenu
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLink1 = new MetroFramework.Controls.MetroLink();
            this.mtReports = new MetroFramework.Controls.MetroTile();
            this.mtusers = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.metroLabel1.Location = new System.Drawing.Point(23, 22);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(142, 25);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Black;
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Manager Menu";
            this.metroLabel1.UseStyleColors = true;
            // 
            // metroLink1
            // 
            this.metroLink1.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.metroLink1.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.metroLink1.Location = new System.Drawing.Point(317, 24);
            this.metroLink1.Name = "metroLink1";
            this.metroLink1.Size = new System.Drawing.Size(75, 23);
            this.metroLink1.TabIndex = 3;
            this.metroLink1.Text = "Logout";
            this.metroLink1.Click += new System.EventHandler(this.metroLink1_Click);
            // 
            // mtReports
            // 
            this.mtReports.Location = new System.Drawing.Point(241, 101);
            this.mtReports.Name = "mtReports";
            this.mtReports.Size = new System.Drawing.Size(112, 91);
            this.mtReports.Style = MetroFramework.MetroColorStyle.Green;
            this.mtReports.TabIndex = 1;
            this.mtReports.Text = "Reports";
            this.mtReports.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mtReports.TileImage = global::Inventory_Control_System.Properties.Resources.if_Business_graph_pie_chart_revenue_business_growth_graph_growth_chart_1886556;
            this.mtReports.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtReports.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mtReports.UseTileImage = true;
            this.mtReports.Click += new System.EventHandler(this.mtReports_Click);
            // 
            // mtusers
            // 
            this.mtusers.Location = new System.Drawing.Point(88, 101);
            this.mtusers.Name = "mtusers";
            this.mtusers.Size = new System.Drawing.Size(107, 91);
            this.mtusers.Style = MetroFramework.MetroColorStyle.Silver;
            this.mtusers.TabIndex = 0;
            this.mtusers.Text = "System Users";
            this.mtusers.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mtusers.TileImage = global::Inventory_Control_System.Properties.Resources.if_Check_interface_ui_Mark_Ok_user_web_18865341;
            this.mtusers.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtusers.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mtusers.UseTileImage = true;
            this.mtusers.Click += new System.EventHandler(this.mtusers_Click);
            // 
            // ManagerMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 245);
            this.ControlBox = false;
            this.Controls.Add(this.metroLink1);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.mtReports);
            this.Controls.Add(this.mtusers);
            this.MaximizeBox = false;
            this.Name = "ManagerMenu";
            //this.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Center;
            this.Load += new System.EventHandler(this.ManagerMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTile mtusers;
        private MetroFramework.Controls.MetroTile mtReports;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLink metroLink1;
    }
}