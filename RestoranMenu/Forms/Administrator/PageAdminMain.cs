using RestoranMenu.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;


namespace RestoranMenu.Forms.Administrator
{
    public partial class PageAdminMain : Form
    {
        private Form aktifForm = null;
        private void ChildFormAc(Form childForm)
        {
            if (aktifForm != null)
            {
                aktifForm.Close(); // Önceki açık formu kapat
            }

            //Çerçevesiz ve tam boyuta ayarlama
            aktifForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            panelMain.Controls.Clear(); // Paneli temizle
            panelMain.Controls.Add(childForm);
            panelMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        public PageAdminMain()
        {
            InitializeComponent();
        }

        private void ExitApplication(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PageAdminMain_Load(object sender, EventArgs e)
        {
        }

        private void btnTatlilar_Click(object sender, EventArgs e)
        {
            ChildFormAc(new Deserts());
        }

        private void btnSalatalar_Click(object sender, EventArgs e)
        {
        }

        private void PageAdminMain_Shown(object sender, EventArgs e)
        {
            lblYonetimBar.Text = Veriler.ad + " " + Veriler.soyad + " - Restoran Menüsü Yönetim Sistemi";
            lblPeronalInformation.Text = Veriler.ad + " " + Veriler.soyad;
        }
    }
}
