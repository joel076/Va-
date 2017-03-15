using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            int TheValue = 0;
            bool wololo = false;
            
            
            do
            {
                TheValue = 0;
                Console.WriteLine("Alphabet values");

                string TheWord = Console.ReadLine();

                if (TheWord.ToLower().Contains('a')) { TheValue += 1; }
                if (TheWord.ToLower().Contains('b')) { TheValue += 2; }
                if(TheWord.ToLower().Contains('c')) { TheValue += 3; }
                if(TheWord.ToLower().Contains('d')) { TheValue += 4; }
                if(TheWord.ToLower().Contains('e')) { TheValue += 5; }
                if(TheWord.ToLower().Contains('f')) { TheValue += 6; }
                if(TheWord.ToLower().Contains('g')) { TheValue += 7; }
                if(TheWord.ToLower().Contains('h')) { TheValue += 8; }
                if(TheWord.ToLower().Contains('i')) { TheValue += 9; }
                if(TheWord.ToLower().Contains('j')) { TheValue += 10; }
                if(TheWord.ToLower().Contains('k')) { TheValue += 11; }
                if(TheWord.ToLower().Contains('l')) { TheValue += 12; }
                if(TheWord.ToLower().Contains('m')) { TheValue += 13; }
                if(TheWord.ToLower().Contains('n')) { TheValue += 14; }
                if(TheWord.ToLower().Contains('o')) { TheValue += 15; }
                if(TheWord.ToLower().Contains('p')) { TheValue += 16; }
                if(TheWord.ToLower().Contains('q')) { TheValue += 17; }
                if(TheWord.ToLower().Contains('r')) { TheValue += 18; }
                if(TheWord.ToLower().Contains('s')) { TheValue += 19; }
                if(TheWord.ToLower().Contains('t')) { TheValue += 20; }
                if(TheWord.ToLower().Contains('u')) { TheValue += 21; }
                if(TheWord.ToLower().Contains('v')) { TheValue += 22; }
                if(TheWord.ToLower().Contains('w')) { TheValue += 23; }
                if(TheWord.ToLower().Contains('x')) { TheValue += 24; }
                if(TheWord.ToLower().Contains('y')) { TheValue += 25; }
                if(TheWord.ToLower().Contains('z')) { TheValue += 26; }
                else { Console.WriteLine(TheValue); }

                Console.WriteLine(TheValue);

            } while (wololo = true);
        }
    }
}
