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
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges6 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges5 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PageAdminMain));
            this.dragForm = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.btnExit = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.elipseForm = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnlHeadBar = new System.Windows.Forms.Panel();
            this.pnlTopColorBar = new Bunifu.UI.WinForms.BunifuPanel();
            this.lblYonetimBar = new Bunifu.UI.WinForms.BunifuLabel();
            this.pnlMenu = new Bunifu.UI.WinForms.BunifuPanel();
            this.pnlButtons = new Bunifu.UI.WinForms.BunifuPanel();
            this.btnYemekler = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnIcecekler = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnSalatalar = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnTatlilar = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnLoginEkraniGecis = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuSeparator1 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.pnlPersonelInformation = new Bunifu.UI.WinForms.BunifuPanel();
            this.pbUserLogo = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.lblPeronalInformation = new Bunifu.UI.WinForms.BunifuLabel();
            this.panelMain = new Bunifu.UI.WinForms.BunifuPanel();
            this.dragBar = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.pnlHeadBar.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.pnlPersonelInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserLogo)).BeginInit();
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
            borderEdges6.BottomLeft = true;
            borderEdges6.BottomRight = true;
            borderEdges6.TopLeft = true;
            borderEdges6.TopRight = true;
            this.btnExit.CustomizableEdges = borderEdges6;
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
            this.lblYonetimBar.Location = new System.Drawing.Point(3, 4);
            this.lblYonetimBar.Name = "lblYonetimBar";
            this.lblYonetimBar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblYonetimBar.Size = new System.Drawing.Size(1221, 22);
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
            this.pnlButtons.Controls.Add(this.btnYemekler);
            this.pnlButtons.Controls.Add(this.btnIcecekler);
            this.pnlButtons.Controls.Add(this.btnSalatalar);
            this.pnlButtons.Controls.Add(this.btnTatlilar);
            this.pnlButtons.Controls.Add(this.btnLoginEkraniGecis);
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlButtons.Location = new System.Drawing.Point(0, 235);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.ShowBorders = true;
            this.pnlButtons.Size = new System.Drawing.Size(246, 502);
            this.pnlButtons.TabIndex = 2;
            // 
            // btnYemekler
            // 
            this.btnYemekler.AllowAnimations = true;
            this.btnYemekler.AllowMouseEffects = true;
            this.btnYemekler.AllowToggling = false;
            this.btnYemekler.AnimationSpeed = 200;
            this.btnYemekler.AutoGenerateColors = false;
            this.btnYemekler.AutoRoundBorders = false;
            this.btnYemekler.AutoSizeLeftIcon = true;
            this.btnYemekler.AutoSizeRightIcon = true;
            this.btnYemekler.BackColor = System.Drawing.Color.Transparent;
            this.btnYemekler.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(166)))), ((int)(((byte)(0)))));
            this.btnYemekler.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnYemekler.BackgroundImage")));
            this.btnYemekler.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnYemekler.ButtonText = "Yemekler";
            this.btnYemekler.ButtonTextMarginLeft = 0;
            this.btnYemekler.ColorContrastOnClick = 45;
            this.btnYemekler.ColorContrastOnHover = 45;
            this.btnYemekler.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnYemekler.CustomizableEdges = borderEdges1;
            this.btnYemekler.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnYemekler.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnYemekler.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnYemekler.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnYemekler.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnYemekler.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnYemekler.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnYemekler.ForeColor = System.Drawing.Color.White;
            this.btnYemekler.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnYemekler.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnYemekler.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnYemekler.IconMarginLeft = 11;
            this.btnYemekler.IconPadding = 10;
            this.btnYemekler.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnYemekler.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnYemekler.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnYemekler.IconSize = 25;
            this.btnYemekler.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btnYemekler.IdleBorderRadius = 1;
            this.btnYemekler.IdleBorderThickness = 1;
            this.btnYemekler.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(166)))), ((int)(((byte)(0)))));
            this.btnYemekler.IdleIconLeftImage = null;
            this.btnYemekler.IdleIconRightImage = null;
            this.btnYemekler.IndicateFocus = false;
            this.btnYemekler.Location = new System.Drawing.Point(0, 195);
            this.btnYemekler.Name = "btnYemekler";
            this.btnYemekler.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnYemekler.OnDisabledState.BorderRadius = 1;
            this.btnYemekler.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnYemekler.OnDisabledState.BorderThickness = 1;
            this.btnYemekler.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnYemekler.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnYemekler.OnDisabledState.IconLeftImage = null;
            this.btnYemekler.OnDisabledState.IconRightImage = null;
            this.btnYemekler.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnYemekler.onHoverState.BorderRadius = 1;
            this.btnYemekler.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnYemekler.onHoverState.BorderThickness = 1;
            this.btnYemekler.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnYemekler.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnYemekler.onHoverState.IconLeftImage = null;
            this.btnYemekler.onHoverState.IconRightImage = null;
            this.btnYemekler.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnYemekler.OnIdleState.BorderRadius = 1;
            this.btnYemekler.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnYemekler.OnIdleState.BorderThickness = 1;
            this.btnYemekler.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(166)))), ((int)(((byte)(0)))));
            this.btnYemekler.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnYemekler.OnIdleState.IconLeftImage = null;
            this.btnYemekler.OnIdleState.IconRightImage = null;
            this.btnYemekler.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnYemekler.OnPressedState.BorderRadius = 1;
            this.btnYemekler.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnYemekler.OnPressedState.BorderThickness = 1;
            this.btnYemekler.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnYemekler.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnYemekler.OnPressedState.IconLeftImage = null;
            this.btnYemekler.OnPressedState.IconRightImage = null;
            this.btnYemekler.Size = new System.Drawing.Size(246, 65);
            this.btnYemekler.TabIndex = 4;
            this.btnYemekler.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnYemekler.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnYemekler.TextMarginLeft = 0;
            this.btnYemekler.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnYemekler.UseDefaultRadiusAndThickness = true;
            // 
            // btnIcecekler
            // 
            this.btnIcecekler.AllowAnimations = true;
            this.btnIcecekler.AllowMouseEffects = true;
            this.btnIcecekler.AllowToggling = false;
            this.btnIcecekler.AnimationSpeed = 200;
            this.btnIcecekler.AutoGenerateColors = false;
            this.btnIcecekler.AutoRoundBorders = false;
            this.btnIcecekler.AutoSizeLeftIcon = true;
            this.btnIcecekler.AutoSizeRightIcon = true;
            this.btnIcecekler.BackColor = System.Drawing.Color.Transparent;
            this.btnIcecekler.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(166)))), ((int)(((byte)(0)))));
            this.btnIcecekler.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnIcecekler.BackgroundImage")));
            this.btnIcecekler.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnIcecekler.ButtonText = "İçecekler";
            this.btnIcecekler.ButtonTextMarginLeft = 0;
            this.btnIcecekler.ColorContrastOnClick = 45;
            this.btnIcecekler.ColorContrastOnHover = 45;
            this.btnIcecekler.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnIcecekler.CustomizableEdges = borderEdges2;
            this.btnIcecekler.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnIcecekler.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnIcecekler.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnIcecekler.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnIcecekler.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnIcecekler.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnIcecekler.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnIcecekler.ForeColor = System.Drawing.Color.White;
            this.btnIcecekler.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIcecekler.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnIcecekler.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnIcecekler.IconMarginLeft = 11;
            this.btnIcecekler.IconPadding = 10;
            this.btnIcecekler.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIcecekler.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnIcecekler.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnIcecekler.IconSize = 25;
            this.btnIcecekler.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btnIcecekler.IdleBorderRadius = 1;
            this.btnIcecekler.IdleBorderThickness = 1;
            this.btnIcecekler.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(166)))), ((int)(((byte)(0)))));
            this.btnIcecekler.IdleIconLeftImage = null;
            this.btnIcecekler.IdleIconRightImage = null;
            this.btnIcecekler.IndicateFocus = false;
            this.btnIcecekler.Location = new System.Drawing.Point(0, 130);
            this.btnIcecekler.Name = "btnIcecekler";
            this.btnIcecekler.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnIcecekler.OnDisabledState.BorderRadius = 1;
            this.btnIcecekler.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnIcecekler.OnDisabledState.BorderThickness = 1;
            this.btnIcecekler.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnIcecekler.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnIcecekler.OnDisabledState.IconLeftImage = null;
            this.btnIcecekler.OnDisabledState.IconRightImage = null;
            this.btnIcecekler.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnIcecekler.onHoverState.BorderRadius = 1;
            this.btnIcecekler.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnIcecekler.onHoverState.BorderThickness = 1;
            this.btnIcecekler.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnIcecekler.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnIcecekler.onHoverState.IconLeftImage = null;
            this.btnIcecekler.onHoverState.IconRightImage = null;
            this.btnIcecekler.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnIcecekler.OnIdleState.BorderRadius = 1;
            this.btnIcecekler.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnIcecekler.OnIdleState.BorderThickness = 1;
            this.btnIcecekler.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(166)))), ((int)(((byte)(0)))));
            this.btnIcecekler.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnIcecekler.OnIdleState.IconLeftImage = null;
            this.btnIcecekler.OnIdleState.IconRightImage = null;
            this.btnIcecekler.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnIcecekler.OnPressedState.BorderRadius = 1;
            this.btnIcecekler.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnIcecekler.OnPressedState.BorderThickness = 1;
            this.btnIcecekler.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnIcecekler.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnIcecekler.OnPressedState.IconLeftImage = null;
            this.btnIcecekler.OnPressedState.IconRightImage = null;
            this.btnIcecekler.Size = new System.Drawing.Size(246, 65);
            this.btnIcecekler.TabIndex = 3;
            this.btnIcecekler.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnIcecekler.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnIcecekler.TextMarginLeft = 0;
            this.btnIcecekler.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnIcecekler.UseDefaultRadiusAndThickness = true;
            // 
            // btnSalatalar
            // 
            this.btnSalatalar.AllowAnimations = true;
            this.btnSalatalar.AllowMouseEffects = true;
            this.btnSalatalar.AllowToggling = false;
            this.btnSalatalar.AnimationSpeed = 200;
            this.btnSalatalar.AutoGenerateColors = false;
            this.btnSalatalar.AutoRoundBorders = false;
            this.btnSalatalar.AutoSizeLeftIcon = true;
            this.btnSalatalar.AutoSizeRightIcon = true;
            this.btnSalatalar.BackColor = System.Drawing.Color.Transparent;
            this.btnSalatalar.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(166)))), ((int)(((byte)(0)))));
            this.btnSalatalar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSalatalar.BackgroundImage")));
            this.btnSalatalar.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSalatalar.ButtonText = "Salatalar";
            this.btnSalatalar.ButtonTextMarginLeft = 0;
            this.btnSalatalar.ColorContrastOnClick = 45;
            this.btnSalatalar.ColorContrastOnHover = 45;
            this.btnSalatalar.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.btnSalatalar.CustomizableEdges = borderEdges3;
            this.btnSalatalar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSalatalar.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnSalatalar.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnSalatalar.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnSalatalar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSalatalar.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnSalatalar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSalatalar.ForeColor = System.Drawing.Color.White;
            this.btnSalatalar.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalatalar.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnSalatalar.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnSalatalar.IconMarginLeft = 11;
            this.btnSalatalar.IconPadding = 10;
            this.btnSalatalar.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalatalar.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnSalatalar.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnSalatalar.IconSize = 25;
            this.btnSalatalar.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btnSalatalar.IdleBorderRadius = 1;
            this.btnSalatalar.IdleBorderThickness = 1;
            this.btnSalatalar.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(166)))), ((int)(((byte)(0)))));
            this.btnSalatalar.IdleIconLeftImage = null;
            this.btnSalatalar.IdleIconRightImage = null;
            this.btnSalatalar.IndicateFocus = false;
            this.btnSalatalar.Location = new System.Drawing.Point(0, 65);
            this.btnSalatalar.Name = "btnSalatalar";
            this.btnSalatalar.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnSalatalar.OnDisabledState.BorderRadius = 1;
            this.btnSalatalar.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSalatalar.OnDisabledState.BorderThickness = 1;
            this.btnSalatalar.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnSalatalar.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnSalatalar.OnDisabledState.IconLeftImage = null;
            this.btnSalatalar.OnDisabledState.IconRightImage = null;
            this.btnSalatalar.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnSalatalar.onHoverState.BorderRadius = 1;
            this.btnSalatalar.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSalatalar.onHoverState.BorderThickness = 1;
            this.btnSalatalar.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnSalatalar.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnSalatalar.onHoverState.IconLeftImage = null;
            this.btnSalatalar.onHoverState.IconRightImage = null;
            this.btnSalatalar.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnSalatalar.OnIdleState.BorderRadius = 1;
            this.btnSalatalar.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSalatalar.OnIdleState.BorderThickness = 1;
            this.btnSalatalar.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(166)))), ((int)(((byte)(0)))));
            this.btnSalatalar.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnSalatalar.OnIdleState.IconLeftImage = null;
            this.btnSalatalar.OnIdleState.IconRightImage = null;
            this.btnSalatalar.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnSalatalar.OnPressedState.BorderRadius = 1;
            this.btnSalatalar.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSalatalar.OnPressedState.BorderThickness = 1;
            this.btnSalatalar.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnSalatalar.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnSalatalar.OnPressedState.IconLeftImage = null;
            this.btnSalatalar.OnPressedState.IconRightImage = null;
            this.btnSalatalar.Size = new System.Drawing.Size(246, 65);
            this.btnSalatalar.TabIndex = 2;
            this.btnSalatalar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSalatalar.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSalatalar.TextMarginLeft = 0;
            this.btnSalatalar.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnSalatalar.UseDefaultRadiusAndThickness = true;
            // 
            // btnTatlilar
            // 
            this.btnTatlilar.AllowAnimations = true;
            this.btnTatlilar.AllowMouseEffects = true;
            this.btnTatlilar.AllowToggling = false;
            this.btnTatlilar.AnimationSpeed = 200;
            this.btnTatlilar.AutoGenerateColors = false;
            this.btnTatlilar.AutoRoundBorders = false;
            this.btnTatlilar.AutoSizeLeftIcon = true;
            this.btnTatlilar.AutoSizeRightIcon = true;
            this.btnTatlilar.BackColor = System.Drawing.Color.Transparent;
            this.btnTatlilar.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(166)))), ((int)(((byte)(0)))));
            this.btnTatlilar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTatlilar.BackgroundImage")));
            this.btnTatlilar.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnTatlilar.ButtonText = "Tatlılar";
            this.btnTatlilar.ButtonTextMarginLeft = 0;
            this.btnTatlilar.ColorContrastOnClick = 45;
            this.btnTatlilar.ColorContrastOnHover = 45;
            this.btnTatlilar.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges4.BottomLeft = true;
            borderEdges4.BottomRight = true;
            borderEdges4.TopLeft = true;
            borderEdges4.TopRight = true;
            this.btnTatlilar.CustomizableEdges = borderEdges4;
            this.btnTatlilar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnTatlilar.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnTatlilar.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnTatlilar.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnTatlilar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTatlilar.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnTatlilar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTatlilar.ForeColor = System.Drawing.Color.White;
            this.btnTatlilar.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTatlilar.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnTatlilar.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnTatlilar.IconMarginLeft = 11;
            this.btnTatlilar.IconPadding = 10;
            this.btnTatlilar.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTatlilar.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnTatlilar.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnTatlilar.IconSize = 25;
            this.btnTatlilar.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btnTatlilar.IdleBorderRadius = 1;
            this.btnTatlilar.IdleBorderThickness = 1;
            this.btnTatlilar.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(166)))), ((int)(((byte)(0)))));
            this.btnTatlilar.IdleIconLeftImage = null;
            this.btnTatlilar.IdleIconRightImage = null;
            this.btnTatlilar.IndicateFocus = false;
            this.btnTatlilar.Location = new System.Drawing.Point(0, 0);
            this.btnTatlilar.Name = "btnTatlilar";
            this.btnTatlilar.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnTatlilar.OnDisabledState.BorderRadius = 1;
            this.btnTatlilar.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnTatlilar.OnDisabledState.BorderThickness = 1;
            this.btnTatlilar.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnTatlilar.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnTatlilar.OnDisabledState.IconLeftImage = null;
            this.btnTatlilar.OnDisabledState.IconRightImage = null;
            this.btnTatlilar.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnTatlilar.onHoverState.BorderRadius = 1;
            this.btnTatlilar.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnTatlilar.onHoverState.BorderThickness = 1;
            this.btnTatlilar.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnTatlilar.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnTatlilar.onHoverState.IconLeftImage = null;
            this.btnTatlilar.onHoverState.IconRightImage = null;
            this.btnTatlilar.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnTatlilar.OnIdleState.BorderRadius = 1;
            this.btnTatlilar.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnTatlilar.OnIdleState.BorderThickness = 1;
            this.btnTatlilar.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(166)))), ((int)(((byte)(0)))));
            this.btnTatlilar.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnTatlilar.OnIdleState.IconLeftImage = null;
            this.btnTatlilar.OnIdleState.IconRightImage = null;
            this.btnTatlilar.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnTatlilar.OnPressedState.BorderRadius = 1;
            this.btnTatlilar.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnTatlilar.OnPressedState.BorderThickness = 1;
            this.btnTatlilar.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnTatlilar.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnTatlilar.OnPressedState.IconLeftImage = null;
            this.btnTatlilar.OnPressedState.IconRightImage = null;
            this.btnTatlilar.Size = new System.Drawing.Size(246, 65);
            this.btnTatlilar.TabIndex = 1;
            this.btnTatlilar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnTatlilar.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnTatlilar.TextMarginLeft = 0;
            this.btnTatlilar.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnTatlilar.UseDefaultRadiusAndThickness = true;
            this.btnTatlilar.Click += new System.EventHandler(this.btnTatlilar_Click);
            // 
            // btnLoginEkraniGecis
            // 
            this.btnLoginEkraniGecis.AllowAnimations = true;
            this.btnLoginEkraniGecis.AllowMouseEffects = true;
            this.btnLoginEkraniGecis.AllowToggling = false;
            this.btnLoginEkraniGecis.AnimationSpeed = 200;
            this.btnLoginEkraniGecis.AutoGenerateColors = false;
            this.btnLoginEkraniGecis.AutoRoundBorders = false;
            this.btnLoginEkraniGecis.AutoSizeLeftIcon = true;
            this.btnLoginEkraniGecis.AutoSizeRightIcon = true;
            this.btnLoginEkraniGecis.BackColor = System.Drawing.Color.Transparent;
            this.btnLoginEkraniGecis.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.btnLoginEkraniGecis.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLoginEkraniGecis.BackgroundImage")));
            this.btnLoginEkraniGecis.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnLoginEkraniGecis.ButtonText = "Hesptan Çıkış Yap";
            this.btnLoginEkraniGecis.ButtonTextMarginLeft = 0;
            this.btnLoginEkraniGecis.ColorContrastOnClick = 45;
            this.btnLoginEkraniGecis.ColorContrastOnHover = 45;
            this.btnLoginEkraniGecis.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges5.BottomLeft = true;
            borderEdges5.BottomRight = true;
            borderEdges5.TopLeft = true;
            borderEdges5.TopRight = true;
            this.btnLoginEkraniGecis.CustomizableEdges = borderEdges5;
            this.btnLoginEkraniGecis.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnLoginEkraniGecis.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnLoginEkraniGecis.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnLoginEkraniGecis.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnLoginEkraniGecis.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLoginEkraniGecis.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnLoginEkraniGecis.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLoginEkraniGecis.ForeColor = System.Drawing.Color.White;
            this.btnLoginEkraniGecis.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoginEkraniGecis.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnLoginEkraniGecis.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnLoginEkraniGecis.IconMarginLeft = 11;
            this.btnLoginEkraniGecis.IconPadding = 10;
            this.btnLoginEkraniGecis.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLoginEkraniGecis.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnLoginEkraniGecis.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnLoginEkraniGecis.IconSize = 25;
            this.btnLoginEkraniGecis.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btnLoginEkraniGecis.IdleBorderRadius = 1;
            this.btnLoginEkraniGecis.IdleBorderThickness = 1;
            this.btnLoginEkraniGecis.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.btnLoginEkraniGecis.IdleIconLeftImage = null;
            this.btnLoginEkraniGecis.IdleIconRightImage = null;
            this.btnLoginEkraniGecis.IndicateFocus = false;
            this.btnLoginEkraniGecis.Location = new System.Drawing.Point(0, 437);
            this.btnLoginEkraniGecis.Name = "btnLoginEkraniGecis";
            this.btnLoginEkraniGecis.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnLoginEkraniGecis.OnDisabledState.BorderRadius = 1;
            this.btnLoginEkraniGecis.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnLoginEkraniGecis.OnDisabledState.BorderThickness = 1;
            this.btnLoginEkraniGecis.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnLoginEkraniGecis.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnLoginEkraniGecis.OnDisabledState.IconLeftImage = null;
            this.btnLoginEkraniGecis.OnDisabledState.IconRightImage = null;
            this.btnLoginEkraniGecis.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnLoginEkraniGecis.onHoverState.BorderRadius = 1;
            this.btnLoginEkraniGecis.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnLoginEkraniGecis.onHoverState.BorderThickness = 1;
            this.btnLoginEkraniGecis.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnLoginEkraniGecis.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnLoginEkraniGecis.onHoverState.IconLeftImage = null;
            this.btnLoginEkraniGecis.onHoverState.IconRightImage = null;
            this.btnLoginEkraniGecis.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnLoginEkraniGecis.OnIdleState.BorderRadius = 1;
            this.btnLoginEkraniGecis.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnLoginEkraniGecis.OnIdleState.BorderThickness = 1;
            this.btnLoginEkraniGecis.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnLoginEkraniGecis.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnLoginEkraniGecis.OnIdleState.IconLeftImage = null;
            this.btnLoginEkraniGecis.OnIdleState.IconRightImage = null;
            this.btnLoginEkraniGecis.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnLoginEkraniGecis.OnPressedState.BorderRadius = 1;
            this.btnLoginEkraniGecis.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnLoginEkraniGecis.OnPressedState.BorderThickness = 1;
            this.btnLoginEkraniGecis.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnLoginEkraniGecis.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnLoginEkraniGecis.OnPressedState.IconLeftImage = null;
            this.btnLoginEkraniGecis.OnPressedState.IconRightImage = null;
            this.btnLoginEkraniGecis.Size = new System.Drawing.Size(246, 65);
            this.btnLoginEkraniGecis.TabIndex = 0;
            this.btnLoginEkraniGecis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLoginEkraniGecis.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnLoginEkraniGecis.TextMarginLeft = 0;
            this.btnLoginEkraniGecis.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnLoginEkraniGecis.UseDefaultRadiusAndThickness = true;
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
            this.pnlPersonelInformation.Controls.Add(this.pbUserLogo);
            this.pnlPersonelInformation.Controls.Add(this.lblPeronalInformation);
            this.pnlPersonelInformation.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPersonelInformation.Location = new System.Drawing.Point(0, 0);
            this.pnlPersonelInformation.Name = "pnlPersonelInformation";
            this.pnlPersonelInformation.ShowBorders = true;
            this.pnlPersonelInformation.Size = new System.Drawing.Size(246, 231);
            this.pnlPersonelInformation.TabIndex = 0;
            // 
            // pbUserLogo
            // 
            this.pbUserLogo.AllowFocused = false;
            this.pbUserLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbUserLogo.AutoSizeHeight = true;
            this.pbUserLogo.BorderRadius = 73;
            this.pbUserLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbUserLogo.Image")));
            this.pbUserLogo.IsCircle = true;
            this.pbUserLogo.Location = new System.Drawing.Point(50, 24);
            this.pbUserLogo.Name = "pbUserLogo";
            this.pbUserLogo.Size = new System.Drawing.Size(147, 147);
            this.pbUserLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbUserLogo.TabIndex = 1;
            this.pbUserLogo.TabStop = false;
            this.pbUserLogo.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
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
            this.Name = "PageAdminMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PageAdminMain";
            this.Load += new System.EventHandler(this.PageAdminMain_Load);
            this.pnlHeadBar.ResumeLayout(false);
            this.pnlMenu.ResumeLayout(false);
            this.pnlButtons.ResumeLayout(false);
            this.pnlPersonelInformation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbUserLogo)).EndInit();
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
        private Bunifu.UI.WinForms.BunifuPictureBox pbUserLogo;
        private Bunifu.UI.WinForms.BunifuLabel lblPeronalInformation;
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator1;
        private Bunifu.UI.WinForms.BunifuPanel pnlButtons;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnLoginEkraniGecis;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnYemekler;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnIcecekler;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnSalatalar;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnTatlilar;
        private Bunifu.UI.WinForms.BunifuLabel lblYonetimBar;
        private Bunifu.Framework.UI.BunifuDragControl dragBar;
        private Bunifu.UI.WinForms.BunifuPanel pnlTopColorBar;
    }
}