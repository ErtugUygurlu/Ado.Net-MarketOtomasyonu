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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GirisBtn_Click(object sender, EventArgs e)
        {
            Controller controller = new Controller();
            User result = controller.Login(KullaniciAdiTb.Text, SifreTb.Text);

           if(result!=null && result.status== LoginStatus.basarili&& result.yetki=="admin")
            {
                AdminPanel adminPanel= new AdminPanel();
                adminPanel.Show();
                this.Hide();
            }
           else if(result != null && result.status == LoginStatus.basarili && result.yetki == "kasiyer")
            {
                KasiyerPanel kasiyerPanel=new KasiyerPanel();
                kasiyerPanel.Show();
                this.Hide();
            }
            else if(result != null && result.status == LoginStatus.basarisiz)
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Eksik paramatre hatası", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            SifreDegistirme SD = new SifreDegistirme();
            SD.Show();
            this.Hide();
        }
    }
}
