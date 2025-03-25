namespace Vehicle_Rental_System.Exceptions
{
    public class VehicleNotFoundException : Exception
    {
        public VehicleNotFoundException()
        {
            
        }
        public VehicleNotFoundException(string message) : base(message)
        {
        }
    }
}
