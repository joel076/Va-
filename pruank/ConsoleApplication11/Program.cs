using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Drawing;

namespace ConsoleApplication11
{
    class Program
    {
        public static Random _random = new Random();

        static void Main(string[] args)
        {


            Thread Mouset = new Thread(new ThreadStart(mouse));


     
            Mouset.Start();




        }





        public static void mouse()
        {
            while (true)
            {
                Cursor.Position = new System.Drawing.Point(Cursor.Position.X - 10, Cursor.Position.Y - 10);
                Thread.Sleep(500);
            }
        }

    }
}
