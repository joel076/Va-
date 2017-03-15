using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpeechLib;

namespace ConsoleApplication14
{
    class Program
    {
        static void Main(string[] args)
        {
            var voice = new SpVoice();
            voice.Speak("Enter the computer...");
            Console.ReadLine();
        }
    }
}
