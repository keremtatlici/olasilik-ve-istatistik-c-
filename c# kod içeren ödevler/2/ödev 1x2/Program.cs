using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ödev_1x2
{
    class Program /* 
            2.	Sistematik rasgele örnekleme (Ben N ve n değerlerini gireceğim ve hesapla gibi bir butona
            (buton olmak zorunda değil) tıklayacağım sistem k=N/n yapacak ardından 0-k arasında rasgele bir sayı üretecek
            (a değeri) ve ardından ürettiği rasgele sayıya k ekleye ekleye,
            ilk ürettiği sayı da dahil olmak üzere toplan n tane sayı oluşturacak)
         */
    {
        static void Main(string[] args)
        {
            int k;
            Console.Write("N sayısı: ");
            int N = Convert.ToInt32(Console.ReadLine());
            Console.Write("n sayısı : ");
            int n = Convert.ToInt32(Console.ReadLine());
            k = N / n;
            Random rastgele = new Random();
            int[] dizi = new int[n];
            int a = rastgele.Next(0, k);
            dizi[0] = a;
            for (int i = 1; i < n; i++)
            {
                dizi[i] = a+(i*k);
            }
            for (int i = 0; i < dizi.Length; i++)
            {
                Console.WriteLine(dizi[i]);
            }


            Console.ReadKey();

        }
    }
}
