using System;
using System.ComponentModel;

namespace Method
{
    internal class Program
    {
        //Parametre var geri dönüş var.
        /*public static void Main(string[] args)
        {
            int a, b;

            Console.WriteLine("Sayı gir: ");
            a = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Sayı gir: ");
            b = Convert.ToInt32(Console.ReadLine());

            int sonuc = Topla(a, b);

            Console.WriteLine("Sonuc = {0}",sonuc);
        }

        public static int Topla(int i, int i1)
        {
            return i + i1;
        }  */
        
        //----------------------------------------------------------------------------------------------------------------------
        
        /*Parametre yok geri dönüş var
        public static void Main(string[] args)
        {
            int sonuc = Topla();

            Console.WriteLine("Sonuc = {0}",sonuc);
        }

        public static int Topla()
        {
            int a, b;

            Console.WriteLine("Sayı gir: ");
            a = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Sayı gir: ");
            b = Convert.ToInt32(Console.ReadLine());

            return b + a;
        }  */
        
        //-----------------------------------------------------------------------------------
        
        /*Parametre var geri dönüş yok
        public static void Main(string[] args)
        {
            int a, b;

            Console.WriteLine("Sayı gir: ");
            a = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Sayı gir: ");
            b = Convert.ToInt32(Console.ReadLine());
            
            int sonuc = Topla(a,b);

            
        }

        public static int Topla(int a, int b)
        {
            Console.WriteLine(a+b);
        } */
        
        //-------------------------------------------------------------------------------------
        
        /*Parametre yok geri dönüş yok
        public static void Main(string[] args)
        {

            Topla();
        }

        public static void Topla()
        {
            int a, b;

            Console.WriteLine("Sayı gir: ");
            a = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Sayı gir: ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(a+b);
        }*/
    }
}