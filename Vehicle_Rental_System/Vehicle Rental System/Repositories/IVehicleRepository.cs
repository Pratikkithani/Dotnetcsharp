using Vehicle_Rental_System.Models;

namespace Vehicle_Rental_System.Repositories
{
    public interface IVehicleRepository
    {
        Task<IEnumerable<Vehicle>> GetAllVehiclesAsync();
        Task<Vehicle> GetVehicleByIdAsync(int vehicleId);
        Task<int> AddVehicleAsync(Vehicle vehicle);
        Task<int> UpdateVehicleAsync(Vehicle vehicle);
        Task<int> DeleteVehicleAsync(int vehicleId);
        Task<IEnumerable<Vehicle>> GetAvailableVehiclesAsync();
    }
}
