using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop_Gun
{
    public class Bicak : Silah, IKesici
    {
        private int KesmeSayisi;
        public Bicak()
        {
            this.AtesliMi = false;
            this.Menzili = Menzil.YakınMenzil;
            this.KesmeSayisi = 5;
        }
        public Bicak(string Marka, string Model, double Agirlik): base(Marka, Model, Agirlik, false, Menzil.YakınMenzil)
        {
            this.KesmeSayisi = 5;
        }
        public string Kes()
        {
            System.Media.SoundPlayer sp = new System.Media.SoundPlayer();
            sp.SoundLocation = @"..\..\..\Oop_Gun\Sesler\StabKnife.wav";
            sp.PlaySync();
            if (KesmeSayisi > 0)
            {
                KesmeSayisi--;
                return Yarala();
            }
            else if (KesmeSayisi == 0)
            {
                KesmeSayisi = 5;
                return Oldur() + " ve " + Bileyle();
            }
            return "";
        }

        public string Bileyle()
        {
            System.Media.SoundPlayer sp = new System.Media.SoundPlayer();
            sp.SoundLocation = @"..\..\..\Silahlarim\Sesler\SharpenKnife.wav";
            sp.Play();
            return "Bıcak Jilet gibi oldu";
        }

    }
}
