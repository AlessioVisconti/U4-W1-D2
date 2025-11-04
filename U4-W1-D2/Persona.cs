using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U4_W1_D2
{
    internal class Persona
    {
        public Persona(string name, string surname, int age)
        {
            Name = name;
            Surname = surname;
            Age = age;
        }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public void GetName()
        {
            Console.WriteLine($"The name is: {Name}");
        }
        public void GetSurname()
        {
            Console.WriteLine($"The surname is: {Surname}");
        }
        public void GetAge()
        {
            Console.WriteLine($"The age is: {Age}");
        }
    }
}
