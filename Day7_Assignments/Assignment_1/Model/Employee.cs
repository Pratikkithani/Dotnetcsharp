using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1.Model
{
    public sealed class Employee
    {
        public int Experience { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Deparment { get; set; }
        public DateOnly DateOfJoining { get; set; }

    }
}
