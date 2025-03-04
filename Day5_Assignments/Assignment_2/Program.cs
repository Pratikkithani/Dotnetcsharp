using Assignment_2.Model;

namespace Assignment_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            VehicleInsurancePolicies bikePolicy = new TwoWheelerInsurance();

            bikePolicy.GetDeatils();
            bikePolicy.CalculatePremium();


            VehicleInsurancePolicies carPolicy = new FourWheelerInsurance();

            carPolicy.GetDeatils();
            carPolicy.CalculatePremium();
            

        }
    }
}
