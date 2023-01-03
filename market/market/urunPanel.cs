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
    public partial class urunPanel : Form
    {
        controller.Controller controller = new controller.Controller();
        public urunPanel()
        {
            InitializeComponent();
        }

        private void urunPanel_Load(object sender, EventArgs e)
        {
            tumUrunleriGetir();
            defaultAlanlariDoldur();
        }

        public void defaultAlanlariDoldur()
        {
            urunIsimCb.Items.Add("Brokoli");
            urunIsimCb.Items.Add("Çilek");
            urunIsimCb.Items.Add("Elma");
            urunIsimCb.Items.Add("Lahana");
            urunIsimCb.Items.Add("Muz");
            urunIsimCb.Items.Add("Portakal");
            urunIsimCb.Items.Add("Üzüm");
        }

        public void tumUrunleriGetir()
        {
            KullaniciPanelDgv.DataSource = controller.tumUrunleriGetir();
        }

        private void geriBtn_Click(object sender, EventArgs e)
        {
            AdminPanel admin = new AdminPanel();
            admin.Show();
            this.Hide();
        }

        private void kayitEkleBtn_Click(object sender, EventArgs e)
        {
            Urun urun = new Urun();
            urun.id = idTxt.Text;
            urun.qrkod = qrTxt.Text;
            urun.barkodKod = barkodTxt.Text;
            urun.olusturmaTarih = olusturmaDt.Value;
            urun.guncellemeTarih = GuncellemeDt.Value;
            urun.urunIsim = urunIsimCb.SelectedItem.ToString();
            urun.kilo = int.Parse(kiloTb.Text);
            urun.ciro = int.Parse(CiroTb.Text);

            LoginStatus sonuc = controller.urunEkle(urun);

            if (sonuc == LoginStatus.basarili)
            {
                MessageBox.Show("Ürün Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                KullaniciPanelDgv.DataSource = controller.tumUrunleriGetir();
            }
            else if (sonuc == LoginStatus.basarisiz)
            {
                MessageBox.Show("Ürün Eklenemedi", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Gerekli Alanları Doldurun", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void KullaniciPanelDgv_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            idTxt.Text = KullaniciPanelDgv.CurrentRow.Cells[0].Value.ToString();
            qrTxt.Text = KullaniciPanelDgv.CurrentRow.Cells[1].Value.ToString();
            barkodTxt.Text = KullaniciPanelDgv.CurrentRow.Cells[2].Value.ToString();
            olusturmaDt.Value = DateTime.Parse(KullaniciPanelDgv.CurrentRow.Cells[3].Value.ToString());
            GuncellemeDt.Value = DateTime.Parse(KullaniciPanelDgv.CurrentRow.Cells[4].Value.ToString());
            urunIsimCb.SelectedItem = KullaniciPanelDgv.CurrentRow.Cells[5].Value.ToString();
            kiloTb.Text = KullaniciPanelDgv.CurrentRow.Cells[6].Value.ToString();
            fiyatTb.Text = KullaniciPanelDgv.CurrentRow.Cells[7].Value.ToString();
            CiroTb.Text = KullaniciPanelDgv.CurrentRow.Cells[8].Value.ToString();
        }

        private void kayitGüncelleBtn_Click(object sender, EventArgs e)
        {
            Urun urun = new Urun();
            urun.id = idTxt.Text;
            urun.qrkod = qrTxt.Text;
            urun.barkodKod = barkodTxt.Text;
            urun.olusturmaTarih = olusturmaDt.Value;
            urun.guncellemeTarih = GuncellemeDt.Value;
            urun.urunIsim = urunIsimCb.SelectedItem.ToString();
            urun.fiyat = int.Parse(fiyatTb.Text);
            urun.kilo = int.Parse(kiloTb.Text);
            urun.ciro = int.Parse(CiroTb.Text);

            LoginStatus sonuc = controller.urunGuncelle(urun);

            if (sonuc == LoginStatus.basarili)
            {
                MessageBox.Show("Ürün Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                KullaniciPanelDgv.DataSource = controller.tumUrunleriGetir();
            }
            else if (sonuc == LoginStatus.basarisiz)
            {
                MessageBox.Show("Ürün Güncellenemedi", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Gerekli Alanları Doldurun", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void kayitSilBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(idTxt.Text))
            {
                LoginStatus sonuc = controller.urunSil(idTxt.Text);
                if (sonuc == LoginStatus.basarili)
                {
                    MessageBox.Show("Kayıt Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    KullaniciPanelDgv.DataSource = controller.tumKullanicilariGetir();
                }
                else
                {
                    MessageBox.Show("Silmek istediğiniz ürünün id değerini giriniz", "Eksik Parametre", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            else
            {
                MessageBox.Show("Silmek istediğiniz ürünün id değerini giriniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
