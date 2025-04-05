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
using Bunifu.UI.WinForms;
using RestoranMenu.Classes;

namespace RestoranMenu.Forms.Administrator
{
    public partial class PageAnalysis : Form
    {
        /*
          
         1-) Son Satılan Ürünler
            1.1-) Resim Verisi Çekme

            1.2-) Komponentler
                1.2.1-) Ürün Panel
                1.2.2-) Picture Box
                1.2.3-) Ürün Adı
                1.2.4-) Adet Bilgisi

            1.3-) Komponent Eklemeleri

         2-) En Çok Satılan Ürünler
            2.1-) Resim Verisi Çekme

            2.2-) Komponentler
                2.2.1-) Ürün Paneli
                2.2.2-) Ürün Resmi
                2.2.3-) Ürün Adı 
                2.2.4-) Ürün Adedi

            2.3-) Komponentleri Ekleme

         3-) Diğer Bilgileri Listeleme
            3.1-) Toplam Satılan Ürün Adeti
            3.2-) Toplam Satılan Ürün Fiyatı
            3.3-) En Çok Satılan Ürün
            3.4-) Toplam Müşteri Sayısı
            3.5-) Toplam Sipariş Sayısı
            3.6-) En Çok Sipariş Veren Müşteri

         4-) Veri Listeleme

         */

        SqlConnection con = new SqlConnection(SqlServer.ConnectionString);
        public PageAnalysis()
        {
            InitializeComponent();
            VerileriGetir();
        }

        // 1-)
        private void SonSatilanlariListele()
        {
            foreach (Control ctrl in pnlSonSatilanlar.Controls.OfType<Control>().ToList())
            {
                if (ctrl != pnlSonSatilanlarHeader)
                {
                    pnlSonSatilanlar.Controls.Remove(ctrl);
                    ctrl.Dispose();  // Bellekten kaldır
                }
            }

            using (SqlConnection con = new SqlConnection(SqlServer.ConnectionString))
            {
                con.Open();
                string query = @"
                    SELECT TOP 5 f.food_name, od.quantity AS Adet, f.food_picture, o.order_date
                    FROM dbo.order_details od
                    JOIN dbo.orders o ON od.order_id = o.order_id
                    JOIN dbo.foods f ON od.food_id = f.food_id
                    ORDER BY o.order_date DESC";

                using (SqlCommand cmd = new SqlCommand(query, con))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    int yOffset = 60; // İlk öğe 60px aşağıdan başlıyor
                    while (reader.Read())
                    {
                        string foodName = reader["food_name"].ToString();
                        int adet = Convert.ToInt32(reader["Adet"]);
                        Image foodImage = Properties.Resources.error_cloud; // Varsayılan resim

                        // 1.1-)
                        if (reader["food_picture"] != DBNull.Value)
                        {
                            byte[] imageData = (byte[])reader["food_picture"];
                            using (MemoryStream ms = new MemoryStream(imageData))
                            {
                                foodImage = Image.FromStream(ms);
                            }
                        }

                        // 1.2.1-)
                        Panel urunPanel = new Panel
                        {
                            Size = new Size(300, 50),
                            Location = new Point(15, yOffset),
                            BackColor = Color.White
                        };

                        // 1.2.2-)
                        BunifuPictureBox pbUrunResmi = new BunifuPictureBox
                        {
                            Size = new Size(50, 50),
                            Location = new Point(5, 0),
                            Image = foodImage,
                            SizeMode = PictureBoxSizeMode.StretchImage
                        };

                        // 1.2.3-)
                        BunifuLabel lblUrunAdi = new BunifuLabel
                        {
                            Text = foodName,
                            Font = new Font("Segoe UI", 10, FontStyle.Bold),
                            AutoSize = true,
                            Location = new Point(65, 15)
                        };

                        // 1.2.4-)
                        BunifuLabel lblAdet = new BunifuLabel
                        {
                            Text = adet.ToString() + " Adet",
                            Font = new Font("Segoe UI", 10, FontStyle.Bold),
                            AutoSize = true,
                            Location = new Point(250, 15)
                        };

                        // 1.3

                        urunPanel.Controls.Add(pbUrunResmi);
                        urunPanel.Controls.Add(lblUrunAdi);
                        urunPanel.Controls.Add(lblAdet);
                        pnlSonSatilanlar.Controls.Add(urunPanel);

                        yOffset += 55; // Bir sonraki öğeye yer açma (aşağıya kaydırma)
                    }
                }
                con.Close();
            }
        }

        // 2-)
        private void EnCokSatilanlariListele()
        {
            foreach (Control ctrl in pnlEnCokSatilanlar.Controls.OfType<Control>().ToList())
            {
                if (ctrl != pnlEnCokSatilanlarHeader)
                {
                    pnlEnCokSatilanlar.Controls.Remove(ctrl);
                    ctrl.Dispose();  // Bellekten kaldır
                }
            }

            using (SqlConnection con = new SqlConnection(SqlServer.ConnectionString))
            {
                con.Open();
                string query = @"
                    SELECT TOP 5 f.food_name, SUM(od.quantity) AS Adet, f.food_picture
                    FROM dbo.order_details od
                    JOIN dbo.foods f ON od.food_id = f.food_id
                    GROUP BY f.food_name, f.food_picture
                    ORDER BY Adet DESC";

                using (SqlCommand cmd = new SqlCommand(query, con))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    int yOffset = 60; // İlk öğe 60px aşağıdan başlıyor
                    while (reader.Read())
                    {
                        string foodName = reader["food_name"].ToString();
                        int adet = Convert.ToInt32(reader["Adet"]);
                        Image foodImage = Properties.Resources.error_cloud; // Varsayılan resim

                        // 2.1-)
                        if (reader["food_picture"] != DBNull.Value)
                        {
                            byte[] imageData = (byte[])reader["food_picture"];
                            using (MemoryStream ms = new MemoryStream(imageData))
                            {
                                foodImage = Image.FromStream(ms); // Byte dizisini resme çevir
                            }
                        }

                        // 2.2.1-)
                        Panel urunPanel = new Panel
                        {
                            Size = new Size(300, 50),
                            Location = new Point(15, yOffset),
                            BackColor = Color.White,
                            AutoScroll = true
                        };

                        // 2.2.2-)
                        BunifuPictureBox pbUrunResmi = new BunifuPictureBox
                        {
                            Size = new Size(50, 50),
                            Location = new Point(5, 0),
                            IsCircle = false,
                            Type = BunifuPictureBox.Types.Square,
                            BorderRadius = 5,
                            Image = foodImage,
                            SizeMode = PictureBoxSizeMode.StretchImage
                        };

                        // 2.2.3-)
                        BunifuLabel lblUrunAdi = new BunifuLabel
                        {
                            Text = foodName,
                            Font = new Font("Segoe UI", 10, FontStyle.Bold),
                            AutoSize = true,
                            Location = new Point(65, 15)
                        };
                        // 2.2.4-)
                        BunifuLabel lblAdet = new BunifuLabel
                        {
                            Text = adet.ToString() + " Adet",
                            Font = new Font("Segoe UI", 10, FontStyle.Bold),
                            AutoSize = true,
                            Location = new Point(250, 15)
                        };

                        // 2.3-)
                        urunPanel.Controls.Add(pbUrunResmi);
                        urunPanel.Controls.Add(lblUrunAdi);
                        urunPanel.Controls.Add(lblAdet);
                        pnlEnCokSatilanlar.Controls.Add(urunPanel);

                        yOffset += 55; // Bir sonraki öğe için mesafe artırma (aşağı kaydırma)
                    }
                }
                con.Close();
            }
        }

        // 3-)
        private void DigerListele()
        {
            con.Open();
            // 3.1-)
            using (SqlCommand cmd = new SqlCommand("SELECT SUM(quantity) FROM dbo.order_details", con))
            {
                lblToplamSatisAdet.Text = "Toplam Satılan Ürün Adeti: " + cmd.ExecuteScalar();
            }

            // 3.2-)
            using (SqlCommand cmd = new SqlCommand(@"
                    SELECT SUM(od.quantity * f.food_price) 
                    FROM dbo.order_details od
                    JOIN dbo.foods f ON od.food_id = f.food_id", con))
            {
                lblToplamSatilanUrunFiyati.Text = "Toplam Satılan Ürün Fiyatı: " + cmd.ExecuteScalar();
            }

            // 3.3-)
            using (SqlCommand cmd = new SqlCommand(@"
                    SELECT TOP 1 f.food_name, SUM(od.quantity) AS Adet
                    FROM dbo.order_details od
                    JOIN dbo.foods f ON od.food_id = f.food_id
                    GROUP BY f.food_name
                    ORDER BY Adet DESC", con))
            {
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        lblEnCokSatilanUrunAdi.Text = "En Çok Satılan Ürün: " + reader[0].ToString();
                        lblEnCokSatilanUrunAdedi.Text = "Adeti: " + reader[1].ToString();
                    }
                }
            }

            // 3.4-)
            using (SqlCommand cmd = new SqlCommand("SELECT COUNT(DISTINCT user_id) FROM dbo.orders", con))
            {
                lblToplamMusteri.Text = "Toplam Müşteri Sayısı: " + cmd.ExecuteScalar();
            }

            // 3.5-)
            using (SqlCommand cmd = new SqlCommand("SELECT COUNT(order_id) FROM dbo.orders", con))
            {
                lblToplamSiparis.Text = "Toplam Sipariş Sayısı: " + cmd.ExecuteScalar();
            }

            // 3.6-)
            using (SqlCommand cmd = new SqlCommand(@"
                    SELECT TOP 1 u.name + ' ' + u.surname, COUNT(o.order_id) AS Adet
                    FROM dbo.orders o
                    JOIN dbo.users u ON o.user_id = u.user_id
                    GROUP BY u.name, u.surname
                    ORDER BY Adet DESC", con))
            {
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        lblEnCokSiparisVerenMusteri.Text = "En Çok Sipariş Veren Müşteri : " + reader[0].ToString();
                        lblEnCokSiparisVerenMusteriAdet.Text = "Adeti: " + reader[1].ToString();
                    }
                }
            }
            con.Close();
        }

        // 4-)
        private void VerileriGetir()
        {
            SonSatilanlariListele();
            EnCokSatilanlariListele();
            DigerListele();
        }
    }
}
