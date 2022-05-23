namespace Logistics.Core.Interface
{
    public interface ISpendingForecastService : IDisposable
    {
        Task<IEnumerable<VehicleDto>> ListVehicles();

        Task<IEnumerable<VehicleDto>> ListTravelCosts( double? fuelPrice, double? distanceCity, double? distanceRoad);

        Task<VehicleDto> GetVehicle( Guid guid);

        Task InsertVehicle(VehicleDto vehicleDto);

    }
}