using System.Text.Json.Serialization;

namespace Logistics.Api.V1.Schemas
{
    public class RegisterVehicleRequest
    {
        [JsonPropertyName("precoCombustivel")]
        public string FuelPrice { get; set; }

        [JsonPropertyName("distanciaCidade")]
        public string DistanceCity { get; set; }

        [JsonPropertyName("distanciaEstrada")]
        public string DistanceRoad { get; set; }
    }
}
