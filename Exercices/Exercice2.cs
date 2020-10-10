using System;
using System.Collections.Generic;

namespace Exercices
{
    public class Exercice2
    {
        public static void Answer()
        {
            Console.Write("Enter a name ");
            var input = Console.ReadLine();

            var inputArr = new char[input.Length];
            for (var i = 0; i < input.Length; i++)
            {
                inputArr[i] = input[i];
            }

            Array.Reverse(inputArr);
            Console.WriteLine(String.Join("", inputArr));
        }
    }
}