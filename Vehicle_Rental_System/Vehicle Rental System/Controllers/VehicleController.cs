using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Vehicle_Rental_System.AspectOrientedProgramming;
using Vehicle_Rental_System.Constants;
using Vehicle_Rental_System.Models;
using Vehicle_Rental_System.Services;

namespace Vehicle_Rental_System.Controllers
{
    [Authorize(Roles = Role.Administrator)]
    [ServiceFilter(typeof(ExceptionHandlerAttribute))]
    public class VehicleController : Controller
    {
        readonly IVehicleService _vehicleService;
        public VehicleController(IVehicleService vehicleService)
        {
            _vehicleService = vehicleService;
        }
        public async Task<IActionResult> GetAllVehicles()
        {
            return View(await _vehicleService.GetAllVehiclesAsync());
        }

        [AllowAnonymous]
        public async Task<IActionResult> GetAvailableVehicles()
        {
            return View(await _vehicleService.GetAvailableVehiclesAsync());
        }

        public async Task<IActionResult> GetVehicleById(int id)
        {
            Vehicle vehicle = await _vehicleService.GetVehicleByIdAsync(id);
            //if (vehicle == null)
            //{
            //    TempData["Msg"] = "Vehicle not found.";
            //}
            return View(vehicle);
        }

        public async Task<IActionResult> AddVehicle()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddVehicle(Vehicle vehicle)
        {
            ModelState.Remove("Bookings");
            if (!ModelState.IsValid)
            {
                return View(vehicle);
            }
            else
            {
                int result = await _vehicleService.AddVehicleAsync(vehicle);
                if (result > 0)
                {
                    TempData["Msg"] = "Vehicle Added Successfully";
                    return RedirectToAction("GetAllVehicles");
                }
                else
                {
                    TempData["Msg"] = "Vehicle Addition Failed";
                    return View(vehicle);
                }
            }
        }

        public async Task<IActionResult> DeleteVehicle(int id)
        {
            Vehicle vehicle = await _vehicleService.GetVehicleByIdAsync(id);
            if (vehicle == null)
            {
                TempData["Msg"] = "Vehicle not found.";
            }
            return View(vehicle);
        }

        [HttpPost]
        public async Task<IActionResult> DeleteVehicle(Vehicle vehicle)
        {
            int res = await _vehicleService.DeleteVehicleAsync(vehicle.VehicleId);

            if (res > 0)
            {
                TempData["Msg"] = "Vehicle deleted successfully.";
            }
            return RedirectToAction("GetAllVehicles");

        }

        public async Task<IActionResult> UpdateVehicle(int id)
        {
            Vehicle vehicle = await _vehicleService.GetVehicleByIdAsync(id);
            if (vehicle == null)
            {
                TempData["Msg"] = "Vehicle not found.";
            }
            return View(vehicle);
        }
        [HttpPost]
        public async Task<IActionResult> UpdateVehicle(Vehicle vehicle)
        {
            ModelState.Remove("Bookings");
            if (!ModelState.IsValid)
            {
                return View(vehicle);
            }
            else
            {
                int res = await _vehicleService.UpdateVehicleAsync(vehicle);

                if (res > 0)
                {
                    TempData["msg"] = "Vehicle updated successfully.";
                }
                return RedirectToAction("GetAllVehicles");
            }
            
        }

    }
}
