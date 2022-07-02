using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KuwaraFamily
{
    class Program
    {
        static void Main(string[] args)
        {
            Duryodana duryodana = new Duryodana();
            Dursasana dursasana = new Dursasana();
            Karna karna = new Karna();
            Bima bima = new Bima();

            duryodana.hit();
            dursasana.kick();
            karna.defend();
            bima.dead();
        }
    }
}
