using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApplication12
{
    public struct Inventions
    {
        public string iName;
        public string releaseDate;
        public string Description;


    public Inventions(string iname, string releasedate, string description)
        {
            iName = iname;
            releaseDate = releasedate;
            Description = description;

        }

    }

    public struct Person
    {
        public string firstName;
        public string lastName;
        public string Age;
        public string Feat;
        public string Name;

        public Person(string firstname, string lastname, string age, string feat)
        {
            firstName = firstname;
            lastName = lastname;
            Age = age;
            Feat = feat;
            Name = firstname + " " + lastname;
        }

    }

    class Program
    {
        public static List<Person> list = new List<Person>();

        public static List<Inventions> list2 = new List<Inventions>();

        static void Main(string[] args)
        {
            try
            {
                Console.SetWindowSize(120, 50); //Is in try catch cause different res might create errors, so yeah.
            }
            catch (System.ArgumentOutOfRangeException error)
            {
                Console.SetWindowSize(62, 25);
                Console.WriteLine("error: " + Convert.ToString(error) + " Please contact David for further information.");
            }
            Person p0 = new Person("Steve", "Jobs", "1955-2011", "The owner of Apple and the inventor of the Macintosh and that was the first sucessful pc with a gui.");//the shit company
            Person p1 = new Person("Bill", "Gates", "1955-", "The owner of Microsoft he was also the richest person. He invented the first version of the programming language BASIC.");
            Person p2 = new Person("Alan", "Turing", "1912-1954", "He cracked the enigma code under ww2. He took suicide 1954.");
            Person p3 = new Person("Ada", "Lovalace", "1815-1852", "She made notes about Charle Babbages computer and she also wrote down what computers possibly could do in the future");
            Person p4 = new Person("Linus", "Torvalds", "1969-", "He made the free open sorce operating system Linux"); //David here, it's GNU/linux you fuckbag!, Joel here he took some shit from GNU so he could make Linux u scumbag!!
            Person p5 = new Person("Charles", "Babbage", "1791-1871", "He made the first computer but it didnt work completly and the computer was mechincal it had cogs.");
            Person p6 = new Person("William", "Shockley", "1910-1989", "Invented the transistor with John Bardeen and Walter Brattain");
            Person p7 = new Person("John", "Bardeen", "1908-1991", "Invented the transistor with William Shockley and Walter Brattain");
            Person p8 = new Person("Walter", "Brattain", "1902-1987", "Invented the transistor with William Shockley and John Bardeen");
            Person p9 = new Person("Jack", "Kilby", "1923-2005", "He invented the microchip with Robert Noyce");
            Person p10 = new Person("Robert", "Noyce", "1927-1990", "He invented the microchip with Jack Kilby");
            Person p11 = new Person("Gordon", "Moore", "1929-", "Started the company Intel");// the almighty god

            Inventions i0 = new Inventions("Intel 4004", "1971", "is the first commercial one chip microprocessor. It ran at 740kHz");
            Inventions i1 = new Inventions("The bombe machine", "1942", "Alan Turings computer that he used to crack the enigma code.");
            Inventions i2 = new Inventions("Eniac", "1946", "The Eniac was the first fully elecrtical computer");
            Inventions i3 = new Inventions("Macintosh", "1984", ", The first famous computer that had a gui. There was a computer that had a gui the apple Lisa that was released 1983 but it is forgotten and it was very bad.");

            AddToList(ref list, p0, p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11);

            AddToList2(ref list2, i0, i1, i2, i3);

            for (;;)
            {
                Console.WriteLine("Type the full name for a person, invention or list for a full list.");
                string command = Console.ReadLine();
                if (command.Equals("list people"))
                {
                    foreach (Person pn in list)
                    {
                        Console.WriteLine(pn.Name + " " + pn.Age + " " + pn.Feat);
                    }
                }
                else if (command.Equals("list inventions"))
                {
                    foreach (Inventions inv in list2)
                    {
                        Console.WriteLine(inv.iName + " " + inv.releaseDate + " " + inv.Description);
                    }
                }
                else
                {
                    command = Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(command.ToLower());
                    foreach (Person pn in list)
                    {
                        if (pn.Name.Equals(command))
                        {
                            Console.WriteLine(pn.Name + " " + pn.Age + " " + pn.Feat);
                        }
                    }
                    foreach (Inventions inv in list2)
                    {
                        if (inv.iName.Equals(command))
                        {
                            Console.WriteLine(inv.iName + " " + inv.releaseDate + " " + inv.Description);
                        }
                    }

                }
            }
        }
        public static void AddToList(ref List<Person> lists, params Person[] listp)
        {
            for (int i = 0; i < listp.Length; i++)
            {
                lists.Add(listp[i]);
            }
        }
        public static void AddToList2(ref List<Inventions> lists, params Inventions[] listq)
        {
            for (int i = 0; i < listq.Length; i++)
            {
                lists.Add(listq[i]);
            }
        }
    }
}