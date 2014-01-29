using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using M5640.CSharpPricatical;

namespace CSharpPricatical
{
    class Program
    {
        void Run()
        {
            List<Person> people = new List<Person>();

            #region Add Loop
            for (int i = 0; i < 5; i++) {
                people.Add(GenPerson());
            }
            #endregion

            #region Print Loop
            foreach (Person p in people)
            {
                Console.WriteLine("Person: " + p);
            }
            #endregion
        }

        Person GenPerson()
        {
            Console.Write("Forename: ");
            string forname = Console.ReadLine();

            Console.Write("Surname: ");
            string surname = Console.ReadLine();

            int age = GetAge();

            return new Person(forname, surname, age);
        }

        int GetAge()
        {
            int age = 0;

            #region Valid Loop
            while (!Valid(age))
            {
                try
                {
                    Console.Write("Age: ");
                    age = Int32.Parse(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Invalid Age");
                    Console.WriteLine(ex.Message);
                }
            }
            #endregion
            return age;
        }

        bool Valid(int value)
        {
            return value >= 1 && value <= 150;
        }

        static void Main(string[] args)
        {
            new Program().Run();
            Console.ReadLine();
        }
    }
}
