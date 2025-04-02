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
    public partial class PageEditFood : Form
    {
        public PageEditFood()
        {
            InitializeComponent();
            VerileriYukle();
            dgvFoods.RowTemplate.Height = 100;
        }
        private void VerileriYukle()
        {
            using (SqlConnection baglanti = new SqlConnection(SqlServer.ConnectionString))
            {
                try
                {
                    baglanti.Open();
                    string query = "SELECT * FROM foods";  // Tablondaki verileri çekiyoruz
                    SqlDataAdapter adapter = new SqlDataAdapter(query, baglanti);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvFoods.DataSource = dt;  // DataGridView'e bağla

                    // Sütun başlıklarını belirleme
                    dgvFoods.Columns["food_id"].HeaderText = "Gıda ID";
                    dgvFoods.Columns["food_name"].HeaderText = "Gıda Adı";
                    dgvFoods.Columns["category_id"].HeaderText = "Kategori ID";
                    dgvFoods.Columns["diet_type_ID"].HeaderText = "Diyet Tipi ID";
                    dgvFoods.Columns["category_id"].HeaderText = "Kategori ID";
                    dgvFoods.Columns["food_price"].HeaderText = "Fiyat";

                    // Sütun genişliklerini 50 olarak ayarla
                    dgvFoods.Columns["food_id"].Width = 70;
                    dgvFoods.Columns["food_name"].Width = 250;
                    dgvFoods.Columns["category_id"].Width = 110;
                    dgvFoods.Columns["diet_type_id"].Width = 110;
                    dgvFoods.Columns["food_calorie"].Width = 110;
                    dgvFoods.Columns["food_picture"].Width = 170;
                    dgvFoods.Columns["food_price"].Width = 100;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }
    }
}
