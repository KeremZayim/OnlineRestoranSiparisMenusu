using RestoranMenu.Classes;
using RestoranMenu.Forms.Administrator;
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

        SqlConnection con = new SqlConnection(SqlServer.ConnectionString);
        string username;
        string password;
        public PageLogin()
        {
            InitializeComponent();

            if(Properties.Settings.Default.username != "")
            {
                tbKullaniciAdi.Text = Properties.Settings.Default.username;
            }

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

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Kullanıcı adı ve şifre giriniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand command;
                    string query = "SELECT username,password,user_type,name,surname FROM users WHERE username = @username AND password = @password";
                    command = new SqlCommand(query, con);
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);
                    SqlDataReader dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        if (username == dataReader.GetValue(0).ToString().Trim() && password == dataReader.GetValue(1).ToString().Trim())
                        {
                            if (dataReader.GetValue(2).ToString().Trim() == "Customer" || dataReader.GetValue(2).ToString().Trim() == "customer")
                            {
                                //Login Formunu Kapatıp Main Formu Açtırma
                                PageMain AnaForm = new PageMain();
                                this.Hide();
                                AnaForm.Show();
                            }
                            else if (dataReader.GetValue(2).ToString().Trim() == "Admin" || dataReader.GetValue(2).ToString().Trim() == "admin")
                            {
                                //Login Formunu Kapatıp Main Formu Açtırma
                                PageAdminMain AdminAnaForm = new PageAdminMain();
                                this.Hide();
                                AdminAnaForm.Show();
                            }
                            if (switchBeniHatirla.Checked)
                            {
                                Properties.Settings.Default.username = tbKullaniciAdi.Text;
                            }
                            else
                            {
                                Properties.Settings.Default.username = "";
                            }
                            Properties.Settings.Default.Save();
                        }
                        else
                        {
                            MessageBox.Show("Kullanıcı adın veya şifren yanlış!", "Giriş Başarısız!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    command.Dispose();
                    con.Close();
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

        private void ExitButtonFocusFix(object sender, MouseEventArgs e)
        {
            this.ActiveControl = pnlMain;
        }

        private void ExitApplication(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
