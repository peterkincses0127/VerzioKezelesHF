using System;
using System.Collections.Generic;

namespace VerzioKezelesHF
{
    class Program
    {
        static void Main(string[] args)
        {
            int index = 0;
            Console.Write("Hány számot akar bekérni?: ");
            index = Convert.ToInt32(Console.ReadLine());
            int[] numbersArray = new int[index];
            Console.Write("Adjon meg {0} számot",index);
            for (int i = 0; i < numbersArray.Length; i++)
            {
                Console.WriteLine("\t");
                numbersArray[i] = Convert.ToInt32(Console.ReadLine());

            }
            int sum = 0;
            for (int i = 0; i < numbersArray.Length; i++)
            {
                sum += numbersArray[i];
            }
            double avg = sum / (numbersArray.Length + 1);
            Console.WriteLine("A {0} szám átlaga: {1}", index,avg);
        }
    }
}
