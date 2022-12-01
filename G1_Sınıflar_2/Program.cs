using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G1_Sınıflar_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Kare nesne1 = new Kare();
            nesne1.kenar_uzunluğu = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(nesne1.Alan_Heapla());
            Console.WriteLine(nesne1.Çevre_Heapla());
            nesne1.Kare_Çiz();
            Console.ReadLine();
        }
    }
}
