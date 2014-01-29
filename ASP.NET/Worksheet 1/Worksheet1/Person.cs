using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M5640.CSharpPricatical
{
    class Person
    {
        public Person()
        {
            // NO-OP
        }

        public Person(string forename, string surname, int age)
        {
            this.Forename = forename;
            this.Surname = surname;
            this.Age = age;
        }

        public string Forename { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return Forename + " " + Surname + ", age: " + Age;
        }
    }
}
