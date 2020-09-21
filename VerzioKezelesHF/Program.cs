using System;
using System.Collections.Generic;

namespace VerzioKezelesHF
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Adjon meg 10 db számot: ");
            List<int> numbersArray = new List<int>();
            for (int i = 0; i < numbersArray.Count; i++)
            {
                numbersArray[i] = Convert.ToInt32(Console.ReadLine());

            }

            Console.WriteLine("Ennek az átlaga: ");
        }
    }
}
