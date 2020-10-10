using System;
using System.Collections.Generic;

namespace Exercices
{
    public class Exercice1
    {
        public static void Answer()
        {
            var names = new List<string>();
            while (true)
            {
                Console.Write("Enter a name ");
                var input = Console.ReadLine();
                if (String.IsNullOrWhiteSpace(input)) break;
                names.Add(input);
            }

            switch (names.Count)
            {
                case 0:
                    break;

                case 1:
                    Console.WriteLine($"{names[0]} likes your post");
                    break;

                case 2:
                    Console.WriteLine($"{names[0]} and {names[1]} like your post");
                    break;

                default:
                    Console.WriteLine($"{names[0]}, {names[1]} and {names.Count - 2} others like your post");
                    break;
            }

        }
    }
}