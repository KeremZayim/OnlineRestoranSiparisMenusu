using Bunifu.UI.WinForms.BunifuButton;
using Bunifu.UI.WinForms;
using RestoranMenu.Properties;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestoranMenu.Classes
{
    public static class Veriler
    {
        /*    Kullanıcı Verileri    */
        public static string ad;
        public static string soyad;
        public static string user_id;
        public static Dictionary<string, int> Siparisler { get; set; } = new Dictionary<string, int>();
        public static Dictionary<string, (BunifuLabel adetLabel, BunifuLabel fiyatLabel, int fiyat, BunifuPanel panel)> urunListesi = new Dictionary<string, (BunifuLabel, BunifuLabel, int, BunifuPanel)>();

        /*     Ürün Düzenleme     */
        // d_ (Düzenleme)
        public static string d_urun_adi;
        public static int d_urun_kategori_id;
        public static int d_urun_diyet_tipi_id;
        public static int d_urun_id;
        public static int d_urun_fiyat;
        public static int d_urun_kalori;
        public static byte[] d_urun_resim;

        public static int diyetId;
    }
}

