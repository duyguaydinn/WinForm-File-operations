using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DosyaIslemleri
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        void kodOlustur()
        {
            Random rasgele = new Random();
            int sayi = rasgele.Next(1000, 10000);
            txtKod2.Text = sayi.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            frm.Show();
            //this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 frm = new Form4();
            frm.Show();
            //this.Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            kodOlustur();
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            if (txtKullaniciAdi.Text == "admin" && txtSifre.Text == "1234" && txtKod1.Text == txtKod2.Text)
            {
                Form3 frm = new Form3();
                frm.kullanici = txtKullaniciAdi.Text;
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı bilgi girişi: Kullanıcı adı, şifre veya kod yanlış girildi!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
       }
    }
}
