namespace Vehicle_Rental_System.Models
{
    public class Vehicle
    {
        public int VehicleId { get; set; }
        public string Model { get; set; }
        public string Brand { get; set; }
        public string Type { get; set; } 
        public decimal RentalPricePerDay { get; set; }
        public bool IsAvailable { get; set; }

        public ICollection<Booking> Bookings { get; set; }
    }
}
