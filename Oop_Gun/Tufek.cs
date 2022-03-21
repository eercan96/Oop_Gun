using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop_Gun
{
    public class Tufek : AtesliSilah
    {
        public enum TufekTipi { Pompalı, Taramalı }

        public TufekTipi Tip { get; set; }

        public Tufek(TufekTipi Tip) : base()
        {
            this.Menzili = Menzil.UzakMenzil;
            this.Tip = Tip;
            if (Tip == TufekTipi.Pompalı)
            {
                this.Mermisi = MermiTipi.Sacmalı;
                this.AudioPathFire = @"..\..\..\Oop_Gun\Sesler\Pompali.wav";
                this.AudioPathReload = @"..\..\..\Oop_Gun\Sesler\PompaliSarjor.wav";
                this.MaxMermiSayisi = 8;
            }
            else if (Tip == TufekTipi.Taramalı)
            {
                this.Mermisi = MermiTipi.Cekirdekli;
                this.AudioPathFire = @"..\..\..\Oop_Gun\Sesler\Taramali.wav";
                this.AudioPathReload = @"..\..\..\Oop_Gun\Sesler\Taramali1.wav";
                this.MaxMermiSayisi = 30;
            }
        }
        public Tufek(string Marka, string Model, double Agirlik, bool YivliMi, double Kalibre, bool DurbunluMu, TufekTipi Tip) : base(Marka, Model, Agirlik, Menzil.UzakMenzil, YivliMi, Kalibre, DurbunluMu)
        {
            this.Tip = Tip;
            if (Tip == TufekTipi.Pompalı)
            {
                this.Mermisi = MermiTipi.Sacmalı;
                this.AudioPathFire = @"..\..\..\Oop_Gun\Sesler\Pompali.wav";
                this.AudioPathReload = @"..\..\..\Oop_Gun\Sesler\PompaliSarjor.wav";
                this.MaxMermiSayisi = 8;
            }
            else if (Tip == TufekTipi.Taramalı)
            {
                this.Mermisi = MermiTipi.Cekirdekli;
                this.AudioPathFire = @"..\..\..\Oop_Gun\Sesler\Taramali.wav";
                this.AudioPathReload = @"..\..\..\Oop_Gun\Sesler\Taramali1.wav";
                this.MaxMermiSayisi = 30;
            }

        }
        public override string Doldur()
        {
            if (this.Tip == TufekTipi.Pompalı && this.MermiAdet < this.MaxMermiSayisi)
            {
                System.Media.SoundPlayer sp = new System.Media.SoundPlayer();
                sp.SoundLocation = this.AudioPathReload;
                sp.Play();
                this.MermiAdet++;
                return "Pompalıya bir fisek kondu";
            }
            else if (this.Tip == TufekTipi.Taramalı && this.MermiAdet < this.MaxMermiSayisi)
            {
                System.Media.SoundPlayer sp = new System.Media.SoundPlayer();
                sp.SoundLocation = this.AudioPathReload;
                sp.Play();
                this.MermiAdet = this.MaxMermiSayisi;
                return "Taramalı tufek sarjoru Fullendi";
            }
            else
                return "Mermi Full";
        }
    }
}
