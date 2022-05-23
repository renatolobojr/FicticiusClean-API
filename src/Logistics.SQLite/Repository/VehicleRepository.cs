
using Logistics.Core.Interface;
using Logistics.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistics.SQLite.Repository
{
    public class VehicleRepository : IVehicleRepository
    {
        public LogisticsContext _logisticsContext;

        public VehicleRepository(LogisticsContext logisticsContext)
        {
            _logisticsContext = logisticsContext;
        }

        public async Task<IEnumerable<Vehicle>> GetAll()
        {
            return _logisticsContext.Vehicles.ToList<Vehicle>();
        }

        public Task<Vehicle> GetById(Guid guid)
        {
            throw new NotImplementedException();
        }

        public async Task Insert(Vehicle vehicle)
        {
            _logisticsContext.Vehicles.Add(vehicle);
            _logisticsContext.SaveChanges();
        }

    }
}
