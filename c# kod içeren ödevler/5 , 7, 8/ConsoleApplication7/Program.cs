using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            double R, k, h;
            Console.Write("N giriniz: ");
            n = int.Parse(Console.ReadLine());
            double[] sayilar = new double[n];
            for (int i = 0; i < n; i++)
            {
                sayilar[i] = double.Parse(Console.ReadLine());
            }
            Array.Sort(sayilar);
            R = sayilar[n - 1] - sayilar[0];
            k = (int)Math.Sqrt(n) + 1;
            h = R / k;
            if ((int)h < h)
            {
                h = (int)h + 1;
            }
            Console.WriteLine("k={0} h={1} R={2}", k, h, R);
            double[] siniflimitAlt = new double[(int)k];
            siniflimitAlt[0] = sayilar[0];
            for (int i = 1; i < k; i++)
            {
                siniflimitAlt[i] = siniflimitAlt[i - 1] + h;
            }
            double[] siniflimitUst = new double[(int)k];
            for (int j = 0; j < k - 1; j++)
            {
                if ((int)siniflimitAlt[0] < siniflimitAlt[0])
                {
                    double cikarilacak_sayi = 0.1;
                    siniflimitUst[j] = siniflimitAlt[j + 1] - cikarilacak_sayi;
                }
                else
                {
                    siniflimitUst[j] = siniflimitAlt[j + 1] - 1;
                }
            }
            if ((int)siniflimitAlt[0] < siniflimitAlt[0])
            {
                siniflimitUst[(int)k - 1] = (siniflimitAlt[(int)k - 1] + h) - 0.1;
            }
            else
            {
                siniflimitUst[(int)k - 1] = (siniflimitAlt[(int)k - 1] + h) - 1;
            }
            double[] sinifsinirUst = new double[(int)k];
            double[] sinifsinirAlt = new double[(int)k];
            for(int a = 0; a < k-1; a++)
            {
                sinifsinirUst[a] = (siniflimitAlt[a + 1] + siniflimitUst[a]) / 2;
                sinifsinirAlt[a + 1] = sinifsinirUst[a];
            }
            sinifsinirAlt[0] = sinifsinirAlt[1] - h;
            sinifsinirUst[(int)k - 1] = sinifsinirUst[(int)k - 2]+h;
            int[] sinifFrekans = new int[(int)k];
            for (int c = 0; c <k; c++)
            {
                int sayac = 0;
                for (int x = 0; x < n; x++)
                {
                    if (sinifsinirAlt[c] <=sayilar[x]&&sayilar[x]<=sinifsinirUst[c])
                    {
                        sayac++;
                        sinifFrekans[c] = sayac;
                    }
                }
            }
            double[] sinifortaNoktasi = new double[(int)k];
            for(int b = 0; b < k ; b++)
            {
                sinifortaNoktasi[b] = (sinifsinirAlt[b] + sinifsinirUst[b]) / 2;
            }
            int[] eklenikFrekans = new int[(int)k];
            eklenikFrekans[0] = sinifFrekans[0];
            for(int y = 1; y < k; y++)
            {
                eklenikFrekans[y] = eklenikFrekans[y-1] + sinifFrekans[y];
            }
            double[] oransalFrekans = new double[(int)k];
            for(int z = 0; z < k; z++)
            {
                oransalFrekans[z] =(double)sinifFrekans[z] / n;
            }
            double[] oransaleklenikFrekans = new double[(int)k];
            for(int t = 0; t < k; t++)
            {
                oransaleklenikFrekans[t] =(double)eklenikFrekans[t] / n;
            }

            Console.WriteLine("  <<< Sınıf Limitleri >>>   <<< Sınıf Sınırları >>>   <<< Sınıf Frekans >>>   <<< Sınıf Orta Noktası >>>   <<< Eklenik Frekans >>>   <<< Oransal Frekans >>>   <<< Oransal Eklenik Frekans >>>");
            for (int a = 0; a < k; a++)
            {
            Console.WriteLine("     {0}       {1}              {2}        {3}                {4}                        {5}                         {6}                 {7}                       {8}   ",   siniflimitAlt[a], siniflimitUst[a],sinifsinirAlt[a],sinifsinirUst[a],sinifFrekans[a],sinifortaNoktasi[a],eklenikFrekans[a],oransalFrekans[a],oransaleklenikFrekans[a]);                
            }
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");

            double aritmetikort = 0, veritoplam = 0, varyans = 0, varyanspay = 0, standartsapma = 0, OMS = 0, OMSpay = 0;



            for (int i = 0; i < n; i++)
            {
                veritoplam += sayilar[i];
            }
            aritmetikort = veritoplam / n;

            for (int i = 0; i < n; i++)
            {
                varyanspay += Math.Pow((sayilar[i] - aritmetikort), 2);
            }
            varyans = varyanspay / (n - 1);

            standartsapma = Math.Sqrt(varyans);

            for (int i = 0; i < n; i++)
            {
                OMSpay += Math.Abs(sayilar[i] - aritmetikort);
            }
            OMS = OMSpay / n;

            double n1 = 0, L1, Q1, fQ1, j1, altceyrekdorttebir;
            int altceyrekdizisayac = 0;
            altceyrekdorttebir = (double)n / 4;

            for (int i = 0; i < k; i++)
            {
                if (eklenikFrekans[i] < altceyrekdorttebir)
                {
                    altceyrekdizisayac += 1;
                }
            }
            

            for (int i = 0; i < altceyrekdizisayac; i++)
            {
                n1 += sinifFrekans[i];
            }

            j1 = altceyrekdorttebir - n1;
            fQ1 = sinifFrekans[altceyrekdizisayac];
            L1 = sinifsinirAlt[altceyrekdizisayac];

            Q1 = L1 + (j1 * h / fQ1);


            double n3 = 0, L3, Q3, fQ3, j3, ustceyrekdorttebir;
            int ustceyrekdizisayac = 0;
            ustceyrekdorttebir = (double)3 * n / 4;

            for (int i = 0; i < k; i++)
            {
                if (eklenikFrekans[i] < ustceyrekdorttebir)
                {
                    ustceyrekdizisayac += 1;
                }
            }
            for (int i = 0; i < ustceyrekdizisayac; i++)
            {
                n3 += sinifFrekans[i];
            }

            j3 = ustceyrekdorttebir - n3;
            fQ3 = sinifFrekans[ustceyrekdizisayac];
            L3 = sinifsinirAlt[ustceyrekdizisayac];

            Q3 = L3 + (j3 * h / fQ3);


            double carpiklik, basiklik, degisim, carpiklikpay = 0, basiklikpay = 0;

            for (int i = 0; i < n; i++)
            {
                carpiklikpay += Math.Pow((sayilar[i] - aritmetikort), 3);
            }
            carpiklik = carpiklikpay / (n - 1);

            for (int i = 0; i < n; i++)
            {
                basiklikpay += Math.Pow((sayilar[i] - aritmetikort), 4);
            }
            basiklik = basiklikpay / (n - 1);

            degisim = standartsapma / aritmetikort;
            
                
                
            Console.WriteLine("Varyans= {0}", varyans);
            Console.WriteLine("Standart Sapma= {0}", standartsapma);
            Console.WriteLine("OMS= {0}", OMS);
            Console.WriteLine("Q1= {0}", Q1);
            Console.WriteLine("Q3= {0}", Q3);
            Console.WriteLine("Carpiklik= {0}", carpiklik);
            Console.WriteLine("Basiklik= {0}", basiklik);
            Console.WriteLine("Degisim= {0}", degisim);




            Console.ReadLine();
        }

    }
}