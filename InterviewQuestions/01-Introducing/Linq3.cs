using System;
using System.Linq;

namespace _01_Introducing
{
    public static class Linq3
    {
        #region -1-

        public static void Question1()
        {
            Console.Clear();

            int[] months = {2, 5, 1, 12, 8};

            // Utilisez Linq pour vérifier que tous les numéros de mois sont valides (compris entre 1 et 12 inclus).
            bool monthsAreValid = false;

            Console.ReadLine();
            Console.Clear();
        }

        #endregion

        #region -2-

        public static void Question2()
        {
            Console.Clear();

            int[] months = {2, 5, 1, 12, 8};

            // Utilisez Linq pour vérifier si le mois de décembre est présent.
            bool containsDecember = false;

            Console.ReadLine();
            Console.Clear();
        }

        #endregion

        #region -3-

        public static void Question3()
        {
            Console.Clear();

            int[] months = {2, 5, 1, 12, 8};

            // Utilisez Linq pour compter le nombre de mois impairs.
            int oddMonths = 0;

            Console.ReadLine();
            Console.Clear();
        }

        #endregion
    }
}