using RestoranMenu.Classes;
using System;
using System.Collections;
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

namespace RestoranMenu.Forms.Administrator
{
    public partial class PageEditFood : Form
    {
        string query = @"
                SELECT 
                    f.food_id, 
                    f.food_name, 
                    c.category_name AS Kategori, 
                    d.diet_type_name AS 'Diyet Tipi', 
                    f.food_calorie, 
                    f.food_picture, 
                    f.food_price 
                FROM foods f
                LEFT JOIN categories c ON f.category_id = c.category_id
                LEFT JOIN diet_types d ON f.diet_type_id = d.diet_type_id";
        public PageEditFood()
        {
            InitializeComponent();
            VerileriYukle(query);
            dgvFoods.RowTemplate.Height = 100;
            dgvFoods.CellPainting += dgvFoods_CellPainting; // Resim çizmek için event ekle
        }
        // Resimi Stretch Yapmak İçin
        private void dgvFoods_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (dgvFoods.Columns[e.ColumnIndex].Name == "food_picture" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All & ~DataGridViewPaintParts.ContentForeground);
                if (dgvFoods.Rows[e.RowIndex].Cells["food_picture"].Value != DBNull.Value)
                {
                    try
                    {
                        byte[] imageData = (byte[])dgvFoods.Rows[e.RowIndex].Cells["food_picture"].Value;
                        using (MemoryStream ms = new MemoryStream(imageData))
                        {
                            Image img = Image.FromStream(ms);
                            Rectangle rect = e.CellBounds;
                            rect.Inflate(-5, -5); // Kenarlardan biraz boşluk bırak
                            e.Graphics.DrawImage(img, rect);
                        }
                    }
                    catch
                    {
                        e.Graphics.DrawString("Resim Yok", dgvFoods.Font, Brushes.Red, e.CellBounds.X + 10, e.CellBounds.Y + 30);
                    }
                }
                else
                {
                    e.Graphics.DrawString("Resim Yok", dgvFoods.Font, Brushes.Red, e.CellBounds.X + 10, e.CellBounds.Y + 30);
                }
                e.Handled = true;
            }
        }
        private void VerileriYukle(string query)
        {
            dgvFoods.Columns.Clear();
            using (SqlConnection baglanti = new SqlConnection(SqlServer.ConnectionString))
            {
                try
                {
                    baglanti.Open();

                    SqlDataAdapter adapter = new SqlDataAdapter(query, baglanti);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvFoods.DataSource = dt;  // DataGridView'e bağla

                    // Çarpı butonunu eklemek için yeni bir sütun ekleyelim
                    DataGridViewButtonColumn deleteColumn = new DataGridViewButtonColumn();
                    deleteColumn.Name = "Sil";
                    deleteColumn.HeaderText = "Sil";
                    deleteColumn.Width = 50;
                    deleteColumn.Text = "❌";
                    deleteColumn.UseColumnTextForButtonValue = true;
                    dgvFoods.Columns.Add(deleteColumn);

                    // Sütun başlıklarını belirleme
                    dgvFoods.Columns["food_id"].HeaderText = "Gıda ID";
                    dgvFoods.Columns["food_name"].HeaderText = "Gıda Adı";
                    dgvFoods.Columns["Kategori"].HeaderText = "Kategori";
                    dgvFoods.Columns["Diyet Tipi"].HeaderText = "Diyet Tipi";
                    dgvFoods.Columns["food_calorie"].HeaderText = "Kalori";
                    dgvFoods.Columns["food_picture"].HeaderText = "Resim";
                    dgvFoods.Columns["food_price"].HeaderText = "Fiyat";

                    // Sütun genişlikleri
                    dgvFoods.Columns["food_id"].Width = 70;
                    dgvFoods.Columns["food_name"].Width = 200;
                    dgvFoods.Columns["Kategori"].Width = 150;
                    dgvFoods.Columns["Diyet Tipi"].Width = 150;
                    dgvFoods.Columns["food_calorie"].Width = 100;
                    dgvFoods.Columns["food_picture"].Width = 170;
                    dgvFoods.Columns["food_price"].Width = 100;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }
        private void dgvFoods_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvFoods.Columns["Sil"].Index && e.RowIndex >= 0)
            {
                try
                {
                    string foodNameValue = dgvFoods.Rows[e.RowIndex].Cells["food_name"].Value?.ToString().Trim();

                    if (string.IsNullOrEmpty(foodNameValue))
                    {
                        MessageBox.Show("Gıda adı bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    DialogResult result = MessageBox.Show($"'{foodNameValue}' adlı ürünü silmek istediğinizden emin misiniz?",
                                                          "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        DeleteFood(foodNameValue);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }

        private void DeleteFood(string foodName)
        {
            using (SqlConnection baglanti = new SqlConnection(SqlServer.ConnectionString))
            {
                try
                {
                    baglanti.Open();

                    // İlk olarak food_id'yi bul
                    string getFoodIdQuery = "SELECT food_id FROM dbo.foods WHERE food_name = @foodName";
                    SqlCommand getIdCmd = new SqlCommand(getFoodIdQuery, baglanti);
                    getIdCmd.Parameters.AddWithValue("@foodName", foodName);

                    object foodIdObj = getIdCmd.ExecuteScalar();

                    if (foodIdObj == null)
                    {
                        MessageBox.Show("Ürün bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    int foodId = Convert.ToInt32(foodIdObj);

                    // Silme işlemleri
                    string deleteQuery = @"
                DELETE FROM dbo.foods_allergens WHERE food_id = @foodId;
                DELETE FROM dbo.order_details WHERE food_id = @foodId;
                DELETE FROM dbo.foods WHERE food_id = @foodId;
            ";

                    SqlCommand komut = new SqlCommand(deleteQuery, baglanti);
                    komut.Parameters.AddWithValue("@foodId", foodId);

                    int affectedRows = komut.ExecuteNonQuery();

                    if (affectedRows > 0)
                        MessageBox.Show("Ürün başarıyla silindi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Ürün silinemedi!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    VerileriYukle(query);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }


        private void tbFoodName_TextChanged(object sender, EventArgs e)
        {
            if (tbFoodName.Text == "" || tbFoodName.Text == null)
            {
                query = @"
                SELECT 
                    f.food_id, 
                    f.food_name, 
                    c.category_name AS Kategori, 
                    d.diet_type_name AS 'Diyet Tipi', 
                    f.food_calorie, 
                    f.food_picture, 
                    f.food_price 
                FROM foods f
                LEFT JOIN categories c ON f.category_id = c.category_id
                LEFT JOIN diet_types d ON f.diet_type_id = d.diet_type_id";
            }
            else
            {
                query = @"
                SELECT 
                    f.food_id, 
                    f.food_name, 
                    c.category_name AS Kategori, 
                    d.diet_type_name AS 'Diyet Tipi', 
                    f.food_calorie, 
                    f.food_picture, 
                    f.food_price 
                FROM foods f
                LEFT JOIN categories c ON f.category_id = c.category_id
                LEFT JOIN diet_types d ON f.diet_type_id = d.diet_type_id
                WHERE f.food_name COLLATE SQL_Latin1_General_CP1_CI_AS LIKE '%" + tbFoodName.Text + "%'";
            }
            try
            {
                VerileriYukle(query);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
