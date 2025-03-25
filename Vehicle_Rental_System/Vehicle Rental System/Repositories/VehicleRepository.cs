using Microsoft.EntityFrameworkCore;
using Vehicle_Rental_System.Context;
using Vehicle_Rental_System.Models;

namespace Vehicle_Rental_System.Repositories
{
    public class VehicleRepository : IVehicleRepository
    {
        readonly VehicleRentalDbContext _vehicleDbContext;
        public VehicleRepository(VehicleRentalDbContext vehicleDbContext)
        {
            _vehicleDbContext = vehicleDbContext;
        }
        public async Task<int> AddVehicleAsync(Vehicle vehicle)
        {
            await _vehicleDbContext.Vehicles.AddAsync(vehicle);
            return await _vehicleDbContext.SaveChangesAsync();
        }

        public async Task<int> DeleteVehicleAsync(int vehicleId)
        {
            Vehicle vehicle = await _vehicleDbContext.Vehicles.FindAsync(vehicleId);
            _vehicleDbContext.Vehicles.Remove(vehicle);
            return await _vehicleDbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Vehicle>> GetAllVehiclesAsync()
        {
            return await _vehicleDbContext.Vehicles.ToListAsync();
        }

        public async Task<IEnumerable<Vehicle>> GetAvailableVehiclesAsync()
        {
            return await _vehicleDbContext.Vehicles
                        .Where(v => v.IsAvailable)
                        .ToListAsync();
        }

        public async Task<Vehicle> GetVehicleByIdAsync(int vehicleId)
        {
            return await _vehicleDbContext.Vehicles.FirstOrDefaultAsync(b => b.VehicleId == vehicleId);
        }

        public async Task<int> UpdateVehicleAsync(Vehicle vehicle)
        {
            _vehicleDbContext.Vehicles.Update(vehicle);
            return await _vehicleDbContext.SaveChangesAsync();
        }
    }
}
