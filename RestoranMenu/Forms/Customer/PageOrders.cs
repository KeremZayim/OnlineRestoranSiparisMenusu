using Bunifu.UI.WinForms;
using Bunifu.UI.WinForms.BunifuButton;
using RestoranMenu.Classes;
using RestoranMenu.Classes.Fonksiyonlar;
using RestoranMenu.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace RestoranMenu.Forms.Customer
{
    public partial class PageOrders : Form
    {

        /*
         
        1-) Ürün Fiyatı Alma
        2-) Komponentler
            2.1-) lblUrunAdi
            2.2-) lblFiyat
            2.3-) btnAzalt
            2.4-) btnArtir
            2.5-) lblAdet
            2.6-) pnlUrun
            2.7-) pnlUrunAdet
            2.8-) pnlUrunFiyat
            2.9-) pnlGidaSatir
        3-) Komponentleri Panele Ekleme
        4-) Buton Click Eventleri
            4.1-) Azalt Butonu
            4.2-) Artır Butonu
            4.3-) Sepete Ekle Butonu
        5-) Listeleme Fonksiyonu

         */

        string query;
        int price = 0, totalPrice = 0, adet = 1;
        int yOffset = 0;
        // Listeleme İçin


        public PageOrders()
        {
            InitializeComponent();
            this.FormClosing += PageOrders_FormClosing; // Form gizlendiğinde sipariş bilgilerini kaydet
        }


        private void PageOrders_Shown(object sender, EventArgs e)
        {
            // Önceki siparişleri temizle
            pnlOrders.Controls.Clear();
            Veriler.urunListesi.Clear();
            totalPrice = 0;
            lblTotalPrice.Text = "0";

            // TemporaryDatas'taki sipariş bilgilerini yükle
            if (Veriler.Siparisler.Count > 0)
            {
                // Koleksiyonun bir kopyasını al
                var siparislerKopya = new Dictionary<string, int>(Veriler.Siparisler);

                foreach (var gida in siparislerKopya.Keys)
                {
                    UrunEkle(gida, siparislerKopya[gida]);
                }
            }
            else
            {
                // Yeni ürünleri ekle
                foreach (var gida in Veriler.Siparisler)
                {
                    UrunEkle(gida.Key, adet);
                }
            }
        }

        private void UrunEkle(string gida, int adet)
        {
            // Eğer ürün zaten eklenmişse adet ve fiyatı günceller
            if (Veriler.urunListesi.ContainsKey(gida))
            {
                var urun = Veriler.urunListesi[gida];
                urun.adetLabel.Text = adet.ToString();
                urun.fiyatLabel.Text = (urun.fiyat * adet).ToString();

                totalPrice += urun.fiyat * adet;
                lblTotalPrice.Text = totalPrice.ToString();

                // TemporaryDatas'ı günceller
                Veriler.Siparisler[gida] = adet;
                return;
            }

            // 1-)
            using (SqlConnection con = new SqlConnection(SqlServer.ConnectionString))
            {
                query = "SELECT food_price " +
                    "FROM foods " +
                    "WHERE food_name ='" + gida + "'";

                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    price = int.Parse(reader["food_price"].ToString().Trim());
                }

                con.Close();
            }

            // 
            // 2.1-)
            // 
            BunifuLabel lblUrunAdi = new BunifuLabel();
            lblUrunAdi.AllowParentOverrides = false;
            lblUrunAdi.AutoEllipsis = false;
            lblUrunAdi.AutoSize = false;
            lblUrunAdi.CursorType = System.Windows.Forms.Cursors.Default;
            lblUrunAdi.Font = new System.Drawing.Font("Segoe UI", 9F);
            lblUrunAdi.Location = new System.Drawing.Point(45, 3);
            lblUrunAdi.Name = "lblUrunAdi";
            lblUrunAdi.RightToLeft = System.Windows.Forms.RightToLeft.No;
            lblUrunAdi.Size = new System.Drawing.Size(149, 58);
            lblUrunAdi.TabIndex = 2;
            lblUrunAdi.Text = gida;
            lblUrunAdi.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            lblUrunAdi.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;

            // 
            // 2.2-)
            // 
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
            lblFiyat.Size = new System.Drawing.Size(74, 64);
            lblFiyat.TabIndex = 3;
            lblFiyat.Text = (price * adet).ToString();
            lblFiyat.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            lblFiyat.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;

            // 
            // 2.5-)
            // 
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
            lblAdet.Size = new System.Drawing.Size(74, 64);
            lblAdet.TabIndex = 3;
            lblAdet.Text = adet.ToString();
            lblAdet.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            lblAdet.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;

            // 
            // 2.3-)
            // 
            BunifuButton btnAzalt = new BunifuButton();
            btnAzalt.Location = new System.Drawing.Point(14, 20);
            btnAzalt.Name = "btnAzalt";
            btnAzalt.Size = new System.Drawing.Size(24, 24);
            btnAzalt.TabIndex = 0;
            btnAzalt.Text = "-";
            btnAzalt.Click += BtnAzalt_Click;
            btnAzalt.Tag = gida; // Ürün adını Tag olarak ata

            // 
            // 2.4-)
            // 
            BunifuButton btnArtir = new BunifuButton();
            btnArtir.Location = new System.Drawing.Point(200, 20);
            btnArtir.Name = "btnArtir";
            btnArtir.Size = new System.Drawing.Size(24, 24);
            btnArtir.TabIndex = 1;
            btnArtir.Text = "+";
            btnArtir.Click += BtnArtır_Click;
            btnArtir.Tag = gida; // Ürün adını Tag olarak ata

            // 
            // 2.6-)
            // 
            BunifuPanel pnlUrun = new BunifuPanel();
            pnlUrun.BackgroundColor = System.Drawing.Color.Violet;
            pnlUrun.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            pnlUrun.BorderColor = System.Drawing.Color.Transparent;
            pnlUrun.BorderRadius = 3;
            pnlUrun.BorderThickness = 1;
            pnlUrun.Controls.Add(lblUrunAdi);
            pnlUrun.Controls.Add(btnArtir);
            pnlUrun.Controls.Add(btnAzalt);
            pnlUrun.Location = new System.Drawing.Point(85, 5);
            pnlUrun.Name = "pnlUrun";
            pnlUrun.ShowBorders = true;
            pnlUrun.Size = new System.Drawing.Size(240, 64);
            pnlUrun.TabIndex = 0;

            // 
            // 2.7-)
            // 
            BunifuPanel pnlUrunAdet = new BunifuPanel();
            pnlUrunAdet.BackgroundColor = System.Drawing.Color.Violet;
            pnlUrunAdet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            pnlUrunAdet.BorderColor = System.Drawing.Color.Transparent;
            pnlUrunAdet.BorderRadius = 3;
            pnlUrunAdet.BorderThickness = 1;
            pnlUrunAdet.Controls.Add(lblFiyat);
            pnlUrunAdet.Location = new System.Drawing.Point(5, 5);
            pnlUrunAdet.Name = price.ToString();
            pnlUrunAdet.ShowBorders = true;
            pnlUrunAdet.Size = new System.Drawing.Size(75, 65);
            pnlUrunAdet.TabIndex = 3;

            // 
            // 2.8-)
            // 
            BunifuPanel pnlUrunFiyat = new BunifuPanel();
            pnlUrunFiyat.BackgroundColor = System.Drawing.Color.Violet;
            pnlUrunFiyat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            pnlUrunFiyat.BorderColor = System.Drawing.Color.Transparent;
            pnlUrunFiyat.BorderRadius = 3;
            pnlUrunFiyat.BorderThickness = 1;
            pnlUrunFiyat.Controls.Add(lblFiyat);
            pnlUrunFiyat.Location = new System.Drawing.Point(330, 5);
            pnlUrunFiyat.Name = price.ToString();
            pnlUrunFiyat.ShowBorders = true;
            pnlUrunFiyat.Size = new System.Drawing.Size(75, 65);
            pnlUrunFiyat.TabIndex = 3;

            // 
            // 2.9-)
            // 
            BunifuPanel pnlGidaSatir = new BunifuPanel();
            pnlGidaSatir.BackgroundColor = System.Drawing.Color.Thistle;
            pnlGidaSatir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            pnlGidaSatir.BorderColor = System.Drawing.Color.Transparent;
            pnlGidaSatir.BorderRadius = 3;
            pnlGidaSatir.BorderThickness = 1;
            pnlGidaSatir.Name = "pnlGidaSatir";
            pnlGidaSatir.ShowBorders = true;
            pnlGidaSatir.Size = new System.Drawing.Size(410, 74);
            pnlGidaSatir.TabIndex = 3;
            pnlGidaSatir.Location = new System.Drawing.Point(0, yOffset);


            // 3-)
            pnlUrunFiyat.Controls.Add(lblFiyat);
            pnlUrunAdet.Controls.Add(lblAdet);
            pnlUrun.Controls.Add(lblUrunAdi);
            pnlUrun.Controls.Add(btnAzalt);
            pnlUrun.Controls.Add(btnArtir);

            pnlGidaSatir.Controls.Add(pnlUrunAdet);
            pnlGidaSatir.Controls.Add(pnlUrun);
            pnlGidaSatir.Controls.Add(pnlUrunFiyat);

            // Yeni satırın Y konumunu artır
            yOffset += 80;

            pnlOrders.Controls.Add(pnlGidaSatir);
            // Toplam fiyatı güncelle
            totalPrice += price * adet;
            lblTotalPrice.Text = totalPrice.ToString();

            // Ürünü listeye ekle
            Veriler.urunListesi.Add(gida, (lblAdet, lblFiyat, price, pnlGidaSatir));
            Veriler.Siparisler[gida] = adet; // TemporaryDatas'a ekle
        }

        private void PageOrders_FormClosing(object sender, EventArgs e)
        {
            // Form gizlendiğinde sipariş bilgilerini TemporaryDatas'a kaydet
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
                    // Eğer adet 1 ise ürünü tamamen kaldır
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
            if (Veriler.Siparisler.Count>1)
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
            // Önceki siparişleri temizle
            pnlOrders.Controls.Clear();
            Veriler.urunListesi.Clear();
            totalPrice = 0;
            lblTotalPrice.Text = "0";

            // TemporaryDatas'taki sipariş bilgilerini yükle
            if (Veriler.Siparisler.Count > 0)
            {
                // Koleksiyonun bir kopyasını al
                var siparislerKopya = new Dictionary<string, int>(Veriler.Siparisler);

                foreach (var gida in siparislerKopya.Keys)
                {
                    UrunEkle(gida, siparislerKopya[gida]);
                }
            }
        }
    }
}
