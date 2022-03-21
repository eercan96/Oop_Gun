using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop_Gun
{
    public class Top : AtesliSilah
    {
        public Top() : base("MKE", "KAFA1500", 150, Menzil.CokUzakMenzil, false, 152, false)
        {
            this.Mermisi = MermiTipi.Top;
            this.AudioPathFire = @"..\..\..\Oop_Gun\Sesler\TopAtis.wav";
            this.AudioPathReload = @"..\..\..\Oop_Gun\Sesler\Taramali2.wav";
            this.MaxMermiSayisi = 1;
        }
        public override string Doldur()
        {
            if (this.MermiAdet < this.MaxMermiSayisi)
            {
                System.Media.SoundPlayer sp = new System.Media.SoundPlayer();
                sp.SoundLocation = this.AudioPathReload;
                sp.Play();
                this.MermiAdet = this.MaxMermiSayisi;
                return "Top Atışa Hazır";
            }
            else
                return "Top Zaten Dolu";
        }
    }
}
