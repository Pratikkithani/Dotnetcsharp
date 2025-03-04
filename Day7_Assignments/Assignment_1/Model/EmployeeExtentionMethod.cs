using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 

namespace Assignment_1.Model
{
    static class EmployeeExtentionMethod
    {

        static DateOnly currentDate = DateOnly.FromDateTime(DateTime.Now);

        public static void CalculateExperience(this Employee employee)
        {

            int experienceYears = currentDate.Year - employee.DateOfJoining.Year;
            int experienceMonths = currentDate.Month - employee.DateOfJoining.Month;

            if (experienceMonths < 0)
            {
                experienceYears--;      
                experienceMonths += 12;     
            }

            if (currentDate.Month == employee.DateOfJoining.Month)
            {
                experienceMonths = 0;      
            }

            Console.WriteLine($"Total Experience :: {experienceYears} Years and {experienceMonths} Months");
        }
    }
}
