using Logistics.Core;
using System.Text.Json.Serialization;

namespace Logistics.WebApi.V1.Model
{
    public class ListAllVehiclesResponse
    {
        [JsonPropertyName("uuid")]
        public Guid Guid { get; set; }

        [JsonPropertyName("nome")]
        public string Name { get; set; }

        [JsonPropertyName("placa")]
        public string LicensePlate { get; set; }

        public ListAllVehiclesResponse(VehicleDto vehicleDto)
        {
            Guid = vehicleDto.Guid;
            Name = vehicleDto.Name;
            LicensePlate = vehicleDto.LicensePlate;
        }

    }
}
