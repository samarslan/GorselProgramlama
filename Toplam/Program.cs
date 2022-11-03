using System;

class Program {
    public static void Main (string[] args) {
        int sayi=0, sayaç=0,toplam=0;

        while(sayi!=-1)
        {
            Console.WriteLine("Sayı girin: ");
            sayi=Convert.ToInt32(Console.ReadLine());
            sayaç++;
            toplam+=sayi;
        }
        Console.WriteLine(toplam);
    }
}