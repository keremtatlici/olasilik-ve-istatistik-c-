using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merkezi_Egilim_Ölcüleri
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            double aritmetikort = 0, medyan, mod, geometrikort, harmonikort, verilertoplami=0,gecici=0,carpimveri=1,ttoplamveri=0;
            

            Console.Write("n degerini girin: ");
            n = int.Parse(Console.ReadLine());
            double[] veriler = new double [n];
            int[] sayac = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("{0}. veriyi girin: ", i+1);
                veriler[i] = int.Parse(Console.ReadLine());
            }

            for(int i = 0; i < n; i++)
            {
                for(int j = i; j < n; j++)
                {
                    if (veriler[i] > veriler[j])
                    {
                        gecici = veriler[i];
                        veriler[i] = veriler[j];
                        veriler[j] = gecici;
                    }
                }
            }



            for(int i = 0; i < n; i++)
            {
                verilertoplami += veriler[i];
            }

            aritmetikort = verilertoplami / n;

            if (n % 2 == 0)
            {
                medyan = (veriler[(n-1) / 2] + veriler[((n-1) / 2) + 1]) / 2;
            }
            else
            {
                medyan = veriler[(n) / 2];
            }

            for(int i = 0; i < n; i++)
            {
                for(int j = i; j < n; j++)
                {
                    if (veriler[i] == veriler[j])
                    {
                        sayac[i] += 1;
                    }
                }
            }
            mod = veriler[0];
            for(int i = 1; i < n; i++)
            {
                if (sayac[i-1] < sayac[i])
                {
                    mod = veriler[i + 1];
                }
            }


            for(int i = 0; i < n; i++)
            {
                carpimveri = carpimveri * veriler[i];
            }
            
            geometrikort = Math.Pow(carpimveri, (double)1 / n);

            for(int i = 0; i < n; i++)
            {
                ttoplamveri += 1 / veriler[i];
            }

            harmonikort = n / ttoplamveri;


            Console.WriteLine("");

            Console.WriteLine("Aritmetik Ortalama: {0}", aritmetikort);
            Console.WriteLine("Medyan: {0}", medyan);
            Console.WriteLine("Mod: {0}",mod);
            Console.WriteLine("Geometrik Ortalama: {0}", geometrikort);
            Console.WriteLine("Harmonik Ortalama: {0}", harmonikort);



            Console.ReadKey();
        }
    }
}
