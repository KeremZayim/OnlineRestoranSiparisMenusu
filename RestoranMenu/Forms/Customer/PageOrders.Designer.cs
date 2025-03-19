namespace RestoranMenu.Forms.Customer
{
    partial class PageOrders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PageOrders));
            this.pnlOrders = new Bunifu.UI.WinForms.BunifuPanel();
            this.pnlToplamFiyat = new Bunifu.UI.WinForms.BunifuPanel();
            this.lblTotalPrice = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.pnlToplamFiyat.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlOrders
            // 
            this.pnlOrders.AutoScroll = true;
            this.pnlOrders.BackgroundColor = System.Drawing.Color.Thistle;
            this.pnlOrders.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlOrders.BackgroundImage")));
            this.pnlOrders.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlOrders.BorderColor = System.Drawing.Color.Transparent;
            this.pnlOrders.BorderRadius = 3;
            this.pnlOrders.BorderThickness = 0;
            this.pnlOrders.Location = new System.Drawing.Point(21, 21);
            this.pnlOrders.Name = "pnlOrders";
            this.pnlOrders.ShowBorders = true;
            this.pnlOrders.Size = new System.Drawing.Size(410, 420);
            this.pnlOrders.TabIndex = 0;
            // 
            // pnlToplamFiyat
            // 
            this.pnlToplamFiyat.BackgroundColor = System.Drawing.Color.Thistle;
            this.pnlToplamFiyat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlToplamFiyat.BackgroundImage")));
            this.pnlToplamFiyat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlToplamFiyat.BorderColor = System.Drawing.Color.Transparent;
            this.pnlToplamFiyat.BorderRadius = 3;
            this.pnlToplamFiyat.BorderThickness = 0;
            this.pnlToplamFiyat.Controls.Add(this.lblTotalPrice);
            this.pnlToplamFiyat.Controls.Add(this.bunifuLabel2);
            this.pnlToplamFiyat.Location = new System.Drawing.Point(21, 447);
            this.pnlToplamFiyat.Name = "pnlToplamFiyat";
            this.pnlToplamFiyat.ShowBorders = true;
            this.pnlToplamFiyat.Size = new System.Drawing.Size(410, 73);
            this.pnlToplamFiyat.TabIndex = 3;
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AllowParentOverrides = false;
            this.lblTotalPrice.AutoEllipsis = false;
            this.lblTotalPrice.AutoSize = false;
            this.lblTotalPrice.CursorType = null;
            this.lblTotalPrice.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.lblTotalPrice.Location = new System.Drawing.Point(333, 5);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTotalPrice.Size = new System.Drawing.Size(74, 64);
            this.lblTotalPrice.TabIndex = 4;
            this.lblTotalPrice.Text = "0 ₺";
            this.lblTotalPrice.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTotalPrice.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel2
            // 
            this.bunifuLabel2.AllowParentOverrides = false;
            this.bunifuLabel2.AutoEllipsis = false;
            this.bunifuLabel2.AutoSize = false;
            this.bunifuLabel2.CursorType = null;
            this.bunifuLabel2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.bunifuLabel2.Location = new System.Drawing.Point(12, 9);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(315, 58);
            this.bunifuLabel2.TabIndex = 3;
            this.bunifuLabel2.Text = "Toplam Fiyat:";
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.bunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // PageOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 698);
            this.Controls.Add(this.pnlToplamFiyat);
            this.Controls.Add(this.pnlOrders);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PageOrders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "PageOrders";
            this.Shown += new System.EventHandler(this.PageOrders_Shown);
            this.pnlToplamFiyat.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPanel pnlOrders;
        private Bunifu.UI.WinForms.BunifuPanel pnlToplamFiyat;
        private Bunifu.UI.WinForms.BunifuLabel lblTotalPrice;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
    }
}