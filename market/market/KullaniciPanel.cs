using market.controller;
using market.enumaration;
using market.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace market
{
    public partial class KullaniciPanel : Form
    {
        Controller controller = new Controller();

        public KullaniciPanel()
        {
            InitializeComponent();
        }

        private void KullaniciPanel_Load(object sender, EventArgs e)
        {
            DefaultDegerleriDoldur();
            tumKullanicilariDoldur();
        }

        private void DefaultDegerleriDoldur()
        {
            yetkiCb.Items.Add("admin");
            yetkiCb.Items.Add("kasiyer");
            yetkiCb.SelectedIndex = 0;

            bolgeCb.Items.Add("Etimesgut");
            bolgeCb.Items.Add("Balgat");
            bolgeCb.Items.Add("Eryaman");
            bolgeCb.Items.Add("Kızılay");
            bolgeCb.Items.Add("Bahçelievler");
            bolgeCb.SelectedIndex = 0;

            guvenlikSorusuCb.Items.Add("En Sevdiğiniz Hayvan Nedir");
            guvenlikSorusuCb.Items.Add("En Sevdiğiniz Araba");
            guvenlikSorusuCb.Items.Add("Birinci Sınıf Öğretmeninizin adı");
            guvenlikSorusuCb.Items.Add("Hangi Şehirde Doğdunuz");
            guvenlikSorusuCb.Items.Add("En Sevdiğiniz Hayvanın Adı");
            guvenlikSorusuCb.SelectedIndex = 0;
        }

        private void tumKullanicilariDoldur()
        {

            List<User> userList = controller.tumKullanicilariGetir();
            KullaniciPanelDgv.DataSource = userList;
        }

        private void kayitEkleBtn_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.kullaniciAdi = kullaniciAdiTxt.Text;
            user.sifre = sifreTxt.Text;
            user.yetki = yetkiCb.SelectedItem.ToString();
            user.bolge = bolgeCb.SelectedItem.ToString();
            user.emailAdres = emailAdresTb.Text;
            user.guvenlikSorusu = guvenlikSorusuCb.SelectedItem.ToString();
            user.GuvenlikCevabi = guvenlikCevabiTb.Text;

            LoginStatus sonuc = controller.KullaniciEkle(user);
            if (sonuc == LoginStatus.basarili)
            {
                MessageBox.Show("Kayıt Eklendi :=()", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                KullaniciPanelDgv.DataSource = controller.tumKullanicilariGetir();
            }
            else
            {
                MessageBox.Show("Gerekli alanların hepsini doldurun!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            kullaniciAdiTxt.Text = KullaniciPanelDgv.CurrentRow.Cells[1].Value.ToString();
            sifreTxt.Text = KullaniciPanelDgv.CurrentRow.Cells[2].Value.ToString();
            yetkiCb.Text = KullaniciPanelDgv.CurrentRow.Cells[3].Value.ToString();
            bolgeCb.Text = KullaniciPanelDgv.CurrentRow.Cells[4].Value.ToString();
            emailAdresTb.Text = KullaniciPanelDgv.CurrentRow.Cells[5].Value.ToString();
            guvenlikSorusuCb.Text = KullaniciPanelDgv.CurrentRow.Cells[6].Value.ToString();
            guvenlikCevabiTb.Text = KullaniciPanelDgv.CurrentRow.Cells[7].Value.ToString();

        }

        private void kayitGüncelleBtn_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.id = int.Parse(idTb.Text);
            user.kullaniciAdi = kullaniciAdiTxt.Text;
            user.sifre = sifreTxt.Text;
            user.yetki = yetkiCb.SelectedItem.ToString();
            user.bolge = bolgeCb.SelectedItem.ToString();
            user.emailAdres = emailAdresTb.Text;
            user.guvenlikSorusu = guvenlikSorusuCb.SelectedItem.ToString();
            user.GuvenlikCevabi = guvenlikCevabiTb.Text;
            controller.KullaniciGuncelle(user);
            LoginStatus sonuc = controller.KullaniciGuncelle(user);

            if (sonuc == LoginStatus.basarili)
            {
                MessageBox.Show("Kayıt Güncellendi :=()", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                KullaniciPanelDgv.DataSource = controller.tumKullanicilariGetir();
            }
            else
            {
                MessageBox.Show("Kayıt Güncellenirken Bir Hata Bulundu", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void kayitSilBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(idTb.Text))
            {

                LoginStatus sonuc = controller.kullaniciSil(int.Parse(idTb.Text));

                if (sonuc == LoginStatus.basarili)
                {
                    MessageBox.Show("Kayıt Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    KullaniciPanelDgv.DataSource = controller.tumKullanicilariGetir();
                }
                else if (sonuc == LoginStatus.basarisiz)
                {
                    MessageBox.Show("Kayıt Silinirken bir Hata Oluştu", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Silmek İstediğiniz Kaydın id değerini girin", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            else
            {
                MessageBox.Show("Kayıt Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void geriBtn_Click(object sender, EventArgs e)
        {
            AdminPanel admin = new AdminPanel();
            admin.Show();
            this.Hide();
        }
    }
}