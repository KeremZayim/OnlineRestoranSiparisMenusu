namespace RestoranMenu.Forms
{
    partial class PageLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PageLogin));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuToggleSwitch.ToggleState toggleState1 = new Bunifu.UI.WinForms.BunifuToggleSwitch.ToggleState();
            Bunifu.UI.WinForms.BunifuToggleSwitch.ToggleState toggleState2 = new Bunifu.UI.WinForms.BunifuToggleSwitch.ToggleState();
            Bunifu.UI.WinForms.BunifuToggleSwitch.ToggleState toggleState3 = new Bunifu.UI.WinForms.BunifuToggleSwitch.ToggleState();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.EllipseForm = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.dragPanelLogin = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.dragPanelImage = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.pnlMain = new System.Windows.Forms.Panel();
            this.btnGirisYap = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.tbSifre = new Bunifu.UI.WinForms.BunifuTextBox();
            this.lblRememberMe = new Bunifu.UI.WinForms.BunifuLabel();
            this.tbKullaniciAdi = new Bunifu.UI.WinForms.BunifuTextBox();
            this.switchBeniHatirla = new Bunifu.UI.WinForms.BunifuToggleSwitch();
            this.btnExit = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.pbLogo = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.dragLogo = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // EllipseForm
            // 
            this.EllipseForm.ElipseRadius = 10;
            this.EllipseForm.TargetControl = this;
            // 
            // dragPanelLogin
            // 
            this.dragPanelLogin.Fixed = true;
            this.dragPanelLogin.Horizontal = true;
            this.dragPanelLogin.TargetControl = null;
            this.dragPanelLogin.Vertical = true;
            // 
            // dragPanelImage
            // 
            this.dragPanelImage.Fixed = true;
            this.dragPanelImage.Horizontal = true;
            this.dragPanelImage.TargetControl = this.pnlMain;
            this.dragPanelImage.Vertical = true;
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.Transparent;
            this.pnlMain.BackgroundImage = global::RestoranMenu.Properties.Resources.login_bg;
            this.pnlMain.Controls.Add(this.btnGirisYap);
            this.pnlMain.Controls.Add(this.tbSifre);
            this.pnlMain.Controls.Add(this.lblRememberMe);
            this.pnlMain.Controls.Add(this.tbKullaniciAdi);
            this.pnlMain.Controls.Add(this.switchBeniHatirla);
            this.pnlMain.Controls.Add(this.btnExit);
            this.pnlMain.Controls.Add(this.pbLogo);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1000, 600);
            this.pnlMain.TabIndex = 6;
            // 
            // btnGirisYap
            // 
            this.btnGirisYap.AllowAnimations = true;
            this.btnGirisYap.AllowMouseEffects = true;
            this.btnGirisYap.AllowToggling = false;
            this.btnGirisYap.AnimationSpeed = 200;
            this.btnGirisYap.AutoGenerateColors = false;
            this.btnGirisYap.AutoRoundBorders = false;
            this.btnGirisYap.AutoSizeLeftIcon = true;
            this.btnGirisYap.AutoSizeRightIcon = true;
            this.btnGirisYap.BackColor = System.Drawing.Color.Transparent;
            this.btnGirisYap.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.btnGirisYap.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGirisYap.BackgroundImage")));
            this.btnGirisYap.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnGirisYap.ButtonText = "Giriş Yap";
            this.btnGirisYap.ButtonTextMarginLeft = 0;
            this.btnGirisYap.ColorContrastOnClick = 45;
            this.btnGirisYap.ColorContrastOnHover = 45;
            this.btnGirisYap.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnGirisYap.CustomizableEdges = borderEdges1;
            this.btnGirisYap.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnGirisYap.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnGirisYap.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnGirisYap.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnGirisYap.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnGirisYap.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGirisYap.ForeColor = System.Drawing.Color.White;
            this.btnGirisYap.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGirisYap.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnGirisYap.IconLeftPadding = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.btnGirisYap.IconMarginLeft = 11;
            this.btnGirisYap.IconPadding = 8;
            this.btnGirisYap.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGirisYap.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnGirisYap.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnGirisYap.IconSize = 25;
            this.btnGirisYap.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnGirisYap.IdleBorderRadius = 30;
            this.btnGirisYap.IdleBorderThickness = 1;
            this.btnGirisYap.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.btnGirisYap.IdleIconLeftImage = ((System.Drawing.Image)(resources.GetObject("btnGirisYap.IdleIconLeftImage")));
            this.btnGirisYap.IdleIconRightImage = null;
            this.btnGirisYap.IndicateFocus = false;
            this.btnGirisYap.Location = new System.Drawing.Point(425, 480);
            this.btnGirisYap.Name = "btnGirisYap";
            this.btnGirisYap.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnGirisYap.OnDisabledState.BorderRadius = 30;
            this.btnGirisYap.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnGirisYap.OnDisabledState.BorderThickness = 1;
            this.btnGirisYap.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnGirisYap.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnGirisYap.OnDisabledState.IconLeftImage = null;
            this.btnGirisYap.OnDisabledState.IconRightImage = null;
            this.btnGirisYap.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnGirisYap.onHoverState.BorderRadius = 30;
            this.btnGirisYap.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnGirisYap.onHoverState.BorderThickness = 1;
            this.btnGirisYap.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnGirisYap.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnGirisYap.onHoverState.IconLeftImage = null;
            this.btnGirisYap.onHoverState.IconRightImage = null;
            this.btnGirisYap.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnGirisYap.OnIdleState.BorderRadius = 30;
            this.btnGirisYap.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnGirisYap.OnIdleState.BorderThickness = 1;
            this.btnGirisYap.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnGirisYap.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnGirisYap.OnIdleState.IconLeftImage = ((System.Drawing.Image)(resources.GetObject("btnGirisYap.OnIdleState.IconLeftImage")));
            this.btnGirisYap.OnIdleState.IconRightImage = null;
            this.btnGirisYap.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnGirisYap.OnPressedState.BorderRadius = 30;
            this.btnGirisYap.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnGirisYap.OnPressedState.BorderThickness = 1;
            this.btnGirisYap.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnGirisYap.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnGirisYap.OnPressedState.IconLeftImage = null;
            this.btnGirisYap.OnPressedState.IconRightImage = null;
            this.btnGirisYap.Size = new System.Drawing.Size(150, 39);
            this.btnGirisYap.TabIndex = 4;
            this.btnGirisYap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGirisYap.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnGirisYap.TextMarginLeft = 0;
            this.btnGirisYap.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnGirisYap.UseDefaultRadiusAndThickness = true;
            this.btnGirisYap.Click += new System.EventHandler(this.btnGirisYap_Click);
            // 
            // tbSifre
            // 
            this.tbSifre.AcceptsReturn = false;
            this.tbSifre.AcceptsTab = false;
            this.tbSifre.AnimationSpeed = 200;
            this.tbSifre.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tbSifre.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tbSifre.BackColor = System.Drawing.Color.Transparent;
            this.tbSifre.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbSifre.BackgroundImage")));
            this.tbSifre.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.tbSifre.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.tbSifre.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.tbSifre.BorderColorIdle = System.Drawing.Color.Silver;
            this.tbSifre.BorderRadius = 30;
            this.tbSifre.BorderThickness = 1;
            this.tbSifre.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbSifre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbSifre.DefaultFont = new System.Drawing.Font("Century Gothic", 9F);
            this.tbSifre.DefaultText = "";
            this.tbSifre.FillColor = System.Drawing.Color.WhiteSmoke;
            this.tbSifre.HideSelection = true;
            this.tbSifre.IconLeft = global::RestoranMenu.Properties.Resources.Password;
            this.tbSifre.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.tbSifre.IconPadding = 1;
            this.tbSifre.IconRight = ((System.Drawing.Image)(resources.GetObject("tbSifre.IconRight")));
            this.tbSifre.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.tbSifre.Lines = new string[0];
            this.tbSifre.Location = new System.Drawing.Point(370, 394);
            this.tbSifre.MaxLength = 32767;
            this.tbSifre.MinimumSize = new System.Drawing.Size(1, 1);
            this.tbSifre.Modified = false;
            this.tbSifre.Multiline = false;
            this.tbSifre.Name = "tbSifre";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.tbSifre.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.tbSifre.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.tbSifre.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.WhiteSmoke;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.tbSifre.OnIdleState = stateProperties4;
            this.tbSifre.Padding = new System.Windows.Forms.Padding(3);
            this.tbSifre.PasswordChar = '\0';
            this.tbSifre.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.tbSifre.PlaceholderText = "Şifre";
            this.tbSifre.ReadOnly = false;
            this.tbSifre.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbSifre.SelectedText = "";
            this.tbSifre.SelectionLength = 0;
            this.tbSifre.SelectionStart = 0;
            this.tbSifre.ShortcutsEnabled = true;
            this.tbSifre.Size = new System.Drawing.Size(260, 35);
            this.tbSifre.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.tbSifre.TabIndex = 1;
            this.tbSifre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbSifre.TextMarginBottom = 0;
            this.tbSifre.TextMarginLeft = 5;
            this.tbSifre.TextMarginTop = 0;
            this.tbSifre.TextPlaceholder = "Şifre";
            this.tbSifre.UseSystemPasswordChar = false;
            this.tbSifre.WordWrap = true;
            // 
            // lblRememberMe
            // 
            this.lblRememberMe.AllowParentOverrides = false;
            this.lblRememberMe.AutoEllipsis = false;
            this.lblRememberMe.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblRememberMe.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblRememberMe.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRememberMe.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblRememberMe.Location = new System.Drawing.Point(525, 439);
            this.lblRememberMe.Name = "lblRememberMe";
            this.lblRememberMe.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblRememberMe.Size = new System.Drawing.Size(67, 17);
            this.lblRememberMe.TabIndex = 5;
            this.lblRememberMe.Text = "Beni Hatırla";
            this.lblRememberMe.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblRememberMe.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // tbKullaniciAdi
            // 
            this.tbKullaniciAdi.AcceptsReturn = false;
            this.tbKullaniciAdi.AcceptsTab = false;
            this.tbKullaniciAdi.AnimationSpeed = 200;
            this.tbKullaniciAdi.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tbKullaniciAdi.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tbKullaniciAdi.BackColor = System.Drawing.Color.Transparent;
            this.tbKullaniciAdi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbKullaniciAdi.BackgroundImage")));
            this.tbKullaniciAdi.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.tbKullaniciAdi.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.tbKullaniciAdi.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.tbKullaniciAdi.BorderColorIdle = System.Drawing.Color.Silver;
            this.tbKullaniciAdi.BorderRadius = 30;
            this.tbKullaniciAdi.BorderThickness = 1;
            this.tbKullaniciAdi.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbKullaniciAdi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbKullaniciAdi.DefaultFont = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbKullaniciAdi.DefaultText = "";
            this.tbKullaniciAdi.FillColor = System.Drawing.Color.WhiteSmoke;
            this.tbKullaniciAdi.HideSelection = true;
            this.tbKullaniciAdi.IconLeft = global::RestoranMenu.Properties.Resources.Username;
            this.tbKullaniciAdi.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.tbKullaniciAdi.IconPadding = 2;
            this.tbKullaniciAdi.IconRight = null;
            this.tbKullaniciAdi.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.tbKullaniciAdi.Lines = new string[0];
            this.tbKullaniciAdi.Location = new System.Drawing.Point(370, 351);
            this.tbKullaniciAdi.MaxLength = 32767;
            this.tbKullaniciAdi.MinimumSize = new System.Drawing.Size(1, 1);
            this.tbKullaniciAdi.Modified = false;
            this.tbKullaniciAdi.Multiline = false;
            this.tbKullaniciAdi.Name = "tbKullaniciAdi";
            stateProperties5.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.tbKullaniciAdi.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.tbKullaniciAdi.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.tbKullaniciAdi.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Silver;
            stateProperties8.FillColor = System.Drawing.Color.WhiteSmoke;
            stateProperties8.ForeColor = System.Drawing.Color.Empty;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.tbKullaniciAdi.OnIdleState = stateProperties8;
            this.tbKullaniciAdi.Padding = new System.Windows.Forms.Padding(3);
            this.tbKullaniciAdi.PasswordChar = '\0';
            this.tbKullaniciAdi.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.tbKullaniciAdi.PlaceholderText = "Kullanıcı Adı";
            this.tbKullaniciAdi.ReadOnly = false;
            this.tbKullaniciAdi.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbKullaniciAdi.SelectedText = "";
            this.tbKullaniciAdi.SelectionLength = 0;
            this.tbKullaniciAdi.SelectionStart = 0;
            this.tbKullaniciAdi.ShortcutsEnabled = true;
            this.tbKullaniciAdi.Size = new System.Drawing.Size(260, 35);
            this.tbKullaniciAdi.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.tbKullaniciAdi.TabIndex = 0;
            this.tbKullaniciAdi.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbKullaniciAdi.TextMarginBottom = 0;
            this.tbKullaniciAdi.TextMarginLeft = 5;
            this.tbKullaniciAdi.TextMarginTop = 0;
            this.tbKullaniciAdi.TextPlaceholder = "Kullanıcı Adı";
            this.tbKullaniciAdi.UseSystemPasswordChar = false;
            this.tbKullaniciAdi.WordWrap = true;
            // 
            // switchBeniHatirla
            // 
            this.switchBeniHatirla.Animation = 5;
            this.switchBeniHatirla.BackColor = System.Drawing.Color.Transparent;
            this.switchBeniHatirla.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("switchBeniHatirla.BackgroundImage")));
            this.switchBeniHatirla.Checked = true;
            this.switchBeniHatirla.Cursor = System.Windows.Forms.Cursors.Hand;
            this.switchBeniHatirla.InnerCirclePadding = 3;
            this.switchBeniHatirla.Location = new System.Drawing.Point(595, 437);
            this.switchBeniHatirla.Name = "switchBeniHatirla";
            this.switchBeniHatirla.Size = new System.Drawing.Size(32, 18);
            this.switchBeniHatirla.TabIndex = 3;
            this.switchBeniHatirla.ThumbMargin = 3;
            toggleState1.BackColor = System.Drawing.Color.DarkGray;
            toggleState1.BackColorInner = System.Drawing.Color.White;
            toggleState1.BorderColor = System.Drawing.Color.DarkGray;
            toggleState1.BorderColorInner = System.Drawing.Color.White;
            toggleState1.BorderRadius = 17;
            toggleState1.BorderRadiusInner = 11;
            toggleState1.BorderThickness = 1;
            toggleState1.BorderThicknessInner = 1;
            this.switchBeniHatirla.ToggleStateDisabled = toggleState1;
            toggleState2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            toggleState2.BackColorInner = System.Drawing.Color.White;
            toggleState2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            toggleState2.BorderColorInner = System.Drawing.Color.White;
            toggleState2.BorderRadius = 17;
            toggleState2.BorderRadiusInner = 11;
            toggleState2.BorderThickness = 1;
            toggleState2.BorderThicknessInner = 1;
            this.switchBeniHatirla.ToggleStateOff = toggleState2;
            toggleState3.BackColor = System.Drawing.Color.DodgerBlue;
            toggleState3.BackColorInner = System.Drawing.Color.White;
            toggleState3.BorderColor = System.Drawing.Color.DodgerBlue;
            toggleState3.BorderColorInner = System.Drawing.Color.White;
            toggleState3.BorderRadius = 17;
            toggleState3.BorderRadiusInner = 11;
            toggleState3.BorderThickness = 1;
            toggleState3.BorderThicknessInner = 1;
            this.switchBeniHatirla.ToggleStateOn = toggleState3;
            this.switchBeniHatirla.Value = true;
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
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnExit.CustomizableEdges = borderEdges2;
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
            this.btnExit.Location = new System.Drawing.Point(950, 0);
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
            this.btnExit.TabIndex = 4;
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnExit.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnExit.TextMarginLeft = 0;
            this.btnExit.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnExit.UseDefaultRadiusAndThickness = true;
            this.btnExit.Click += new System.EventHandler(this.ExitApplication);
            this.btnExit.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ExitButtonFocusFix);
            // 
            // pbLogo
            // 
            this.pbLogo.AllowFocused = false;
            this.pbLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbLogo.AutoSizeHeight = true;
            this.pbLogo.BorderRadius = 100;
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.IsCircle = false;
            this.pbLogo.Location = new System.Drawing.Point(400, 73);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(200, 200);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 3;
            this.pbLogo.TabStop = false;
            this.pbLogo.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // dragLogo
            // 
            this.dragLogo.Fixed = true;
            this.dragLogo.Horizontal = true;
            this.dragLogo.TargetControl = this.pbLogo;
            this.dragLogo.Vertical = true;
            // 
            // PageLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.pnlMain);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PageLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PageLogin";
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.UI.WinForms.BunifuTextBox tbSifre;
        private Bunifu.UI.WinForms.BunifuTextBox tbKullaniciAdi;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnGirisYap;
        private Bunifu.Framework.UI.BunifuElipse EllipseForm;
        private Bunifu.UI.WinForms.BunifuPictureBox pbLogo;
        private Bunifu.Framework.UI.BunifuDragControl dragPanelLogin;
        private Bunifu.Framework.UI.BunifuDragControl dragPanelImage;
        private Bunifu.Framework.UI.BunifuDragControl dragLogo;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnExit;
        private Bunifu.UI.WinForms.BunifuToggleSwitch switchBeniHatirla;
        private Bunifu.UI.WinForms.BunifuLabel lblRememberMe;
        private System.Windows.Forms.Panel pnlMain;
    }
}