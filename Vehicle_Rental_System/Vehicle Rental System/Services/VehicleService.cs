using Vehicle_Rental_System.Exceptions;
using Vehicle_Rental_System.Models;
using Vehicle_Rental_System.Repositories;

namespace Vehicle_Rental_System.Services
{
    public class VehicleService : IVehicleService
    {
        readonly IVehicleRepository _vehicleRepository;
        public VehicleService(IVehicleRepository vehicleRepository)
        {
            _vehicleRepository = vehicleRepository;
        }
        public async Task<int> AddVehicleAsync(Vehicle vehicle)
        {
            return await _vehicleRepository.AddVehicleAsync(vehicle);
        }

        public async Task<int> DeleteVehicleAsync(int vehicleId)
        {
            var vehicle = await _vehicleRepository.GetVehicleByIdAsync(vehicleId);
            if (vehicle == null)
                throw new VehicleNotFoundException($"Vehicle with Id {vehicleId} not found");
            return await _vehicleRepository.DeleteVehicleAsync(vehicleId);
        }

        public async Task<IEnumerable<Vehicle>> GetAllVehiclesAsync()
        {
            return await _vehicleRepository.GetAllVehiclesAsync();
        }

        public async Task<IEnumerable<Vehicle>> GetAvailableVehiclesAsync()
        {
            return await _vehicleRepository.GetAvailableVehiclesAsync();
        }

        public async Task<Vehicle> GetVehicleByIdAsync(int vehicleId)
        {
            var vehicle = await _vehicleRepository.GetVehicleByIdAsync(vehicleId);
            if (vehicle == null)
                throw new VehicleNotFoundException($"Vehicle with Id {vehicleId} not found");
            return vehicle;
        }

        public async Task<int> UpdateVehicleAsync(Vehicle vehicle)
        {
            if (vehicle == null)
                throw new VehicleNotFoundException($"Vehicle with Id {vehicle.VehicleId} not found");
            return await _vehicleRepository.UpdateVehicleAsync(vehicle);
        }
    }
}
