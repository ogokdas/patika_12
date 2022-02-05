using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patika_12
{
    public class Program
    {
        static void Main(string[] args)
        {
            Islem(3, 2);
        }

        public static int Toplama(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }

        public static int Cikarma(int sayi1, int sayi2)
        {
            return sayi1 - sayi2;
        }

        public static int Carpma(int sayi1, int sayi2)
        {
            return sayi1 * sayi2;

        }

        public static void Islem(int sayi1, int sayi2)
        {
            Console.WriteLine("Bu iki sayiyi kullanarak bazi islemler yapacagiz.{0}{1}",sayi1,sayi2);
            Toplama(sayi1, sayi2);
            Cikarma(sayi1, sayi2);
            Carpma(sayi1, sayi2);
        }

    }
}
