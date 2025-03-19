using Bunifu.UI.WinForms;
using Bunifu.UI.WinForms.BunifuButton;
using RestoranMenu.Classes;
using RestoranMenu.Properties;
using SecureTeam.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Bunifu.UI.WinForms.BunifuButton.BunifuButton;

namespace RestoranMenu.Forms.Customer
{

    /*
        1-) FlowLayoutPanel ayarları
        2-) Dinamik Komponent Eklemeleri
            2.1-) Panel oluştur
            2.2-) PictureBox (Resim)
            2.3-) Yemek adı label
            2.4-) Kalori label
            2.5-) Fiyat label
            2.6-) Sepete Ekle Butonu
        3-) Kontrol Eklemeleri
     
     
     
     */
    public partial class UrunleriListele: Form
    {
        private FlowLayoutPanel flowPanel = new FlowLayoutPanel();
        public UrunleriListele()
        {
            InitializeComponent();
            this.Text = "Yemek Listesi";
            this.Size = new Size(1034,780);

            // 1-) FlowLayoutPanel ayarları
            flowPanel.Dock = DockStyle.Fill;
            flowPanel.Padding = new Padding(20, 10, 20, 10); // Sağdan ve soldan 20px boşluk bırakır

            flowPanel.AutoScroll = true;
            flowPanel.FlowDirection = FlowDirection.LeftToRight;
            flowPanel.WrapContents = true;
            this.Controls.Add(flowPanel);

            // Verileri çek ve göster
            //LoadFoods();
        }
        //string query = "SELECT food_name, food_calorie, food_price, food_picture FROM foods";
        public void LoadFoods(string query)
        {
            using (SqlConnection con = new SqlConnection(SqlServer.ConnectionString))
            {
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string foodName = reader["food_name"].ToString().Trim();
                    string foodCalorie = reader["food_calorie"].ToString().Trim();
                    string foodPrice = reader["food_price"].ToString().Trim();
                    byte[] imageBytes = reader["food_picture"] as byte[];

                    // 2.1-) Panel oluştur
                    BunifuPanel panel = new BunifuPanel();
                    panel.BackgroundColor = Color.FromArgb(230, 230, 230);
                    panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                    panel.BorderColor = System.Drawing.Color.Transparent;
                    panel.BorderRadius = 10;
                    panel.BorderThickness = 1;
                    panel.Location = new System.Drawing.Point(53, 42);
                    panel.ShowBorders = true;
                    panel.Size = new System.Drawing.Size(240, 350);

                    // 2.2-) PictureBox (Resim)
                    BunifuPictureBox pictureBox = new BunifuPictureBox();
                    pictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
                    pictureBox.AutoSizeHeight = false;
                    pictureBox.BorderRadius = 10;
                    pictureBox.IsCircle = false;
                    pictureBox.Location = new System.Drawing.Point(25, 15);
                    pictureBox.Size = new System.Drawing.Size(190, 190);
                    pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                    pictureBox.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Custom;

                    if (imageBytes != null)
                    {
                        using (MemoryStream ms = new MemoryStream(imageBytes))
                        {
                            pictureBox.Image = Image.FromStream(ms);
                        }
                    }

                    // 2.3-) Yemek adı label
                    BunifuLabel nameLabel = new BunifuLabel();
                    nameLabel.Text = foodName;
                    nameLabel.Location = new Point(0, 223);
                    nameLabel.AutoSize = false;
                    nameLabel.Size = new Size(240, 24);
                    nameLabel.Font = new Font("Century Gothic", 9F);
                    nameLabel.TextAlignment = ContentAlignment.MiddleCenter;
                    nameLabel.TextFormat = BunifuLabel.TextFormattingOptions.Default;
                    nameLabel.RightToLeft = RightToLeft.No;

                    // 2.4-) Kalori label
                    BunifuLabel calorieLabel = new BunifuLabel();
                    calorieLabel.Text = "Kalori: " + foodCalorie;
                    calorieLabel.Location = new Point(10, 240);
                    calorieLabel.AutoSize = false;
                    calorieLabel.Size = new Size(220, 24);
                    calorieLabel.TextAlignment = ContentAlignment.MiddleLeft;
                    calorieLabel.Font = new Font("Century Gothic", 9F);
                    calorieLabel.TextFormat = BunifuLabel.TextFormattingOptions.Default;
                    calorieLabel.RightToLeft = RightToLeft.No;

                    // 2.5-) Fiyat label
                    BunifuLabel priceLabel = new BunifuLabel();
                    priceLabel.Text = "Fiyat: " + foodPrice + " TL";
                    priceLabel.Location = new Point(10, 260);
                    priceLabel.AutoSize = false;
                    priceLabel.Size = new Size(220, 24);
                    priceLabel.TextAlignment = ContentAlignment.MiddleLeft;
                    priceLabel.Font = new Font("Century Gothic", 9F);
                    priceLabel.TextFormat = BunifuLabel.TextFormattingOptions.Default;
                    priceLabel.RightToLeft = RightToLeft.No;

                    // 2.6-) Sepete Ekle Butonu
                    BunifuButton sepeteEkle = new BunifuButton();
                    BunifuButton.BorderEdges borderEdges1 = new BunifuButton.BorderEdges();
                    sepeteEkle.AllowAnimations = true;
                    sepeteEkle.AllowMouseEffects = true;
                    sepeteEkle.AllowToggling = false;
                    sepeteEkle.AnimationSpeed = 200;
                    sepeteEkle.AutoGenerateColors = false;
                    sepeteEkle.AutoRoundBorders = false;
                    sepeteEkle.AutoSizeLeftIcon = true;
                    sepeteEkle.AutoSizeRightIcon = true;
                    sepeteEkle.BackColor = System.Drawing.Color.Transparent;
                    sepeteEkle.BackColor1 = System.Drawing.Color.DodgerBlue;
                    sepeteEkle.BackgroundImage = Resources.sepet;
                    sepeteEkle.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
                    sepeteEkle.ButtonText = "Sepete Ekle";
                    sepeteEkle.ButtonTextMarginLeft = 0;
                    sepeteEkle.ColorContrastOnClick = 45;
                    sepeteEkle.ColorContrastOnHover = 45;
                    sepeteEkle.Cursor = System.Windows.Forms.Cursors.Default;
                    borderEdges1.BottomLeft = false;
                    borderEdges1.BottomRight = true;
                    borderEdges1.TopLeft = true;
                    borderEdges1.TopRight = false;
                    sepeteEkle.CustomizableEdges = borderEdges1;
                    sepeteEkle.DialogResult = System.Windows.Forms.DialogResult.None;
                    sepeteEkle.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
                    sepeteEkle.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
                    sepeteEkle.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
                    sepeteEkle.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
                    sepeteEkle.Font = new System.Drawing.Font("Segoe UI", 9F);
                    sepeteEkle.ForeColor = System.Drawing.Color.White;
                    sepeteEkle.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
                    sepeteEkle.IconLeftCursor = System.Windows.Forms.Cursors.Default;
                    sepeteEkle.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
                    sepeteEkle.IconMarginLeft = 11;
                    sepeteEkle.IconPadding = 10;
                    sepeteEkle.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
                    sepeteEkle.IconRightCursor = System.Windows.Forms.Cursors.Default;
                    sepeteEkle.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
                    sepeteEkle.IconSize = 25;
                    sepeteEkle.IdleBorderColor = System.Drawing.Color.DodgerBlue;
                    sepeteEkle.IdleBorderRadius = 10;
                    sepeteEkle.IdleBorderThickness = 1;
                    sepeteEkle.IdleFillColor = System.Drawing.Color.DodgerBlue;
                    sepeteEkle.IdleIconLeftImage = global::RestoranMenu.Properties.Resources.sepet;
                    sepeteEkle.IdleIconRightImage = null;
                    sepeteEkle.IndicateFocus = false;
                    sepeteEkle.Location = new System.Drawing.Point(43, 295);
                    sepeteEkle.Name = "sepeteEkle";
                    sepeteEkle.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
                    sepeteEkle.OnDisabledState.BorderRadius = 10;
                    sepeteEkle.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
                    sepeteEkle.OnDisabledState.BorderThickness = 1;
                    sepeteEkle.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
                    sepeteEkle.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
                    sepeteEkle.OnDisabledState.IconLeftImage = null;
                    sepeteEkle.OnDisabledState.IconRightImage = null;
                    sepeteEkle.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
                    sepeteEkle.onHoverState.BorderRadius = 10;
                    sepeteEkle.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
                    sepeteEkle.onHoverState.BorderThickness = 1;
                    sepeteEkle.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
                    sepeteEkle.onHoverState.ForeColor = System.Drawing.Color.White;
                    sepeteEkle.onHoverState.IconLeftImage = null;
                    sepeteEkle.onHoverState.IconRightImage = null;
                    sepeteEkle.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
                    sepeteEkle.OnIdleState.BorderRadius = 10;
                    sepeteEkle.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
                    sepeteEkle.OnIdleState.BorderThickness = 1;
                    sepeteEkle.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
                    sepeteEkle.OnIdleState.ForeColor = System.Drawing.Color.White;
                    sepeteEkle.OnIdleState.IconLeftImage = global::RestoranMenu.Properties.Resources.sepet;
                    sepeteEkle.OnIdleState.IconRightImage = null;
                    sepeteEkle.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
                    sepeteEkle.OnPressedState.BorderRadius = 10;
                    sepeteEkle.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
                    sepeteEkle.OnPressedState.BorderThickness = 1;
                    sepeteEkle.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
                    sepeteEkle.OnPressedState.ForeColor = System.Drawing.Color.White;
                    sepeteEkle.OnPressedState.IconLeftImage = null;
                    sepeteEkle.OnPressedState.IconRightImage = null;
                    sepeteEkle.Size = new System.Drawing.Size(150, 40);
                    sepeteEkle.TabIndex = 1;
                    sepeteEkle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                    sepeteEkle.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
                    sepeteEkle.TextMarginLeft = 0;
                    sepeteEkle.TextPadding = new System.Windows.Forms.Padding(0);
                    sepeteEkle.UseDefaultRadiusAndThickness = true;

                    // 3-) Kontrol Eklemeleri
                    // Panel içine ekle
                    panel.Controls.Add(pictureBox);
                    panel.Controls.Add(nameLabel);
                    panel.Controls.Add(calorieLabel);
                    panel.Controls.Add(priceLabel);
                    panel.Controls.Add(sepeteEkle);

                    // FlowLayoutPanel içine ekle
                    flowPanel.Controls.Add(panel);
                }

                reader.Close();
            }
        }

    }
}
