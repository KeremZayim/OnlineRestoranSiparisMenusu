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

namespace RestoranMenu.Forms.Administrator
{
    public partial class PageVersiyonSecim: Form
    {
        public PageVersiyonSecim()
        {
            InitializeComponent();
        }

        private void VersiyonSecim_Shown(object sender, EventArgs e)
        {
            lblWelcome.Text = "Hoş Geldin " + Veriler.ad + " " + Veriler.soyad;
        }

        private void pbAdministrator_Click(object sender, EventArgs e)
        {
            PageAdminMain adminMainForm = new PageAdminMain();
            this.Hide();
            adminMainForm.Show();
        }

        private void pbCustomer_Click(object sender, EventArgs e)
        {
            PageMain MainForm = new PageMain();
            this.Hide();
            MainForm.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
