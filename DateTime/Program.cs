using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeProj
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("\nŞimdi {0} dır.", DateTime.Now);
            Console.Write("\nBugünün tarihi {0} dur.", DateTime.Today);
            Console.Write("\nYılın {0}. günü", DateTime.Today.DayOfYear);
            Console.Write("\nHaftanın {0} günüdür.", DateTime.Today.DayOfWeek);


            DateTime tarih = new DateTime();
            tarih = DateTime.Now;
            Console.WriteLine("Şuan {0},",tarih);
            Console.WriteLine("Şu anda günün {0} saatindeyiz,", tarih.Hour);
            Console.WriteLine("Saatin {0} dakikasındayız,", tarih.Minute);
            Console.WriteLine("Dakikanın {0} saniyesindeyiz,", tarih.Second);
            Console.WriteLine("Saniyenin {0} milisaniyesindeyiz.", tarih.Millisecond);
        }
    }
}
