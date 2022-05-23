using Logistics.Core;
using System.Text.Json.Serialization;

namespace Logistics.WebApi.V1.Model
{
    public class SpendingForecastResponse
    {        
        [JsonPropertyName("nome")]
        public string Name { get; set; }

        [JsonPropertyName("marca")]
        public string Make { get; set; }

        [JsonPropertyName("modelo")]
        public string Model { get; set; }

        [JsonPropertyName("anoModelo")]
        public int? ModelYear { get; set; }

        [JsonPropertyName("litrosGastos")]
        public double? LitersUsed { get; set; }

        [JsonPropertyName("valorTotal")]
        public double? TotalCosts { get; set; }

        public SpendingForecastResponse(VehicleDto vehicleDto)
        {
            Name = vehicleDto.Name;
            Make = vehicleDto.Make;
            Model = vehicleDto.Model;
            ModelYear = vehicleDto.ModelYear;
            LitersUsed = vehicleDto.LitersUsed;
            TotalCosts = vehicleDto.TotalCosts;
        }

    }
}
