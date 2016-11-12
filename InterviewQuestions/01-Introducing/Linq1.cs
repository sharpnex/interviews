﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _01_Introducing
{
    public class Linq1
    {
        public static void Question1()
        {
            Console.Clear();

            string[] names = { "Ada", "Tom", "Rob", "Jim", "Joe" };

            IOrderedEnumerable<string> orderedNames = names.OrderBy(x => x.ToLower());
            foreach (string name in orderedNames)
            {
                Console.Write(name + " ");
            }
            // Donnez la sortie écran de cette boucle.

            Console.ReadLine();
            Console.Clear();
        }

        public static void Question2()
        {
            Console.Clear();

            string[] names = { "Ada", "Tom", "Rob", "Jim", "Joe" };

            IEnumerable<string> filtered = names.Where(x => x.ToLower().Contains("o"));
            foreach (string name in filtered)
            {
                Console.Write(name + " ");
            }
            // Donnez la sortie écran de cette boucle.

            Console.ReadLine();
            Console.Clear();
        }

        public static void Question3()
        {
            Console.Clear();

            string[] names = { "Ada", "Tom", "Rob", "Jim", "Joe" };

            IEnumerable<string> filtered = names.Where(x => x.ToLower().Contains("o"))
                                                .OrderBy(x => x.ToLower());
            foreach (string name in filtered)
            {
                Console.Write(name + " ");
            }
            // Donnez la sortie écran de cette boucle.

            Console.ReadLine();
            Console.Clear();
        }

        public static void Question4()
        {
            Console.Clear();

            int[] shift = { 1, 1 };
            for (int i = 1; i <= 10; ++i)
            {
                Console.WriteLine(shift[1]);

                int sum = shift.Sum();
                shift[0] = shift[1];
                shift[1] = sum;
            }
            // Donnez la sortie écran de cette boucle. Que remarquez-vous ?

            Console.ReadLine();
            Console.Clear();
        }

        public static void Question5()
        {
            Console.Clear();

            IList<string> names = new List<string> { "Ada", "Tom", "Rob", "Jim", "Joe" };
            var filtered = names.Where(x => x.Contains("o"));

            names.Add("Bob");

            foreach (string name in filtered)
            {
                Console.Write(name + " ");
            }
            // Donnez la sortie écran de cette boucle. Expliquez le résultat.

            Console.ReadLine();
            Console.Clear();
        }
    }
}
