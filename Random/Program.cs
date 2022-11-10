using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Randoms
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList kolon;
            ArrayList kupon = new ArrayList();
            Random rastgele = new Random();
            int sayi;

            for (int k = 0; k < 8; k++)
            {
                kolon = new ArrayList();
                for (int i = 0; i < 6; i++)
                {
                    sayi = rastgele.Next(1, 50);
                    if (kolon.Contains(sayi) == false)
                    {
                        kolon.Add(sayi);
                    }
                    else
                    {
                        i--;
                    }
                }
                kolon.Sort();
                kupon.Add(kolon);
            }


            foreach (ArrayList kolone in kupon)
            {
                foreach (var eleman in kolone)
                {
                    Console.Write(eleman + " - ");
                }
                Console.WriteLine("\n");
            }
        }
    }
}
