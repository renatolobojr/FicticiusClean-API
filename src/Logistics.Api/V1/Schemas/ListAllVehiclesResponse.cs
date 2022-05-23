using System.Text.Json.Serialization;

namespace Logistics.Api.V1.Schemas
{
    public class ListAllVehiclesResponse
    {
        [JsonPropertyName("nome")]
        public string Name { get; set; }

        [JsonPropertyName("placa")]
        public string LicensePlate { get; set; }
    }
}
