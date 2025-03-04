using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2.Model
{
    public abstract class VehicleInsurancePolicies
    {
        public int VehicleAge { set; get; }

        public abstract void CalculatePremium();

        public void DisplayDetails()
        {
            Console.WriteLine($"Vehicle Age: {VehicleAge}");
        }

        public void GetDeatils()
        {
            Console.WriteLine("Enter the Vehicle Age::");
            VehicleAge = Convert.ToInt32(Console.ReadLine());
        }
    }
}
