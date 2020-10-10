using System;
using System.Collections.Generic;

namespace Exercices
{
    public class Exercice5
    {
        public static void Answer()
        {
            Console.Write("Enter a coma separated list of numbers (2, 5, 7, ...) ");
            var inputStr = Console.ReadLine();

            var numList = new List<int>();
            foreach (char item in inputStr)
            {
                if (!(item == Convert.ToChar(" ")) && !(item == Convert.ToChar(","))) numList.Add(Convert.ToInt32(item.ToString()));
            }

            numList.Sort();
            Console.WriteLine($"{numList[0]} - {numList[1]} - {numList[2]}");
        }
    }
}