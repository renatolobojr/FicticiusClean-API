using System.Text.Json.Serialization;

namespace Logistics.Api.V1.Schemas
{
    public class SpendingForecastResponse
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
        public string ModelYear { get; set; }

        [JsonPropertyName("dataFaricacao")]
        public string ProductionDate { get; set; }

        [JsonPropertyName("litrosGastos")]
        public string LitersUsed { get; set; }

        [JsonPropertyName("valorTotal")]
        public string TotalCosts { get; set; }

    }
}
