using System.Drawing;
using System.Windows.Forms;

namespace cemal
{
    class UcakSavar:PictureBox
    {
        private PictureBox ucak = new PictureBox();

        public void ucakSavarOlustur(int x,int y,MainPencere ciz)
        {
            ucak.ImageLocation = "tanknavy.png";
            ucak.SizeMode = PictureBoxSizeMode.StretchImage;
            ucak.Size = new Size(50, 30);
            ucak.Location = new Point(x,y);
            ucak.BackColor = Color.Transparent;
            ciz.Controls.Add(ucak);
        }

        public int xDondur()
        {
            return ucak.Left;
        }
        public int genislik()
        {
            return ucak.Width;
        }
        public int yukseklik()
        {
            return ucak.Height;
        }
        public int yDondur()
        {
            return ucak.Top;
        }

        public void sagaGit()
        {
            ucak.Left += 30;
        }
        public void solaGit()
        {
            ucak.Left -= 30;
        }
    }
}
