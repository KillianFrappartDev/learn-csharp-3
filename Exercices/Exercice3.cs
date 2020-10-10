using System;
using System.Collections.Generic;

namespace Exercices
{
    public class Exercice3
    {
        public static void Answer()
        {
            var inputArr = new int[5];
            var counter = 0;
            while (counter < 5)
            {
                Console.Write("Enter a unique number ");
                var input = Convert.ToInt32(Console.ReadLine());
                if (Array.Exists(inputArr, element => element == input))
                {
                    Console.WriteLine("Error, number is not unique");
                    continue;
                }
                else
                {
                    inputArr[counter] = input;
                    counter++;
                    continue;
                }
            }

            Array.Sort(inputArr);
            foreach (int num in inputArr) Console.WriteLine(num);
        }
    }
}