using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2.Model
{
        class EventReg
        {
            Dictionary<string, HashSet<int>> workshopRegistration = new Dictionary<string, HashSet<int>>();
            public void Registration(string workshopname, int studentId)
            {
                if (!workshopRegistration.ContainsKey(workshopname))
                {
                    workshopRegistration[workshopname] = new HashSet<int>();
                }
                if (workshopRegistration[workshopname].Add(studentId))
                {
                    Console.WriteLine("added successfuly");
                }
                else
                {
                    Console.WriteLine("you can register only once");
                }
            }
            public void PrintAllDetails()
            {
                foreach (var workshop in workshopRegistration)
                {
                    Console.Write(workshop.Key + " :\n{");
                    foreach (var id in workshop.Value)
                    {
                        Console.Write(id + " ");
                    }
                    Console.Write("}\n");
                }
            }
        }
}
