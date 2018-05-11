using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasitRastgeleÖrnekleme
{
    class Program
    {/* 
        Rasgele sayı üretme (başlangıç-bitiş sınırları ve kaç sayı üretmesi gerektiğini ben gireceğim, yazılım girdiğim sınırlar arasında, 
        istediğim kadar rasgele sayı üretecek, eğer üretilecek sayı, verilen başlangıç-bitiş 
        aralığındaki sayıların toplamından az ise sayılar tekrar üretilemez, fazla ise üretilebilir)

        */
        static void Main(string[] args)
        {
            int alt, ust, adet, sayi;

            Console.Write("minimum değeri giriniz : ");
            alt = int.Parse(Console.ReadLine());
            Console.Write("maximum değeri giriniz : ");
            ust = int.Parse(Console.ReadLine());
            Console.Write("Sayı adedini giriniz: ");
            adet = int.Parse(Console.ReadLine());



            int[] dizi = new int[adet];

            Random rastgele = new Random();


            for(int i=0;i< adet; i++)
            {
                sayi = rastgele.Next(alt, ust + 1);
                
                bool x = false;

                if (adet <= ust+1 - alt)
                {
               
                    kontrol:
                    for(int j=0;j<=i; j++)
                    {
                        if (sayi == dizi[j])
                        {
                            
                            sayi = rastgele.Next(alt, ust + 1);
                            x = true;
                            goto kontrol;
                            
                        }else
                        {
                            x = false;
                        }
                        
                    }

                    if (x == false) 
                    {
                        dizi[i] = sayi;
                    }



                    Console.WriteLine(dizi[i]);


                }
                else
                {
                    dizi[i] = sayi;
                    Console.WriteLine(dizi[i]);
                }


            }

            Console.ReadKey();
        }
    }
}
