using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2.Model
{
    internal class Manager:Empolyee
    {
        public double Bonus { get; set;}

        public Manager(string name,double salary,double bonus) : base(name,salary)
        {
            Bonus = bonus;
        }

        public override void displayDetails()
        {
            Console.WriteLine($"Name::{Name}");
            Console.WriteLine($"Salary::{Salary}");
            Console.WriteLine($"Bonus::{Bonus}");
        }

    }
}
