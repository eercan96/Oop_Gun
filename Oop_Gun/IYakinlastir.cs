using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop_Gun
{
    public interface IYakinlastir
    {
        bool DurbunluMu { get; set; }
        string Yakinlastir();
        string Uzaklastir();
    }
}
