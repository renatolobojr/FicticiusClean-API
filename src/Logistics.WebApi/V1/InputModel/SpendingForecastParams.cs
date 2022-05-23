using System.Text.Json.Serialization;

namespace Logistics.WebApi.V1.Model
{
    public class SpendingForecastParams
    {
        
        [JsonPropertyName("precoCombustivel")]
        public double FuelPrice { get; set; }

        [JsonPropertyName("distanciaCidade")]
        public double DistanceCity { get; set; }

        [JsonPropertyName("distanciaEstrada")]
        public double DistanceRoad { get; set; }
    }
}
