using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Vehicle_Rental_System.Constants;
using Vehicle_Rental_System.Models;
using Vehicle_Rental_System.Services;

namespace Vehicle_Rental_System.Controllers
{
    [Authorize]
    public class BookingController : Controller
    {
        readonly IVehicleService _vehicleService;
        readonly IBookingService _bookingService;
        public BookingController(IBookingService bookingService, IVehicleService vehicleService)
        {
            _bookingService = bookingService;
            _vehicleService = vehicleService;
        }

        [Authorize(Roles = Role.Administrator)]
        public async Task<IActionResult> GetAllBookings()
        {
            return View(await _bookingService.GetAllBookingsAsync());
        }

        public async Task<IActionResult> GetBookingById(int id)
        {
            var result = await _bookingService.GetBookingByIdAsync(id);
            return View(result);
        }

        public async Task<IActionResult> AddBooking()
        {
            ViewData["VehicleId"] = new SelectList(await _vehicleService.GetAvailableVehiclesAsync(), "VehicleId", "Brand");
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddBooking(Booking booking)
        {
            ModelState.Remove("User");
            ModelState.Remove("Vehicle");
            ModelState.Remove("UserId");

            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier); 

            if (string.IsNullOrEmpty(userId))
            {
                return Unauthorized(); 
            }

            booking.UserId = userId; 


            if (!ModelState.IsValid)
            {
                return View(booking);
            }
            else
            {
                int result = await _bookingService.AddBookingAsync(booking, booking.UserId);
                if (result > 0)
                {
                    TempData["Msg"] = "Vehicle Added Successfully";
                    return RedirectToAction("GetBookingsByUserId");
                }
                else
                {
                    TempData["Msg"] = "Vehicle Addition Failed";
                    return View(booking);
                }
            }

        }

        public async Task<IActionResult> DeleteBooking(int id)
        {
            Booking booking = await _bookingService.GetBookingByIdAsync(id);
            if (booking == null)
            {
                TempData["msg"] = "Vehicle not found.";
            }
            return View(booking);
        }

        [HttpPost]
        public async Task<IActionResult> DeleteBooking(Booking booking)
        {
            int res = await _bookingService.DeleteBookingAsync(booking.BookingId);

            if (res > 0)
            {
                TempData["msg"] = "Vehicle deleted successfully.";
            }
            return RedirectToAction("GetBookingsByUserId");

        }

        public async Task<IActionResult> GetBookingsByVehicle(int Id)
        {
            var result = await _bookingService.GetBookingsByVehicleIdAsync(Id);
            return View(result);
        }

        public async Task<IActionResult> GetBookingsByUserId()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var bookings = await _bookingService.GetBookingsByUserIdAsync(userId);
            return View(bookings);
        }


    }
}
