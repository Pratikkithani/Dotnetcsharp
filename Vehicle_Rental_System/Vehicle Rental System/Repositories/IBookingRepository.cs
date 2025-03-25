using Vehicle_Rental_System.Models;

namespace Vehicle_Rental_System.Repositories
{
    public interface IBookingRepository
    {
        Task<IEnumerable<Booking>> GetAllBookingsAsync();
        Task<Booking> GetBookingByIdAsync(int bookingId);
        Task<int> AddBookingAsync(Booking booking);
        Task<IEnumerable<Booking>> GetBookingsByUserIdAsync(string userId);
        Task<IEnumerable<Booking>> GetBookingsByVehicleIdAsync(int vehicleId); 
        Task<int> DeleteBookingAsync(int bookingId);
    }
}
