using Vehicle_Rental_System.Models;

namespace Vehicle_Rental_System.Services
{
    public interface IBookingService
    {
        Task<IEnumerable<Booking>> GetAllBookingsAsync(); 
        Task<Booking> GetBookingByIdAsync(int bookingId); 
        Task<int> AddBookingAsync(Booking booking, string userId); 
        Task<IEnumerable<Booking>> GetBookingsByUserIdAsync(string userId);
        Task<IEnumerable<Booking>> GetBookingsByVehicleIdAsync(int vehicleId); 
        Task<int> DeleteBookingAsync(int bookingId);
    }
}
