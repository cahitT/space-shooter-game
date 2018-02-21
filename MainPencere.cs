using System;
using System.Drawing;
using System.Windows.Forms;

namespace cemal
{
    public partial class MainPencere : Form
    {
        Dusman dusman = new Dusman();
        UcakSavar ucak = new UcakSavar();        //Nesneler oluşturuluyor.
        Mermi mermi = new Mermi();
        Ses ses = new Ses();

        private Timer zamanlayici;   //Timerlerın degiskenleri
        private Timer dusmanZaman;
        int sayac = 0;

        public MainPencere()
        {
            KeyDown += MainPencere_KeyDown; 
            InitializeComponent();
            DoubleBuffered = true;
            BackgroundImage = Image.FromFile("bg.png");
            zamanlayici = new Timer();
            zamanlayici.Interval = 50;
            zamanlayici.Tick += Zamanlayici_Tick;
            dusmanZaman = new Timer();
            dusmanZaman.Interval = 2000;
            dusmanZaman.Tick += DusmanZaman_Tick;
        }

        private void DusmanZaman_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            dusman.dusmanGemisiOlustur(rnd.Next(0, ActiveForm.Width-50), 0,this);
        }

        private void Zamanlayici_Tick(object sender, EventArgs e)
        {
            mermi.mermiHareket();
            carpmaDenetimi();              //Mermi ve dusmanların hareketleri yapılır ve carpma kontrolu yapılır.
            dusman.hareket();
            mermi.mermiCiktiMi();
            
            for (int i = 0; i < dusman.dusmanlar.Count; i++)
            {
                if (dusman.dusmanlar[i].Top > ActiveForm.Height-dusman.dYukseklikGetir()-45)
                {
                    zamanlayici.Stop();
                    dusmanZaman.Stop();                         //Ucak asagi indiginde timerlar durdurulur.
                    ses.bitisSesi();
                    gameOver.Visible = true;   //Gameover labeli ekrana cikartilir.
                }
            }
        
        }

        private void MainPencere_KeyDown(object sender, KeyEventArgs e)
        {
            if (zamanlayici.Enabled == true && dusmanZaman.Enabled == true||e.KeyCode==Keys.Enter)
            {
                if (e.KeyCode == Keys.Space) //Her space'e basıldıgında mermi cikartir.
                {
                    mermi.mermiOlustur(ucak.xDondur() + ucak.genislik() / 3 + 3, ucak.yDondur() - 25, this);
                    ses.mermiSesi();
                }
                else if (e.KeyCode == Keys.D && ucak.xDondur() + ucak.genislik() + 20 < ActiveForm.Right) //Her D'ye basildiginda saga dogru gider.
                {
                    ucak.sagaGit();
                }
                else if (e.KeyCode == Keys.A && ucak.xDondur() - 10 > 0)
                {
                    ucak.solaGit();
                }
                else if (e.KeyCode == Keys.Enter) //Entera basildiginda oyun baslar.
                {
                    ucak.ucakSavarOlustur(ActiveForm.Width / 2-ucak.genislik(), ActiveForm.Height - 65, this);
                    zamanlayici.Start();
                    oyunBasla.Hide();
                    dusmanZaman.Start();
                    if(gameOver.Visible==true)
                    {
                        Application.Restart(); //Gameover labeli ciktiginda ENTER'a basilirsa Oyunu tekrar baslatir.
                    }
                }
            }
        }

        public void carpmaDenetimi() //Carpisma denetimi yapilir.
        {
            for (int i = 0; i < mermi.mermiler.Count; i++)
            {
                PictureBox m = mermi.mermiler[i];

                for (int j = 0; j < dusman.dusmanlar.Count; j++)
                {
                    PictureBox d = dusman.dusmanlar[j];
                    if (m.Left + m.Width > d.Left && m.Left + m.Width < d.Left + d.Width && m.Top > d.Top && m.Top < d.Top + d.Height)
                    {
                        mermi.mermiler[i].Dispose();
                        mermi.mermiler.RemoveAt(i);
                        mermi.mermiIndex--;
                        dusman.dusmanlar[j].Dispose();
                        dusman.dusmanlar.RemoveAt(j);
                        dusman.dusmanIndex--;
                        sayac++;
                        scoreSayac.Text = sayac.ToString();
                    }
                }
            }
        }
    }
}
