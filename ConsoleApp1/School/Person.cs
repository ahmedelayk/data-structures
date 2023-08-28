using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.School
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public Person(string name, int age, string address)
        {
            this.Name = name;
            this.Age = age;
            this.Address = address;
        }

    }
}
