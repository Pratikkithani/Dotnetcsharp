using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2.Model
{
    public class FourWheelerInsurance : VehicleInsurancePolicies
    {
        public const double BasePremium = 10000;
        public override void CalculatePremium()
        {
            if (VehicleAge > 3)
            {
                Console.WriteLine(BasePremium + 2000);
            }
            else
            {
                Console.WriteLine(BasePremium + 1000);
            }
        }
    }
}
