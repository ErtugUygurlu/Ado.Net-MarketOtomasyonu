using AForge.Video.DirectShow;
using market.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;

namespace market
{
    public partial class SebzePanel : Form
    {
        int sayi1;
        int sayi2;
        int islemTip;
        public SebzePanel()
        {
            InitializeComponent();
            islemTxt.Text = "0";
        }

        private void SebzePanel_Load(object sender, EventArgs e)
        {
            timer1.Start();
            fic = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo camera in fic)
            {
                KameraCb.Items.Add(camera.Name);
            }
        }

        FilterInfoCollection fic;
        VideoCaptureDevice vcd;
        private void dokuzBtn_Click(object sender, EventArgs e)
        {
            if(islemTxt.Text == "0")
            {
                islemTxt.Text = "";
            }
            islemTxt.Text += ((Button)sender).Text;
        }

        private void temizleBtn_Click(object sender, EventArgs e)
        {
            islemTxt.Text = "0";
        }

        private void toplamaBtn_Click(object sender, EventArgs e)
        {
            islemTip = 1;//artıyı temsil etsin
            sayi1 = int.Parse(islemTxt.Text);
            islemTxt.Text = "0";
        }

        private void esittirBtn_Click(object sender, EventArgs e)
        {
            if (islemTip == 1)
            {
                sayi2 = int.Parse(islemTxt.Text);
                islemTxt.Text = (sayi1 + sayi2).ToString();
            }
            else if (islemTip == 2)
            {
                sayi2 = int.Parse(islemTxt.Text);
                islemTxt.Text = (sayi1 - sayi2).ToString();
            }
            else if (islemTip == 3)
            {
                sayi2 = int.Parse(islemTxt.Text);
                islemTxt.Text = (sayi1 * sayi2).ToString();
            }
            else if (islemTip == 4)
            {
                sayi2 = int.Parse(islemTxt.Text);
                islemTxt.Text = (sayi1 / sayi2).ToString();
            }
        }

        private void cıkarmaBtn_Click(object sender, EventArgs e)
        {
            islemTip = 2; // çıkarmayı temsil eder
            sayi1 = int.Parse(islemTxt.Text);
            islemTxt.Text = "0";    
        }

        private void carpmaBtn_Click(object sender, EventArgs e)
        {
            islemTip = 3; // çarpmayı temsil eder
            sayi1 = int.Parse(islemTxt.Text);
            islemTxt.Text = "0";
        }

        private void bolmeBtn_Click(object sender, EventArgs e)
        {
            islemTip = 4; // bölü temsil eder
            sayi1 = int.Parse(islemTxt.Text);
            islemTxt.Text = "0";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (islemTxt.Text.Length != 0) 
            {
                islemTxt.Text = islemTxt.Text.Substring(0, islemTxt.Text.Length - 1);
            }
            else
            {
                islemTxt.Text = "0";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(kameraPb.Image!=null)
            {
                BarcodeReader reader = new BarcodeReader();
               Result result= reader.Decode((Bitmap)kameraPb.Image);

                if(result!=null)
                {
                    textBox1.Text = result.ToString();
                    timer1.Stop();
                }
            }
        }

        private void KameraAcBtn_Click(object sender, EventArgs e)
        {
            vcd = new VideoCaptureDevice(fic[KameraCb.SelectedIndex].MonikerString);
            vcd.NewFrame += Vcd_NewFrame;
            vcd.Start();
            timer1.Start();
        }

        private void Vcd_NewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        {
           kameraPb.Image=(Bitmap) eventArgs.Frame.Clone();
        }

        private void kameraKapatBtn_Click(object sender, EventArgs e)
        {
            vcd.Stop();
            kameraPb.Image = Image.FromFile(@"D:\market\resimler\camera.ico");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            controller.Controller controller = new controller.Controller();
            Urun TUrun = controller.urunuGetir(textBox1.Text);
            islemTxt.Text = TUrun.fiyat.ToString();
            urunIsımLbl.Text = TUrun.urunIsim.ToString();
            SoundPlayer ses = new SoundPlayer();
            ses.SoundLocation = "barkodd.wav";
            ses.Play();
        }
    }
}
