using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Oop_Gun
{
    public abstract class AtesliSilah : Silah, IAtesli, IYakinlastir
    {
        public enum MermiTipi { Sacmalı, Cekirdekli, Top, Roket }
        public bool YivliMi { get; set; }
        public double Kalibre { get; set; }
        public bool DurbunluMu { get; set; }
        public MermiTipi Mermisi { get; protected set; }
        public int MermiAdet { get; protected set; }
        public int MaxMermiSayisi { get; protected set; }
        public string AudioPathFire { get; set; }
        public string AudioPathReload { get; set; }

        private Random Olasilik = new Random();
        public AtesliSilah():base()
        {
            this.AtesliMi = true;
        }
        public AtesliSilah(string Marka, string Model, double Agirlik, Menzil Menzili, bool YivliMi, double Kalibre, bool DurbunluMu): base(Marka, Model, Agirlik, true, Menzili)
        {
            this.YivliMi = YivliMi;
            this.Kalibre = Kalibre;
            this.DurbunluMu = DurbunluMu;
            this.AtesliMi = true;

        }
        public virtual string AtesEt()
        {
            int OldururMu = Olasilik.Next(1, 3);
            if (this.MermiAdet > 0)
            {
                SoundPlayer sp = new SoundPlayer();
                sp.SoundLocation = this.AudioPathFire;
                sp.PlaySync();
                this.MermiAdet--;
                if (OldururMu == 1)
                {
                    return "Ateş Edildi ve " + Yarala();
                }
                else
                    return "Ates Edildi ve " + Oldur();
            }
            else
            {
                SoundPlayer sp = new SoundPlayer();
                sp.SoundLocation = @"..\..\..\Oop_Gun\Sesler\GunEmpty.wav";
                sp.Play();
                return "Mermimiz Bitti";
            }
        }

        public string Yakinlastir()
        {
            if (this.DurbunluMu == true)
                return "Yakınlaştırıldı";
            else
                return "Silahınız durbunsuzdur";
        }


        public string Uzaklastir()
        {
            if (this.DurbunluMu == true)
                return "Uzaklaştırıldı";
            else
                return "Silahınız durbunsuzdur";
        }


        public abstract string Doldur();
    }
}
