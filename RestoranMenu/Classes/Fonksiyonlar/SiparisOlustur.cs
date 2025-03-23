using RestoranMenu.Forms.Customer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoranMenu.Classes.Fonksiyonlar
{
    class SiparisOlustur
    {
        /*
         
         1-) Sipariş Ekle
         2-) Gıda ID Bulma
         3-) Sipariş Detay Ekleme
         4-) Sipariş Sonrası Liste Temizleme

         */


        // 1-)
        public static int YeniSiparisEkle(int userId)
        {
            int orderId = 0;
            using (SqlConnection con = new SqlConnection(SqlServer.ConnectionString))
            {
                con.Open();
                string query = "INSERT INTO orders (user_id, order_date) OUTPUT INSERTED.order_id VALUES (@userId, @orderDate)";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@userId", userId);
                    cmd.Parameters.AddWithValue("@orderDate", DateTime.Today);

                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        orderId = Convert.ToInt32(result);
                    }
                }
            }
            return orderId;
        }

        // 2-)
        public static int FoodIdBul(string foodName)
        {
            int foodId = 0;
            using (SqlConnection con = new SqlConnection(SqlServer.ConnectionString))
            {
                con.Open();
                string query = "SELECT food_id FROM foods WHERE food_name = @foodName";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@foodName", foodName);
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        foodId = Convert.ToInt32(result);
                    }
                }
            }
            return foodId;
        }

        // 3-)
        public static void SiparisDetayEkle(int orderId, int foodId, int quantity)
        {
            using (SqlConnection con = new SqlConnection(SqlServer.ConnectionString))
            {
                con.Open();
                string query = "INSERT INTO order_details (order_id, food_id, quantity) VALUES (@orderId, @foodId, @quantity)";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@orderId", orderId);
                    cmd.Parameters.AddWithValue("@foodId", foodId);
                    cmd.Parameters.AddWithValue("@quantity", quantity);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // 4-)
        public static void SepetiTemizle()
        {
            Veriler.Siparisler.Clear();
            Veriler.urunListesi.Clear();
        }
    }

}
