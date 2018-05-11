using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ödev_1x4
{
    class Program
    {/* 4.	Frekans Serisi (n değerini ve veri girişini yapacağım, yazılım frekans 
        serisini oluşturacak yani her veri değerini (Xi) sadece 1 kere yazacak ve 
        karşısına o değerin kaç kere tekrar edildiğini azacak (fi))
        */
        static void Main(string[] args)
        {

           int sayac = 0;
            Console.WriteLine("Dizinin Eleman Sayısını Girin");
           int n = Int16.Parse(Console.ReadLine());
            int[] dizi = new int[n];
            Console.WriteLine("Dizinin Elemanlarını Sırayla Girin");
            for (int i = 0; i < n; i++)
            {
                dizi[i] = Int16.Parse(Console.ReadLine());
            }
            Array.Sort(dizi);

            for (int j = 0; j < n; j++)
            {
                for (int k = 0; k < n; k++)
                {
                    if (dizi[j] == dizi[k])
                    {
                        for (int l = 0; l < j; l++)
                        {
                            if (dizi[l] == dizi[j])
                         
                                sayac = -1;
                        }
                        sayac++;
                    }
                }
                if (sayac != 0)
                    Console.WriteLine(dizi[j] + " sayısı " + sayac + " kez tekrar edildi");
                sayac = 0;
            }
            Console.ReadKey();
        }
    }
}
