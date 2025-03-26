namespace RestoranMenu.Forms.Administrator
{
    partial class PageSelectApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PageSelectApp));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.pbCustomer = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.pbAdministrator = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.lblWelcome = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblCustomer = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblAdministrator = new Bunifu.UI.WinForms.BunifuLabel();
            this.ellipseForm = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btnExit = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.pnlHeadBar = new System.Windows.Forms.Panel();
            this.dragControlHeadBar = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.pnlHeadBarSeperator = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pbCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdministrator)).BeginInit();
            this.pnlHeadBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbCustomer
            // 
            this.pbCustomer.AllowFocused = false;
            this.pbCustomer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbCustomer.AutoSizeHeight = true;
            this.pbCustomer.BackColor = System.Drawing.Color.Transparent;
            this.pbCustomer.BorderRadius = 0;
            this.pbCustomer.Image = ((System.Drawing.Image)(resources.GetObject("pbCustomer.Image")));
            this.pbCustomer.IsCircle = false;
            this.pbCustomer.Location = new System.Drawing.Point(47, 70);
            this.pbCustomer.Name = "pbCustomer";
            this.pbCustomer.Size = new System.Drawing.Size(154, 154);
            this.pbCustomer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCustomer.TabIndex = 0;
            this.pbCustomer.TabStop = false;
            this.pbCustomer.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square;
            this.pbCustomer.Click += new System.EventHandler(this.pbCustomer_Click);
            // 
            // pbAdministrator
            // 
            this.pbAdministrator.AllowFocused = false;
            this.pbAdministrator.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbAdministrator.AutoSizeHeight = true;
            this.pbAdministrator.BorderRadius = 0;
            this.pbAdministrator.Image = ((System.Drawing.Image)(resources.GetObject("pbAdministrator.Image")));
            this.pbAdministrator.IsCircle = false;
            this.pbAdministrator.Location = new System.Drawing.Point(266, 70);
            this.pbAdministrator.Name = "pbAdministrator";
            this.pbAdministrator.Size = new System.Drawing.Size(154, 154);
            this.pbAdministrator.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAdministrator.TabIndex = 0;
            this.pbAdministrator.TabStop = false;
            this.pbAdministrator.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square;
            this.pbAdministrator.Click += new System.EventHandler(this.pbAdministrator_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AllowParentOverrides = false;
            this.lblWelcome.AutoEllipsis = false;
            this.lblWelcome.AutoSize = false;
            this.lblWelcome.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblWelcome.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblWelcome.Enabled = false;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblWelcome.Location = new System.Drawing.Point(0, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblWelcome.Size = new System.Drawing.Size(430, 31);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.Text = "Hoş Geldin -name surname-";
            this.lblWelcome.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblWelcome.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lblCustomer
            // 
            this.lblCustomer.AllowParentOverrides = false;
            this.lblCustomer.AutoEllipsis = false;
            this.lblCustomer.AutoSize = false;
            this.lblCustomer.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblCustomer.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblCustomer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCustomer.Location = new System.Drawing.Point(47, 230);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblCustomer.Size = new System.Drawing.Size(154, 27);
            this.lblCustomer.TabIndex = 2;
            this.lblCustomer.Text = "Menü Paneli";
            this.lblCustomer.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCustomer.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lblAdministrator
            // 
            this.lblAdministrator.AllowParentOverrides = false;
            this.lblAdministrator.AutoEllipsis = false;
            this.lblAdministrator.AutoSize = false;
            this.lblAdministrator.CursorType = null;
            this.lblAdministrator.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblAdministrator.Location = new System.Drawing.Point(266, 230);
            this.lblAdministrator.Name = "lblAdministrator";
            this.lblAdministrator.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblAdministrator.Size = new System.Drawing.Size(154, 27);
            this.lblAdministrator.TabIndex = 2;
            this.lblAdministrator.Text = "Yönetim Paneli";
            this.lblAdministrator.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAdministrator.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // ellipseForm
            // 
            this.ellipseForm.ElipseRadius = 10;
            this.ellipseForm.TargetControl = this;
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
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.btnExit.CustomizableEdges = borderEdges3;
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
            this.btnExit.Location = new System.Drawing.Point(427, 0);
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
            this.btnExit.TabIndex = 5;
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnExit.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnExit.TextMarginLeft = 0;
            this.btnExit.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnExit.UseDefaultRadiusAndThickness = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pnlHeadBar
            // 
            this.pnlHeadBar.Controls.Add(this.btnExit);
            this.pnlHeadBar.Controls.Add(this.lblWelcome);
            this.pnlHeadBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeadBar.Location = new System.Drawing.Point(0, 0);
            this.pnlHeadBar.Name = "pnlHeadBar";
            this.pnlHeadBar.Size = new System.Drawing.Size(477, 30);
            this.pnlHeadBar.TabIndex = 6;
            // 
            // dragControlHeadBar
            // 
            this.dragControlHeadBar.Fixed = true;
            this.dragControlHeadBar.Horizontal = true;
            this.dragControlHeadBar.TargetControl = this.pnlHeadBar;
            this.dragControlHeadBar.Vertical = true;
            // 
            // pnlHeadBarSeperator
            // 
            this.pnlHeadBarSeperator.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlHeadBarSeperator.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeadBarSeperator.Location = new System.Drawing.Point(0, 30);
            this.pnlHeadBarSeperator.Name = "pnlHeadBarSeperator";
            this.pnlHeadBarSeperator.Size = new System.Drawing.Size(477, 1);
            this.pnlHeadBarSeperator.TabIndex = 7;
            // 
            // VersiyonSecim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 290);
            this.Controls.Add(this.pnlHeadBarSeperator);
            this.Controls.Add(this.pnlHeadBar);
            this.Controls.Add(this.lblAdministrator);
            this.Controls.Add(this.lblCustomer);
            this.Controls.Add(this.pbAdministrator);
            this.Controls.Add(this.pbCustomer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VersiyonSecim";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yummy Day";
            this.Shown += new System.EventHandler(this.VersiyonSecim_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pbCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdministrator)).EndInit();
            this.pnlHeadBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPictureBox pbCustomer;
        private Bunifu.UI.WinForms.BunifuPictureBox pbAdministrator;
        private Bunifu.UI.WinForms.BunifuLabel lblWelcome;
        private Bunifu.UI.WinForms.BunifuLabel lblCustomer;
        private Bunifu.UI.WinForms.BunifuLabel lblAdministrator;
        private Bunifu.Framework.UI.BunifuElipse ellipseForm;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnExit;
        private System.Windows.Forms.Panel pnlHeadBar;
        private Bunifu.Framework.UI.BunifuDragControl dragControlHeadBar;
        private System.Windows.Forms.Panel pnlHeadBarSeperator;
    }
}