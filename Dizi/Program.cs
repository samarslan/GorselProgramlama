int toplam = 0;
int[] sayilar = new int[10];
double ortalama;

for (int i = 0; i < sayilar.Length; i++)
{
    Console.Write("{0}. index gir: ", i);
    sayilar[i] = Convert.ToInt32(Console.ReadLine());
}

foreach (int eleman in sayilar)
{
    Console.Write(eleman+"\t");
    toplam += eleman;
}

ortalama = toplam * 1.0 / sayilar.Length;
Console.WriteLine("Ortalama={0}",ortalama);

for (int i = 0; i < sayilar.Length; i++)
{
    if(sayilar[i]>ortalama)
        Console.WriteLine("+ {0}.index {1} ile geçti",i,sayilar[i]);
    else
        Console.WriteLine("- {0}.index {1} ile kaldı",i,sayilar[i]);
}

int eb=sayilar[0], ek=sayilar[0];
int eb_i=0, ek_i=0;

for (int i = 0; i < sayilar.Length; i++)
{
    if (sayilar[i] > eb)
    {
        eb = sayilar[i];
        eb_i = i;
    }

    if (sayilar[i] < ek)
    {
        ek = sayilar[i];
        ek_i = i;
    }
}

Console.WriteLine("En büyük={0} ve {1}.indextedir",eb,eb_i);
Console.WriteLine("En küçük={0} ve {1}.indextedir",ek,ek_i);