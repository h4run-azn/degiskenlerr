using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace degiskenler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string isim = "Ali";
            string soyisim = "Yılmaz";

            int yasim = 20;
            double boyum = 1.75;
            bool evliMi = false;
            char ilkHarf = 'A';
            decimal maas = 5000.50m;
            DateTime dogumTarihi = new DateTime(2003, 5, 15);
            Console.WriteLine("İsim: " + isim);
            Console.WriteLine("Soyisim: " + soyisim);
            Console.WriteLine("Yaş: " + yasim);

        }
    }
}
