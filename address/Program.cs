using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication12
{
    public struct Person
    {
        public string firstName;
        public string lastName;
        public string Age;
        public string Feat;
		public string Name;
        public Person(string firstname,string lastname, string age, string feat)
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
			List <Person> list = new List<Person>();
            Person p0 = new Person("Steve","Jobs","1955-2011","The owner of Apple and the inventor of the first famous computer with a gui.");
			Person p1 = new Person("Bill","Gates","1955-","The owner of Microsoft he was also the richest person. He invented the first version of the programming language BASIC.");
			Person p2 = new Person("Alan","Turing","1912-1954","He cracked the nazis secret code");
			Person p3 = new Person("Ada","Lovalace","1815-1852","She made notes about Charle Babbages computer and she also wrote down what computers possibly could do in the future");
			Person p4 = new Person("Linus","Torvalds","1969-","He made the free os Linux"); //David here, it's GNU/linux you fuckbag!
			Person p5 = new Person("Charles", "Babbage", "1791-1871", "He made the first computer but it didnt work completly");
			Person p6 = new Person("William", "Shockley", "1910-1989", "Invented the transistor with John Bardeen and Walter Brattain");
			Person p7 = new Person("John", "Bardeen", "1908-1991", "Invented the transistor with William Shockley and Walter Brattain");
			Person p8 = new Person("Walter", "Brattain", "1902-1987", "Invented the transistor with William Shockley and John Bardeen");
			Person p9 = new Person("Jack", "Kilby", "1923-2005", "He invented the microchip with Robert Noyce");
			Person p10= new Person("Robert", "Noyce", "1927-1990", "He invented the microchip with Jack Kilby");
			Person p11= new Person("Gordon", "Moore", "1929-", "Started the company Intel");
			list.Add(p0);
			list.Add(p1);
			list.Add(p2);
			list.Add(p3);
			list.Add(p4);
			list.Add(p5);
			list.Add(p6);
			list.Add(p7);
			list.Add(p8);
			list.Add(p9);
			list.Add(p10);
			list.Add(p11);

			Console.WriteLine("Type the full name for a person or list for a full list.");
            string command= Console.ReadLine();
			if (command.Equals("list"))
			{ 
                foreach(Person pn in list)
				{
					Console.WriteLine(pn.Name + " " + pn.Age + " " + pn.Feat);
				}
			}
			else
			{
				foreach(Person pn in list)
				{
					if (pn.Name.Equals(command))
					{
						Console.WriteLine(pn.Name + " " + pn.Age + " " + pn.Feat);
					}
				}
				
			}
			Console.ReadKey();
        }
    }
}
