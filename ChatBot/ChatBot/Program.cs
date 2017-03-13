using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatBot
{
    class Program
    {
        static void Main(string[] args)
        {
        //en fin klocka ,för att ,lixsom
            bool number = true;
            Random randomObject = new Random();
            Console.Clear();
            string name;
            DateTime dat = DateTime.Now;
            Console.WriteLine("\nToday is {0:d} at {0:T}.", dat);
            while (number == true)
            {
                int randomNumber = randomObject.Next(6);
                string theWord = Console.ReadLine();

                switch (theWord)
                {
                    case "hej":
                    
                        if (randomNumber == 1) {
                            Console.WriteLine("Hej på dig!");
                        }
                        if (randomNumber == 2)
                        {
                            Console.WriteLine("Hej hej hemskt mycket hej");
                        }
                        if (randomNumber == 3)
                        {
                            Console.WriteLine("Tjenare");
                        }
                        if (randomNumber == 4)
                        {
                            Console.WriteLine("Goddag");
                        }
                        if (randomNumber == 5)
                        {
                            Console.WriteLine("Hejsan");
                        }
                        


                        if (randomNumber <= 1)
                        {
                            Console.WriteLine("Vill du höra ett skämt?");
                            string skamt = Console.ReadLine();
                            if (skamt == "okej" | skamt == "ja")
                            {
                                Console.WriteLine("Varför är de i Kanada så dumma..... de kan nada. ;D");
                                //badumtsss
                            }
                            else {
                                Console.WriteLine("Jaha");
                            }
                        }

                        break;

                    case "vem är du":                    
                        Console.WriteLine("Gissa.");
                        break;

                    case "hejdå":                        
                        Console.WriteLine("Nämen måste du gå. :(");
                        Environment.Exit(0);
                        break;

                    case "vad heter du":                    
                        Console.WriteLine("Jag heter Konrad och vad heter du?");
                        name = Console.ReadLine();
                        Console.WriteLine("Från och med nu kallar jag dig " + name + ".");
                        break;

                    case "vad gillar du att göra":                    
                        Console.WriteLine("Spela minecraft å roblox.");
                        break;

                    case "vad är meningen med livet":                   
                        Console.WriteLine("Söker på wikipedia...............  ");
                        Console.WriteLine("Meningen med livet är en fråga som människor funderat över i alla tider. \n Frågan har särskilt avhandlats av religionsstiftare och filosofer.\n En central följdfråga är huruvida det finns något liv efter detta.\n De som tror på ett sådant liv räknar ofta med att detta liv ska vara avgörande för nästa.");
                        break;

                    case "vad kan jag fråga dig":
                        Console.WriteLine("Väldigt mycket saker.");
                        break;

                    case "hur gammal är du":
                        Console.WriteLine("2 veckor.");
                        break;

                    case "vad är klockan":
                        Console.WriteLine("klockan är {0:d} och {0:T}.", dat);
                        break;
                }

            }
        }
    }
}
