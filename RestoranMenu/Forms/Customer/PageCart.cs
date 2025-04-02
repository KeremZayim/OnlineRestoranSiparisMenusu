using Bunifu.UI.WinForms;
using Bunifu.UI.WinForms.BunifuButton;
using RestoranMenu.Classes;
using RestoranMenu.Classes.Fonksiyonlar;
using RestoranMenu.Forms.Customer;
using RestoranMenu.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace RestoranMenu.Forms.Customer
{
    /*
         
        1-) Ürün Fiyatı Alma
        2-) Komponentler
            2.1-) pbFood
            2.2-) lblUrunAdi
            2.3-) lblFiyat
            2.4-) lblAdet
            2.5-) btnAzalt
            2.6-) btnArtır
            2.7-) pnlUrun
            2.8-) pnlUrunAdet
            2.9-) pnlUrunFiyat
            2.10-) pnlGidaSatir
        3-) Komponentleri Panele Ekleme
        4-) Buton Click Eventleri
            4.1-) Azalt Butonu
            4.2-) Artır Butonu
            4.3-) Sepete Ekle Butonu
        5-) Sipariş Listesini Yenileme ve Listeleme

    */

    public partial class PageCart : Form
    {
        string query;
        int price = 0, totalPrice = 0, adet = 1;
        int yOffset = 0;

        public PageCart()
        {
            InitializeComponent();
            this.FormClosing += PageOrders_FormClosing;
        }

        private void PageOrders_Shown(object sender, EventArgs e)
        {
            pnlOrders.Controls.Clear();
            Veriler.urunListesi.Clear();
            totalPrice = 0;
            lblTotalPrice.Text = "0";

            if (Veriler.Siparisler.Count > 0)
            {
                var siparislerKopya = new Dictionary<string, int>(Veriler.Siparisler);
                foreach (var gida in siparislerKopya.Keys)
                {
                    UrunEkle(gida, siparislerKopya[gida]);
                }
            }
            else
            {
                foreach (var gida in Veriler.Siparisler)
                {
                    UrunEkle(gida.Key, adet);
                }
            }
        }

        private void UrunEkle(string gida, int adet)
        {
            if (Veriler.urunListesi.ContainsKey(gida))
            {
                var urun = Veriler.urunListesi[gida];
                urun.adetLabel.Text = adet.ToString();
                urun.fiyatLabel.Text = (urun.fiyat * adet).ToString();

                totalPrice += urun.fiyat * adet;
                lblTotalPrice.Text = totalPrice.ToString();

                Veriler.Siparisler[gida] = adet;
                return;
            }

            // x-)
            byte[] foodImage = null;
            using (SqlConnection con = new SqlConnection(SqlServer.ConnectionString))
            {
                query = "SELECT food_price, food_picture FROM foods WHERE food_name ='" + gida + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    price = int.Parse(reader["food_price"].ToString().Trim());
                    if (reader["food_picture"] != DBNull.Value)
                    {
                        foodImage = (byte[])reader["food_picture"];
                    }
                }
                con.Close();
            }

            // 2.1-)
            BunifuPictureBox pbFood = new BunifuPictureBox();
            pbFood.AllowFocused = false;
            pbFood.Anchor = System.Windows.Forms.AnchorStyles.None;
            pbFood.AutoSizeHeight = true;
            pbFood.BorderRadius = 20;
            pbFood.IsCircle = false;
            pbFood.Name = "pbFood_" + gida;
            pbFood.Size = new Size(70, 70);
            pbFood.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pbFood.TabIndex = 0;
            pbFood.TabStop = false;
            pbFood.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square;
            pbFood.Location = new Point(10, 10);

            if (foodImage != null)
            {
                using (MemoryStream ms = new MemoryStream(foodImage))
                {
                    pbFood.Image = Image.FromStream(ms);
                }
            }

            // 2.2-)
            BunifuLabel lblUrunAdi = new BunifuLabel();
            lblUrunAdi.AllowParentOverrides = false;
            lblUrunAdi.AutoEllipsis = false;
            lblUrunAdi.AutoSize = false;
            lblUrunAdi.CursorType = System.Windows.Forms.Cursors.Default;
            lblUrunAdi.Font = new System.Drawing.Font("Segoe UI", 9F);
            lblUrunAdi.Location = new System.Drawing.Point(80, 0);
            lblUrunAdi.Name = "lblUrunAdi";
            lblUrunAdi.RightToLeft = System.Windows.Forms.RightToLeft.No;
            lblUrunAdi.Size = new System.Drawing.Size(430, 70);
            lblUrunAdi.TabIndex = 2;
            lblUrunAdi.Text = gida;
            lblUrunAdi.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            lblUrunAdi.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;

            // 2.3-)
            BunifuLabel lblFiyat = new BunifuLabel();
            lblFiyat.AllowParentOverrides = false;
            lblFiyat.AutoEllipsis = false;
            lblFiyat.AutoSize = false;
            lblFiyat.CursorType = null;
            lblFiyat.Dock = System.Windows.Forms.DockStyle.Fill;
            lblFiyat.Font = new System.Drawing.Font("Segoe UI", 9F);
            lblFiyat.Location = new System.Drawing.Point(0, 0);
            lblFiyat.Name = "lblFiyat";
            lblFiyat.RightToLeft = System.Windows.Forms.RightToLeft.No;
            lblFiyat.Size = new System.Drawing.Size(75, 70);
            lblFiyat.TabIndex = 3;
            lblFiyat.Text = (price * adet).ToString();
            lblFiyat.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            lblFiyat.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;

            // 2.4-)
            BunifuLabel lblAdet = new BunifuLabel();
            lblAdet.Name = "lblAdet";
            lblAdet.AllowParentOverrides = false;
            lblAdet.AutoEllipsis = false;
            lblAdet.AutoSize = false;
            lblAdet.CursorType = null;
            lblAdet.Dock = System.Windows.Forms.DockStyle.Fill;
            lblAdet.Font = new System.Drawing.Font("Segoe UI", 9F);
            lblAdet.Location = new System.Drawing.Point(0, 0);
            lblAdet.RightToLeft = System.Windows.Forms.RightToLeft.No;
            lblAdet.Size = new System.Drawing.Size(75, 70);
            lblAdet.TabIndex = 3;
            lblAdet.Text = adet.ToString();
            lblAdet.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            lblAdet.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;

            // 2.5-)
            BunifuButton btnAzalt = new BunifuButton();
            btnAzalt.Location = new System.Drawing.Point(20, 15);
            btnAzalt.Name = "btnAzalt";
            btnAzalt.Size = new System.Drawing.Size(40, 40);
            btnAzalt.TabIndex = 0;
            btnAzalt.Text = "-";
            btnAzalt.Click += BtnAzalt_Click;
            btnAzalt.Tag = gida;

            // 2.6-)
            BunifuButton btnArtir = new BunifuButton();
            btnArtir.Location = new System.Drawing.Point(540, 15);
            btnArtir.Name = "btnArtir";
            btnArtir.Size = new System.Drawing.Size(40, 40);
            btnArtir.TabIndex = 1;
            btnArtir.Text = "+";
            btnArtir.Click += BtnArtır_Click;
            btnArtir.Tag = gida;

            // 2.7-)
            BunifuPanel pnlUrun = new BunifuPanel();
            pnlUrun.BackgroundColor = System.Drawing.Color.FromArgb(59, 125, 203);
            pnlUrun.BorderColor = Color.Transparent;
            pnlUrun.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            pnlUrun.BorderRadius = 3;
            pnlUrun.BorderThickness = 1;
            pnlUrun.Controls.Add(lblUrunAdi);
            pnlUrun.Controls.Add(btnArtir);
            pnlUrun.Controls.Add(btnAzalt);
            pnlUrun.Location = new System.Drawing.Point(210, 10);
            pnlUrun.Name = "pnlUrun";
            pnlUrun.ShowBorders = true;
            pnlUrun.Size = new System.Drawing.Size(600, 70);
            pnlUrun.TabIndex = 0;

            // 2.8-)
            BunifuPanel pnlUrunAdet = new BunifuPanel();
            pnlUrunAdet.BackgroundColor = Color.FromArgb(59, 125, 203);
            pnlUrunAdet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            pnlUrunAdet.BorderColor = Color.Transparent;
            pnlUrunAdet.BorderRadius = 3;
            pnlUrunAdet.BorderThickness = 0;
            pnlUrunAdet.Controls.Add(lblFiyat);
            pnlUrunAdet.Location = new System.Drawing.Point(125, 10);
            pnlUrunAdet.Name = price.ToString();
            pnlUrunAdet.ShowBorders = false;
            pnlUrunAdet.Size = new System.Drawing.Size(75, 70);
            pnlUrunAdet.TabIndex = 3;

            // 2.9-)
            BunifuPanel pnlUrunFiyat = new BunifuPanel();
            pnlUrunFiyat.BackgroundColor = Color.FromArgb(59, 125, 203);
            pnlUrunFiyat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            pnlUrunFiyat.BorderColor = Color.Transparent;
            pnlUrunFiyat.BorderRadius = 3;
            pnlUrunFiyat.BorderThickness = 0;
            pnlUrunFiyat.Controls.Add(lblFiyat);
            pnlUrunFiyat.Location = new System.Drawing.Point(820, 10);
            pnlUrunFiyat.Name = price.ToString();
            pnlUrunFiyat.ShowBorders = false;
            pnlUrunFiyat.Size = new System.Drawing.Size(75, 70);
            pnlUrunFiyat.TabIndex = 3;

            // 2.10-)
            BunifuPanel pnlGidaSatir = new BunifuPanel();
            pnlGidaSatir.BackgroundColor = Color.FromArgb(59, 125, 203);
            pnlGidaSatir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            pnlGidaSatir.BorderColor = Color.Transparent;
            pnlGidaSatir.BorderRadius = 3;
            pnlGidaSatir.BorderThickness = 0;
            pnlGidaSatir.Name = "pnlGidaSatir";
            pnlGidaSatir.ShowBorders = false;
            pnlGidaSatir.Size = new System.Drawing.Size(950, 90);
            pnlGidaSatir.TabIndex = 3;
            pnlGidaSatir.Location = new System.Drawing.Point(0, yOffset);

            // 3-)
            pnlUrunFiyat.Controls.Add(lblFiyat);
            pnlUrunAdet.Controls.Add(lblAdet);
            pnlUrun.Controls.Add(lblUrunAdi);
            pnlUrun.Controls.Add(btnAzalt);
            pnlUrun.Controls.Add(btnArtir);

            pnlGidaSatir.Controls.Add(pbFood);
            pnlGidaSatir.Controls.Add(pnlUrunAdet);
            pnlGidaSatir.Controls.Add(pnlUrun);
            pnlGidaSatir.Controls.Add(pnlUrunFiyat);

            yOffset += 95;

            pnlOrders.Controls.Add(pnlGidaSatir);
            totalPrice += price * adet;
            lblTotalPrice.Text = totalPrice.ToString();

            Veriler.urunListesi.Add(gida, (lblAdet, lblFiyat, price, pnlGidaSatir));
            Veriler.Siparisler[gida] = adet;
        }

        // Form Kapanırken Siparişlerin Kayıt Edilmesi
        private void PageOrders_FormClosing(object sender, EventArgs e)
        {
            Veriler.Siparisler = new Dictionary<string, int>(Veriler.urunListesi.ToDictionary(x => x.Key, x => int.Parse(x.Value.adetLabel.Text)));
        }

        // 4-)
            // 4.1-)
        private void BtnAzalt_Click(object sender, EventArgs e)
        {
            if (sender is BunifuButton btn && btn.Tag is string gida && Veriler.urunListesi.ContainsKey(gida))
            {
                var urun = Veriler.urunListesi[gida];
                int adet = int.Parse(urun.adetLabel.Text);

                if (adet > 1)
                {
                    adet--;
                    urun.adetLabel.Text = adet.ToString();
                    urun.fiyatLabel.Text = (adet * urun.fiyat).ToString();
                    totalPrice -= urun.fiyat;
                    Veriler.Siparisler[gida] = adet;
                }
                else
                {
                    pnlOrders.Controls.Remove(urun.panel);
                    Veriler.urunListesi.Remove(gida);
                    totalPrice -= urun.fiyat;
                    Veriler.Siparisler.Remove(gida);
                    RefreshOrderList();
                }

                lblTotalPrice.Text = totalPrice.ToString();
            }
        }
            // 4.2-)
        private void BtnArtır_Click(object sender, EventArgs e)
        {
            if (sender is BunifuButton btn && btn.Tag is string gida && Veriler.urunListesi.ContainsKey(gida))
            {
                var urun = Veriler.urunListesi[gida];
                int adet = int.Parse(urun.adetLabel.Text);
                adet++;
                urun.adetLabel.Text = adet.ToString();
                urun.fiyatLabel.Text = (adet * urun.fiyat).ToString();
                totalPrice += urun.fiyat;
                lblTotalPrice.Text = totalPrice.ToString();
                Veriler.Siparisler[gida] = adet;
            }
        }
            // 4.3-)
        private void btnSepeteEkle_Click(object sender, EventArgs e)
        {
            if (Veriler.Siparisler.Count > 1)
            {
                int orderId = SiparisOlustur.YeniSiparisEkle(int.Parse(Veriler.user_id));

                if (orderId > 0)
                {
                    foreach (var siparis in Veriler.Siparisler)
                    {
                        int foodId = SiparisOlustur.FoodIdBul(siparis.Key);
                        if (foodId > 0)
                        {
                            SiparisOlustur.SiparisDetayEkle(orderId, foodId, siparis.Value);
                        }
                    }
                    MessageBox.Show("Sipariş başarıyla eklendi.", "Başarılı", MessageBoxButtons.OK);
                    SiparisOlustur.SepetiTemizle();
                }
                else
                {
                    MessageBox.Show("Sipariş eklenirken hata oluştu.", "Başarılı", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Lütfen Sepete Ürün Ekleyiniz!", "Başarısız!", MessageBoxButtons.OK);
            }
        }

        // 5-)
        private void RefreshOrderList()
        {
            yOffset = 0;
            pnlOrders.Controls.Clear();
            Veriler.urunListesi.Clear();
            totalPrice = 0;
            lblTotalPrice.Text = "0";

            if (Veriler.Siparisler.Count > 0)
            {
                var siparislerKopya = new Dictionary<string, int>(Veriler.Siparisler);
                foreach (var gida in siparislerKopya.Keys)
                {
                    UrunEkle(gida, siparislerKopya[gida]);
                }
            }
        }
    }
}