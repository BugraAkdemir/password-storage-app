using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace password_storage_app
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void kaydet_button_Click(object sender, EventArgs e)
        {
            string isim = şifre_isim_ver.Text;
            string sifre = şifre_giriş.Text;

            // İsim ve şifreyi virgülle ayrılmış bir formatta birleştir
            string kayit = isim + "," + sifre;

            // Kaydı dosyaya yaz
            Kaydet(kayit);

            // Kullanıcıya bilgi mesajı göster
            onay_mesajı_label.ForeColor = Color.Green;
            onay_mesajı_label.Text = "Şifre Başarıyla Kaydedildi"; 

            // TextBox'ları temizle
            şifre_isim_ver.Clear();
            şifre_giriş.Clear();
        }

        private void Kaydet(string kayit)
        {
            // Dosyayı aç ve yeni bir satır olarak kaydı ekle
            using (StreamWriter writer = new StreamWriter("sifreler.txt", true))
            {
                writer.WriteLine(kayit);
            }
        }

        private void ara_button_Click(object sender, EventArgs e)
        {
            string arananIsim = şifre_ismi_arama.Text;

            // Aranan ismi dosyadan ara
            string sifre = SifreBul(arananIsim);

            // Eğer şifre bulunduysa label'a yazdır, bulunamadıysa mesaj göster
            if (!string.IsNullOrEmpty(sifre))
            {
                şifre_cıkısı.ForeColor = Color.Green;
                şifre_cıkısı.Text = "Şifre: " + sifre;
                şifre_ismi_cıkısı.Text = $"Şifre İsmi: {arananIsim}";
            }
            else
            {
                şifre_ismi_cıkısı.Text = "";
                şifre_cıkısı.ForeColor = Color.Red;
                şifre_cıkısı.Text = "Şifre bulunamadı.";
            }
        }

        private void tüm_şifreleri_göster_button_Click(object sender, EventArgs e)
        {
            TumSifreleriGoster();
        }

        private void TumSifreleriGoster()
        {
            

            // Dosyadan tüm satırları oku ve label'a yaz
            using (StreamReader reader = new StreamReader("sifreler.txt"))
            {
                string satir;
                while ((satir = reader.ReadLine()) != null)
                {
                    string[] parcalar = satir.Split(',');
                    if (parcalar.Length == 2)
                    {
                        tüm_şifreleri_göster.Text += "Şifre Adı: " + parcalar[0] + " Şifre: " + parcalar[1] + "\n";
                    }
                }
            }
        }

        private string SifreBul(string arananIsim)
        {
            string sifre = null;

            // Dosyadan satır satır oku ve aranan ismi ara
            using (StreamReader reader = new StreamReader("sifreler.txt"))
            {
                string satir;
                while ((satir = reader.ReadLine()) != null)
                {
                    string[] parcalar = satir.Split(',');
                    if (parcalar.Length == 2 && parcalar[0] == arananIsim)
                    {
                        sifre = parcalar[1];
                        break;
                    }
                }
            }

            return sifre;
        }

        private void Kaydet2(string kayit)
        {
            // Dosyayı aç ve yeni bir satır olarak kaydı ekle
            using (StreamWriter writer = new StreamWriter("sifreler.txt", true))
            {
                writer.WriteLine(kayit);
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        
    }
    
    
}
