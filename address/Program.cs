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
        public Person(string firstname,string lastname, string age, string feat)
        {
            firstName = firstname;
            lastName = lastname;
            Age = age;
            Feat = feat;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Steve","Jobs","1955-2011","The owner of Apple and the inventor of the first famous computer with a gui.");
            Person p2 = new Person("Bill","Gates","1955-","The owner of Microsoft he was also the richest person. He invented the first version of the programming language BASIC.");
            Person p3 = new Person("Alan","Turing","1912-1954","He cracked the nazis secret code");
            Person p4 = new Person("Ada","Lovalace","1815-1852","She made notes about Charle Babbages computer and she also wrote down what computers possibly could do in the future");
            Person p5 = new Person("Linus","Torvalds","1969-","He made the free os Linux");
            Person p6 = new Person("Charles", "Babbage", "1791-1871", "He made the first computer but it didnt work completly");
            Person p7 = new Person("William", "Shockley", "1910-1989", "Invented the transistor with John Bardeen and Walter Brattain");
            Person p8 = new Person("John", "Bardeen", "1908-1991", "Invented the transistor with William Shockley and Walter Brattain");
            Person p9 = new Person("Walter", "Brattain", "1902-1987", "Invented the transistor with William Shockley and John Bardeen");
            Person p10 = new Person("Jack", "Kilby", "1923-2005", "He invented the microchip with Robert Noyce");
            Person p11= new Person("Robert", "Noyce", "1927-1990", "He invented the microchip with Jack Kilby");
            Person p11 = new Person("Gordon", "Moore", "1929-", "Started the company Intel");


            string command= Console.ReadLine();
            switch{
                case "list":
                    
                    Console.WriteLine(p1.Name + " " + p1.Age);
                    break;
            };
        }
    }
}
