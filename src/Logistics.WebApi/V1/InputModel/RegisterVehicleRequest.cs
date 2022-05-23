using Logistics.Core;
using System.Text.Json.Serialization;

namespace Logistics.WebApi.V1.Model
{
    public class RegisterVehicleRequest
    {
        [JsonPropertyName("nome")]
        public string Name { get; set; }

        [JsonPropertyName("placa")]
        public string LicensePlate { get; set; }

        [JsonPropertyName("marca")]
        public string Make { get; set; }

        [JsonPropertyName("modelo")]
        public string Model { get; set; }

        [JsonPropertyName("anoModelo")]
        public int ModelYear { get; set; }

        [JsonPropertyName("dataFaricacao")]
        public int ProductionDate { get; set; }

        [JsonPropertyName("consumoCidade")]
        public double FuelConsumptionCity { get; set; }

        [JsonPropertyName("consumoEstrada")]
        public double FuelConsumptionRoad { get; set; }

        public VehicleDto ToDto()
        {
            return new VehicleDto()
            {
                Guid = Guid.NewGuid(),
                Name = this.Name,
                LicensePlate = this.LicensePlate,
                Make = this.Make,
                Model = this.Model,
                ModelYear = this.ModelYear,
                ProductionDate = this.ProductionDate,
                FuelConsumptionCity = this.FuelConsumptionCity,
                FuelConsumptionRoad = this.FuelConsumptionRoad,
            }; ;
        }
    }
}
