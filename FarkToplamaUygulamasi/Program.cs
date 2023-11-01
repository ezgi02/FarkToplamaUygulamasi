// See https://aka.ms/new-console-template for more information
/*
 Ekrandan girilen n tane sayının 67'den küçük yada büyük olduğuna 
bakan. Küçük olanların farklarının toplamını, büyük ise de farkların 
mutlak karelerini alarak toplayıp ekrana yazdıran console 
uygulamasını yazınız.

Örnek: Input: 56 45 68 77

Output: 33 101
 */

using System;
using System.Globalization;
using System.Collections.Generic;

namespace FarktoplamaUygulamasi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sayıları boşlukla ayırarak girin:");
            string input = Console.ReadLine();

            string[] sayilar = input.Split(' ');
            List<int> min = new List<int>();
            List<int> max = new List<int>();
            List<int> dizeler = new List<int>();
            int toplamFark = 0;
            for (int i = 0; i < sayilar.Length; i ++)
            {
                int num1 = int.Parse(sayilar[i]);//integer degere çevirdik
                if (num1 < 67)
                {
                    int result = 67 - num1;
                    min.Add(result);
                }
                if (num1 > 67)
                {
                    int result = num1 - 67;
                    int kare=(int)Math.Pow(result, 2);
                    max.Add(kare);
                }


            }
            int toplamFarkMin = 0;
            int toplamFarkMax = 0;

            foreach (int fark in min)
            {
                toplamFarkMin += fark;//Kucuk olanaları farkları toplamını
                
            }
            dizeler.Add(toplamFarkMin);

            foreach (int fark in max)
            {
                toplamFarkMax += fark; //Buyuk olanları ise mutlak kareleriini alıp ekrana yazdırma
               
            }
            dizeler.Add(toplamFarkMax);
            Console.WriteLine(toplamFarkMin + " " + toplamFarkMax);
        
            foreach (int dize in dizeler)
            {
                Console.Write(dize + " ");
            }
        }
    }
}
