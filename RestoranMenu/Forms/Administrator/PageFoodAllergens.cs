using RestoranMenu.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestoranMenu.Forms.Administrator
{
    public partial class PageFoodAllergens : Form
    {
        SqlConnection con = new SqlConnection(SqlServer.ConnectionString);
        public PageFoodAllergens()
        {
            InitializeComponent();
        }
        private void PageFoodAllergens_Shown(object sender, EventArgs e)
        {
            ComboBoxlarıDoldur();
            GidaAlerjenleriniListele();
        }

        void GidaAlerjenleriniListele()
        {
            dgvFoodAllergens.Columns.Clear();
            string query = @"SELECT food_name,allergen_name 
                            FROM foods_allergens as fa
                            JOIN foods as f on f.food_id = fa.food_id
                            JOIN allergens as a on a.allergen_id = fa.allergen_id";

            try
            {
                dgvFoodAllergens.Columns.Clear();

                con.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                // Tüm hücreleri Trimle
                foreach (DataRow row in dt.Rows)
                {
                    row["food_name"] = row["food_name"].ToString().Trim();
                    row["allergen_name"] = row["allergen_name"].ToString().Trim();
                }

                dgvFoodAllergens.DataSource = dt;

                DataGridViewButtonColumn deleteColumn = new DataGridViewButtonColumn();
                deleteColumn.Name = "Sil";
                deleteColumn.HeaderText = "Sil";
                deleteColumn.Width = 50;
                deleteColumn.Text = "❌";
                deleteColumn.UseColumnTextForButtonValue = true;
                dgvFoodAllergens.Columns.Add(deleteColumn);

                con.Close();

                // Tablo Düzeni
                // Sütun başlıklarını belirleme
                dgvFoodAllergens.Columns["food_name"].HeaderText = "Gıda Adı";
                dgvFoodAllergens.Columns["allergen_name"].HeaderText = "Alerjen Adı";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Alerjen Listelemesinde Hata: {ex}", "Hata");
            }
        }

        private void ComboBoxlarıDoldur()
        {
            try
            {
                string query = "SELECT * FROM allergens ORDER BY allergen_name asc";
                con.Open();

                // Alerjen Adını Combobox'a Ekleme
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    cbAllergenName.Items.Add(sdr["allergen_name"].ToString().Trim());
                }
                sdr.Close();
                // Gıda Adlarını Combobox'a Listeleme

                string query2 = "SELECT food_id,food_name FROM foods ORDER BY food_name asc";
                SqlCommand cmd2 = new SqlCommand(query2, con);
                SqlDataReader sdr2 = cmd2.ExecuteReader();
                while (sdr2.Read())
                {
                    cbFoodName.Items.Add(sdr2["food_name"].ToString().Trim());
                }
                sdr2.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Veri Getirilmesinde Hata: {ex}", "Hata!");
            }
        }
        private void btnGidaAlerjeniEkle_Click(object sender, EventArgs e)
        {
            if (cbFoodName.SelectedIndex >= 0 && cbAllergenName.SelectedIndex >= 0)
            {
                string selectedFood = cbFoodName.SelectedItem?.ToString();
                string selectedAllergen = cbAllergenName.SelectedItem?.ToString();

                if (string.IsNullOrEmpty(selectedFood) || string.IsNullOrEmpty(selectedAllergen))
                {
                    MessageBox.Show("Lütfen gıda ve alerjen seçiniz.");
                    return;
                }

                con.Open();

                // food_id'yi çek
                SqlCommand foodCmd = new SqlCommand("SELECT food_id FROM foods WHERE food_name = @foodName", con);
                foodCmd.Parameters.AddWithValue("@foodName", selectedFood);
                object foodIdObj = foodCmd.ExecuteScalar();

                // allergen_id'yi çek
                SqlCommand allergenCmd = new SqlCommand("SELECT allergen_id FROM allergens WHERE allergen_name = @allergenName", con);
                allergenCmd.Parameters.AddWithValue("@allergenName", selectedAllergen);
                object allergenIdObj = allergenCmd.ExecuteScalar();

                if (foodIdObj == null || allergenIdObj == null)
                {
                    MessageBox.Show("Seçilen gıda veya alerjen veritabanında bulunamadı.");
                    return;
                }

                int foodId = Convert.ToInt32(foodIdObj);
                int allergenId = Convert.ToInt32(allergenIdObj);

                // Aynı kayıt var mı kontrol et
                SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM foods_allergens WHERE food_id = @foodId AND allergen_id = @allergenId", con);
                checkCmd.Parameters.AddWithValue("@foodId", foodId);
                checkCmd.Parameters.AddWithValue("@allergenId", allergenId);

                int count = (int)checkCmd.ExecuteScalar();
                if (count > 0)
                {
                    MessageBox.Show("Bu kayıt zaten var!");
                    return;
                }

                // Ekleme işlemi
                SqlCommand cmd = new SqlCommand("INSERT INTO foods_allergens (food_id, allergen_id) VALUES (@foodId, @allergenId)", con);
                cmd.Parameters.AddWithValue("@foodId", foodId);
                cmd.Parameters.AddWithValue("@allergenId", allergenId);
                cmd.ExecuteNonQuery();
                
                con.Close();
                MessageBox.Show("Kayıt başarıyla eklendi.");

                cbFoodName.SelectedItem = null;
                cbAllergenName.SelectedItem = null;
                GidaAlerjenleriniListele();
            }
            else
            {
                MessageBox.Show("Lütfen Gıdayı ve Alerjeni Seçtiğinizden Emin Olun!", "Hata!");
            }
        }

        private void dgvFoodAllergens_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Sil sütununa tıklanmış mı ve geçerli satır mı?
            if (dgvFoodAllergens.Columns[e.ColumnIndex].Name == "Sil" && e.RowIndex >= 0)
            {
                string selectedFood = dgvFoodAllergens.Rows[e.RowIndex].Cells["food_name"].Value.ToString();
                string selectedAllergen = dgvFoodAllergens.Rows[e.RowIndex].Cells["allergen_name"].Value.ToString();

                DialogResult result = MessageBox.Show($"'{selectedFood}' ve '{selectedAllergen}' ilişkisini silmek istiyor musunuz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        con.Open();

                        // Gıda ID'sini bul
                        SqlCommand foodCmd = new SqlCommand("SELECT food_id FROM foods WHERE food_name = @foodName", con);
                        foodCmd.Parameters.AddWithValue("@foodName", selectedFood);
                        int foodId = Convert.ToInt32(foodCmd.ExecuteScalar());

                        // Alerjen ID'sini bul
                        SqlCommand allergenCmd = new SqlCommand("SELECT allergen_id FROM allergens WHERE allergen_name = @allergenName", con);
                        allergenCmd.Parameters.AddWithValue("@allergenName", selectedAllergen);
                        int allergenId = Convert.ToInt32(allergenCmd.ExecuteScalar());

                        // foods_allergens tablosundan sil
                        SqlCommand deleteCmd = new SqlCommand("DELETE FROM foods_allergens WHERE food_id = @foodId AND allergen_id = @allergenId", con);
                        deleteCmd.Parameters.AddWithValue("@foodId", foodId);
                        deleteCmd.Parameters.AddWithValue("@allergenId", allergenId);
                        deleteCmd.ExecuteNonQuery();

                        con.Close();

                        // Listeyi yenile
                        GidaAlerjenleriniListele();
                        MessageBox.Show("Gıda-alerjen ilişkisi başarıyla silindi.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Silme sırasında hata oluştu: " + ex.Message, "Hata");
                    }
                }
            }
        }

    }
}
