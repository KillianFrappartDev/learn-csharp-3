using System;
using System.Collections.Generic;

namespace Exercices
{
    public class Exercice4
    {
        public static void Answer()
        {
            var numList = new List<int>();
            while (true)
            {
                Console.Write("Enter a number or leave empty to leave ");
                var input = Console.ReadLine();
                if (String.IsNullOrWhiteSpace(input)) break;
                else numList.Add(Convert.ToInt32(input));
            }
            while (numList.Count > 0)
            {
                var current = numList[0];
                Console.WriteLine(current);
                numList.RemoveAll(element => element == current);
            }
        }
    }
}