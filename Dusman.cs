using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace cemal
{
    class Dusman:PictureBox
    {
        PictureBox dusman;
        public List<PictureBox> dusmanlar=new List<PictureBox>();
        public int dusmanIndex = 0;
        public int index=0;


        public void dusmanGemisiOlustur(int x, int y,MainPencere ciz)
        {
            dusman = new PictureBox();
            dusman.ImageLocation = "enemyShip.png";
            dusman.SizeMode = PictureBoxSizeMode.StretchImage;
            dusman.Size = new Size(50, 45);
            dusman.Location = new Point(x, y);
            dusman.BackColor = Color.Transparent;
            dusmanlar.Add(dusman);
            ciz.Controls.Add(dusmanlar[dusmanIndex]);
            dusmanIndex++;
        }

        public void hareket()
        {
            for(int i=0;i<dusmanlar.Count;i++)
            {
                dusmanlar[i].Top += 7;
            }
        }

        public int dYukseklikGetir()
        {
            return dusman.Height;
        }
    }
}
