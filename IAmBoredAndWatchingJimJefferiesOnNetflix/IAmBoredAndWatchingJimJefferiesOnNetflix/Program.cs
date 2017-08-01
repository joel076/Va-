using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IAmBoredAndWatchingJimJefferiesOnNetflix //This is just a copy of the programm in https://www.youtube.com/watch?v=QPZ0pIK_wsc
{
	class Program
	{
		static void Main(string[] args)
		{
			for(int i = 0; i <= 100; i++)
			{
				string output = "";
				if(i % 3 == 0){output += "fizz";}
				if(i % 5 == 0){output += "buzz";}
				if(output == ""){output = Convert.ToString(i);}
				Console.WriteLine(output);
			}
			Console.ReadKey();
		}
	}
}
