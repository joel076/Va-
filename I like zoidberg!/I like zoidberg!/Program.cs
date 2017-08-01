using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace I_like_zoidberg_
{
	class Program
	{
		static void Main(string[] args)
		{
			var thread = new Thread(Thread => threado());
			for (;;)
			{
				thread.Start();
			}
		}
		static void threado(){
			for (;;)
			{
				double powereater = Math.Sqrt(Math.Sqrt(2)) * Math.Sqrt(5);
				Console.WriteLine("get fucked");
			}
		}
	}
}
