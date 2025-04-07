namespace RestoranMenu.Forms.Administrator
{
    partial class PageAnalysis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PageAnalysis));
            this.pnlHeader = new Bunifu.UI.WinForms.BunifuGradientPanel();
            this.lblAnalizSayfasiBaslik = new System.Windows.Forms.Label();
            this.pnlMain = new Bunifu.UI.WinForms.BunifuShadowPanel();
            this.pnlDiger = new Bunifu.UI.WinForms.BunifuShadowPanel();
            this.lblEnCokSiparisVerenMusteriAdet = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblEnCokSiparisVerenMusteri = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblToplamSiparis = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblToplamMusteri = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblEnCokSatilanUrunAdedi = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblEnCokSatilanUrunAdi = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblToplamSatilanUrunFiyati = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblToplamSatisAdet = new Bunifu.UI.WinForms.BunifuLabel();
            this.pnlDigerHeader = new Bunifu.UI.WinForms.BunifuGradientPanel();
            this.lblDiger = new System.Windows.Forms.Label();
            this.pnlSonSatilanlar = new Bunifu.UI.WinForms.BunifuShadowPanel();
            this.pnlSonSatilanlarHeader = new Bunifu.UI.WinForms.BunifuGradientPanel();
            this.lblSonSatilanlar = new System.Windows.Forms.Label();
            this.pnlEnCokSatilanlar = new Bunifu.UI.WinForms.BunifuShadowPanel();
            this.pnlEnCokSatilanlarHeader = new Bunifu.UI.WinForms.BunifuGradientPanel();
            this.lblEnCokSatilanlar = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.pnlDiger.SuspendLayout();
            this.pnlDigerHeader.SuspendLayout();
            this.pnlSonSatilanlar.SuspendLayout();
            this.pnlSonSatilanlarHeader.SuspendLayout();
            this.pnlEnCokSatilanlar.SuspendLayout();
            this.pnlEnCokSatilanlarHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.Transparent;
            this.pnlHeader.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlHeader.BackgroundImage")));
            this.pnlHeader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlHeader.BorderRadius = 10;
            this.pnlHeader.Controls.Add(this.lblAnalizSayfasiBaslik);
            this.pnlHeader.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(88)))), ((int)(((byte)(190)))));
            this.pnlHeader.GradientBottomRight = System.Drawing.Color.LightBlue;
            this.pnlHeader.GradientTopLeft = System.Drawing.Color.DodgerBlue;
            this.pnlHeader.GradientTopRight = System.Drawing.SystemColors.ActiveCaption;
            this.pnlHeader.Location = new System.Drawing.Point(44, 35);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Quality = 10;
            this.pnlHeader.Size = new System.Drawing.Size(944, 62);
            this.pnlHeader.TabIndex = 5;
            // 
            // lblAnalizSayfasiBaslik
            // 
            this.lblAnalizSayfasiBaslik.Font = new System.Drawing.Font("Century Gothic", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAnalizSayfasiBaslik.Location = new System.Drawing.Point(3, 0);
            this.lblAnalizSayfasiBaslik.Name = "lblAnalizSayfasiBaslik";
            this.lblAnalizSayfasiBaslik.Size = new System.Drawing.Size(199, 62);
            this.lblAnalizSayfasiBaslik.TabIndex = 1;
            this.lblAnalizSayfasiBaslik.Text = "Analiz Sayfası";
            this.lblAnalizSayfasiBaslik.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.Transparent;
            this.pnlMain.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.pnlMain.BorderRadius = 10;
            this.pnlMain.BorderThickness = 1;
            this.pnlMain.Controls.Add(this.pnlDiger);
            this.pnlMain.Controls.Add(this.pnlSonSatilanlar);
            this.pnlMain.Controls.Add(this.pnlEnCokSatilanlar);
            this.pnlMain.FillStyle = Bunifu.UI.WinForms.BunifuShadowPanel.FillStyles.Solid;
            this.pnlMain.GradientMode = Bunifu.UI.WinForms.BunifuShadowPanel.GradientModes.Vertical;
            this.pnlMain.Location = new System.Drawing.Point(44, 32);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.PanelColor = System.Drawing.Color.WhiteSmoke;
            this.pnlMain.PanelColor2 = System.Drawing.Color.WhiteSmoke;
            this.pnlMain.ShadowColor = System.Drawing.Color.DarkGray;
            this.pnlMain.ShadowDept = 2;
            this.pnlMain.ShadowDepth = 5;
            this.pnlMain.ShadowStyle = Bunifu.UI.WinForms.BunifuShadowPanel.ShadowStyles.ForwardDiagonal;
            this.pnlMain.ShadowTopLeftVisible = false;
            this.pnlMain.Size = new System.Drawing.Size(950, 693);
            this.pnlMain.Style = Bunifu.UI.WinForms.BunifuShadowPanel.BevelStyles.Flat;
            this.pnlMain.TabIndex = 6;
            // 
            // pnlDiger
            // 
            this.pnlDiger.BackColor = System.Drawing.Color.Transparent;
            this.pnlDiger.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.pnlDiger.BorderRadius = 1;
            this.pnlDiger.BorderThickness = 1;
            this.pnlDiger.Controls.Add(this.lblEnCokSiparisVerenMusteriAdet);
            this.pnlDiger.Controls.Add(this.lblEnCokSiparisVerenMusteri);
            this.pnlDiger.Controls.Add(this.lblToplamSiparis);
            this.pnlDiger.Controls.Add(this.lblToplamMusteri);
            this.pnlDiger.Controls.Add(this.lblEnCokSatilanUrunAdedi);
            this.pnlDiger.Controls.Add(this.lblEnCokSatilanUrunAdi);
            this.pnlDiger.Controls.Add(this.lblToplamSatilanUrunFiyati);
            this.pnlDiger.Controls.Add(this.lblToplamSatisAdet);
            this.pnlDiger.Controls.Add(this.pnlDigerHeader);
            this.pnlDiger.FillStyle = Bunifu.UI.WinForms.BunifuShadowPanel.FillStyles.Solid;
            this.pnlDiger.GradientMode = Bunifu.UI.WinForms.BunifuShadowPanel.GradientModes.Vertical;
            this.pnlDiger.Location = new System.Drawing.Point(189, 415);
            this.pnlDiger.Name = "pnlDiger";
            this.pnlDiger.PanelColor = System.Drawing.Color.WhiteSmoke;
            this.pnlDiger.PanelColor2 = System.Drawing.Color.WhiteSmoke;
            this.pnlDiger.ShadowColor = System.Drawing.Color.DarkGray;
            this.pnlDiger.ShadowDept = 2;
            this.pnlDiger.ShadowDepth = 5;
            this.pnlDiger.ShadowStyle = Bunifu.UI.WinForms.BunifuShadowPanel.ShadowStyles.ForwardDiagonal;
            this.pnlDiger.ShadowTopLeftVisible = false;
            this.pnlDiger.Size = new System.Drawing.Size(566, 257);
            this.pnlDiger.Style = Bunifu.UI.WinForms.BunifuShadowPanel.BevelStyles.Flat;
            this.pnlDiger.TabIndex = 8;
            // 
            // lblEnCokSiparisVerenMusteriAdet
            // 
            this.lblEnCokSiparisVerenMusteriAdet.AllowParentOverrides = false;
            this.lblEnCokSiparisVerenMusteriAdet.AutoEllipsis = false;
            this.lblEnCokSiparisVerenMusteriAdet.AutoSize = false;
            this.lblEnCokSiparisVerenMusteriAdet.CursorType = null;
            this.lblEnCokSiparisVerenMusteriAdet.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEnCokSiparisVerenMusteriAdet.Location = new System.Drawing.Point(415, 203);
            this.lblEnCokSiparisVerenMusteriAdet.Name = "lblEnCokSiparisVerenMusteriAdet";
            this.lblEnCokSiparisVerenMusteriAdet.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblEnCokSiparisVerenMusteriAdet.Size = new System.Drawing.Size(128, 20);
            this.lblEnCokSiparisVerenMusteriAdet.TabIndex = 14;
            this.lblEnCokSiparisVerenMusteriAdet.Text = "Adeti: ";
            this.lblEnCokSiparisVerenMusteriAdet.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblEnCokSiparisVerenMusteriAdet.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lblEnCokSiparisVerenMusteri
            // 
            this.lblEnCokSiparisVerenMusteri.AllowParentOverrides = false;
            this.lblEnCokSiparisVerenMusteri.AutoEllipsis = false;
            this.lblEnCokSiparisVerenMusteri.AutoSize = false;
            this.lblEnCokSiparisVerenMusteri.CursorType = null;
            this.lblEnCokSiparisVerenMusteri.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEnCokSiparisVerenMusteri.Location = new System.Drawing.Point(10, 203);
            this.lblEnCokSiparisVerenMusteri.Name = "lblEnCokSiparisVerenMusteri";
            this.lblEnCokSiparisVerenMusteri.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblEnCokSiparisVerenMusteri.Size = new System.Drawing.Size(399, 20);
            this.lblEnCokSiparisVerenMusteri.TabIndex = 13;
            this.lblEnCokSiparisVerenMusteri.Text = "En Çok Sipariş Veren Müşteri : ";
            this.lblEnCokSiparisVerenMusteri.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblEnCokSiparisVerenMusteri.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lblToplamSiparis
            // 
            this.lblToplamSiparis.AllowParentOverrides = false;
            this.lblToplamSiparis.AutoEllipsis = false;
            this.lblToplamSiparis.AutoSize = false;
            this.lblToplamSiparis.CursorType = null;
            this.lblToplamSiparis.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamSiparis.Location = new System.Drawing.Point(10, 177);
            this.lblToplamSiparis.Name = "lblToplamSiparis";
            this.lblToplamSiparis.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblToplamSiparis.Size = new System.Drawing.Size(198, 20);
            this.lblToplamSiparis.TabIndex = 12;
            this.lblToplamSiparis.Text = "Toplam Sipariş Sayısı: ";
            this.lblToplamSiparis.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblToplamSiparis.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lblToplamMusteri
            // 
            this.lblToplamMusteri.AllowParentOverrides = false;
            this.lblToplamMusteri.AutoEllipsis = false;
            this.lblToplamMusteri.AutoSize = false;
            this.lblToplamMusteri.CursorType = null;
            this.lblToplamMusteri.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamMusteri.Location = new System.Drawing.Point(10, 151);
            this.lblToplamMusteri.Name = "lblToplamMusteri";
            this.lblToplamMusteri.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblToplamMusteri.Size = new System.Drawing.Size(198, 20);
            this.lblToplamMusteri.TabIndex = 11;
            this.lblToplamMusteri.Text = "Toplam Müşteri Sayısı: ";
            this.lblToplamMusteri.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblToplamMusteri.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lblEnCokSatilanUrunAdedi
            // 
            this.lblEnCokSatilanUrunAdedi.AllowParentOverrides = false;
            this.lblEnCokSatilanUrunAdedi.AutoEllipsis = false;
            this.lblEnCokSatilanUrunAdedi.AutoSize = false;
            this.lblEnCokSatilanUrunAdedi.CursorType = null;
            this.lblEnCokSatilanUrunAdedi.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEnCokSatilanUrunAdedi.Location = new System.Drawing.Point(226, 125);
            this.lblEnCokSatilanUrunAdedi.Name = "lblEnCokSatilanUrunAdedi";
            this.lblEnCokSatilanUrunAdedi.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblEnCokSatilanUrunAdedi.Size = new System.Drawing.Size(198, 20);
            this.lblEnCokSatilanUrunAdedi.TabIndex = 10;
            this.lblEnCokSatilanUrunAdedi.Text = "Adeti: ";
            this.lblEnCokSatilanUrunAdedi.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblEnCokSatilanUrunAdedi.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lblEnCokSatilanUrunAdi
            // 
            this.lblEnCokSatilanUrunAdi.AllowParentOverrides = false;
            this.lblEnCokSatilanUrunAdi.AutoEllipsis = false;
            this.lblEnCokSatilanUrunAdi.AutoSize = false;
            this.lblEnCokSatilanUrunAdi.CursorType = null;
            this.lblEnCokSatilanUrunAdi.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEnCokSatilanUrunAdi.Location = new System.Drawing.Point(10, 125);
            this.lblEnCokSatilanUrunAdi.Name = "lblEnCokSatilanUrunAdi";
            this.lblEnCokSatilanUrunAdi.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblEnCokSatilanUrunAdi.Size = new System.Drawing.Size(198, 20);
            this.lblEnCokSatilanUrunAdi.TabIndex = 9;
            this.lblEnCokSatilanUrunAdi.Text = "En Çok Satılan Ürün: ";
            this.lblEnCokSatilanUrunAdi.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblEnCokSatilanUrunAdi.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lblToplamSatilanUrunFiyati
            // 
            this.lblToplamSatilanUrunFiyati.AllowParentOverrides = false;
            this.lblToplamSatilanUrunFiyati.AutoEllipsis = false;
            this.lblToplamSatilanUrunFiyati.AutoSize = false;
            this.lblToplamSatilanUrunFiyati.CursorType = null;
            this.lblToplamSatilanUrunFiyati.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamSatilanUrunFiyati.Location = new System.Drawing.Point(10, 99);
            this.lblToplamSatilanUrunFiyati.Name = "lblToplamSatilanUrunFiyati";
            this.lblToplamSatilanUrunFiyati.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblToplamSatilanUrunFiyati.Size = new System.Drawing.Size(198, 20);
            this.lblToplamSatilanUrunFiyati.TabIndex = 8;
            this.lblToplamSatilanUrunFiyati.Text = "Toplam Satılan Ürün Fiyatı: \r\n";
            this.lblToplamSatilanUrunFiyati.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblToplamSatilanUrunFiyati.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lblToplamSatisAdet
            // 
            this.lblToplamSatisAdet.AllowParentOverrides = false;
            this.lblToplamSatisAdet.AutoEllipsis = false;
            this.lblToplamSatisAdet.AutoSize = false;
            this.lblToplamSatisAdet.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblToplamSatisAdet.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblToplamSatisAdet.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamSatisAdet.Location = new System.Drawing.Point(10, 73);
            this.lblToplamSatisAdet.Name = "lblToplamSatisAdet";
            this.lblToplamSatisAdet.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblToplamSatisAdet.Size = new System.Drawing.Size(198, 20);
            this.lblToplamSatisAdet.TabIndex = 7;
            this.lblToplamSatisAdet.Text = "Toplam Satılan Ürün Adeti: ";
            this.lblToplamSatisAdet.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblToplamSatisAdet.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // pnlDigerHeader
            // 
            this.pnlDigerHeader.BackColor = System.Drawing.Color.Transparent;
            this.pnlDigerHeader.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlDigerHeader.BackgroundImage")));
            this.pnlDigerHeader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlDigerHeader.BorderRadius = 10;
            this.pnlDigerHeader.Controls.Add(this.lblDiger);
            this.pnlDigerHeader.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(88)))), ((int)(((byte)(190)))));
            this.pnlDigerHeader.GradientBottomRight = System.Drawing.Color.LightBlue;
            this.pnlDigerHeader.GradientTopLeft = System.Drawing.Color.DodgerBlue;
            this.pnlDigerHeader.GradientTopRight = System.Drawing.SystemColors.ActiveCaption;
            this.pnlDigerHeader.Location = new System.Drawing.Point(3, 3);
            this.pnlDigerHeader.Name = "pnlDigerHeader";
            this.pnlDigerHeader.Quality = 10;
            this.pnlDigerHeader.Size = new System.Drawing.Size(560, 45);
            this.pnlDigerHeader.TabIndex = 6;
            // 
            // lblDiger
            // 
            this.lblDiger.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDiger.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDiger.Location = new System.Drawing.Point(0, 0);
            this.lblDiger.Name = "lblDiger";
            this.lblDiger.Size = new System.Drawing.Size(560, 45);
            this.lblDiger.TabIndex = 1;
            this.lblDiger.Text = "Diğer";
            this.lblDiger.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlSonSatilanlar
            // 
            this.pnlSonSatilanlar.BackColor = System.Drawing.Color.Transparent;
            this.pnlSonSatilanlar.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.pnlSonSatilanlar.BorderRadius = 1;
            this.pnlSonSatilanlar.BorderThickness = 1;
            this.pnlSonSatilanlar.Controls.Add(this.pnlSonSatilanlarHeader);
            this.pnlSonSatilanlar.FillStyle = Bunifu.UI.WinForms.BunifuShadowPanel.FillStyles.Solid;
            this.pnlSonSatilanlar.GradientMode = Bunifu.UI.WinForms.BunifuShadowPanel.GradientModes.Vertical;
            this.pnlSonSatilanlar.Location = new System.Drawing.Point(555, 102);
            this.pnlSonSatilanlar.Name = "pnlSonSatilanlar";
            this.pnlSonSatilanlar.PanelColor = System.Drawing.Color.WhiteSmoke;
            this.pnlSonSatilanlar.PanelColor2 = System.Drawing.Color.WhiteSmoke;
            this.pnlSonSatilanlar.ShadowColor = System.Drawing.Color.DarkGray;
            this.pnlSonSatilanlar.ShadowDept = 2;
            this.pnlSonSatilanlar.ShadowDepth = 5;
            this.pnlSonSatilanlar.ShadowStyle = Bunifu.UI.WinForms.BunifuShadowPanel.ShadowStyles.ForwardDiagonal;
            this.pnlSonSatilanlar.ShadowTopLeftVisible = false;
            this.pnlSonSatilanlar.Size = new System.Drawing.Size(330, 278);
            this.pnlSonSatilanlar.Style = Bunifu.UI.WinForms.BunifuShadowPanel.BevelStyles.Flat;
            this.pnlSonSatilanlar.TabIndex = 7;
            // 
            // pnlSonSatilanlarHeader
            // 
            this.pnlSonSatilanlarHeader.BackColor = System.Drawing.Color.Transparent;
            this.pnlSonSatilanlarHeader.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlSonSatilanlarHeader.BackgroundImage")));
            this.pnlSonSatilanlarHeader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlSonSatilanlarHeader.BorderRadius = 10;
            this.pnlSonSatilanlarHeader.Controls.Add(this.lblSonSatilanlar);
            this.pnlSonSatilanlarHeader.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(88)))), ((int)(((byte)(190)))));
            this.pnlSonSatilanlarHeader.GradientBottomRight = System.Drawing.Color.LightBlue;
            this.pnlSonSatilanlarHeader.GradientTopLeft = System.Drawing.Color.DodgerBlue;
            this.pnlSonSatilanlarHeader.GradientTopRight = System.Drawing.SystemColors.ActiveCaption;
            this.pnlSonSatilanlarHeader.Location = new System.Drawing.Point(3, 3);
            this.pnlSonSatilanlarHeader.Name = "pnlSonSatilanlarHeader";
            this.pnlSonSatilanlarHeader.Quality = 10;
            this.pnlSonSatilanlarHeader.Size = new System.Drawing.Size(324, 45);
            this.pnlSonSatilanlarHeader.TabIndex = 6;
            // 
            // lblSonSatilanlar
            // 
            this.lblSonSatilanlar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSonSatilanlar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSonSatilanlar.Location = new System.Drawing.Point(0, 0);
            this.lblSonSatilanlar.Name = "lblSonSatilanlar";
            this.lblSonSatilanlar.Size = new System.Drawing.Size(324, 45);
            this.lblSonSatilanlar.TabIndex = 1;
            this.lblSonSatilanlar.Text = "Son Satılanlar";
            this.lblSonSatilanlar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlEnCokSatilanlar
            // 
            this.pnlEnCokSatilanlar.BackColor = System.Drawing.Color.Transparent;
            this.pnlEnCokSatilanlar.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.pnlEnCokSatilanlar.BorderRadius = 1;
            this.pnlEnCokSatilanlar.BorderThickness = 1;
            this.pnlEnCokSatilanlar.Controls.Add(this.pnlEnCokSatilanlarHeader);
            this.pnlEnCokSatilanlar.FillStyle = Bunifu.UI.WinForms.BunifuShadowPanel.FillStyles.Solid;
            this.pnlEnCokSatilanlar.GradientMode = Bunifu.UI.WinForms.BunifuShadowPanel.GradientModes.Vertical;
            this.pnlEnCokSatilanlar.Location = new System.Drawing.Point(8, 99);
            this.pnlEnCokSatilanlar.Name = "pnlEnCokSatilanlar";
            this.pnlEnCokSatilanlar.PanelColor = System.Drawing.Color.WhiteSmoke;
            this.pnlEnCokSatilanlar.PanelColor2 = System.Drawing.Color.WhiteSmoke;
            this.pnlEnCokSatilanlar.ShadowColor = System.Drawing.Color.DarkGray;
            this.pnlEnCokSatilanlar.ShadowDept = 2;
            this.pnlEnCokSatilanlar.ShadowDepth = 5;
            this.pnlEnCokSatilanlar.ShadowStyle = Bunifu.UI.WinForms.BunifuShadowPanel.ShadowStyles.ForwardDiagonal;
            this.pnlEnCokSatilanlar.ShadowTopLeftVisible = false;
            this.pnlEnCokSatilanlar.Size = new System.Drawing.Size(330, 278);
            this.pnlEnCokSatilanlar.Style = Bunifu.UI.WinForms.BunifuShadowPanel.BevelStyles.Flat;
            this.pnlEnCokSatilanlar.TabIndex = 0;
            // 
            // pnlEnCokSatilanlarHeader
            // 
            this.pnlEnCokSatilanlarHeader.BackColor = System.Drawing.Color.Transparent;
            this.pnlEnCokSatilanlarHeader.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlEnCokSatilanlarHeader.BackgroundImage")));
            this.pnlEnCokSatilanlarHeader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlEnCokSatilanlarHeader.BorderRadius = 10;
            this.pnlEnCokSatilanlarHeader.Controls.Add(this.lblEnCokSatilanlar);
            this.pnlEnCokSatilanlarHeader.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(88)))), ((int)(((byte)(190)))));
            this.pnlEnCokSatilanlarHeader.GradientBottomRight = System.Drawing.Color.LightBlue;
            this.pnlEnCokSatilanlarHeader.GradientTopLeft = System.Drawing.Color.DodgerBlue;
            this.pnlEnCokSatilanlarHeader.GradientTopRight = System.Drawing.SystemColors.ActiveCaption;
            this.pnlEnCokSatilanlarHeader.Location = new System.Drawing.Point(3, 3);
            this.pnlEnCokSatilanlarHeader.Name = "pnlEnCokSatilanlarHeader";
            this.pnlEnCokSatilanlarHeader.Quality = 10;
            this.pnlEnCokSatilanlarHeader.Size = new System.Drawing.Size(324, 45);
            this.pnlEnCokSatilanlarHeader.TabIndex = 6;
            // 
            // lblEnCokSatilanlar
            // 
            this.lblEnCokSatilanlar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEnCokSatilanlar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEnCokSatilanlar.Location = new System.Drawing.Point(0, 0);
            this.lblEnCokSatilanlar.Name = "lblEnCokSatilanlar";
            this.lblEnCokSatilanlar.Size = new System.Drawing.Size(324, 45);
            this.lblEnCokSatilanlar.TabIndex = 1;
            this.lblEnCokSatilanlar.Text = "En Çok Satılanlar";
            this.lblEnCokSatilanlar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PageAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 737);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PageAnalysis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yummy Day | Restoran Analizi";
            this.pnlHeader.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            this.pnlDiger.ResumeLayout(false);
            this.pnlDigerHeader.ResumeLayout(false);
            this.pnlSonSatilanlar.ResumeLayout(false);
            this.pnlSonSatilanlarHeader.ResumeLayout(false);
            this.pnlEnCokSatilanlar.ResumeLayout(false);
            this.pnlEnCokSatilanlarHeader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuGradientPanel pnlHeader;
        private System.Windows.Forms.Label lblAnalizSayfasiBaslik;
        private Bunifu.UI.WinForms.BunifuShadowPanel pnlMain;
        private Bunifu.UI.WinForms.BunifuShadowPanel pnlEnCokSatilanlar;
        private Bunifu.UI.WinForms.BunifuGradientPanel pnlEnCokSatilanlarHeader;
        private System.Windows.Forms.Label lblEnCokSatilanlar;
        private Bunifu.UI.WinForms.BunifuShadowPanel pnlSonSatilanlar;
        private Bunifu.UI.WinForms.BunifuGradientPanel pnlSonSatilanlarHeader;
        private System.Windows.Forms.Label lblSonSatilanlar;
        private Bunifu.UI.WinForms.BunifuShadowPanel pnlDiger;
        private Bunifu.UI.WinForms.BunifuGradientPanel pnlDigerHeader;
        private System.Windows.Forms.Label lblDiger;
        private Bunifu.UI.WinForms.BunifuLabel lblToplamSatisAdet;
        private Bunifu.UI.WinForms.BunifuLabel lblToplamSatilanUrunFiyati;
        private Bunifu.UI.WinForms.BunifuLabel lblEnCokSatilanUrunAdedi;
        private Bunifu.UI.WinForms.BunifuLabel lblEnCokSatilanUrunAdi;
        private Bunifu.UI.WinForms.BunifuLabel lblToplamMusteri;
        private Bunifu.UI.WinForms.BunifuLabel lblToplamSiparis;
        private Bunifu.UI.WinForms.BunifuLabel lblEnCokSiparisVerenMusteri;
        private Bunifu.UI.WinForms.BunifuLabel lblEnCokSiparisVerenMusteriAdet;
    }
}