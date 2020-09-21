using System;
using System.Collections.Generic;

namespace VerzioKezelesHF
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbersArray = new int[10];
            Console.Write("Adjon meg 10 számot");
            for (int i = 0; i < numbersArray.Length; i++)
            {
                numbersArray[i] = Convert.ToInt32(Console.ReadLine());

            }
            int sum = 0;
            for (int i = 0; i < numbersArray.Length; i++)
            {
                sum += numbersArray[i];
            }
            Console.WriteLine("A 10 szám átlaga: "+ sum/(numbersArray.Length+1));
        }
    }
}
