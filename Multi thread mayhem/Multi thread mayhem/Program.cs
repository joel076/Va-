using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Multi_thread_mayhem
{
	class Program
	{

		public static string inp;

		static void Main(string[] args)
		{
			Thread wthread = new Thread(writer);
			Thread rthread = new Thread(reader);
			wthread.Start();
			rthread.Start();
		}
		public static void writer()
		{
			for (;;)
			{
				Console.WriteLine(inp);
			}
		}
		public static void reader()
		{
			for (;;)
			{
				inp = Console.ReadLine();
			}
		}
	}
}
