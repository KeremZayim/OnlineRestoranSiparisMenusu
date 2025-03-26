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
    public partial class PageUrunEkle : Form
    {
        SqlConnection con = new SqlConnection(SqlServer.ConnectionString);
        SqlCommand command;
        string query = "";
        string yol = string.Empty;
        int food_id, diet_id;


        public PageUrunEkle()
        {
            InitializeComponent();
            verileriYukle();
        }
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
                    pb_food.Image = Image.FromFile(yol); // PictureBox'a resmi yükle
                    pb_food.SizeMode = PictureBoxSizeMode.StretchImage; // Resmi PictureBox'a sığdır
                }
            }
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            //Kategori Adı Alma
            query = "SELECT category_id,category_name FROM categories WHERE category_name ='" + cbCategory.SelectedItem.ToString().Trim() + "'";
            command = new SqlCommand(query, con);
            SqlDataReader dR3 = command.ExecuteReader();
            while (dR3.Read())
            {
                food_id = Convert.ToInt32(dR3.GetValue(0).ToString().Trim());
            }
            dR3.Close();

            //Diyet Tipi Adı ALma
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

        private void SadeceRakamGirisi(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8) // 8: Backspace tuşu
            {
                e.Handled = true; // Tuşun işlenmesini engelle
            }
        }
    }
}
