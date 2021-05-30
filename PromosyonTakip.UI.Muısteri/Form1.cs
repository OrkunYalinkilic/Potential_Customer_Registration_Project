using PromosyonTakip.Core.BusinessLogicService;
using PromosyonTakip.Core.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PromosyonTakip.UI.Muısteri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtKullaniciAdi.Text) && !string.IsNullOrEmpty(txTSifre.Text))
            {
                sistemMagazaServis servisMagaza = new sistemMagazaServis();
                int magazaID = servisMagaza.magazaKullaniciKontrol(txtKullaniciAdi.Text, txTSifre.Text);
                if (magazaID > 0)
                {
                    StaticFieldList.magazaID = magazaID;
                    anaEkran _anaekran = new anaEkran();
                    _anaekran.ShowDialog();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Hatali Kullanici Adi veya Şifre!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Form Alanlarını eksiksiz olarak doldurun!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
