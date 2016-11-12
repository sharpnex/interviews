using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CppMathWrapper;
using std;

namespace CsharpSample
{
    class Program
    {
        static void Main(string[] args)
        {
            ManagedCppMathWrapper managedCppMathWrapper = new ManagedCppMathWrapper();

            var values = new List<Tuple<double, uint>>();
            values.Add(new Tuple<double, uint>(100.1, 1000));
            values.Add(new Tuple<double, uint>(99.98, 1350));
            values.Add(new Tuple<double, uint>(104.25, 790));

            double vwap = managedCppMathWrapper.Vwap(values);

            Console.WriteLine("vwap=" + vwap);

            Console.ReadLine();
        }
    }
}
