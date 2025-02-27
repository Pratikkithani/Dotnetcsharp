using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2.Model
{
    internal class Empolyee
    { 

        public string Name{ get; set;}
        public double Salary{ get; set;}

        public Empolyee(string name,double salary)
        {
            Name = name;
            Salary = salary;
        }

        public virtual void displayDetails()
        {
            Console.WriteLine($"Name::{Name}");
            Console.WriteLine($"Salary::{Salary}");
        }
    }
}
