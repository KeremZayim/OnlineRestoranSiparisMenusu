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
    /*
     
        1-) Alerjenleri Listele
        2-) Alerjen Ekleme Butonu
        3-) Alerjen Silme

     */

    public partial class PageAllergens : Form
    {
        SqlConnection con = new SqlConnection(SqlServer.ConnectionString);
        public PageAllergens()
        {
            InitializeComponent();
        }

        private void PageAllergens_Shown(object sender, EventArgs e)
        {
            AlerjenListele();
        }

        // 1-)
        void AlerjenListele()
        {
            string query = "SELECT * FROM allergens";
            try
            {
                dgvAllergens.Columns.Clear();

                con.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvAllergens.DataSource = dt;

                DataGridViewButtonColumn deleteColumn = new DataGridViewButtonColumn();
                deleteColumn.Name = "Sil";
                deleteColumn.HeaderText = "Sil";
                deleteColumn.Width = 50;
                deleteColumn.Text = "❌";
                deleteColumn.UseColumnTextForButtonValue = true;
                dgvAllergens.Columns.Add(deleteColumn);

                con.Close();

                // Tablo Düzeni
                // Sütun başlıklarını belirleme
                dgvAllergens.Columns["allergen_id"].HeaderText = "Alerjen ID";
                dgvAllergens.Columns["allergen_name"].HeaderText = "Alerjen Adı";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Alerjen Listelemesinde Hata: {ex}", "Hata");
            }
        }


        // 2-)
        private void btnAlerjenEkle_Click(object sender, EventArgs e)
        {
            try
            {
                string allergenName = tbAlerjenAdi.Text.Trim();

                if (string.IsNullOrEmpty(allergenName))
                {
                    MessageBox.Show("Lütfen bir alerjen girin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                con.Open();

                // Aynı alerjen var mı kontrolü
                SqlCommand kontrolCmd = new SqlCommand("SELECT COUNT(*) FROM allergens WHERE allergen_name = @name", con);
                kontrolCmd.Parameters.AddWithValue("@name", allergenName);

                int count = (int)kontrolCmd.ExecuteScalar();
                if (count > 0)
                {
                    MessageBox.Show("Bu alerjen zaten mevcut.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                SqlCommand cmd = new SqlCommand("INSERT INTO allergens (allergen_name) VALUES (@name)", con);
                cmd.Parameters.AddWithValue("@name", allergenName);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Alerjen başarıyla eklendi.");
                tbAlerjenAdi.Clear();
                con.Close();

                AlerjenListele();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Alerjen Eklenemedi.\n{ex}", "Hata!");
            }
        }

        // 3-)
        private void dgvAllergens_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Geçerli hücre buton sütunu mu?
            if (dgvAllergens.Columns[e.ColumnIndex].Name == "Sil" && e.RowIndex >= 0)
            {
                // Silinecek ID'yi al
                int allergenId = Convert.ToInt32(dgvAllergens.Rows[e.RowIndex].Cells["allergen_id"].Value);

                // Kullanıcıya onay sor
                DialogResult result = MessageBox.Show("Bu alerjeni silmek istediğinizden emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    try
                    {

                        con.Open();
                        SqlCommand cmd = new SqlCommand("DELETE FROM allergens WHERE allergen_id = @id", con);
                        cmd.Parameters.AddWithValue("@id", allergenId);
                        cmd.ExecuteNonQuery();
                        con.Close();


                        // Güncel listeyi tekrar yükle
                        AlerjenListele();
                        MessageBox.Show("Alerjen başarıyla silindi.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Silme sırasında hata oluştu: {ex.Message}", "Hata");
                    }
                }
            }
        }
    }
}
