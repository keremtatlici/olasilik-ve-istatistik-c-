using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ödev_1x3
{
    class Program
    {/*3.	Basit seri (ben n değerini ve verileri gireceğim,
        yazılım n değeri ile girilen veri sayısını karşılaştırdıktan sonra 
        girilmiş olan verileri küçükten büyüğe sıralayacak)
       */
        static void Main(string[] args)
        {
            Console.Write("n değerini girin: "); 
            int n = Convert.ToInt32(Console.ReadLine());
            int[] sayilar = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0}.sayiyi giriniz:",i+1);
                sayilar[i] = Convert.ToInt32(Console.ReadLine());

            }
            
            Array.Sort(sayilar);
            foreach (int i in sayilar)
            {

                Console.WriteLine("{0}", i);

            }
            Console.ReadKey();
        }
    }
}
