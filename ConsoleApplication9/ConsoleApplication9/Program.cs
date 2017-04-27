using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{
    class Program
    {
        static void Main(string[] args)
        {
            const double pi = 3.1415926535897932384626433832795;
            List<double> numbers = new List<double>();
            numbers.Add(pi);
            if (numbers.Contains(pi))
            {
                Console.WriteLine("That's a hecking good pizza the pi right there");
            }
            Console.ReadKey();
        }
    }
}
