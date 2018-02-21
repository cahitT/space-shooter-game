using System.Media;

namespace cemal
{
    class Ses
    {
        SoundPlayer player = new SoundPlayer();

        public void mermiSesi()
        {   
            player.SoundLocation = "gun.wav";
            player.Play();
        }
        public void bitisSesi()
        {
            player.SoundLocation = "sidious.wav";
            player.Play();
        }
    }
}
