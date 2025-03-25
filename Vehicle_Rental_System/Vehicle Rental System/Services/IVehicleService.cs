using Vehicle_Rental_System.Models;

namespace Vehicle_Rental_System.Services
{
    public interface IVehicleService
    {
        Task<IEnumerable<Vehicle>> GetAllVehiclesAsync(); 
        Task<Vehicle> GetVehicleByIdAsync(int vehicleId); 
        Task<int> AddVehicleAsync(Vehicle vehicle); 
        Task<int> UpdateVehicleAsync(Vehicle vehicle);
        Task<int> DeleteVehicleAsync(int vehicleId); 
        Task<IEnumerable<Vehicle>> GetAvailableVehiclesAsync();
    }
}
