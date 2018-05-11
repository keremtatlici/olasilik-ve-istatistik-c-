using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace olasilikveistatistik9
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, r,a,permutasyon;
            Console.WriteLine("n değerini giriniz: ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("r değerini giriniz: ");
            r= int.Parse(Console.ReadLine());
            int fakt = n;
            for(int i=n-1;i>=1;i--)
            {
                fakt = fakt * i;
            }
            a = n - r;
            int fakt1 = a;
            for(int j=a-1;j>=1;j--)
            {
                fakt1 = fakt1 * j;
            }
            permutasyon = fakt / fakt1;

            Console.WriteLine("Sonuç= " + permutasyon);

            Console.ReadKey();
        }
    }
}
