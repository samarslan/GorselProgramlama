using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G1_Sınıflar_2
{
    class Kare
    {
        public int kenar_uzunluğu;

        public int Alan_Heapla() => kenar_uzunluğu * kenar_uzunluğu;
        public int Çevre_Heapla() => kenar_uzunluğu * 4;
        public void Kare_Çiz()
        {
            for (int i = 0; i < kenar_uzunluğu; i++)
            {
                for (int k = 0; k < kenar_uzunluğu; k++)
                {
                    Console.Write('■');
                }
                Console.WriteLine();
            }
        }
    }
}
