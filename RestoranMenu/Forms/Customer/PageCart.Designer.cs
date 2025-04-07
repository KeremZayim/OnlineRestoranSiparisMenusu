namespace RestoranMenu.Forms.Customer
{
    partial class PageCart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PageCart));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.pnlOrders = new Bunifu.UI.WinForms.BunifuPanel();
            this.pnlToplamFiyat = new Bunifu.UI.WinForms.BunifuPanel();
            this.btnSepeteEkle = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.lblTotalPrice = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuGradientPanel1 = new Bunifu.UI.WinForms.BunifuGradientPanel();
            this.lblSepetBaslik = new System.Windows.Forms.Label();
            this.pnlToplamFiyat.SuspendLayout();
            this.bunifuGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlOrders
            // 
            this.pnlOrders.AutoScroll = true;
            this.pnlOrders.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.pnlOrders.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlOrders.BackgroundImage")));
            this.pnlOrders.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlOrders.BorderColor = System.Drawing.Color.Transparent;
            this.pnlOrders.BorderRadius = 10;
            this.pnlOrders.BorderThickness = 0;
            this.pnlOrders.Location = new System.Drawing.Point(34, 85);
            this.pnlOrders.Name = "pnlOrders";
            this.pnlOrders.ShowBorders = true;
            this.pnlOrders.Size = new System.Drawing.Size(950, 371);
            this.pnlOrders.TabIndex = 0;
            // 
            // pnlToplamFiyat
            // 
            this.pnlToplamFiyat.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(225)))));
            this.pnlToplamFiyat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlToplamFiyat.BackgroundImage")));
            this.pnlToplamFiyat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlToplamFiyat.BorderColor = System.Drawing.Color.Transparent;
            this.pnlToplamFiyat.BorderRadius = 10;
            this.pnlToplamFiyat.BorderThickness = 0;
            this.pnlToplamFiyat.Controls.Add(this.btnSepeteEkle);
            this.pnlToplamFiyat.Controls.Add(this.lblTotalPrice);
            this.pnlToplamFiyat.Controls.Add(this.bunifuLabel2);
            this.pnlToplamFiyat.Location = new System.Drawing.Point(34, 463);
            this.pnlToplamFiyat.Name = "pnlToplamFiyat";
            this.pnlToplamFiyat.ShowBorders = true;
            this.pnlToplamFiyat.Size = new System.Drawing.Size(950, 73);
            this.pnlToplamFiyat.TabIndex = 3;
            // 
            // btnSepeteEkle
            // 
            this.btnSepeteEkle.AllowAnimations = true;
            this.btnSepeteEkle.AllowMouseEffects = true;
            this.btnSepeteEkle.AllowToggling = false;
            this.btnSepeteEkle.AnimationSpeed = 200;
            this.btnSepeteEkle.AutoGenerateColors = false;
            this.btnSepeteEkle.AutoRoundBorders = false;
            this.btnSepeteEkle.AutoSizeLeftIcon = true;
            this.btnSepeteEkle.AutoSizeRightIcon = true;
            this.btnSepeteEkle.BackColor = System.Drawing.Color.Transparent;
            this.btnSepeteEkle.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(155)))), ((int)(((byte)(255)))));
            this.btnSepeteEkle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSepeteEkle.BackgroundImage")));
            this.btnSepeteEkle.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSepeteEkle.ButtonText = "Sipariş Ver";
            this.btnSepeteEkle.ButtonTextMarginLeft = 0;
            this.btnSepeteEkle.ColorContrastOnClick = 45;
            this.btnSepeteEkle.ColorContrastOnHover = 45;
            this.btnSepeteEkle.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnSepeteEkle.CustomizableEdges = borderEdges1;
            this.btnSepeteEkle.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSepeteEkle.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnSepeteEkle.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnSepeteEkle.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnSepeteEkle.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnSepeteEkle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSepeteEkle.ForeColor = System.Drawing.Color.White;
            this.btnSepeteEkle.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSepeteEkle.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnSepeteEkle.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnSepeteEkle.IconMarginLeft = 11;
            this.btnSepeteEkle.IconPadding = 10;
            this.btnSepeteEkle.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSepeteEkle.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnSepeteEkle.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnSepeteEkle.IconSize = 25;
            this.btnSepeteEkle.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(155)))), ((int)(((byte)(255)))));
            this.btnSepeteEkle.IdleBorderRadius = 20;
            this.btnSepeteEkle.IdleBorderThickness = 1;
            this.btnSepeteEkle.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(155)))), ((int)(((byte)(255)))));
            this.btnSepeteEkle.IdleIconLeftImage = null;
            this.btnSepeteEkle.IdleIconRightImage = null;
            this.btnSepeteEkle.IndicateFocus = false;
            this.btnSepeteEkle.Location = new System.Drawing.Point(325, 10);
            this.btnSepeteEkle.Name = "btnSepeteEkle";
            this.btnSepeteEkle.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnSepeteEkle.OnDisabledState.BorderRadius = 20;
            this.btnSepeteEkle.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSepeteEkle.OnDisabledState.BorderThickness = 0;
            this.btnSepeteEkle.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnSepeteEkle.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnSepeteEkle.OnDisabledState.IconLeftImage = null;
            this.btnSepeteEkle.OnDisabledState.IconRightImage = null;
            this.btnSepeteEkle.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnSepeteEkle.onHoverState.BorderRadius = 20;
            this.btnSepeteEkle.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSepeteEkle.onHoverState.BorderThickness = 0;
            this.btnSepeteEkle.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnSepeteEkle.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnSepeteEkle.onHoverState.IconLeftImage = null;
            this.btnSepeteEkle.onHoverState.IconRightImage = null;
            this.btnSepeteEkle.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(155)))), ((int)(((byte)(255)))));
            this.btnSepeteEkle.OnIdleState.BorderRadius = 20;
            this.btnSepeteEkle.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSepeteEkle.OnIdleState.BorderThickness = 0;
            this.btnSepeteEkle.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(155)))), ((int)(((byte)(255)))));
            this.btnSepeteEkle.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnSepeteEkle.OnIdleState.IconLeftImage = null;
            this.btnSepeteEkle.OnIdleState.IconRightImage = null;
            this.btnSepeteEkle.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnSepeteEkle.OnPressedState.BorderRadius = 20;
            this.btnSepeteEkle.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSepeteEkle.OnPressedState.BorderThickness = 0;
            this.btnSepeteEkle.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnSepeteEkle.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnSepeteEkle.OnPressedState.IconLeftImage = null;
            this.btnSepeteEkle.OnPressedState.IconRightImage = null;
            this.btnSepeteEkle.Size = new System.Drawing.Size(300, 54);
            this.btnSepeteEkle.TabIndex = 5;
            this.btnSepeteEkle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSepeteEkle.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSepeteEkle.TextMarginLeft = 0;
            this.btnSepeteEkle.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnSepeteEkle.UseDefaultRadiusAndThickness = true;
            this.btnSepeteEkle.Click += new System.EventHandler(this.btnSepeteEkle_Click);
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AllowParentOverrides = false;
            this.lblTotalPrice.AutoEllipsis = false;
            this.lblTotalPrice.AutoSize = false;
            this.lblTotalPrice.CursorType = null;
            this.lblTotalPrice.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.lblTotalPrice.Location = new System.Drawing.Point(872, 0);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTotalPrice.Size = new System.Drawing.Size(74, 71);
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
            this.bunifuLabel2.Location = new System.Drawing.Point(763, 3);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(103, 66);
            this.bunifuLabel2.TabIndex = 3;
            this.bunifuLabel2.Text = "Toplam Fiyat:";
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.bunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.BorderRadius = 10;
            this.bunifuGradientPanel1.Controls.Add(this.lblSepetBaslik);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(88)))), ((int)(((byte)(190)))));
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.LightBlue;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.DodgerBlue;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.SystemColors.ActiveCaption;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(34, 17);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(950, 62);
            this.bunifuGradientPanel1.TabIndex = 4;
            // 
            // lblSepetBaslik
            // 
            this.lblSepetBaslik.Font = new System.Drawing.Font("Century Gothic", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSepetBaslik.Location = new System.Drawing.Point(18, 0);
            this.lblSepetBaslik.Name = "lblSepetBaslik";
            this.lblSepetBaslik.Size = new System.Drawing.Size(181, 62);
            this.lblSepetBaslik.TabIndex = 1;
            this.lblSepetBaslik.Text = "Sepet";
            this.lblSepetBaslik.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PageCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 553);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Controls.Add(this.pnlToplamFiyat);
            this.Controls.Add(this.pnlOrders);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PageCart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Yummy Day | Siparişler";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PageOrders_FormClosing);
            this.Shown += new System.EventHandler(this.PageOrders_Shown);
            this.pnlToplamFiyat.ResumeLayout(false);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPanel pnlOrders;
        private Bunifu.UI.WinForms.BunifuPanel pnlToplamFiyat;
        private Bunifu.UI.WinForms.BunifuLabel lblTotalPrice;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnSepeteEkle;
        private Bunifu.UI.WinForms.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.Label lblSepetBaslik;
    }
}