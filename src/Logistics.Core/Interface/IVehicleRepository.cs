using Logistics.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistics.Core.Interface
{
    public interface IVehicleRepository
    {
        Task Insert( Vehicle vehicle);
        Task<IEnumerable<Vehicle>> GetAll();
        Task<Vehicle> GetById(Guid guid);
    }
}
