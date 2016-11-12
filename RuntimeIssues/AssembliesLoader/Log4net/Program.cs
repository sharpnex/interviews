using System;
using Market.Equities;
using Market.Rates;

namespace OrderBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Stock stock = new Stock();

            Bond bond = new Bond();
            // Exception :
            // "Impossible de charger le fichier ou l'assembly 'log4net, Version=1.2.11.0, Culture=neutral, PublicKeyToken=669e0ddf0bb1aa2a'
            // ou une de ses dépendances. La définition trouvée du manifeste de l'assembly ne correspond pas à la référence de l'assembly.
            // (Exception de HRESULT : 0x80131040)":"log4net, Version=1.2.11.0, Culture=neutral, PublicKeyToken=669e0ddf0bb1aa2a"}

            Console.ReadLine();
        }
    }
}
