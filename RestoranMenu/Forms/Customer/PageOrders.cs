using Bunifu.UI.WinForms;
using Bunifu.UI.WinForms.BunifuButton;
using RestoranMenu.Classes;
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
         
        1-) Komponentler
            1.1-) lblUrunAdi
            1.2-) lblFiyat
            1.3-) btnAzalt
            1.4-) btnArtir
            1.5-) lblAdet
            1.6-) pnlUrun
            1.7-) pnlUrunAdet
            1.8-) pnlUrunFiyat
            1.9-) pnlGidaSatir
        2-) Ürün Fiyatı Alma
        3-) Komponentleri Panele Ekleme
        4-) Buton Click Eventleri
            4.1-) Azalt Butonu
            4.2-) Artır Butonu

         */
        public PageOrders()
        {
            InitializeComponent();
        }
        string query;
        int price, totalPrice = 0, adet;

        private void PageOrders_Shown(object sender, EventArgs e)
        {
            foreach (var gida in Veriler.foods)
            {
                // 
                // 1.1-)
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

                // 2-)
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
                // 1.2-)
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
                lblFiyat.Text = price.ToString();
                lblFiyat.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
                lblFiyat.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;

                // 
                // 1.3-)
                // 
                BunifuButton btnAzalt = new BunifuButton();
                btnAzalt.Location = new System.Drawing.Point(14, 20);
                btnAzalt.Name = "btnAzalt";
                btnAzalt.Size = new System.Drawing.Size(24, 24);
                btnAzalt.TabIndex = 0;
                btnAzalt.Text = "-";
                btnAzalt.Click += BtnAzalt_Click;

                // 
                // 1.4-)
                // 
                BunifuButton btnArtir = new BunifuButton();
                btnArtir.Location = new System.Drawing.Point(200, 20);
                btnArtir.Name = "btnArtir";
                btnArtir.Size = new System.Drawing.Size(24, 24);
                btnArtir.TabIndex = 1;
                btnArtir.Text = "+";
                btnArtir.Click += BtnArtır_Click;

                // 
                // 1.5-)
                // 
                BunifuLabel lblAdet = new BunifuLabel();
                lblAdet.AllowParentOverrides = false;
                lblAdet.AutoEllipsis = false;
                lblAdet.AutoSize = false;
                lblAdet.CursorType = null;
                lblAdet.Dock = System.Windows.Forms.DockStyle.Fill;
                lblAdet.Font = new System.Drawing.Font("Segoe UI", 9F);
                lblAdet.Location = new System.Drawing.Point(0, 0);
                lblAdet.Name = "lblFiyat";
                lblAdet.RightToLeft = System.Windows.Forms.RightToLeft.No;
                lblAdet.Size = new System.Drawing.Size(74, 64);
                lblAdet.TabIndex = 3;
                lblAdet.Text = adet.ToString();
                lblAdet.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
                lblAdet.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;

                // 
                // 1.6-)
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
                // 1.7-)
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
                // 1.8-)
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
                // 1.9-) pnlGidaSatir
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

                // 3-)
                pnlUrunFiyat.Controls.Add(lblFiyat);
                pnlUrunAdet.Controls.Add(lblAdet);
                pnlUrun.Controls.Add(lblUrunAdi);
                pnlUrun.Controls.Add(btnAzalt);
                pnlUrun.Controls.Add(btnArtir);

                pnlGidaSatir.Controls.Add(pnlUrunAdet);
                pnlGidaSatir.Controls.Add(pnlUrun);
                pnlGidaSatir.Controls.Add(pnlUrunFiyat);


                pnlOrders.Controls.Add(pnlGidaSatir);
                //Toplam Fiyatı Yazdırma
                totalPrice += price;
                lblTotalPrice.Text = totalPrice.ToString();
            }
        }
        // 4.1-)
        private void BtnAzalt_Click(object sender, EventArgs e)
        {
            //adet--;
        }
        // 4.2-)
        private void BtnArtır_Click(object sender, EventArgs e)
        {
            //adet++;
        }
    }
}
