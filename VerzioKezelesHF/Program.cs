﻿using System;
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
            int temp = 0;
            for (int i = 0; i < numbersArray.Count; i++)
            {
                temp += numbersArray[i];

            }

            Console.WriteLine("Ennek az átlaga: "+ temp / numbersArray.Count+1);
        }
    }
}
