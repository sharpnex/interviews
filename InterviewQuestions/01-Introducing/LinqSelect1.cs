using System;
using System.Collections.Generic;
using System.Linq;

namespace _01_Introducing
{
    public class LinqSelect1
    {
        public class Person
        {
            public string Name { get; set; }
        }

        public static void Select1()
        {
            Console.Clear();

            string[] names = {"Ada", "Tom", "Rob", "Jim", "Joe"};

            // Ecrire une ligne de code générant une liste de personnes avec les noms ci-dessus.
            IList<Person> persons = null; //

            Console.ReadLine();
            Console.Clear();
        }

        public static void Select2()
        {
            Console.Clear();

            int[] ages = {40, 35, 28, 41, 39};

            // Ecrire une ligne de code générant une nouvelle liste d'âges augmentés de 1 année.
            IList<int> nextAges = null;

            Console.ReadLine();
            Console.Clear();
        }

        public static void Select3()
        {
            Console.Clear();

            int[] months = {2, 5, 1, 12, 8};
            string[] monthsNames = {"JAN", "FEV", "MAR", "APR", "MAY", "JUN", "JUL", "AUG", "SEP", "OCT", "NOV", "DEC"};

            // Ecrire une ligne de code générant les mois en lettres à partir de la liste 'months'
            IList<string> monthsLetters = null;

            foreach (var month in monthsLetters)
            {
                Console.Write(month + " ");
            }

            Console.ReadLine();
            Console.Clear();
        }

        public static void Select4()
        {
            Console.Clear();

            int[] months = {2, 5, 1, 12, 8};
            string[] monthsNames = {"JAN", "FEV", "MAR", "APR", "MAY", "JUN", "JUL", "AUG", "SEP", "OCT", "NOV", "DEC"};

            // Ecrire une ligne de code générant la liste des paires {numéro du mois, lettres du mois} à partir de 'months'
            // et l'afficher.
            // var monthsAndLetters = months......

            //foreach (var month in monthsAndLetters)
            //{
            //    Console.Write(month + " ");
            //}

            Console.ReadLine();
            Console.Clear();
        }

        public class Stock
        {
            public string Name { get; set; }
        }

        public class Market
        {
            public IList<Stock> Stocks = new List<Stock>();
        }

        public class EuropeanMarkets
        {
            public IList<Market> Markets = new List<Market>();
        }

        public static void Select5()
        {
            Console.Clear();

            Market french = new Market();
            french.Stocks.Add(new Stock {Name = "FTE"});
            french.Stocks.Add(new Stock {Name = "GLE"});

            Market german = new Market();
            german.Stocks.Add(new Stock { Name = "DTB" });
            german.Stocks.Add(new Stock { Name = "RWE" });

            EuropeanMarkets eur = new EuropeanMarkets();
            eur.Markets.Add(french);
            eur.Markets.Add(german);

            // Ecrire une ligne de code qui génère la liste de tous les stocks européens.
            IList<Stock> europeanStocks = null;

            foreach (var stock in europeanStocks)
            {
                Console.Write(stock.Name + " ");
            }

            Console.ReadLine();
            Console.Clear();
        }
    }
}