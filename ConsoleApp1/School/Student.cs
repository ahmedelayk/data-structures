using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.School
{
    public class Student : Person
    {
        public int grade { get; set; }
        public Student(string name, int age, string address, int grade):base(name, age, address)
        {
            this.grade = grade;
        }
        public void PrintData()
        {
            Console.WriteLine("Name: "+Name+", age: "+Age+", address: "+Address);
        }
    }
}
