using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop_Gun
{
    public class Cephanem
    {
        public Silah[] MyWeapons { get; set; }
        public Cephanem()
        {
            MyWeapons = new Silah[6];
        }
        public Image SilahDegis(int Hangisi)
        {
            switch (Hangisi)
            {
                case 1:
                    return Image.FromFile(@"..\..\..\Oop_Gun\Resimler\Knife.jpg");
                case 2:
                    return Image.FromFile(@"..\..\..\Oop_Gun\Resimler\Pistol.jpg");
                case 3:
                    return Image.FromFile(@"..\..\..\Oop_Gun\Resimler\ShotGun.jpg");
                case 4:
                    return Image.FromFile(@"..\..\..\Oop_Gun\Resimler\MachineGun.gif");
                case 5:
                    return Image.FromFile(@"..\..\..\Oop_Gun\Resimler\KF1500.jpg");
                case 6:
                    return Image.FromFile(@"..\..\..\Oop_Gun\Resimler\RPG.jpg");
            }
            return Image.FromFile(@"..\..\..\Oop_Gun\Resimler\Knife.jpg");
        }
    }
}
