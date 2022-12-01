using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G1_Sınıflar_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(İşlem.topla(3,5));
            İşlem sınıf1 = new İşlem();
            sınıf1.Yazdır(İşlem.topla(3, 5));
        }
    }

}
