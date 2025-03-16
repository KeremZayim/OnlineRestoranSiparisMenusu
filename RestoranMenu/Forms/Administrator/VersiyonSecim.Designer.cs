namespace RestoranMenu.Forms.Administrator
{
    partial class VersiyonSecim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VersiyonSecim));
            this.pbCustomer = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.pbAdministrator = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.lblWelcome = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblCustomer = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblAdministrator = new Bunifu.UI.WinForms.BunifuLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pbCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdministrator)).BeginInit();
            this.SuspendLayout();
            // 
            // pbCustomer
            // 
            this.pbCustomer.AllowFocused = false;
            this.pbCustomer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbCustomer.AutoSizeHeight = true;
            this.pbCustomer.BackColor = System.Drawing.Color.Transparent;
            this.pbCustomer.BorderRadius = 0;
            this.pbCustomer.IsCircle = false;
            this.pbCustomer.Location = new System.Drawing.Point(220, 234);
            this.pbCustomer.Name = "pbCustomer";
            this.pbCustomer.Size = new System.Drawing.Size(154, 154);
            this.pbCustomer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCustomer.TabIndex = 0;
            this.pbCustomer.TabStop = false;
            this.pbCustomer.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square;
            // 
            // pbAdministrator
            // 
            this.pbAdministrator.AllowFocused = false;
            this.pbAdministrator.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbAdministrator.AutoSizeHeight = true;
            this.pbAdministrator.BorderRadius = 0;
            this.pbAdministrator.Image = ((System.Drawing.Image)(resources.GetObject("pbAdministrator.Image")));
            this.pbAdministrator.IsCircle = false;
            this.pbAdministrator.Location = new System.Drawing.Point(439, 234);
            this.pbAdministrator.Name = "pbAdministrator";
            this.pbAdministrator.Size = new System.Drawing.Size(154, 154);
            this.pbAdministrator.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAdministrator.TabIndex = 0;
            this.pbAdministrator.TabStop = false;
            this.pbAdministrator.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AllowParentOverrides = false;
            this.lblWelcome.AutoEllipsis = false;
            this.lblWelcome.AutoSize = false;
            this.lblWelcome.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblWelcome.Location = new System.Drawing.Point(269, 200);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblWelcome.Size = new System.Drawing.Size(285, 28);
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
            this.lblCustomer.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblCustomer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCustomer.Location = new System.Drawing.Point(220, 407);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblCustomer.Size = new System.Drawing.Size(154, 27);
            this.lblCustomer.TabIndex = 2;
            this.lblCustomer.Text = "Sipariş Paneli";
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
            this.lblAdministrator.Location = new System.Drawing.Point(439, 407);
            this.lblAdministrator.Name = "lblAdministrator";
            this.lblAdministrator.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblAdministrator.Size = new System.Drawing.Size(154, 27);
            this.lblAdministrator.TabIndex = 2;
            this.lblAdministrator.Text = "Yönetim Paneli";
            this.lblAdministrator.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAdministrator.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // VersiyonSecim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 542);
            this.Controls.Add(this.lblAdministrator);
            this.Controls.Add(this.lblCustomer);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.pbAdministrator);
            this.Controls.Add(this.pbCustomer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VersiyonSecim";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VersiyonSecim";
            ((System.ComponentModel.ISupportInitialize)(this.pbCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdministrator)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPictureBox pbCustomer;
        private Bunifu.UI.WinForms.BunifuPictureBox pbAdministrator;
        private Bunifu.UI.WinForms.BunifuLabel lblWelcome;
        private Bunifu.UI.WinForms.BunifuLabel lblCustomer;
        private Bunifu.UI.WinForms.BunifuLabel lblAdministrator;
    }
}