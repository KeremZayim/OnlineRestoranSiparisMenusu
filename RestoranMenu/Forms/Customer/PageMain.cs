using RestoranMenu.Classes;
using RestoranMenu.Forms.Customer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestoranMenu
{
    public partial class PageMain: Form
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
            Button tiklananKategori = (Button)sender;
            switch (tiklananKategori.Text)
            {
                case "Çorbalar":
                    break;
                case "Tatlılar":
                    query = "SELECT food_name, food_calorie, food_price, food_picture FROM foods";
                    break;
                case "İçecekler":
                    break;
                case "Et Yemekleri":
                    break;
                case "Sebze Yemekleri":
                    break;
                case "Makarnalar":
                    break;
                case "Salatalar":
                    break;

                default:
                    break;
            }
        }
    }
}
