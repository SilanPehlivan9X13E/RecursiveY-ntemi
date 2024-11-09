using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriOdevi8 //İterasyon Yöntemi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcıdan eleman sayısını alalım
            Console.WriteLine("Eleman sayısını girin: ");
            int n = int.Parse(Console.ReadLine());

            double[] x = new double[n];
            Console.WriteLine("Sayı girin:");
            for (int i = 0; i < n; i++)
            {
                x[i] = double.Parse(Console.ReadLine());
            }

            // İterasyon ile standart sapma hesaplama
            double standartSapma = iterasyonlaStandartSapma(x, n);
            Console.WriteLine("İterasyon ile Standart Sapma : " + standartSapma);

            Console.ReadLine();
        }
        static double iterasyonlaStandartSapma(double[] x, int n)
        {
            // Ortalama hesaplanıyor
            double mean = 0;
            for (int i = 0; i < n; i++)
            {
                mean += x[i];
            }
            mean /= n;

            // Varyans hesaplanıyor
            double varyans = 0;
            for (int i = 0; i < n; i++)
            {
                varyans += Math.Pow(x[i] - mean, 2); // Her değerin ortalamadan farkının karesi
            }
            varyans /= n; // Varyansın ortalamasını hesaplamak için

         
            return Math.Sqrt(varyans);
        }
    }
}
