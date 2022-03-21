using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop_Gun
{
    public class Tabanca : AtesliSilah
    {
        public Tabanca() : base()
        {
            this.Mermisi = MermiTipi.Cekirdekli;
            this.Menzili = Menzil.UzakMenzil;
            this.AudioPathFire = @"..\..\..\Oop_Gun\Sesler\Tabanca.wav";
            this.AudioPathReload = @"..\..\..\Oop_Gun\Sesler\silah1.wav";
            this.MaxMermiSayisi = 15;
        }
        public Tabanca(string Marka, string Model, double Agirlik, bool YivliMi, double Kalibre, bool DurbunluMu) : base(Marka, Model, Agirlik, Menzil.UzakMenzil, YivliMi, Kalibre, DurbunluMu)
        {
            this.AudioPathFire = @"..\..\..\Oop_Gun\Sesler\Tabanca.wav";
            this.AudioPathReload = @"..\..\..\Oop_Gun\Sesler\silah1.wav";
            this.Mermisi = MermiTipi.Cekirdekli;
            this.MaxMermiSayisi = 15;
        }
        public override string Doldur()
        {
            if (this.MermiAdet < this.MaxMermiSayisi)
            {
                System.Media.SoundPlayer sp = new System.Media.SoundPlayer();
                sp.SoundLocation = this.AudioPathReload;
                sp.Play();
                this.MermiAdet = this.MaxMermiSayisi;
                return "Tabancaya 15 mermilik şarjor takıldı";
            }
            else
                return "Şarjor zaten dolu";
        }
    }
}
