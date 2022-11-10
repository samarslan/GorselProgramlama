using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ArrayLists
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList dizi_listesi = new ArrayList();
            int[] sayilar = new int[5] { 10, 20, 30, 40, 50 };


            dizi_listesi.Add(100);
            dizi_listesi.Add("İstanbul");
            dizi_listesi.Add(3.1471592);
            dizi_listesi.Add('x');
            dizi_listesi.Add("Salam");
            dizi_listesi.Add(true);

            foreach (object eleman in dizi_listesi) 
            {
                Console.WriteLine(eleman+" - "+eleman.GetType());
            }
            Console.WriteLine("--------------------------------------");


            dizi_listesi.AddRange(sayilar);
            foreach (object eleman in dizi_listesi)
            {
                Console.WriteLine(eleman + " - " + eleman.GetType());
            }
            Console.WriteLine("--------------------------------------");
            Console.ReadLine( );
        }
    }
}
