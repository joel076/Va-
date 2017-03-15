using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = Console.;
            if (isprime(x))
            {
                
            }
            
              
            
        }

        static bool isprime(int x)
        {
            bool prime = true;
            for (int y = 2; y < x - 1; y++)
            {
                if (x % y == 0)
                {
                    prime = false;
                }
            }
            if (prime)
            {
                return true;
            }else
            {
                return false;
            }
        }
    }
}
