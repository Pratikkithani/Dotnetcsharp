using Microsoft.AspNetCore.Identity;

namespace Vehicle_Rental_System.Models
{
    public class User : IdentityUser
    {
        //public int UserId { get; set; }
        //public string Name { get; set; }
        //public string Email { get; set; }
        //public string Password { get; set; }
        public ICollection<Booking> Bookings { get; set; }
    }
}
