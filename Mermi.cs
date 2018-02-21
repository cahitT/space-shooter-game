using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace cemal
{
    class Mermi:PictureBox
    {
        PictureBox mermi;
        public List<PictureBox> mermiler = new List<PictureBox>();
        public int mermiIndex = 0;


        public void mermiOlustur(int x, int y, MainPencere ciz)
        {
            mermi = new PictureBox();
            mermi.ImageLocation = "ammo.png";
            mermi.Size = new Size(7, 14);
            mermi.SizeMode = PictureBoxSizeMode.StretchImage;
            mermi.Location = new Point(x, y);
            mermi.BackColor = Color.Transparent;
            mermiler.Add(mermi);
            ciz.Controls.Add(mermiler[mermiIndex]);
            mermiIndex++;
        }

        public void mermiHareket()
        {
            for (int i = 0; i < mermiler.Count; i++)
                mermiler[i].Top -= 8;
        }


        public void mermiCiktiMi()
        {
            for (int i = 0; i < mermiler.Count; i++)
            {
                if (mermiler[i].Top < 0)
                {
                    mermiler[i].Dispose();
                    mermiler.RemoveAt(i);
                    mermiIndex--;
                }
            }
        }
    }
}
