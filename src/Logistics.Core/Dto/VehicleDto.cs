using Logistics.Core.Entity;

namespace Logistics.Core
{
    public class VehicleDto
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
        public double? LitersUsed { get; set; }
        public double? TotalCosts { get; set; }

        public VehicleDto()
        {
        }

        public VehicleDto(Vehicle vehicle)
        {
            Guid = vehicle.Guid;
            Name = vehicle.Name;
            LicensePlate = vehicle.LicensePlate;
            Make = vehicle.Make;
            Model = vehicle.Model;
            ModelYear = vehicle.ModelYear;
            ProductionDate = vehicle.ProductionDate;
            FuelConsumptionCity = vehicle.FuelConsumptionCity;
            FuelConsumptionRoad = vehicle.FuelConsumptionRoad;
        }

        public Vehicle ToEntity()
        {
            return new Vehicle()
            {
                Guid = this.Guid,
                Name = this.Name,
                LicensePlate = this.LicensePlate,
                Make = this.Make,
                Model = this.Model,
                ModelYear = this.ModelYear,
                ProductionDate = this.ProductionDate,
                FuelConsumptionCity = this.FuelConsumptionCity,
                FuelConsumptionRoad = this.FuelConsumptionRoad,
            };
        }
    }
}