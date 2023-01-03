using market.controller;
using market.enumaration;
using market.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace market
{
    public partial class SifreDegistirme : Form
    { int code;
        public SifreDegistirme()
        {
            InitializeComponent();
        }

        private void SifreDegistirme_Load(object sender, EventArgs e)
        {
            Controller controller = new Controller();
            List<LoginTable> loginTableList = controller.getLoginTable();
            mailAlaniGb.Enabled = false;
            sifreDegistirmeGb.Enabled = false;

            foreach (LoginTable It in loginTableList)
            {
                GuvenlikSorusuCb.Items.Add(It.guvenlikSorusu.ToString());
            }

            GuvenlikSorusuCb.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Controller controller = new Controller();
            LoginStatus result =  controller.doAuthentication(KullaniciAdiTb.Text.Trim().ToLower(),GuvenlikSorusuCb.SelectedItem.ToString(),GuvenlikCevabiTb.Text.ToLower());

            if(result== LoginStatus.basarili)
            {
                mailAlaniGb.Enabled = true;
            }
            else if(result== LoginStatus.basarisiz)
            {
                MessageBox.Show("Girdiğiniz Bilgileri Kontrol Ediniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Tüm Alanları Doldurunuz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Controller controller = new Controller();
           string emailAdres= controller.checkEmailAddress(KullaniciAdiTb.Text);
            if(emailAdres== EmailAdresTb.Text)
            {
                Random rdn = new Random();
                code = rdn.Next(111111, 999999);

                MailAddress mailAlan = new MailAddress(EmailAdresTb.Text, KullaniciAdiTb.Text);
                MailAddress mailGonderen = new MailAddress("ertu_uu@hotmail.com", "Ertuğ Uygurlu");
                MailMessage mesaj = new MailMessage();

                mesaj.To.Add(mailAlan);
                mesaj.From = mailGonderen;
                mesaj.Subject = "Şifre Değiştirme";
                mesaj.Body = "Şifrenizi değiştirmek için doğrulama kodunuz:" + code;

                SmtpClient smtp = new SmtpClient("smtp.live.com", 587);
                smtp.Credentials = new System.Net.NetworkCredential("ertu_uu@hotmail.com", "502020Eu");
                smtp.EnableSsl = true;
                smtp.Send(mesaj);
                MessageBox.Show("Doğrulama Kodu Gönderildi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Hesabınıza bağlı mail adresinizi giriniz.","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(DogrulamaKoduTb.Text==code.ToString())
            {
                sifreDegistirmeGb.Enabled = true;
            }
            else
            {
                MessageBox.Show("Doğrulama kodunuz yanıştır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Controller controller = new Controller();
            
            if(YeniSifreTb.Text==YeniSifreTekrarTb.Text)
            {
                controller.changePassword(KullaniciAdiTb.Text, YeniSifreTb.Text);
                LoginStatus result = controller.changePassword(KullaniciAdiTb.Text, YeniSifreTb.Text);
                
                if(result==LoginStatus.basarili)
                {
                    MessageBox.Show("Şifreniz Değiştirilmiştir.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Gerekli Alanları doldurunuz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("İki şifre birbirleriyle aynı değildir.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
