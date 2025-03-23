using Bunifu.UI.WinForms;
using Bunifu.UI.WinForms.BunifuButton;
using RestoranMenu.Classes;
using RestoranMenu.Forms.Customer;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace RestoranMenu
{
    public partial class PageMain : Form
    {
        /*
         
         1-) Butonlar
         2-) Sayfa Sorguları

         - Son Siparişler -
         3-) Veri Tabanından Fotoğrafı Çekme
         4-) Komponentler
            4.1-) Panel
            4.2-) Picture Box
            4.3-) Label
         -                -
         5-) Sepete Ekle Butonu

        */
        string query;
        int xOffset;
        public PageMain()
        {
            InitializeComponent();
        }

        private void PageMain_Shown(object sender, EventArgs e)
        {
            lblYonetimBar.Text = Veriler.ad + " " + Veriler.soyad + " | Yummy Day Menü";
            SonSiparisleriGetir();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // 1-)
        private void MenuButonlari(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            BunifuButton tiklananKategori = (BunifuButton)sender;
            PageListFoods child = pnlMain.Controls.OfType<PageListFoods>().FirstOrDefault();

            if (child == null) // Eğer form yoksa yeni form oluşturur
            {
                child = new PageListFoods();
                child.TopLevel = false;  // Formu panel içinde gösterebilmek için
                child.FormBorderStyle = FormBorderStyle.None;
                child.Dock = DockStyle.Fill;
                pnlMain.Controls.Clear();
                pnlMain.Controls.Add(child);
                child.Show();
            }

            // 2-)
            // Tiklanan butona göre veritabanı sorgusu (Listeleme Sayfası)
            switch (tiklananKategori.Text)
            {
                case "Çorbalar":
                    query = "SELECT food_name, food_calorie, food_price, food_picture FROM foods AS f " +
                            "JOIN categories AS c ON c.category_id = f.category_id " +
                            "WHERE c.category_name='Çorbalar'";
                    break;

                case "Tatlılar":
                    query = "SELECT food_name, food_calorie, food_price, food_picture FROM foods AS f " +
                            "JOIN categories AS c ON c.category_id = f.category_id " +
                            "WHERE c.category_name='Tatlılar'";
                    break;

                case "İçecekler":
                    query = "SELECT food_name, food_calorie, food_price, food_picture FROM foods AS f " +
                            "JOIN categories AS c ON c.category_id = f.category_id " +
                            "WHERE c.category_name='İçecekler'";
                    break;

                case "Et Yemekleri":
                    query = "SELECT food_name, food_calorie, food_price, food_picture FROM foods AS f " +
                            "JOIN categories AS c ON c.category_id = f.category_id " +
                            "WHERE c.category_name='Et Yemekleri'";
                    break;

                case "Sebze Yemekleri":
                    query = "SELECT food_name, food_calorie, food_price, food_picture FROM foods AS f " +
                            "JOIN categories AS c ON c.category_id = f.category_id " +
                            "WHERE c.category_name='Sebze Yemekleri'";
                    break;

                case "Makarnalar":
                    query = "SELECT food_name, food_calorie, food_price, food_picture FROM foods AS f " +
                            "JOIN categories AS c ON c.category_id = f.category_id " +
                            "WHERE c.category_name='Makarnalar'";
                    break;

                case "Salatalar":
                    query = "SELECT food_name, food_calorie, food_price, food_picture FROM foods AS f " +
                            "JOIN categories AS c ON c.category_id = f.category_id " +
                            "WHERE c.category_name='Salatalar'";
                    break;

                default:
                    query = "";
                    break;
            }


            if (!string.IsNullOrEmpty(query))
            {
                child.LoadFoods(query);
            }
        }

        // 3-)
        private Image ByteArrayToImage(byte[] byteArrayIn)
        {
            using (var ms = new System.IO.MemoryStream(byteArrayIn))
            {
                return Image.FromStream(ms);
            }
        }
        private void SonSiparisleriGetir()
        {
            using (SqlConnection con = new SqlConnection(SqlServer.ConnectionString))
            {
                con.Open();
                string query = @"
                SELECT TOP 10 f.food_name, f.food_picture
                FROM order_details od
                INNER JOIN foods f ON od.food_id = f.food_id
                ORDER BY od.order_detail_id DESC";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            string foodName = dr["food_name"].ToString();
                            byte[] imgData = dr["food_picture"] as byte[];

                            // 4.1-)
                            BunifuPanel pnlExample = new BunifuPanel
                            {
                                Location = new Point(xOffset, 7),
                                BackgroundColor = Color.FromArgb(235,235,235),
                                ShowBorders = true,
                                BorderRadius = 5,
                                BorderThickness = 1,
                                Size = new Size(170, 170)
                            };

                            // 4.2-)
                            BunifuPictureBox pbExample = new BunifuPictureBox
                            {
                                AllowFocused = false,
                                Anchor = AnchorStyles.None,
                                AutoSizeHeight = true,
                                Image = imgData != null ? ByteArrayToImage(imgData) : Properties.Resources.error_cloud,
                                Location = new Point(25, 10),
                                Name = "pbExample",
                                TabIndex = 0,
                                TabStop = false,
                                Size = new Size(120, 120),
                                SizeMode = PictureBoxSizeMode.StretchImage,
                                Type = BunifuPictureBox.Types.Custom,
                                IsCircle = false,
                                BorderRadius = 5,
                            };

                            // 4.3-)
                            BunifuLabel lblExample = new BunifuLabel
                            {
                                AutoSize = false,
                                Size = new Size(164, 30),
                                Font = new Font("Segoe UI", 9F),
                                Text = foodName,
                                TextAlignment = ContentAlignment.MiddleCenter,
                                Location = new Point(3, 139)
                            };

                            // Bileşenleri panele ekle
                            pnlExample.Controls.Add(pbExample);
                            pnlExample.Controls.Add(lblExample);
                            pnlLastOrders.Controls.Add(pnlExample);
                            // Sonraki panelin konumunu ayarla (yanyana dizmek için)
                            xOffset += 180;
                        }
                    }
                }
            }
        }

        // 5-)
        private void btnSepet_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            PageOrders child = pnlMain.Controls.OfType<PageOrders>().FirstOrDefault();
            child = new PageOrders();
            child.TopLevel = false;  // Formu panel içinde gösterebilmek için
            child.FormBorderStyle = FormBorderStyle.None;
            child.Dock = DockStyle.Fill;
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(child);
            child.Show();
        }
    }
}
