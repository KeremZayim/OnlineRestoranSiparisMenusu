using Bunifu.UI.WinForms.BunifuButton;
using RestoranMenu.Classes;
using RestoranMenu.Forms.Customer;
using System;
using System.Linq;
using System.Windows.Forms;

namespace RestoranMenu
{
    public partial class PageMain : Form
    {
        public PageMain()
        {
            InitializeComponent();
        }

        private void PageMain_Shown(object sender, EventArgs e)
        {
            lblYonetimBar.Text = Veriler.ad + " " + Veriler.soyad + " | Yummy Day Menü";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        string query;

        private void MenuButonlari(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            BunifuButton tiklananKategori = (BunifuButton)sender;
            PageListFoods child = pnlMain.Controls.OfType<PageListFoods>().FirstOrDefault();

            if (child == null) // Eğer form yoksa, yeni form oluştur
            {
                child = new PageListFoods();
                child.TopLevel = false;  // Formu panel içinde gösterebilmek için
                child.FormBorderStyle = FormBorderStyle.None;  // Kenarlıkları kaldır
                child.Dock = DockStyle.Fill;  // Paneli tamamen kaplasın
                pnlMain.Controls.Clear();  // Panel içindekileri temizle
                pnlMain.Controls.Add(child);  // Formu panele ekle
                child.Show();  // Formu göster
            }

            // Tiklanan butona göre veritabanı sorgusu
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
                child.LoadFoods(query);  // Child formdaki fonksiyonu çağır
            }
        }

        private void btnSepet_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            PageOrders child = pnlMain.Controls.OfType<PageOrders>().FirstOrDefault();
            child = new PageOrders();
            child.TopLevel = false;  // Formu panel içinde gösterebilmek için
            child.FormBorderStyle = FormBorderStyle.None;  // Kenarlıkları kaldır
            child.Dock = DockStyle.Fill;  // Paneli tamamen kaplasın
            pnlMain.Controls.Clear();  // Panel içindekileri temizle
            pnlMain.Controls.Add(child);  // Formu panele ekle
            child.Show();  // Formu göster
        }
    }
}
