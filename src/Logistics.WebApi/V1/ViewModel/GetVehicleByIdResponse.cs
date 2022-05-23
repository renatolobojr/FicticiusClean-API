using Logistics.Core;
using System.Text.Json.Serialization;

namespace Logistics.WebApi.V1.Model
{
    public class GetVehicleByIdResponse
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
        public int? ModelYear { get; set; }

        [JsonPropertyName("dataFaricacao")]
        public int? ProductionDate { get; set; }

        [JsonPropertyName("consumoCidade")]
        public double? FuelConsumptionCity { get; set; }

        [JsonPropertyName("consumoEstrada")]
        public double? FuelConsumptionRoad { get; set; }

        public GetVehicleByIdResponse(VehicleDto vehicleDto)
        {
            Name = vehicleDto.Name;
            LicensePlate = vehicleDto.LicensePlate;
            Make = vehicleDto.Make;
            Model = vehicleDto.Model;
            ModelYear = vehicleDto.ModelYear;
            ProductionDate = vehicleDto.ProductionDate;
            FuelConsumptionCity = vehicleDto.FuelConsumptionCity;
            FuelConsumptionRoad = vehicleDto.FuelConsumptionRoad;
        }
    }
}