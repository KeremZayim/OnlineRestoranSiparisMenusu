using RestoranMenu.Classes;
using RestoranMenu.Forms.Administrator;
using RestoranMenu.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestoranMenu.Forms
{
    public partial class PageLogin : Form
    {
        /*
         
            Aşağıdaki Sayıları Aratarak Hızlı Kod Düzenlemesi Yapabilirsiniz!

        1-) SQL Bağlantısı Tanımlama
        2-) Beni Hatırla Özelliği
            2.1-) Girişte Kullanıcı Adı Doldurma
            2.2-) Kullanıcı Adı Kaydetme
        3-) Girişte Veritabanı Bağlantısı Kontrolü
        4-) Kullanıcı Girişi Veritabanı Komutları
        5-) Şifre Gösterme/Gizleme
        6-) Enter Tuşu ile Giriş Yapma

        */


        // 1-) SQL Bağlantısı Tanımlıyoruz
        SqlConnection con = new SqlConnection(SqlServer.ConnectionString);

        string username;
        string password;
        bool sifreGoster = false;
        public PageLogin()
        {
            InitializeComponent();

            // 2.1-)
            if (Settings.Default.username != "")
            {
                tbKullaniciAdi.Text = Settings.Default.username;
            }

            // 3-)
            try
            {
                con.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("Veritabanı Bağlantı Hatası!");
                Application.Exit();
            }
            finally
            {
                con.Close();
            }
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            username = tbKullaniciAdi.Text.Trim();
            password = tbSifre.Text.Trim();

            // TextBox Boşluk Kontrolü
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Kullanıcı adı ve şifre giriniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // 4-)
            else
            {
                try
                {
                    con.Open();
                    string query = "SELECT username,password,user_type,name,surname,user_id FROM users WHERE username = @username AND password = @password";
                    SqlCommand command = new SqlCommand(query, con);
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);

                    SqlDataReader dataReader = command.ExecuteReader();
                    bool foundUser = false; // Kullanıcı bulundu mu?

                    while (dataReader.Read())
                    {
                        foundUser = true; // Kullanıcı bulundu

                        if (dataReader["user_type"].ToString().Trim().ToLower() == "customer")
                        {
                            PageMain AnaForm = new PageMain();
                            this.Hide();
                            AnaForm.Show();
                        }
                        else if (dataReader["user_type"].ToString().Trim().ToLower() == "admin")
                        {
                            PageSelectApp secimForm = new PageSelectApp();
                            this.Hide();
                            secimForm.Show();
                        }

                        // "Beni Hatırla" ayarları
                        Settings.Default.username = switchBeniHatirla.Checked ? tbKullaniciAdi.Text : "";
                        Settings.Default.Save();

                        // Kullanıcı bilgilerini kaydet
                        Veriler.ad = dataReader["name"].ToString().Trim();
                        Veriler.soyad = dataReader["surname"].ToString().Trim();
                        Veriler.user_id = dataReader["user_id"].ToString().Trim();
                    }

                    dataReader.Close();
                    command.Dispose();

                    if (!foundUser) // Eğer hiç kullanıcı bulunamadıysa
                    {
                        MessageBox.Show("Kullanıcı adın veya şifren yanlış!", "Giriş Başarısız!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    con.Close();
                }
            }
        }

        // Sağ Üstteki Uygulamayı Kapat Butonu Renk Bugu Fix
        private void ExitButtonFocusFix(object sender, MouseEventArgs e)
        {
            this.ActiveControl = pnlMain;
        }

        private void ExitApplication(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // 5-)
        private void tbSifre_OnIconRightClick(object sender, EventArgs e)
        {
            sifreGoster = !sifreGoster;

            tbSifre.PasswordChar = sifreGoster ? '\0' : '*';
            tbSifre.IconRight = sifreGoster
            ? Properties.Resources.pass_open  // Açık göz ikonu
            : Properties.Resources.pass_close; // Kapalı göz ikonu
        }

        // 6-)
        private void PageLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnGirisYap.PerformClick(); // Burada tıklanmasını istediğin butonu çağır
                e.SuppressKeyPress = true; // Enter tuşunun normal çalışmasını engelle
            }
        }

    }
}
