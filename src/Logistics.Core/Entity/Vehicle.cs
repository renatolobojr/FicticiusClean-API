using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistics.Core.Entity
{
    public class Vehicle
    {
        public Guid Guid { get; set; }
        public string? Name { get; set; }
        public string? LicensePlate { get; set; }
        public string? Make { get; set; }
        public string? Model { get; set; }
        public int? ModelYear { get; set; }
        public int? ProductionDate { get; set; }
        public double? FuelConsumptionCity { get; set; }
        public double? FuelConsumptionRoad { get; set; }
    }
}
