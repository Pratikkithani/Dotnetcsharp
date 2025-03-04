using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2.Model
{
    public class TwoWheelerInsurance : VehicleInsurancePolicies
    {
        public const double BasePremium = 5000;
        public override void CalculatePremium()
        {
            if (VehicleAge > 5)
            {
                Console.WriteLine(BasePremium + 1000);
            }
            else
            {
                Console.WriteLine(BasePremium + 500);
            }
        }
    }
}
