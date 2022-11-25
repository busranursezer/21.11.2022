using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21._11._2022
{
    public class cDeger
    {
       
    
        public void DegeriKontrolEt()
        {
            Console.WriteLine("bir sayı giriniz ");
            int __Number = int.Parse(Console.ReadLine());
            if (__Number < 0)
            {
                Console.WriteLine("sayı negatiftir.");
            }

            else if (__Number > 0)
                {
                Console.WriteLine("sayı pozitiftir.");
                }
            else
            {
                Console.WriteLine("sayı değeri girmediniz.");
            }
        }



    }
}

