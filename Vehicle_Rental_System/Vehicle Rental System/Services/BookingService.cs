using Vehicle_Rental_System.Models;
using Vehicle_Rental_System.Repositories;

namespace Vehicle_Rental_System.Services
{
    public class BookingService : IBookingService
    {
        readonly IBookingRepository _bookingRepository;
        public BookingService(IBookingRepository bookingRepository)
        {
            _bookingRepository = bookingRepository;
        }
        public async Task<int> AddBookingAsync(Booking booking,string userId)
        {
            if (string.IsNullOrEmpty(userId))
            {
                throw new Exception("User is not logged in.");
            }

            booking.UserId = userId; // Assign the logged-in UserId to the booking
            return await _bookingRepository.AddBookingAsync(booking);
        }

        public async Task<int> DeleteBookingAsync(int bookingId)
        {
            return await _bookingRepository.DeleteBookingAsync(bookingId);
        }

        public async Task<IEnumerable<Booking>> GetAllBookingsAsync()
        {
            return await _bookingRepository.GetAllBookingsAsync();
        }

        public async Task<Booking> GetBookingByIdAsync(int bookingId)
        {
            var booking = await _bookingRepository.GetBookingByIdAsync(bookingId);
            return booking;
        }

        public async Task<IEnumerable<Booking>> GetBookingsByUserIdAsync(string userId)
        {
            return await _bookingRepository.GetBookingsByUserIdAsync(userId);
        }

        public async Task<IEnumerable<Booking>> GetBookingsByVehicleIdAsync(int vehicleId)
        {
            var vehicle = await _bookingRepository.GetBookingsByVehicleIdAsync(vehicleId);
            return vehicle;
        }
    }
}
