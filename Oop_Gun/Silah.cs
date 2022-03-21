using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Oop_Gun
{
    public abstract class Silah
    {
        public enum Menzil { YakınMenzil, UzakMenzil, CokUzakMenzil }

        public double Agirlik { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public bool AtesliMi { get; protected set; }
        public Menzil Menzili { get; protected set; }
        public Silah(string Marka, string Model, double Agirlik, bool AtesliMi, Menzil Menzili)
        {
            this.Marka = Marka;
            this.Model = Model;
            this.Agirlik = Agirlik;
            this.AtesliMi = AtesliMi;
            this.Menzili = Menzili;
        }
        public Silah()
        {

        }
        SoundPlayer sp2;
        protected string Oldur()
        {
            
            sp2 = new SoundPlayer(); 
            SoundPlayer sp = new SoundPlayer();
            sp.SoundLocation = @"..\..\..\Oop_Gun\Sesler\death.wav";
            sp.PlaySync();
            return "Öldürüldü";
        }
        protected string Yarala()
        {
            SoundPlayer sp = new SoundPlayer();
            sp.SoundLocation = @"..\..\..\Oop_Gun\Sesler\scream.wav";
            sp.Play();
            return "Yaralandı";
        }
    }
}
