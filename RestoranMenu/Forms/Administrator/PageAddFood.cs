using RestoranMenu.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace RestoranMenu.Forms.Administrator
{
    /*
     
     1-) Sayfa Durumunu İlk Haline Getirme (Sıfırlama)
     2-) ComboBox'a Verileri Ekleme
     3-) Resim Seçim Butonu
     4-) Kaydet Butonu
        4.1-) Kategori Adı Alma
        4.2-) Diyet Tipi Adı Alma
        4.3-) Kayıt İşlemi
     5-) TextBox Sadece Rakam Girişi

     */

    public partial class PageAddFood : Form
    {
        SqlConnection con = new SqlConnection(SqlServer.ConnectionString);
        SqlCommand command;
        string query = "";
        string yol = string.Empty;
        int food_id, diet_id;


        public PageAddFood()
        {
            InitializeComponent();
            verileriYukle();
        }
        // 1-)
        void durumSifirla()
        {
            tbFoodName.Text = "";
            cbCategory.Items.Clear();
            cbDiet_type.Items.Clear();
            tbCalorie.Text = "";
            tbPrice.Text = "";
            yol = "";
            pb_food.Image = null;
            verileriYukle();
        }
        // 2-)
        void verileriYukle()
        {
            con.Open();
            query = "SELECT category_name FROM categories";
            command = new SqlCommand(query, con);

            SqlDataReader dR1 = command.ExecuteReader();
            while (dR1.Read())
            {
                cbCategory.Items.Add(dR1.GetValue(0).ToString().Trim());
            }
            dR1.Close();

            query = "SELECT diet_type_name FROM diet_types";
            command = new SqlCommand(query, con);
            SqlDataReader dR2 = command.ExecuteReader();
            while (dR2.Read())
            {
                cbDiet_type.Items.Add(dR2.GetValue(0).ToString().Trim());
            }
            dR2.Close();

        }
        // 3-)
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
        // 4-)
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            // 4.1-)
            query = "SELECT category_id,category_name FROM categories WHERE category_name ='" + cbCategory.SelectedItem.ToString().Trim() + "'";
            command = new SqlCommand(query, con);
            SqlDataReader dR3 = command.ExecuteReader();
            while (dR3.Read())
            {
                food_id = Convert.ToInt32(dR3.GetValue(0).ToString().Trim());
            }
            dR3.Close();

            // 4.2-)
            if (cbDiet_type.SelectedItem != null)
            {
                query = "SELECT diet_type_id FROM diet_types WHERE diet_type_name ='" + cbDiet_type.SelectedItem.ToString().Trim() + "'";
                command = new SqlCommand(query, con);
                SqlDataReader dR4 = command.ExecuteReader();
                while (dR4.Read())
                {
                    diet_id = Convert.ToInt32(dR4.GetValue(0).ToString().Trim());
                }
                dR4.Close();

            }
            //Resim
            byte[] imageData = File.ReadAllBytes(yol);

            // 4.3-)
            if (string.IsNullOrEmpty(tbFoodName.Text) || string.IsNullOrEmpty(cbCategory.SelectedItem.ToString()) || string.IsNullOrEmpty(tbCalorie.Text) || string.IsNullOrEmpty(tbPrice.Text) || yol != "")
            {
                try
                {
                    query = "INSERT INTO foods(food_name,category_id,food_calorie,food_picture,food_price) VALUES (@food_name, @category_id,@food_calorie,@food_picture,@food_price)";
                    command = new SqlCommand(query, con);
                    command.Parameters.AddWithValue("@food_name", tbFoodName.Text);
                    command.Parameters.AddWithValue("@category_id", food_id);
                    command.Parameters.AddWithValue("@food_calorie", Convert.ToInt32(tbCalorie.Text));
                    command.Parameters.AddWithValue("@food_picture", imageData);
                    command.Parameters.AddWithValue("@food_price", Convert.ToInt32(tbPrice.Text));
                    if (cbDiet_type.SelectedItem == null)
                    {
                        query = "INSERT INTO foods(food_name,category_id,food_calorie,food_picture,food_price) VALUES (@food_name, @category_id,@food_calorie,@food_picture,@food_price)";
                    }
                    else
                    {
                        query = "INSERT INTO foods(food_name,category_id,food_calorie,food_picture,food_price,diet_type_id) VALUES (@food_name, @category_id,@food_calorie,@food_picture,@food_price,@diet_type_id)";
                        command.Parameters.AddWithValue("@diet_type_id", diet_id);
                    }

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Veri Ekleme Başarılı");
                        durumSifirla();
                    }
                    else
                    {
                        MessageBox.Show("Veri Eklenirken Hata Oluştu!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Lütfen Boş Alan Bırakmayın!");
            }

        }

        // 5-)
        private void SadeceRakamGirisi(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8) // (8: Backspace tuşu)
            {
                e.Handled = true; // Tuşun işlenmesini engelle
            }
        }
    }
}
