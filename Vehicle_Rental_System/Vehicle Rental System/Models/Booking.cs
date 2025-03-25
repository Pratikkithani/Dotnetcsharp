using System.ComponentModel.DataAnnotations.Schema;

namespace Vehicle_Rental_System.Models
{
    public class Booking
    {
        public int BookingId { get; set; }
        public int VehicleId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        [NotMapped] 
        public decimal TotalAmount
        {
            get => Vehicle != null
                ? (decimal)(EndDate - StartDate).TotalDays * Vehicle.RentalPricePerDay
                : 0;
        }
        public Vehicle Vehicle { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }

        
    }
}
