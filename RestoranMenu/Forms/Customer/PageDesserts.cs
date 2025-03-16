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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestoranMenu.Forms.Customer
{
    public partial class PageDesserts: Form
    {
        private FlowLayoutPanel flowPanel = new FlowLayoutPanel();
        public PageDesserts()
        {
            InitializeComponent();
            this.Text = "Yemek Listesi";
            this.Size = new Size(1034,780);

            // FlowLayoutPanel ayarları
            flowPanel.Dock = DockStyle.Fill;
            flowPanel.Padding = new Padding(20, 10, 20, 10); // Sağdan ve soldan 20px boşluk bırakır

            flowPanel.AutoScroll = true;
            flowPanel.FlowDirection = FlowDirection.LeftToRight;
            flowPanel.WrapContents = true;
            this.Controls.Add(flowPanel);

            // Verileri çek ve göster
            LoadFoods();
        }
        private void LoadFoods()
        {
            using (SqlConnection con = new SqlConnection(SqlServer.ConnectionString))
            {
                string query = "SELECT food_name, food_calorie, food_price, food_picture FROM foods";
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string foodName = reader["food_name"].ToString().Trim();
                    string foodCalorie = reader["food_calorie"].ToString().Trim();
                    string foodPrice = reader["food_price"].ToString().Trim();
                    byte[] imageBytes = reader["food_picture"] as byte[];

                    // Panel oluştur
                    BunifuPanel panel = new BunifuPanel();
                    panel.BackgroundColor = Color.FromArgb(230, 230, 230);
                    panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                    panel.BorderColor = System.Drawing.Color.Transparent;
                    panel.BorderRadius = 10;
                    panel.BorderThickness = 1;
                    panel.Location = new System.Drawing.Point(53, 42);
                    panel.ShowBorders = true;
                    panel.Size = new System.Drawing.Size(240, 350);

                    // PictureBox (Resim)
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

                    // Yemek adı label
                    BunifuLabel nameLabel = new BunifuLabel();
                    nameLabel.Text = foodName;
                    nameLabel.Location = new Point(0, 223);
                    nameLabel.AutoSize = false;
                    nameLabel.Size = new Size(240, 24);
                    nameLabel.Font = new Font("Century Gothic", 9F);
                    nameLabel.TextAlignment = ContentAlignment.MiddleCenter;
                    nameLabel.TextFormat = BunifuLabel.TextFormattingOptions.Default;
                    nameLabel.RightToLeft = RightToLeft.No;

                    // Kalori label
                    BunifuLabel calorieLabel = new BunifuLabel();
                    calorieLabel.Text = "Kalori: " + foodCalorie;
                    calorieLabel.Location = new Point(10, 240);
                    calorieLabel.AutoSize = false;
                    calorieLabel.Size = new Size(220, 24);
                    calorieLabel.TextAlignment = ContentAlignment.MiddleLeft;
                    calorieLabel.Font = new Font("Century Gothic", 9F);
                    calorieLabel.TextFormat = BunifuLabel.TextFormattingOptions.Default;
                    calorieLabel.RightToLeft = RightToLeft.No;

                    // Fiyat label
                    BunifuLabel priceLabel = new BunifuLabel();
                    priceLabel.Text = "Fiyat: " + foodPrice + " TL";
                    priceLabel.Location = new Point(10, 260);
                    priceLabel.AutoSize = false;
                    priceLabel.Size = new Size(220, 24);
                    priceLabel.TextAlignment = ContentAlignment.MiddleLeft;
                    priceLabel.Font = new Font("Century Gothic", 9F);
                    priceLabel.TextFormat = BunifuLabel.TextFormattingOptions.Default;
                    priceLabel.RightToLeft = RightToLeft.No;

                    //Sepete Ekle Butonu
                    BunifuButton sepeteEkle = new BunifuButton();



                    // Panel içine ekle
                    panel.Controls.Add(pictureBox);
                    panel.Controls.Add(nameLabel);
                    panel.Controls.Add(calorieLabel);
                    panel.Controls.Add(priceLabel);

                    // FlowLayoutPanel içine ekle
                    flowPanel.Controls.Add(panel);
                }

                reader.Close();
            }
        }

    }
}
