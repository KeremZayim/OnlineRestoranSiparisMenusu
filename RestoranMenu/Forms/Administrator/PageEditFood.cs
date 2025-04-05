using RestoranMenu.Classes;
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

namespace RestoranMenu
{
    public partial class PageEditFood : Form
    {

        /*
         1-) Verileri Yükle
            1.1-) Ürün Adı
            1.2-) Diyet Tipi
            1.3-) Gıda Kategorisi
            1.4-) Kalori
            1.5-) Fiyat
            1.6-) Resim
         
         2-)
         
         
         
         */
        SqlConnection con = new SqlConnection(SqlServer.ConnectionString);

        void VerileriTemizle()
        {
            cbCategory.Items.Clear();
            cbDiet_type.Items.Clear();
            tbCalorie.Text = "";
            tbFoodName.Text = "";
            tbPrice.Text = "";
            pb_food.Image = null;
        }
        void VerileriYukle()
        {
            VerileriTemizle();

            // 1-)
            try
            {
                string cbQuery = "SELECT category_name FROM categories";
                con.Open();
                SqlCommand cmd = new SqlCommand(cbQuery, con);
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    cbCategory.Items.Add(sdr["category_name"]);
                }
                sdr.Close();

                cbQuery = "SELECT diet_type_name FROM diet_types";
                cmd = new SqlCommand(cbQuery, con);
                sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    cbDiet_type.Items.Add(sdr["diet_type_name"]);
                }
                sdr.Close();

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Diyet Tipi ve Kategori Adı Verisi Getirilemedi, Hata: {ex}");
            }

            // 1.1-)
            tbFoodName.Text = Veriler.d_urun_adi;

            // 1.2-)
            try
            {
                con.Open();
                string query = "SELECT diet_type_name FROM diet_types as d JOIN foods as f on f.diet_type_id = d.diet_type_id WHERE food_id = '" + Veriler.d_urun_id + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    cbDiet_type.SelectedItem = sdr["diet_type_name"];
                }

                sdr.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Diyet Tipi Verisi Getirilemedi, Hata: {ex}", "Hata");
            }

            // 1.3-)
            try
            {
                con.Open();
                string query = "SELECT category_name FROM categories as c JOIN foods as f on f.category_id = c.category_id WHERE food_id ='" + Veriler.d_urun_id + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    cbCategory.SelectedItem = sdr["category_name"];
                }

                sdr.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Diyet Tipi Verisi Getirilemedi, Hata: {ex}", "Hata");
            }

            // 1.4-)
            tbCalorie.Text = Veriler.d_urun_kalori.ToString().Trim();

            // 1.5-)
            tbPrice.Text = Veriler.d_urun_fiyat.ToString().Trim();

            // 1.6-)
            if (Veriler.d_urun_resim != null)
            {
                using (MemoryStream ms = new MemoryStream(Veriler.d_urun_resim))
                {
                    pb_food.Image = Image.FromStream(ms);
                }
            }
        }
        public PageEditFood()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // * *
            this.Close();
        }

        private void PageEditFood_Shown(object sender, EventArgs e)
        {
            VerileriYukle();
        }
        private void SadeceRakamGirisi(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8) // (8: Backspace tuşu)
            {
                e.Handled = true; // Tuşun işlenmesini engelle
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                // Kategori adı ile ID'yi al
                string selectedCategory = cbCategory.SelectedItem != null ? cbCategory.SelectedItem.ToString() : null;
                SqlCommand cmdKategori = new SqlCommand("SELECT category_id FROM categories WHERE category_name = @name", con);
                cmdKategori.Parameters.AddWithValue("@name", selectedCategory);
                object kategoriObj = cmdKategori.ExecuteScalar();

                if (kategoriObj == null)
                {
                    MessageBox.Show("Kategori bulunamadı.", "Hata");
                }
                int kategoriId = Convert.ToInt32(kategoriObj);

                // Diyet tipi adı ile ID'yi al
                string selectedDiet = cbDiet_type.SelectedItem != null ? cbDiet_type.SelectedItem.ToString() : null;

                SqlCommand cmdDiyet = new SqlCommand("SELECT diet_type_id FROM diet_types WHERE diet_type_name = @name", con);
                cmdDiyet.Parameters.AddWithValue("@name", selectedDiet);

                if (selectedDiet != null)
                {
                    object diyetObj = cmdDiyet.ExecuteScalar();
                    if (diyetObj == null)
                    {
                        MessageBox.Show("Diyet tipi bulunamadı.", "Hata");
                        Veriler.diyetId = Convert.ToInt32(diyetObj);
                    }
                }



                // Resmi byte[] olarak al
                byte[] imageBytes = Veriler.d_urun_resim;
                if (pb_food.Image != null)
                /*{
                    using (MemoryStream ms = new MemoryStream())
                    {
                        pb_food.Image.Save(ms, pb_food.Image.RawFormat);
                        imageBytes = ms.ToArray();
                    }
                }*/
                if (selectedDiet != null)
                {
                    SqlCommand updateCmd = new SqlCommand(@"UPDATE foods 
                                                            SET food_name = @name, category_id = @categoryId, 
                                                            diet_type_id = @dietTypeId, food_calorie = @calorie, 
                                                            food_price = @price, food_picture = @picture 
                                                            WHERE food_id = @id", con);


                    updateCmd.Parameters.AddWithValue("@name", tbFoodName.Text.Trim());
                    updateCmd.Parameters.AddWithValue("@categoryId", kategoriId);
                    updateCmd.Parameters.AddWithValue("@dietTypeId", Veriler.diyetId);
                    updateCmd.Parameters.AddWithValue("@calorie", tbCalorie.Text.Trim());
                    updateCmd.Parameters.AddWithValue("@price", tbPrice.Text.Trim());

                    if (imageBytes != null)
                    {
                        updateCmd.Parameters.AddWithValue("@picture", imageBytes);
                    }
                    else
                    {
                        updateCmd.Parameters.Add("@picture", SqlDbType.VarBinary).Value = DBNull.Value;
                    }

                    updateCmd.Parameters.AddWithValue("@id", Veriler.d_urun_id);

                    int rowsAffected = updateCmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Ürün başarıyla güncellendi!", "Başarılı");
                    }
                    else
                    {
                        MessageBox.Show("Güncelleme başarısız oldu!", "Hata");
                    }
                }
                else
                {
                    SqlCommand updateCmd = new SqlCommand(@"UPDATE foods 
                                                            SET food_name = @name, category_id = @categoryId, 
                                                            food_calorie = @calorie, 
                                                            food_price = @price, food_picture = @picture 
                                                            WHERE food_id = @id", con);


                    updateCmd.Parameters.AddWithValue("@name", tbFoodName.Text.Trim());
                    updateCmd.Parameters.AddWithValue("@categoryId", kategoriId);
                    updateCmd.Parameters.AddWithValue("@calorie", tbCalorie.Text.Trim());
                    updateCmd.Parameters.AddWithValue("@price", tbPrice.Text.Trim());

                    if (imageBytes != null)
                    {
                        updateCmd.Parameters.AddWithValue("@picture", imageBytes);
                    }
                    else
                    {
                        updateCmd.Parameters.Add("@picture", SqlDbType.VarBinary).Value = DBNull.Value;
                    }

                    updateCmd.Parameters.AddWithValue("@id", Veriler.d_urun_id);

                    int rowsAffected = updateCmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Ürün başarıyla güncellendi!", "Başarılı");
                    }
                    else
                    {
                        MessageBox.Show("Güncelleme başarısız oldu!", "Hata");
                    }
                }

                con.Close();
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show("Hata oluştu: " + ex.Message, "Hata");
            }

        }
        string yol;
        private void btnResimSec_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Resim Seç";
                ofd.Filter = "Resim Dosyaları|*.png;*.jpg;*.jpeg";
                ofd.Multiselect = false; // Tek dosya seçimi

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    yol = ofd.FileName; // Seçilen dosyanın yolunu al
                    pb_food.Image = Image.FromFile(yol);
                    pb_food.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
        }
    }
}
