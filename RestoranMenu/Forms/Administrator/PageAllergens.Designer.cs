namespace RestoranMenu.Forms.Administrator
{
    partial class PageAllergens
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PageAllergens));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.dgvAllergens = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.pnlBaslik = new Bunifu.UI.WinForms.BunifuGradientPanel();
            this.lblAlerjenler = new System.Windows.Forms.Label();
            this.bunifuShadowPanel1 = new Bunifu.UI.WinForms.BunifuShadowPanel();
            this.gbAlerjenEkle = new Bunifu.UI.WinForms.BunifuGroupBox();
            this.lblAlerjenAdi = new Bunifu.UI.WinForms.BunifuLabel();
            this.btnAlerjenEkle = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.tbAlerjenAdi = new Bunifu.UI.WinForms.BunifuTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllergens)).BeginInit();
            this.pnlBaslik.SuspendLayout();
            this.bunifuShadowPanel1.SuspendLayout();
            this.gbAlerjenEkle.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAllergens
            // 
            this.dgvAllergens.AllowCustomTheming = false;
            this.dgvAllergens.AllowUserToAddRows = false;
            this.dgvAllergens.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvAllergens.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAllergens.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAllergens.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAllergens.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvAllergens.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAllergens.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAllergens.ColumnHeadersHeight = 40;
            this.dgvAllergens.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dgvAllergens.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvAllergens.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvAllergens.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgvAllergens.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvAllergens.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dgvAllergens.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgvAllergens.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.dgvAllergens.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dgvAllergens.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvAllergens.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.dgvAllergens.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvAllergens.CurrentTheme.Name = null;
            this.dgvAllergens.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvAllergens.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvAllergens.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvAllergens.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgvAllergens.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAllergens.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAllergens.EnableHeadersVisualStyles = false;
            this.dgvAllergens.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgvAllergens.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.dgvAllergens.HeaderBgColor = System.Drawing.Color.Empty;
            this.dgvAllergens.HeaderForeColor = System.Drawing.Color.White;
            this.dgvAllergens.Location = new System.Drawing.Point(509, 93);
            this.dgvAllergens.Name = "dgvAllergens";
            this.dgvAllergens.RowHeadersVisible = false;
            this.dgvAllergens.RowTemplate.Height = 40;
            this.dgvAllergens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAllergens.Size = new System.Drawing.Size(430, 543);
            this.dgvAllergens.TabIndex = 0;
            this.dgvAllergens.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.dgvAllergens.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAllergens_CellContentClick);
            // 
            // pnlBaslik
            // 
            this.pnlBaslik.BackColor = System.Drawing.Color.Transparent;
            this.pnlBaslik.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlBaslik.BackgroundImage")));
            this.pnlBaslik.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlBaslik.BorderRadius = 10;
            this.pnlBaslik.Controls.Add(this.lblAlerjenler);
            this.pnlBaslik.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBaslik.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(95)))), ((int)(((byte)(239)))));
            this.pnlBaslik.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(30)))), ((int)(((byte)(42)))));
            this.pnlBaslik.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(225)))), ((int)(((byte)(243)))));
            this.pnlBaslik.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(88)))), ((int)(((byte)(190)))));
            this.pnlBaslik.Location = new System.Drawing.Point(0, 0);
            this.pnlBaslik.Name = "pnlBaslik";
            this.pnlBaslik.Quality = 10;
            this.pnlBaslik.Size = new System.Drawing.Size(978, 71);
            this.pnlBaslik.TabIndex = 11;
            // 
            // lblAlerjenler
            // 
            this.lblAlerjenler.Font = new System.Drawing.Font("Century Gothic", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAlerjenler.Location = new System.Drawing.Point(0, 0);
            this.lblAlerjenler.Name = "lblAlerjenler";
            this.lblAlerjenler.Size = new System.Drawing.Size(218, 71);
            this.lblAlerjenler.TabIndex = 0;
            this.lblAlerjenler.Text = "Alerjenler";
            this.lblAlerjenler.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuShadowPanel1
            // 
            this.bunifuShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuShadowPanel1.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuShadowPanel1.BorderRadius = 1;
            this.bunifuShadowPanel1.BorderThickness = 1;
            this.bunifuShadowPanel1.Controls.Add(this.gbAlerjenEkle);
            this.bunifuShadowPanel1.Controls.Add(this.pnlBaslik);
            this.bunifuShadowPanel1.Controls.Add(this.dgvAllergens);
            this.bunifuShadowPanel1.FillStyle = Bunifu.UI.WinForms.BunifuShadowPanel.FillStyles.Solid;
            this.bunifuShadowPanel1.GradientMode = Bunifu.UI.WinForms.BunifuShadowPanel.GradientModes.Vertical;
            this.bunifuShadowPanel1.Location = new System.Drawing.Point(30, 31);
            this.bunifuShadowPanel1.Name = "bunifuShadowPanel1";
            this.bunifuShadowPanel1.PanelColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuShadowPanel1.PanelColor2 = System.Drawing.Color.WhiteSmoke;
            this.bunifuShadowPanel1.ShadowColor = System.Drawing.Color.DarkGray;
            this.bunifuShadowPanel1.ShadowDept = 2;
            this.bunifuShadowPanel1.ShadowDepth = 5;
            this.bunifuShadowPanel1.ShadowStyle = Bunifu.UI.WinForms.BunifuShadowPanel.ShadowStyles.Surrounded;
            this.bunifuShadowPanel1.ShadowTopLeftVisible = false;
            this.bunifuShadowPanel1.Size = new System.Drawing.Size(978, 671);
            this.bunifuShadowPanel1.Style = Bunifu.UI.WinForms.BunifuShadowPanel.BevelStyles.Flat;
            this.bunifuShadowPanel1.TabIndex = 12;
            // 
            // gbAlerjenEkle
            // 
            this.gbAlerjenEkle.BackColor = System.Drawing.Color.Gainsboro;
            this.gbAlerjenEkle.BorderColor = System.Drawing.Color.Silver;
            this.gbAlerjenEkle.BorderRadius = 1;
            this.gbAlerjenEkle.BorderThickness = 1;
            this.gbAlerjenEkle.Controls.Add(this.lblAlerjenAdi);
            this.gbAlerjenEkle.Controls.Add(this.btnAlerjenEkle);
            this.gbAlerjenEkle.Controls.Add(this.tbAlerjenAdi);
            this.gbAlerjenEkle.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbAlerjenEkle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gbAlerjenEkle.LabelAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gbAlerjenEkle.LabelIndent = 10;
            this.gbAlerjenEkle.LineStyle = Bunifu.UI.WinForms.BunifuGroupBox.LineStyles.Solid;
            this.gbAlerjenEkle.Location = new System.Drawing.Point(49, 133);
            this.gbAlerjenEkle.Name = "gbAlerjenEkle";
            this.gbAlerjenEkle.Size = new System.Drawing.Size(380, 287);
            this.gbAlerjenEkle.TabIndex = 15;
            this.gbAlerjenEkle.TabStop = false;
            this.gbAlerjenEkle.Text = "Alerjen Ekle";
            // 
            // lblAlerjenAdi
            // 
            this.lblAlerjenAdi.AllowParentOverrides = false;
            this.lblAlerjenAdi.AutoEllipsis = false;
            this.lblAlerjenAdi.AutoSize = false;
            this.lblAlerjenAdi.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblAlerjenAdi.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblAlerjenAdi.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.lblAlerjenAdi.Location = new System.Drawing.Point(60, 59);
            this.lblAlerjenAdi.Name = "lblAlerjenAdi";
            this.lblAlerjenAdi.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblAlerjenAdi.Size = new System.Drawing.Size(260, 28);
            this.lblAlerjenAdi.TabIndex = 13;
            this.lblAlerjenAdi.Text = "Alerjen Adı";
            this.lblAlerjenAdi.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblAlerjenAdi.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // btnAlerjenEkle
            // 
            this.btnAlerjenEkle.AllowAnimations = true;
            this.btnAlerjenEkle.AllowMouseEffects = true;
            this.btnAlerjenEkle.AllowToggling = false;
            this.btnAlerjenEkle.AnimationSpeed = 200;
            this.btnAlerjenEkle.AutoGenerateColors = false;
            this.btnAlerjenEkle.AutoRoundBorders = false;
            this.btnAlerjenEkle.AutoSizeLeftIcon = true;
            this.btnAlerjenEkle.AutoSizeRightIcon = true;
            this.btnAlerjenEkle.BackColor = System.Drawing.Color.Transparent;
            this.btnAlerjenEkle.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.btnAlerjenEkle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAlerjenEkle.BackgroundImage")));
            this.btnAlerjenEkle.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAlerjenEkle.ButtonText = "Alerjen Ekle";
            this.btnAlerjenEkle.ButtonTextMarginLeft = 0;
            this.btnAlerjenEkle.ColorContrastOnClick = 45;
            this.btnAlerjenEkle.ColorContrastOnHover = 45;
            this.btnAlerjenEkle.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = false;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = false;
            this.btnAlerjenEkle.CustomizableEdges = borderEdges1;
            this.btnAlerjenEkle.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAlerjenEkle.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAlerjenEkle.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnAlerjenEkle.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnAlerjenEkle.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnAlerjenEkle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAlerjenEkle.ForeColor = System.Drawing.Color.White;
            this.btnAlerjenEkle.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlerjenEkle.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnAlerjenEkle.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnAlerjenEkle.IconMarginLeft = 11;
            this.btnAlerjenEkle.IconPadding = 10;
            this.btnAlerjenEkle.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAlerjenEkle.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnAlerjenEkle.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnAlerjenEkle.IconSize = 25;
            this.btnAlerjenEkle.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btnAlerjenEkle.IdleBorderRadius = 20;
            this.btnAlerjenEkle.IdleBorderThickness = 1;
            this.btnAlerjenEkle.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.btnAlerjenEkle.IdleIconLeftImage = null;
            this.btnAlerjenEkle.IdleIconRightImage = null;
            this.btnAlerjenEkle.IndicateFocus = false;
            this.btnAlerjenEkle.Location = new System.Drawing.Point(106, 204);
            this.btnAlerjenEkle.Name = "btnAlerjenEkle";
            this.btnAlerjenEkle.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAlerjenEkle.OnDisabledState.BorderRadius = 20;
            this.btnAlerjenEkle.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAlerjenEkle.OnDisabledState.BorderThickness = 1;
            this.btnAlerjenEkle.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnAlerjenEkle.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnAlerjenEkle.OnDisabledState.IconLeftImage = null;
            this.btnAlerjenEkle.OnDisabledState.IconRightImage = null;
            this.btnAlerjenEkle.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnAlerjenEkle.onHoverState.BorderRadius = 20;
            this.btnAlerjenEkle.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAlerjenEkle.onHoverState.BorderThickness = 1;
            this.btnAlerjenEkle.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnAlerjenEkle.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnAlerjenEkle.onHoverState.IconLeftImage = null;
            this.btnAlerjenEkle.onHoverState.IconRightImage = null;
            this.btnAlerjenEkle.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnAlerjenEkle.OnIdleState.BorderRadius = 20;
            this.btnAlerjenEkle.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAlerjenEkle.OnIdleState.BorderThickness = 1;
            this.btnAlerjenEkle.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnAlerjenEkle.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnAlerjenEkle.OnIdleState.IconLeftImage = null;
            this.btnAlerjenEkle.OnIdleState.IconRightImage = null;
            this.btnAlerjenEkle.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnAlerjenEkle.OnPressedState.BorderRadius = 20;
            this.btnAlerjenEkle.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAlerjenEkle.OnPressedState.BorderThickness = 1;
            this.btnAlerjenEkle.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnAlerjenEkle.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnAlerjenEkle.OnPressedState.IconLeftImage = null;
            this.btnAlerjenEkle.OnPressedState.IconRightImage = null;
            this.btnAlerjenEkle.Size = new System.Drawing.Size(168, 47);
            this.btnAlerjenEkle.TabIndex = 14;
            this.btnAlerjenEkle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAlerjenEkle.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAlerjenEkle.TextMarginLeft = 0;
            this.btnAlerjenEkle.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnAlerjenEkle.UseDefaultRadiusAndThickness = true;
            this.btnAlerjenEkle.Click += new System.EventHandler(this.btnAlerjenEkle_Click);
            // 
            // tbAlerjenAdi
            // 
            this.tbAlerjenAdi.AcceptsReturn = false;
            this.tbAlerjenAdi.AcceptsTab = false;
            this.tbAlerjenAdi.AnimationSpeed = 200;
            this.tbAlerjenAdi.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tbAlerjenAdi.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tbAlerjenAdi.BackColor = System.Drawing.Color.Transparent;
            this.tbAlerjenAdi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbAlerjenAdi.BackgroundImage")));
            this.tbAlerjenAdi.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.tbAlerjenAdi.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.tbAlerjenAdi.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.tbAlerjenAdi.BorderColorIdle = System.Drawing.Color.Silver;
            this.tbAlerjenAdi.BorderRadius = 1;
            this.tbAlerjenAdi.BorderThickness = 1;
            this.tbAlerjenAdi.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbAlerjenAdi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbAlerjenAdi.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.tbAlerjenAdi.DefaultText = "";
            this.tbAlerjenAdi.FillColor = System.Drawing.Color.White;
            this.tbAlerjenAdi.HideSelection = true;
            this.tbAlerjenAdi.IconLeft = null;
            this.tbAlerjenAdi.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.tbAlerjenAdi.IconPadding = 10;
            this.tbAlerjenAdi.IconRight = null;
            this.tbAlerjenAdi.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.tbAlerjenAdi.Lines = new string[0];
            this.tbAlerjenAdi.Location = new System.Drawing.Point(60, 93);
            this.tbAlerjenAdi.MaxLength = 32767;
            this.tbAlerjenAdi.MinimumSize = new System.Drawing.Size(1, 1);
            this.tbAlerjenAdi.Modified = false;
            this.tbAlerjenAdi.Multiline = false;
            this.tbAlerjenAdi.Name = "tbAlerjenAdi";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.tbAlerjenAdi.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.tbAlerjenAdi.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.tbAlerjenAdi.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.tbAlerjenAdi.OnIdleState = stateProperties4;
            this.tbAlerjenAdi.Padding = new System.Windows.Forms.Padding(3);
            this.tbAlerjenAdi.PasswordChar = '\0';
            this.tbAlerjenAdi.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.tbAlerjenAdi.PlaceholderText = "Alerjen Adı";
            this.tbAlerjenAdi.ReadOnly = false;
            this.tbAlerjenAdi.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbAlerjenAdi.SelectedText = "";
            this.tbAlerjenAdi.SelectionLength = 0;
            this.tbAlerjenAdi.SelectionStart = 0;
            this.tbAlerjenAdi.ShortcutsEnabled = true;
            this.tbAlerjenAdi.Size = new System.Drawing.Size(260, 37);
            this.tbAlerjenAdi.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.tbAlerjenAdi.TabIndex = 12;
            this.tbAlerjenAdi.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbAlerjenAdi.TextMarginBottom = 0;
            this.tbAlerjenAdi.TextMarginLeft = 3;
            this.tbAlerjenAdi.TextMarginTop = 0;
            this.tbAlerjenAdi.TextPlaceholder = "Alerjen Adı";
            this.tbAlerjenAdi.UseSystemPasswordChar = false;
            this.tbAlerjenAdi.WordWrap = true;
            // 
            // PageAllergens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 737);
            this.Controls.Add(this.bunifuShadowPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PageAllergens";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yummy Day";
            this.Shown += new System.EventHandler(this.PageAllergens_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllergens)).EndInit();
            this.pnlBaslik.ResumeLayout(false);
            this.bunifuShadowPanel1.ResumeLayout(false);
            this.gbAlerjenEkle.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuDataGridView dgvAllergens;
        private Bunifu.UI.WinForms.BunifuGradientPanel pnlBaslik;
        private System.Windows.Forms.Label lblAlerjenler;
        private Bunifu.UI.WinForms.BunifuShadowPanel bunifuShadowPanel1;
        private Bunifu.UI.WinForms.BunifuLabel lblAlerjenAdi;
        private Bunifu.UI.WinForms.BunifuTextBox tbAlerjenAdi;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnAlerjenEkle;
        private Bunifu.UI.WinForms.BunifuGroupBox gbAlerjenEkle;
    }
}