using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace ConsoleApp10
{
    class Program
    {



        static void Main(string[] args)
        {
        System.Net.ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.Tls12;
            for (;;)
            {
                Console.WriteLine("Type your username (case sensitive):");
                string username = Console.ReadLine();
                string Url = "https://www.overbuff.com/search?q=" + username;
                /*Console.Clear();
                Console.WriteLine("Type your battle tag (without the #):");
                string tag = Console.ReadLine();
                Url = "https://www.overbuff.com/players/pc/" + username + "-" + tag;*/
                Console.WriteLine(Url);
                Console.Clear();
                HtmlWeb web = new HtmlWeb();
                HtmlDocument doc = web.Load(Url);
                string tag = doc.DocumentNode.SelectNodes("/html/body/div/div[3]/div/div[2]/div/div[2]/h2/small")[0].InnerText;
                tag = tag.Remove(0, 1);
                Console.WriteLine(tag);
                Url = "https://www.overbuff.com/players/pc/" + username + "-" + tag;
                doc = web.Load(Url);
                Console.WriteLine(Url);
                try
                {
                    string sr = doc.DocumentNode.SelectNodes("/html/body/div/div[3]/div/div[2]/div[1]/div[2]/div/dl[2]/dd/span")[0].InnerText;
                    Console.WriteLine(sr);
                }
                catch
                {
                    Console.WriteLine("You probably wrote something wrong, or you have a psn account");
                }
            }
        }
    }
}
