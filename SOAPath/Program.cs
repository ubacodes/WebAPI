using Calculator;
using System;

namespace SOAPath
{
    class Program
    {
        static void Main(string[] args)
        {
            // Reusability = yeniden kullanılabilirlik
            /* 
             * Unstructed Programming
             * Procedural Programming
             * OOP
             * Component Based Programming (Layered arch)
             * Service Oriented Arch.
             */

            // Unstructed Programming
            int[] numbers1 = new int[] {1,2,3,4,5};
            int[] numbers2 = new int[] {10,20,30,40,50,60};
            /*
            int sum1 = 0;
            int sum2 = 0;

            for (int i = 0; i < numbers1.Length; i++)
            {
                sum1 += numbers1[i];
            }

            for (int i = 0; i < numbers2.Length; i++)
            {
                sum2 += numbers2[i];
            }
            Console.WriteLine("Birinci dizinin elemanlarının toplamı : " + sum1);
            Console.WriteLine("İkinci dizinin elemanlarının toplamı : " + sum2); 
            */

            //Procedural Programming
            /*
            int Sum(int[] numbers)
            {
                int total = 0;
                for (int i = 0; i < numbers.Length; i++)
                {
                    total += numbers[i];
                }
                return total;
            }

            Console.WriteLine("Birinci dizinin elemanlarının toplamı : " + Sum(numbers1));
            Console.WriteLine("İkinci dizinin elemanlarının toplamı : " + Sum(numbers2));
            */

            // OOP
            /*
            Calculater calculater = new Calculater();
            Console.WriteLine("Birinci dizinin elemanlarının toplamı : " + calculater.Sum(numbers1));
            Console.WriteLine("İkinci dizinin elemanlarının toplamı : " + calculater.Sum(numbers2));    
            */

            //Component Based Programming (Layered Arch)
            /* SOAPath projesi içerisinde calculator'ı bir class olarak tanımlamaktansa bu calculator objesini de farklı bir proje halinde barındırırsam istediğim her farklı projemde
            // .dll dosyası ile taşıyıp bu nesneyi namespace'in üzerinde tanımlamasını yapıp başka projelerde de türetip kullanabilirim
            Yani yeni bir katman olarak (yeni bir component olarak) calculator u ekliyorum ve .dll dosyası oluşuyor ve herhangi bir başka projemde daha aynı şekilde kullanabilirim. */

            BasicCalculator basicCalculator = new BasicCalculator(); // add referans to Calculator ( calculator katmanını kullanabilmek için using Calculator )
            Console.WriteLine("Birinci dizinin elemanlarının toplamı : " + basicCalculator.Sum(numbers1));
            Console.WriteLine("İkinci dizinin elemanlarının toplamı : " + basicCalculator.Sum(numbers2));
            //basicCalculator.Sum(numbers1) burada basicCalculator nesnesinde varolan Sum metotuna numbers1 dizisini ver ve metot çalıştıktan sonra sonucunu ekrana bas


        }
    }
}