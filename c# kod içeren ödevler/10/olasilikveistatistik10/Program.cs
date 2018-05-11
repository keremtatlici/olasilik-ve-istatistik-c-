using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace olasilikveistatistik10
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, r,a;
            Console.WriteLine("n değerini giriniz: ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("r değerini giriniz: ");
            r = int.Parse(Console.ReadLine());
            int komb = n;
           
            for (int i = n - 1; i >= 1; i--)
            {
                komb = komb* i;
            }
            
            a = n - r;
            int komb1 = a;
            for (int j = a - 1; j >= 1; j--)
            {
                komb1 = komb1 * j;
            }
            int x = r;
            for (int j = r - 1; j >= 1; j--)
            {
                x = x * j;
            }
            double sonuc = komb / (komb1 * x);
          

            Console.WriteLine("Sonuç={0} ",sonuc);

            Console.ReadKey();

        }
    }
}
