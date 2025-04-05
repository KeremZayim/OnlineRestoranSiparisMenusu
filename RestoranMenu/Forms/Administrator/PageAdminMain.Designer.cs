namespace RestoranMenu.Forms.Administrator
{
    partial class PageAdminMain
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
            this.components = new System.ComponentModel.Container();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PageAdminMain));
            this.dragForm = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.btnExit = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.elipseForm = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnlHeadBar = new System.Windows.Forms.Panel();
            this.pnlTopColorBar = new Bunifu.UI.WinForms.BunifuPanel();
            this.lblYonetimBar = new Bunifu.UI.WinForms.BunifuLabel();
            this.pnlMenu = new Bunifu.UI.WinForms.BunifuPanel();
            this.pnlButtons = new Bunifu.UI.WinForms.BunifuPanel();
            this.btnAnaliz = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnUrunDuzenle = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnUrunEkle = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuSeparator1 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.pnlPersonelInformation = new Bunifu.UI.WinForms.BunifuPanel();
            this.pbLogo = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.lblPeronalInformation = new Bunifu.UI.WinForms.BunifuLabel();
            this.panelMain = new Bunifu.UI.WinForms.BunifuPanel();
            this.dragBar = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.pnlHeadBar.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.pnlPersonelInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // dragForm
            // 
            this.dragForm.Fixed = true;
            this.dragForm.Horizontal = true;
            this.dragForm.TargetControl = this;
            this.dragForm.Vertical = true;
            // 
            // btnExit
            // 
            this.btnExit.AllowAnimations = true;
            this.btnExit.AllowMouseEffects = true;
            this.btnExit.AllowToggling = false;
            this.btnExit.AnimationSpeed = 200;
            this.btnExit.AutoGenerateColors = false;
            this.btnExit.AutoRoundBorders = false;
            this.btnExit.AutoSizeLeftIcon = true;
            this.btnExit.AutoSizeRightIcon = true;
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnExit.ButtonText = "X";
            this.btnExit.ButtonTextMarginLeft = 0;
            this.btnExit.ColorContrastOnClick = 45;
            this.btnExit.ColorContrastOnHover = 45;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges4.BottomLeft = true;
            borderEdges4.BottomRight = true;
            borderEdges4.TopLeft = true;
            borderEdges4.TopRight = true;
            this.btnExit.CustomizableEdges = borderEdges4;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnExit.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnExit.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnExit.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnExit.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnExit.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnExit.IconMarginLeft = 11;
            this.btnExit.IconPadding = 10;
            this.btnExit.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExit.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnExit.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnExit.IconSize = 25;
            this.btnExit.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnExit.IdleBorderRadius = 1;
            this.btnExit.IdleBorderThickness = 1;
            this.btnExit.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnExit.IdleIconLeftImage = null;
            this.btnExit.IdleIconRightImage = null;
            this.btnExit.IndicateFocus = false;
            this.btnExit.Location = new System.Drawing.Point(1230, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnExit.OnDisabledState.BorderRadius = 1;
            this.btnExit.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnExit.OnDisabledState.BorderThickness = 1;
            this.btnExit.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnExit.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnExit.OnDisabledState.IconLeftImage = null;
            this.btnExit.OnDisabledState.IconRightImage = null;
            this.btnExit.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnExit.onHoverState.BorderRadius = 1;
            this.btnExit.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnExit.onHoverState.BorderThickness = 1;
            this.btnExit.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnExit.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnExit.onHoverState.IconLeftImage = null;
            this.btnExit.onHoverState.IconRightImage = null;
            this.btnExit.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnExit.OnIdleState.BorderRadius = 1;
            this.btnExit.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnExit.OnIdleState.BorderThickness = 1;
            this.btnExit.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnExit.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnExit.OnIdleState.IconLeftImage = null;
            this.btnExit.OnIdleState.IconRightImage = null;
            this.btnExit.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnExit.OnPressedState.BorderRadius = 1;
            this.btnExit.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnExit.OnPressedState.BorderThickness = 1;
            this.btnExit.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnExit.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnExit.OnPressedState.IconLeftImage = null;
            this.btnExit.OnPressedState.IconRightImage = null;
            this.btnExit.Size = new System.Drawing.Size(50, 30);
            this.btnExit.TabIndex = 6;
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnExit.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnExit.TextMarginLeft = 0;
            this.btnExit.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnExit.UseDefaultRadiusAndThickness = true;
            this.btnExit.Click += new System.EventHandler(this.ExitApplication);
            // 
            // elipseForm
            // 
            this.elipseForm.ElipseRadius = 10;
            this.elipseForm.TargetControl = this;
            // 
            // pnlHeadBar
            // 
            this.pnlHeadBar.Controls.Add(this.pnlTopColorBar);
            this.pnlHeadBar.Controls.Add(this.lblYonetimBar);
            this.pnlHeadBar.Controls.Add(this.btnExit);
            this.pnlHeadBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeadBar.Location = new System.Drawing.Point(0, 0);
            this.pnlHeadBar.Name = "pnlHeadBar";
            this.pnlHeadBar.Size = new System.Drawing.Size(1280, 31);
            this.pnlHeadBar.TabIndex = 7;
            // 
            // pnlTopColorBar
            // 
            this.pnlTopColorBar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(166)))), ((int)(((byte)(0)))));
            this.pnlTopColorBar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlTopColorBar.BackgroundImage")));
            this.pnlTopColorBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlTopColorBar.BorderColor = System.Drawing.Color.Transparent;
            this.pnlTopColorBar.BorderRadius = 3;
            this.pnlTopColorBar.BorderThickness = 1;
            this.pnlTopColorBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlTopColorBar.Location = new System.Drawing.Point(0, 30);
            this.pnlTopColorBar.Name = "pnlTopColorBar";
            this.pnlTopColorBar.ShowBorders = true;
            this.pnlTopColorBar.Size = new System.Drawing.Size(1280, 1);
            this.pnlTopColorBar.TabIndex = 8;
            // 
            // lblYonetimBar
            // 
            this.lblYonetimBar.AllowParentOverrides = false;
            this.lblYonetimBar.AutoEllipsis = false;
            this.lblYonetimBar.AutoSize = false;
            this.lblYonetimBar.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblYonetimBar.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblYonetimBar.Enabled = false;
            this.lblYonetimBar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblYonetimBar.Location = new System.Drawing.Point(50, 0);
            this.lblYonetimBar.Name = "lblYonetimBar";
            this.lblYonetimBar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblYonetimBar.Size = new System.Drawing.Size(1180, 30);
            this.lblYonetimBar.TabIndex = 7;
            this.lblYonetimBar.Text = "Name Surname - Restoran Menüsü Yönetim Sistemi";
            this.lblYonetimBar.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblYonetimBar.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackgroundColor = System.Drawing.Color.Transparent;
            this.pnlMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlMenu.BackgroundImage")));
            this.pnlMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlMenu.BorderColor = System.Drawing.Color.Transparent;
            this.pnlMenu.BorderRadius = 3;
            this.pnlMenu.BorderThickness = 1;
            this.pnlMenu.Controls.Add(this.pnlButtons);
            this.pnlMenu.Controls.Add(this.bunifuSeparator1);
            this.pnlMenu.Controls.Add(this.pnlPersonelInformation);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 31);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.ShowBorders = true;
            this.pnlMenu.Size = new System.Drawing.Size(246, 737);
            this.pnlMenu.TabIndex = 8;
            // 
            // pnlButtons
            // 
            this.pnlButtons.BackgroundColor = System.Drawing.Color.Transparent;
            this.pnlButtons.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlButtons.BackgroundImage")));
            this.pnlButtons.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlButtons.BorderColor = System.Drawing.Color.Transparent;
            this.pnlButtons.BorderRadius = 3;
            this.pnlButtons.BorderThickness = 1;
            this.pnlButtons.Controls.Add(this.btnAnaliz);
            this.pnlButtons.Controls.Add(this.btnUrunDuzenle);
            this.pnlButtons.Controls.Add(this.btnUrunEkle);
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlButtons.Location = new System.Drawing.Point(0, 235);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.ShowBorders = true;
            this.pnlButtons.Size = new System.Drawing.Size(246, 502);
            this.pnlButtons.TabIndex = 2;
            // 
            // btnAnaliz
            // 
            this.btnAnaliz.AllowAnimations = true;
            this.btnAnaliz.AllowMouseEffects = true;
            this.btnAnaliz.AllowToggling = false;
            this.btnAnaliz.AnimationSpeed = 200;
            this.btnAnaliz.AutoGenerateColors = false;
            this.btnAnaliz.AutoRoundBorders = false;
            this.btnAnaliz.AutoSizeLeftIcon = true;
            this.btnAnaliz.AutoSizeRightIcon = true;
            this.btnAnaliz.BackColor = System.Drawing.Color.Transparent;
            this.btnAnaliz.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(22)))), ((int)(((byte)(165)))));
            this.btnAnaliz.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAnaliz.BackgroundImage")));
            this.btnAnaliz.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAnaliz.ButtonText = "Analiz";
            this.btnAnaliz.ButtonTextMarginLeft = 0;
            this.btnAnaliz.ColorContrastOnClick = 45;
            this.btnAnaliz.ColorContrastOnHover = 45;
            this.btnAnaliz.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = false;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = false;
            borderEdges1.TopRight = true;
            this.btnAnaliz.CustomizableEdges = borderEdges1;
            this.btnAnaliz.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAnaliz.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAnaliz.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnAnaliz.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnAnaliz.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAnaliz.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnAnaliz.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAnaliz.ForeColor = System.Drawing.Color.White;
            this.btnAnaliz.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnaliz.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnAnaliz.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnAnaliz.IconMarginLeft = 11;
            this.btnAnaliz.IconPadding = 10;
            this.btnAnaliz.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAnaliz.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnAnaliz.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnAnaliz.IconSize = 25;
            this.btnAnaliz.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(22)))), ((int)(((byte)(165)))));
            this.btnAnaliz.IdleBorderRadius = 1;
            this.btnAnaliz.IdleBorderThickness = 1;
            this.btnAnaliz.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(22)))), ((int)(((byte)(165)))));
            this.btnAnaliz.IdleIconLeftImage = null;
            this.btnAnaliz.IdleIconRightImage = null;
            this.btnAnaliz.IndicateFocus = false;
            this.btnAnaliz.Location = new System.Drawing.Point(0, 130);
            this.btnAnaliz.Name = "btnAnaliz";
            this.btnAnaliz.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAnaliz.OnDisabledState.BorderRadius = 1;
            this.btnAnaliz.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAnaliz.OnDisabledState.BorderThickness = 1;
            this.btnAnaliz.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnAnaliz.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnAnaliz.OnDisabledState.IconLeftImage = null;
            this.btnAnaliz.OnDisabledState.IconRightImage = null;
            this.btnAnaliz.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnAnaliz.onHoverState.BorderRadius = 1;
            this.btnAnaliz.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAnaliz.onHoverState.BorderThickness = 1;
            this.btnAnaliz.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnAnaliz.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnAnaliz.onHoverState.IconLeftImage = null;
            this.btnAnaliz.onHoverState.IconRightImage = null;
            this.btnAnaliz.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(22)))), ((int)(((byte)(165)))));
            this.btnAnaliz.OnIdleState.BorderRadius = 1;
            this.btnAnaliz.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAnaliz.OnIdleState.BorderThickness = 1;
            this.btnAnaliz.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(22)))), ((int)(((byte)(165)))));
            this.btnAnaliz.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnAnaliz.OnIdleState.IconLeftImage = null;
            this.btnAnaliz.OnIdleState.IconRightImage = null;
            this.btnAnaliz.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnAnaliz.OnPressedState.BorderRadius = 1;
            this.btnAnaliz.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAnaliz.OnPressedState.BorderThickness = 1;
            this.btnAnaliz.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnAnaliz.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnAnaliz.OnPressedState.IconLeftImage = null;
            this.btnAnaliz.OnPressedState.IconRightImage = null;
            this.btnAnaliz.Size = new System.Drawing.Size(246, 65);
            this.btnAnaliz.TabIndex = 4;
            this.btnAnaliz.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAnaliz.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAnaliz.TextMarginLeft = 0;
            this.btnAnaliz.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnAnaliz.UseDefaultRadiusAndThickness = true;
            this.btnAnaliz.Click += new System.EventHandler(this.btnAnaliz_Click);
            // 
            // btnUrunDuzenle
            // 
            this.btnUrunDuzenle.AllowAnimations = true;
            this.btnUrunDuzenle.AllowMouseEffects = true;
            this.btnUrunDuzenle.AllowToggling = false;
            this.btnUrunDuzenle.AnimationSpeed = 200;
            this.btnUrunDuzenle.AutoGenerateColors = false;
            this.btnUrunDuzenle.AutoRoundBorders = false;
            this.btnUrunDuzenle.AutoSizeLeftIcon = true;
            this.btnUrunDuzenle.AutoSizeRightIcon = true;
            this.btnUrunDuzenle.BackColor = System.Drawing.Color.Transparent;
            this.btnUrunDuzenle.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(22)))), ((int)(((byte)(165)))));
            this.btnUrunDuzenle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUrunDuzenle.BackgroundImage")));
            this.btnUrunDuzenle.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnUrunDuzenle.ButtonText = "Ürünleri Düzenle";
            this.btnUrunDuzenle.ButtonTextMarginLeft = 0;
            this.btnUrunDuzenle.ColorContrastOnClick = 45;
            this.btnUrunDuzenle.ColorContrastOnHover = 45;
            this.btnUrunDuzenle.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = false;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = false;
            borderEdges2.TopRight = true;
            this.btnUrunDuzenle.CustomizableEdges = borderEdges2;
            this.btnUrunDuzenle.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnUrunDuzenle.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnUrunDuzenle.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnUrunDuzenle.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnUrunDuzenle.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUrunDuzenle.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnUrunDuzenle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnUrunDuzenle.ForeColor = System.Drawing.Color.White;
            this.btnUrunDuzenle.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUrunDuzenle.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnUrunDuzenle.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnUrunDuzenle.IconMarginLeft = 11;
            this.btnUrunDuzenle.IconPadding = 10;
            this.btnUrunDuzenle.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUrunDuzenle.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnUrunDuzenle.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnUrunDuzenle.IconSize = 25;
            this.btnUrunDuzenle.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(22)))), ((int)(((byte)(165)))));
            this.btnUrunDuzenle.IdleBorderRadius = 1;
            this.btnUrunDuzenle.IdleBorderThickness = 1;
            this.btnUrunDuzenle.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(22)))), ((int)(((byte)(165)))));
            this.btnUrunDuzenle.IdleIconLeftImage = null;
            this.btnUrunDuzenle.IdleIconRightImage = null;
            this.btnUrunDuzenle.IndicateFocus = false;
            this.btnUrunDuzenle.Location = new System.Drawing.Point(0, 65);
            this.btnUrunDuzenle.Name = "btnUrunDuzenle";
            this.btnUrunDuzenle.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnUrunDuzenle.OnDisabledState.BorderRadius = 1;
            this.btnUrunDuzenle.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnUrunDuzenle.OnDisabledState.BorderThickness = 1;
            this.btnUrunDuzenle.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnUrunDuzenle.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnUrunDuzenle.OnDisabledState.IconLeftImage = null;
            this.btnUrunDuzenle.OnDisabledState.IconRightImage = null;
            this.btnUrunDuzenle.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnUrunDuzenle.onHoverState.BorderRadius = 1;
            this.btnUrunDuzenle.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnUrunDuzenle.onHoverState.BorderThickness = 1;
            this.btnUrunDuzenle.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnUrunDuzenle.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnUrunDuzenle.onHoverState.IconLeftImage = null;
            this.btnUrunDuzenle.onHoverState.IconRightImage = null;
            this.btnUrunDuzenle.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(22)))), ((int)(((byte)(165)))));
            this.btnUrunDuzenle.OnIdleState.BorderRadius = 1;
            this.btnUrunDuzenle.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnUrunDuzenle.OnIdleState.BorderThickness = 1;
            this.btnUrunDuzenle.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(22)))), ((int)(((byte)(165)))));
            this.btnUrunDuzenle.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnUrunDuzenle.OnIdleState.IconLeftImage = null;
            this.btnUrunDuzenle.OnIdleState.IconRightImage = null;
            this.btnUrunDuzenle.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnUrunDuzenle.OnPressedState.BorderRadius = 1;
            this.btnUrunDuzenle.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnUrunDuzenle.OnPressedState.BorderThickness = 1;
            this.btnUrunDuzenle.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnUrunDuzenle.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnUrunDuzenle.OnPressedState.IconLeftImage = null;
            this.btnUrunDuzenle.OnPressedState.IconRightImage = null;
            this.btnUrunDuzenle.Size = new System.Drawing.Size(246, 65);
            this.btnUrunDuzenle.TabIndex = 3;
            this.btnUrunDuzenle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnUrunDuzenle.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnUrunDuzenle.TextMarginLeft = 0;
            this.btnUrunDuzenle.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnUrunDuzenle.UseDefaultRadiusAndThickness = true;
            this.btnUrunDuzenle.Click += new System.EventHandler(this.btnUrunDuzenle_Click);
            // 
            // btnUrunEkle
            // 
            this.btnUrunEkle.AllowAnimations = true;
            this.btnUrunEkle.AllowMouseEffects = true;
            this.btnUrunEkle.AllowToggling = false;
            this.btnUrunEkle.AnimationSpeed = 200;
            this.btnUrunEkle.AutoGenerateColors = false;
            this.btnUrunEkle.AutoRoundBorders = false;
            this.btnUrunEkle.AutoSizeLeftIcon = true;
            this.btnUrunEkle.AutoSizeRightIcon = true;
            this.btnUrunEkle.BackColor = System.Drawing.Color.Transparent;
            this.btnUrunEkle.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(22)))), ((int)(((byte)(165)))));
            this.btnUrunEkle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUrunEkle.BackgroundImage")));
            this.btnUrunEkle.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnUrunEkle.ButtonText = "Ürün Ekle";
            this.btnUrunEkle.ButtonTextMarginLeft = 0;
            this.btnUrunEkle.ColorContrastOnClick = 45;
            this.btnUrunEkle.ColorContrastOnHover = 45;
            this.btnUrunEkle.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges3.BottomLeft = false;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = false;
            borderEdges3.TopRight = true;
            this.btnUrunEkle.CustomizableEdges = borderEdges3;
            this.btnUrunEkle.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnUrunEkle.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnUrunEkle.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnUrunEkle.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnUrunEkle.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUrunEkle.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnUrunEkle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnUrunEkle.ForeColor = System.Drawing.Color.White;
            this.btnUrunEkle.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUrunEkle.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnUrunEkle.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnUrunEkle.IconMarginLeft = 11;
            this.btnUrunEkle.IconPadding = 10;
            this.btnUrunEkle.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUrunEkle.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnUrunEkle.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnUrunEkle.IconSize = 25;
            this.btnUrunEkle.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(22)))), ((int)(((byte)(165)))));
            this.btnUrunEkle.IdleBorderRadius = 1;
            this.btnUrunEkle.IdleBorderThickness = 1;
            this.btnUrunEkle.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(22)))), ((int)(((byte)(165)))));
            this.btnUrunEkle.IdleIconLeftImage = null;
            this.btnUrunEkle.IdleIconRightImage = null;
            this.btnUrunEkle.IndicateFocus = false;
            this.btnUrunEkle.Location = new System.Drawing.Point(0, 0);
            this.btnUrunEkle.Name = "btnUrunEkle";
            this.btnUrunEkle.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnUrunEkle.OnDisabledState.BorderRadius = 1;
            this.btnUrunEkle.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnUrunEkle.OnDisabledState.BorderThickness = 1;
            this.btnUrunEkle.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnUrunEkle.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnUrunEkle.OnDisabledState.IconLeftImage = null;
            this.btnUrunEkle.OnDisabledState.IconRightImage = null;
            this.btnUrunEkle.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnUrunEkle.onHoverState.BorderRadius = 1;
            this.btnUrunEkle.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnUrunEkle.onHoverState.BorderThickness = 1;
            this.btnUrunEkle.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnUrunEkle.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnUrunEkle.onHoverState.IconLeftImage = null;
            this.btnUrunEkle.onHoverState.IconRightImage = null;
            this.btnUrunEkle.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(22)))), ((int)(((byte)(165)))));
            this.btnUrunEkle.OnIdleState.BorderRadius = 1;
            this.btnUrunEkle.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnUrunEkle.OnIdleState.BorderThickness = 1;
            this.btnUrunEkle.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(22)))), ((int)(((byte)(165)))));
            this.btnUrunEkle.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnUrunEkle.OnIdleState.IconLeftImage = null;
            this.btnUrunEkle.OnIdleState.IconRightImage = null;
            this.btnUrunEkle.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnUrunEkle.OnPressedState.BorderRadius = 1;
            this.btnUrunEkle.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnUrunEkle.OnPressedState.BorderThickness = 1;
            this.btnUrunEkle.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnUrunEkle.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnUrunEkle.OnPressedState.IconLeftImage = null;
            this.btnUrunEkle.OnPressedState.IconRightImage = null;
            this.btnUrunEkle.Size = new System.Drawing.Size(246, 65);
            this.btnUrunEkle.TabIndex = 2;
            this.btnUrunEkle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnUrunEkle.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnUrunEkle.TextMarginLeft = 0;
            this.btnUrunEkle.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnUrunEkle.UseDefaultRadiusAndThickness = true;
            this.btnUrunEkle.Click += new System.EventHandler(this.btnSalatalar_Click);
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuSeparator1.BackgroundImage")));
            this.bunifuSeparator1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuSeparator1.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.Silver;
            this.bunifuSeparator1.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.Solid;
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(-3, 221);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.bunifuSeparator1.Size = new System.Drawing.Size(246, 10);
            this.bunifuSeparator1.TabIndex = 1;
            // 
            // pnlPersonelInformation
            // 
            this.pnlPersonelInformation.BackgroundColor = System.Drawing.Color.Transparent;
            this.pnlPersonelInformation.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlPersonelInformation.BackgroundImage")));
            this.pnlPersonelInformation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlPersonelInformation.BorderColor = System.Drawing.Color.Transparent;
            this.pnlPersonelInformation.BorderRadius = 3;
            this.pnlPersonelInformation.BorderThickness = 1;
            this.pnlPersonelInformation.Controls.Add(this.pbLogo);
            this.pnlPersonelInformation.Controls.Add(this.lblPeronalInformation);
            this.pnlPersonelInformation.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPersonelInformation.Location = new System.Drawing.Point(0, 0);
            this.pnlPersonelInformation.Name = "pnlPersonelInformation";
            this.pnlPersonelInformation.ShowBorders = true;
            this.pnlPersonelInformation.Size = new System.Drawing.Size(246, 231);
            this.pnlPersonelInformation.TabIndex = 0;
            // 
            // pbLogo
            // 
            this.pbLogo.AllowFocused = false;
            this.pbLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbLogo.AutoSizeHeight = true;
            this.pbLogo.BorderRadius = 73;
            this.pbLogo.Image = global::RestoranMenu.Properties.Resources.logo;
            this.pbLogo.IsCircle = true;
            this.pbLogo.Location = new System.Drawing.Point(50, 24);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(147, 147);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 1;
            this.pbLogo.TabStop = false;
            this.pbLogo.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // lblPeronalInformation
            // 
            this.lblPeronalInformation.AllowParentOverrides = false;
            this.lblPeronalInformation.AutoEllipsis = false;
            this.lblPeronalInformation.AutoSize = false;
            this.lblPeronalInformation.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblPeronalInformation.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblPeronalInformation.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPeronalInformation.Location = new System.Drawing.Point(2, 177);
            this.lblPeronalInformation.Name = "lblPeronalInformation";
            this.lblPeronalInformation.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblPeronalInformation.Size = new System.Drawing.Size(243, 23);
            this.lblPeronalInformation.TabIndex = 0;
            this.lblPeronalInformation.Text = "Name Surname";
            this.lblPeronalInformation.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPeronalInformation.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // panelMain
            // 
            this.panelMain.BackgroundColor = System.Drawing.Color.Transparent;
            this.panelMain.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelMain.BackgroundImage")));
            this.panelMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelMain.BorderColor = System.Drawing.Color.Transparent;
            this.panelMain.BorderRadius = 3;
            this.panelMain.BorderThickness = 1;
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(246, 31);
            this.panelMain.Name = "panelMain";
            this.panelMain.ShowBorders = true;
            this.panelMain.Size = new System.Drawing.Size(1034, 737);
            this.panelMain.TabIndex = 9;
            // 
            // dragBar
            // 
            this.dragBar.Fixed = true;
            this.dragBar.Horizontal = true;
            this.dragBar.TargetControl = this.pnlHeadBar;
            this.dragBar.Vertical = true;
            // 
            // PageAdminMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 768);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlHeadBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PageAdminMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yummy Day";
            this.Shown += new System.EventHandler(this.PageAdminMain_Shown);
            this.pnlHeadBar.ResumeLayout(false);
            this.pnlMenu.ResumeLayout(false);
            this.pnlButtons.ResumeLayout(false);
            this.pnlPersonelInformation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuDragControl dragForm;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnExit;
        private Bunifu.Framework.UI.BunifuElipse elipseForm;
        private System.Windows.Forms.Panel pnlHeadBar;
        private Bunifu.UI.WinForms.BunifuPanel pnlMenu;
        private Bunifu.UI.WinForms.BunifuPanel panelMain;
        private Bunifu.UI.WinForms.BunifuPanel pnlPersonelInformation;
        private Bunifu.UI.WinForms.BunifuPictureBox pbLogo;
        private Bunifu.UI.WinForms.BunifuLabel lblPeronalInformation;
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator1;
        private Bunifu.UI.WinForms.BunifuPanel pnlButtons;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnUrunDuzenle;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnUrunEkle;
        private Bunifu.UI.WinForms.BunifuLabel lblYonetimBar;
        private Bunifu.Framework.UI.BunifuDragControl dragBar;
        private Bunifu.UI.WinForms.BunifuPanel pnlTopColorBar;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnAnaliz;
    }
}