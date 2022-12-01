using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G1_Sınıflar_3
{
    class Okul
    {
        public int sınıf_adet;
        public string okul_isim;
        public int öğrenci_sayısı;

        public Okul(int a, string b, int c)
        {
            sınıf_adet = a;
            okul_isim = b;
            öğrenci_sayısı = c;
        }
        public void Yazdır()
        {
            Console.WriteLine("okulumuzdae {0} adet sınıf vardır. {1} okulumuzun ismidir. {2} Öğrenci sayısı = {2}", sınıf_adet, okul_isim, öğrenci_sayısı);
        }
    }
}
