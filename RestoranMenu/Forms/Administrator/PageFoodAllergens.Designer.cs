namespace RestoranMenu.Forms.Administrator
{
    partial class PageFoodAllergens
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
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PageFoodAllergens));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuShadowPanel1 = new Bunifu.UI.WinForms.BunifuShadowPanel();
            this.gbAddFoodAllergen = new Bunifu.UI.WinForms.BunifuGroupBox();
            this.lblFoodName = new Bunifu.UI.WinForms.BunifuLabel();
            this.btnGidaAlerjeniEkle = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.cbFoodName = new Bunifu.UI.WinForms.BunifuDropdown();
            this.cbAllergenName = new Bunifu.UI.WinForms.BunifuDropdown();
            this.lblAllergenName = new Bunifu.UI.WinForms.BunifuLabel();
            this.pnlBaslik = new Bunifu.UI.WinForms.BunifuGradientPanel();
            this.lblGidaAlerjenleri = new System.Windows.Forms.Label();
            this.dgvFoodAllergens = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.bunifuShadowPanel1.SuspendLayout();
            this.gbAddFoodAllergen.SuspendLayout();
            this.pnlBaslik.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoodAllergens)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuShadowPanel1
            // 
            this.bunifuShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuShadowPanel1.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuShadowPanel1.BorderRadius = 1;
            this.bunifuShadowPanel1.BorderThickness = 1;
            this.bunifuShadowPanel1.Controls.Add(this.gbAddFoodAllergen);
            this.bunifuShadowPanel1.Controls.Add(this.pnlBaslik);
            this.bunifuShadowPanel1.Controls.Add(this.dgvFoodAllergens);
            this.bunifuShadowPanel1.FillStyle = Bunifu.UI.WinForms.BunifuShadowPanel.FillStyles.Solid;
            this.bunifuShadowPanel1.GradientMode = Bunifu.UI.WinForms.BunifuShadowPanel.GradientModes.Vertical;
            this.bunifuShadowPanel1.Location = new System.Drawing.Point(28, 33);
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
            this.bunifuShadowPanel1.TabIndex = 13;
            // 
            // gbAddFoodAllergen
            // 
            this.gbAddFoodAllergen.BackColor = System.Drawing.Color.Gainsboro;
            this.gbAddFoodAllergen.BorderColor = System.Drawing.Color.Silver;
            this.gbAddFoodAllergen.BorderRadius = 1;
            this.gbAddFoodAllergen.BorderThickness = 1;
            this.gbAddFoodAllergen.Controls.Add(this.lblFoodName);
            this.gbAddFoodAllergen.Controls.Add(this.btnGidaAlerjeniEkle);
            this.gbAddFoodAllergen.Controls.Add(this.cbFoodName);
            this.gbAddFoodAllergen.Controls.Add(this.cbAllergenName);
            this.gbAddFoodAllergen.Controls.Add(this.lblAllergenName);
            this.gbAddFoodAllergen.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gbAddFoodAllergen.LabelAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.gbAddFoodAllergen.LabelIndent = 10;
            this.gbAddFoodAllergen.LineStyle = Bunifu.UI.WinForms.BunifuGroupBox.LineStyles.Solid;
            this.gbAddFoodAllergen.Location = new System.Drawing.Point(39, 92);
            this.gbAddFoodAllergen.Name = "gbAddFoodAllergen";
            this.gbAddFoodAllergen.Size = new System.Drawing.Size(389, 348);
            this.gbAddFoodAllergen.TabIndex = 17;
            this.gbAddFoodAllergen.TabStop = false;
            this.gbAddFoodAllergen.Text = "Gıda Alerjeni Ekle";
            // 
            // lblFoodName
            // 
            this.lblFoodName.AllowParentOverrides = false;
            this.lblFoodName.AutoEllipsis = false;
            this.lblFoodName.AutoSize = false;
            this.lblFoodName.CursorType = null;
            this.lblFoodName.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.lblFoodName.Location = new System.Drawing.Point(64, 47);
            this.lblFoodName.Name = "lblFoodName";
            this.lblFoodName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblFoodName.Size = new System.Drawing.Size(260, 28);
            this.lblFoodName.TabIndex = 13;
            this.lblFoodName.Text = "Gıda Adı";
            this.lblFoodName.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblFoodName.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // btnGidaAlerjeniEkle
            // 
            this.btnGidaAlerjeniEkle.AllowAnimations = true;
            this.btnGidaAlerjeniEkle.AllowMouseEffects = true;
            this.btnGidaAlerjeniEkle.AllowToggling = false;
            this.btnGidaAlerjeniEkle.AnimationSpeed = 200;
            this.btnGidaAlerjeniEkle.AutoGenerateColors = false;
            this.btnGidaAlerjeniEkle.AutoRoundBorders = false;
            this.btnGidaAlerjeniEkle.AutoSizeLeftIcon = true;
            this.btnGidaAlerjeniEkle.AutoSizeRightIcon = true;
            this.btnGidaAlerjeniEkle.BackColor = System.Drawing.Color.Transparent;
            this.btnGidaAlerjeniEkle.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.btnGidaAlerjeniEkle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGidaAlerjeniEkle.BackgroundImage")));
            this.btnGidaAlerjeniEkle.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnGidaAlerjeniEkle.ButtonText = "Gıda Alerjeni Ekle";
            this.btnGidaAlerjeniEkle.ButtonTextMarginLeft = 0;
            this.btnGidaAlerjeniEkle.ColorContrastOnClick = 45;
            this.btnGidaAlerjeniEkle.ColorContrastOnHover = 45;
            this.btnGidaAlerjeniEkle.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = false;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = false;
            this.btnGidaAlerjeniEkle.CustomizableEdges = borderEdges2;
            this.btnGidaAlerjeniEkle.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnGidaAlerjeniEkle.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnGidaAlerjeniEkle.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnGidaAlerjeniEkle.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnGidaAlerjeniEkle.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnGidaAlerjeniEkle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnGidaAlerjeniEkle.ForeColor = System.Drawing.Color.White;
            this.btnGidaAlerjeniEkle.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGidaAlerjeniEkle.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnGidaAlerjeniEkle.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnGidaAlerjeniEkle.IconMarginLeft = 11;
            this.btnGidaAlerjeniEkle.IconPadding = 10;
            this.btnGidaAlerjeniEkle.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGidaAlerjeniEkle.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnGidaAlerjeniEkle.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnGidaAlerjeniEkle.IconSize = 25;
            this.btnGidaAlerjeniEkle.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btnGidaAlerjeniEkle.IdleBorderRadius = 20;
            this.btnGidaAlerjeniEkle.IdleBorderThickness = 1;
            this.btnGidaAlerjeniEkle.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.btnGidaAlerjeniEkle.IdleIconLeftImage = null;
            this.btnGidaAlerjeniEkle.IdleIconRightImage = null;
            this.btnGidaAlerjeniEkle.IndicateFocus = false;
            this.btnGidaAlerjeniEkle.Location = new System.Drawing.Point(110, 273);
            this.btnGidaAlerjeniEkle.Name = "btnGidaAlerjeniEkle";
            this.btnGidaAlerjeniEkle.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnGidaAlerjeniEkle.OnDisabledState.BorderRadius = 20;
            this.btnGidaAlerjeniEkle.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnGidaAlerjeniEkle.OnDisabledState.BorderThickness = 1;
            this.btnGidaAlerjeniEkle.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnGidaAlerjeniEkle.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnGidaAlerjeniEkle.OnDisabledState.IconLeftImage = null;
            this.btnGidaAlerjeniEkle.OnDisabledState.IconRightImage = null;
            this.btnGidaAlerjeniEkle.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnGidaAlerjeniEkle.onHoverState.BorderRadius = 20;
            this.btnGidaAlerjeniEkle.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnGidaAlerjeniEkle.onHoverState.BorderThickness = 1;
            this.btnGidaAlerjeniEkle.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnGidaAlerjeniEkle.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnGidaAlerjeniEkle.onHoverState.IconLeftImage = null;
            this.btnGidaAlerjeniEkle.onHoverState.IconRightImage = null;
            this.btnGidaAlerjeniEkle.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnGidaAlerjeniEkle.OnIdleState.BorderRadius = 20;
            this.btnGidaAlerjeniEkle.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnGidaAlerjeniEkle.OnIdleState.BorderThickness = 1;
            this.btnGidaAlerjeniEkle.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnGidaAlerjeniEkle.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnGidaAlerjeniEkle.OnIdleState.IconLeftImage = null;
            this.btnGidaAlerjeniEkle.OnIdleState.IconRightImage = null;
            this.btnGidaAlerjeniEkle.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnGidaAlerjeniEkle.OnPressedState.BorderRadius = 20;
            this.btnGidaAlerjeniEkle.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnGidaAlerjeniEkle.OnPressedState.BorderThickness = 1;
            this.btnGidaAlerjeniEkle.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnGidaAlerjeniEkle.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnGidaAlerjeniEkle.OnPressedState.IconLeftImage = null;
            this.btnGidaAlerjeniEkle.OnPressedState.IconRightImage = null;
            this.btnGidaAlerjeniEkle.Size = new System.Drawing.Size(168, 47);
            this.btnGidaAlerjeniEkle.TabIndex = 16;
            this.btnGidaAlerjeniEkle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGidaAlerjeniEkle.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnGidaAlerjeniEkle.TextMarginLeft = 0;
            this.btnGidaAlerjeniEkle.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnGidaAlerjeniEkle.UseDefaultRadiusAndThickness = true;
            this.btnGidaAlerjeniEkle.Click += new System.EventHandler(this.btnGidaAlerjeniEkle_Click);
            // 
            // cbFoodName
            // 
            this.cbFoodName.BackColor = System.Drawing.Color.Transparent;
            this.cbFoodName.BackgroundColor = System.Drawing.Color.White;
            this.cbFoodName.BorderColor = System.Drawing.Color.Silver;
            this.cbFoodName.BorderRadius = 1;
            this.cbFoodName.Color = System.Drawing.Color.Silver;
            this.cbFoodName.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.cbFoodName.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cbFoodName.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.cbFoodName.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cbFoodName.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.cbFoodName.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.cbFoodName.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbFoodName.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.cbFoodName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFoodName.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.cbFoodName.FillDropDown = true;
            this.cbFoodName.FillIndicator = false;
            this.cbFoodName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbFoodName.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbFoodName.ForeColor = System.Drawing.Color.Silver;
            this.cbFoodName.FormattingEnabled = true;
            this.cbFoodName.Icon = null;
            this.cbFoodName.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.cbFoodName.IndicatorColor = System.Drawing.Color.Gray;
            this.cbFoodName.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.cbFoodName.ItemBackColor = System.Drawing.Color.White;
            this.cbFoodName.ItemBorderColor = System.Drawing.Color.White;
            this.cbFoodName.ItemForeColor = System.Drawing.Color.Black;
            this.cbFoodName.ItemHeight = 31;
            this.cbFoodName.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.cbFoodName.ItemHighLightForeColor = System.Drawing.Color.White;
            this.cbFoodName.ItemTopMargin = 3;
            this.cbFoodName.Location = new System.Drawing.Point(64, 81);
            this.cbFoodName.Name = "cbFoodName";
            this.cbFoodName.Size = new System.Drawing.Size(260, 37);
            this.cbFoodName.TabIndex = 12;
            this.cbFoodName.Text = "Seçiniz";
            this.cbFoodName.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.cbFoodName.TextLeftMargin = 5;
            // 
            // cbAllergenName
            // 
            this.cbAllergenName.BackColor = System.Drawing.Color.Transparent;
            this.cbAllergenName.BackgroundColor = System.Drawing.Color.White;
            this.cbAllergenName.BorderColor = System.Drawing.Color.Silver;
            this.cbAllergenName.BorderRadius = 1;
            this.cbAllergenName.Color = System.Drawing.Color.Silver;
            this.cbAllergenName.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.cbAllergenName.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cbAllergenName.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.cbAllergenName.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cbAllergenName.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.cbAllergenName.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.cbAllergenName.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbAllergenName.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.cbAllergenName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAllergenName.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.cbAllergenName.FillDropDown = true;
            this.cbAllergenName.FillIndicator = false;
            this.cbAllergenName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbAllergenName.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbAllergenName.ForeColor = System.Drawing.Color.Silver;
            this.cbAllergenName.FormattingEnabled = true;
            this.cbAllergenName.Icon = null;
            this.cbAllergenName.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.cbAllergenName.IndicatorColor = System.Drawing.Color.Gray;
            this.cbAllergenName.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.cbAllergenName.ItemBackColor = System.Drawing.Color.White;
            this.cbAllergenName.ItemBorderColor = System.Drawing.Color.White;
            this.cbAllergenName.ItemForeColor = System.Drawing.Color.Black;
            this.cbAllergenName.ItemHeight = 31;
            this.cbAllergenName.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.cbAllergenName.ItemHighLightForeColor = System.Drawing.Color.White;
            this.cbAllergenName.ItemTopMargin = 3;
            this.cbAllergenName.Location = new System.Drawing.Point(64, 181);
            this.cbAllergenName.Name = "cbAllergenName";
            this.cbAllergenName.Size = new System.Drawing.Size(260, 37);
            this.cbAllergenName.TabIndex = 14;
            this.cbAllergenName.Text = "Seçiniz";
            this.cbAllergenName.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.cbAllergenName.TextLeftMargin = 5;
            // 
            // lblAllergenName
            // 
            this.lblAllergenName.AllowParentOverrides = false;
            this.lblAllergenName.AutoEllipsis = false;
            this.lblAllergenName.AutoSize = false;
            this.lblAllergenName.CursorType = null;
            this.lblAllergenName.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.lblAllergenName.Location = new System.Drawing.Point(64, 147);
            this.lblAllergenName.Name = "lblAllergenName";
            this.lblAllergenName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblAllergenName.Size = new System.Drawing.Size(260, 28);
            this.lblAllergenName.TabIndex = 15;
            this.lblAllergenName.Text = "Alerjen Adı";
            this.lblAllergenName.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblAllergenName.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // pnlBaslik
            // 
            this.pnlBaslik.BackColor = System.Drawing.Color.Transparent;
            this.pnlBaslik.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlBaslik.BackgroundImage")));
            this.pnlBaslik.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlBaslik.BorderRadius = 10;
            this.pnlBaslik.Controls.Add(this.lblGidaAlerjenleri);
            this.pnlBaslik.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBaslik.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(88)))), ((int)(((byte)(190)))));
            this.pnlBaslik.GradientBottomRight = System.Drawing.Color.LightBlue;
            this.pnlBaslik.GradientTopLeft = System.Drawing.Color.DodgerBlue;
            this.pnlBaslik.GradientTopRight = System.Drawing.SystemColors.ActiveCaption;
            this.pnlBaslik.Location = new System.Drawing.Point(0, 0);
            this.pnlBaslik.Name = "pnlBaslik";
            this.pnlBaslik.Quality = 10;
            this.pnlBaslik.Size = new System.Drawing.Size(978, 71);
            this.pnlBaslik.TabIndex = 11;
            // 
            // lblGidaAlerjenleri
            // 
            this.lblGidaAlerjenleri.Font = new System.Drawing.Font("Century Gothic", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGidaAlerjenleri.Location = new System.Drawing.Point(0, 0);
            this.lblGidaAlerjenleri.Name = "lblGidaAlerjenleri";
            this.lblGidaAlerjenleri.Size = new System.Drawing.Size(218, 71);
            this.lblGidaAlerjenleri.TabIndex = 0;
            this.lblGidaAlerjenleri.Text = "Gıda Alerjenleri";
            this.lblGidaAlerjenleri.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvFoodAllergens
            // 
            this.dgvFoodAllergens.AllowCustomTheming = false;
            this.dgvFoodAllergens.AllowUserToAddRows = false;
            this.dgvFoodAllergens.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.dgvFoodAllergens.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvFoodAllergens.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFoodAllergens.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvFoodAllergens.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvFoodAllergens.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFoodAllergens.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvFoodAllergens.ColumnHeadersHeight = 40;
            this.dgvFoodAllergens.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dgvFoodAllergens.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvFoodAllergens.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvFoodAllergens.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgvFoodAllergens.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvFoodAllergens.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dgvFoodAllergens.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgvFoodAllergens.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.dgvFoodAllergens.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dgvFoodAllergens.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvFoodAllergens.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.dgvFoodAllergens.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvFoodAllergens.CurrentTheme.Name = null;
            this.dgvFoodAllergens.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvFoodAllergens.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvFoodAllergens.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvFoodAllergens.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgvFoodAllergens.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFoodAllergens.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvFoodAllergens.EnableHeadersVisualStyles = false;
            this.dgvFoodAllergens.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgvFoodAllergens.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.dgvFoodAllergens.HeaderBgColor = System.Drawing.Color.Empty;
            this.dgvFoodAllergens.HeaderForeColor = System.Drawing.Color.White;
            this.dgvFoodAllergens.Location = new System.Drawing.Point(502, 92);
            this.dgvFoodAllergens.Name = "dgvFoodAllergens";
            this.dgvFoodAllergens.RowHeadersVisible = false;
            this.dgvFoodAllergens.RowTemplate.Height = 40;
            this.dgvFoodAllergens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFoodAllergens.Size = new System.Drawing.Size(430, 543);
            this.dgvFoodAllergens.TabIndex = 0;
            this.dgvFoodAllergens.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.dgvFoodAllergens.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFoodAllergens_CellContentClick);
            // 
            // PageFoodAllergens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 737);
            this.Controls.Add(this.bunifuShadowPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PageFoodAllergens";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yummy Day";
            this.Shown += new System.EventHandler(this.PageFoodAllergens_Shown);
            this.bunifuShadowPanel1.ResumeLayout(false);
            this.gbAddFoodAllergen.ResumeLayout(false);
            this.pnlBaslik.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoodAllergens)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuShadowPanel bunifuShadowPanel1;
        private Bunifu.UI.WinForms.BunifuGradientPanel pnlBaslik;
        private System.Windows.Forms.Label lblGidaAlerjenleri;
        private Bunifu.UI.WinForms.BunifuDataGridView dgvFoodAllergens;
        private Bunifu.UI.WinForms.BunifuDropdown cbAllergenName;
        private Bunifu.UI.WinForms.BunifuLabel lblAllergenName;
        private Bunifu.UI.WinForms.BunifuDropdown cbFoodName;
        private Bunifu.UI.WinForms.BunifuLabel lblFoodName;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnGidaAlerjeniEkle;
        private Bunifu.UI.WinForms.BunifuGroupBox gbAddFoodAllergen;
    }
}