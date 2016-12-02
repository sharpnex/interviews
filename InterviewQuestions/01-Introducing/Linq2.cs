using System;
using System.Collections.Generic;
using System.Linq;

namespace _01_Introducing
{
    public class Linq2
    {
        #region -1-

        public class Person
        {
            public string Name { get; set; }
        }

        public static void Select1()
        {
            Console.Clear();

            string[] names = {"Ada", "Tom", "Rob", "Jim", "Joe"};

            // Utilisez Linq pour créer une liste de personnes avec les noms ci-dessus.
            IList<Person> persons = null; //

            Console.ReadLine();
            Console.Clear();
        }

        #endregion

        #region -2-

        public static void Select2()
        {
            Console.Clear();

            int[] ages = {40, 35, 28, 41, 39};

            // Utilisez linq pour augmenter tous les âges d'une année.
            IList<int> nextAges = null;

            Console.ReadLine();
            Console.Clear();
        }

        #endregion

        #region -3-

        public static void Select3()
        {
            Console.Clear();

            int[] months = {2, 5, 1, 12, 8};
            string[] monthsNames = {"JAN", "FEV", "MAR", "APR", "MAY", "JUN", "JUL", "AUG", "SEP", "OCT", "NOV", "DEC"};

            // Utilisez Linq pour transformer 'months' en liste de mois en lettres.
            IList<string> monthsLetters = null;

            foreach (var month in monthsLetters)
            {
                Console.Write(month + " ");
            }

            Console.ReadLine();
            Console.Clear();
        }

        #endregion

        #region -4-

        public static void Select4()
        {
            Console.Clear();

            int[] months = {2, 5, 1, 12, 8};
            string[] monthsNames = {"JAN", "FEV", "MAR", "APR", "MAY", "JUN", "JUL", "AUG", "SEP", "OCT", "NOV", "DEC"};

            // Utilisez Linq pour transformer 'months' en une liste de paires {numéro du mois / lettres du mois}.
            // et l'afficher.
            // var monthsAndLetters = months......

            //foreach (var month in monthsAndLetters)
            //{
            //    Console.Write(month + " ");
            //}

            Console.ReadLine();
            Console.Clear();
        }

        #endregion

        #region -5-

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
            german.Stocks.Add(new Stock {Name = "DTB"});
            german.Stocks.Add(new Stock {Name = "RWE"});

            EuropeanMarkets eur = new EuropeanMarkets();
            eur.Markets.Add(french);
            eur.Markets.Add(german);

            // Utilisez Linq pour lister tous les stocks européens.
            IList<Stock> europeanStocks = null;

            foreach (var stock in europeanStocks)
            {
                Console.Write(stock.Name + " ");
            }

            Console.ReadLine();
            Console.Clear();
        }

        #endregion
    }
}