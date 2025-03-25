using Microsoft.EntityFrameworkCore;
using Vehicle_Rental_System.Context;
using Vehicle_Rental_System.Exceptions;
using Vehicle_Rental_System.Models;

namespace Vehicle_Rental_System.Repositories
{
    public class BookingRepository : IBookingRepository
    {
        readonly VehicleRentalDbContext _vehicleDbContext;
        public BookingRepository(VehicleRentalDbContext vehicleDbContext)
        {
            _vehicleDbContext = vehicleDbContext;
        }
        public async Task<int> AddBookingAsync(Booking booking)
        {
            var vehicle = await _vehicleDbContext.Vehicles.FindAsync(booking.VehicleId);

            if (!vehicle.IsAvailable)
            {
                throw new Exception("Vehicle is already booked");
            }
            vehicle.IsAvailable = false;
            await _vehicleDbContext.Bookings.AddAsync(booking);
            return await _vehicleDbContext.SaveChangesAsync();
        }

        public async Task<int> DeleteBookingAsync(int bookingId)
        {
            Booking booking = await _vehicleDbContext.Bookings.FindAsync(bookingId);
            if (booking == null)
            {
                throw new BookingConflictException($"Booking with ID {bookingId} not found.");
            }

            var vehicle = await _vehicleDbContext.Vehicles.FindAsync(booking.VehicleId);
            if (vehicle == null)
            {
                throw new VehicleNotFoundException($"Vehicle with ID {booking.VehicleId} not found.");
            }
            vehicle.IsAvailable = true;
            _vehicleDbContext.Bookings.Remove(booking);
            return await _vehicleDbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Booking>> GetAllBookingsAsync()
        {
                return await _vehicleDbContext.Bookings
                .Include(b => b.Vehicle)
                .Include(c => c.User)
                .ToListAsync();
        }

        public async Task<Booking> GetBookingByIdAsync(int bookingId)
        {
            return await _vehicleDbContext.Bookings
                .Include(b => b.Vehicle)
                .Include(c => c.User)
                .FirstOrDefaultAsync(b => b.BookingId == bookingId);
        }

        public async Task<IEnumerable<Booking>> GetBookingsByVehicleIdAsync(int vehicleId)
        {
            return await _vehicleDbContext.Bookings
                .Include(b => b.Vehicle)
                .Include(c => c.User)
                .Where(c => c.VehicleId == vehicleId)
                .ToListAsync();
           
        }

        public async Task<IEnumerable<Booking>> GetBookingsByUserIdAsync(string userId)
        {
            return await _vehicleDbContext.Bookings
                .Include(b => b.Vehicle)  
                .Where(b => b.UserId == userId)
                .ToListAsync();
        }
    }
}
