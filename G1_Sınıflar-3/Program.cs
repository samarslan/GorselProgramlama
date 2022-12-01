using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G1_Sınıflar_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Okul okul = new Okul(20, "Salamcılar Anadolu Lisesi", 20);
            okul.Yazdır();

            Okul okul2 = new Okul(30, "Atatürk Anadolu Lisesi", 9000);
            okul2.Yazdır();
        }
    }
}
