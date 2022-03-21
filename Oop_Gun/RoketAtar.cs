using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop_Gun
{
    public class RoketAtar : AtesliSilah
    {
        public RoketAtar() : base("Bazooka", "Atarlı_Girl", 10, Menzil.UzakMenzil, false, 90, true)
        {
            this.Mermisi = MermiTipi.Roket;
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
                return "Roket Atışa Hazır";
            }
            else
                return "RoketAtar Zaten Dolu";
        }
    }
}
