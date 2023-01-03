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
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            saatLbl.Text=DateTime.Now.Hour.ToString();
            dakikaLbl.Text=DateTime.Now.Minute.ToString();
            saniyeLbl.Text=DateTime.Now.Second.ToString();
        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void kullaniciBtn_Click(object sender, EventArgs e)
        {
            KullaniciPanel kullaniciPanel= new KullaniciPanel();
            kullaniciPanel.Show();
            this.Hide();
        }

        private void urunBtn_Click(object sender, EventArgs e)
        {
            urunPanel urun = new urunPanel();
            urun.Show();
            this.Hide();
        }

        private void cikisBtn_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }
    }
}
