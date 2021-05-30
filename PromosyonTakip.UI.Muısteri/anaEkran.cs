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
    public partial class anaEkran : Form
    {
        public anaEkran()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtIsim_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTCKimlikNo_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtSoyisim_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtDogumTarih_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cmbCinsiyet_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtMeslek_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtEMailAdres_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkEPostaOnay_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkSMSOnay_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtTelefonNo_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            PotansiyelMusteriServis;
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            GroupBox musteriBilgileri = (GroupBox)this.Controls["GPMusteriBilgileri"];
            foreach (Control item in musteriBilgileri.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = string.Empty;
                }
                else if (item is CheckBox)
                {
                    ((CheckBox)item).Checked = false;
                }
            }
        }

        private void HediyePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
