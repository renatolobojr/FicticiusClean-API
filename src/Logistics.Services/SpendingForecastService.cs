using Logistics.Core;
using Logistics.Core.Interface;

namespace Logistics.Services
{
    public class SpendingForecastService : ISpendingForecastService
    {
        private bool disposedValue;
        private readonly IVehicleRepository _vehicleRepository;

        public SpendingForecastService(IVehicleRepository vehicleRepository)
        {
            _vehicleRepository = vehicleRepository;
        }

        public async Task<VehicleDto> GetVehicle(Guid guid)
        {
            var vehicle = await _vehicleRepository.GetById(guid);
            
            return new VehicleDto(vehicle);
        }

        public async Task InsertVehicle(VehicleDto vehicleDto)
        {            
            await _vehicleRepository.Insert(vehicleDto.ToEntity());
        }

        public async Task<IEnumerable<VehicleDto>> ListTravelCosts( double? fuelPrice,
                                                                    double? distanceCity,
                                                                    double? distanceRoad )
        {
            var vehiclesDto = new List<VehicleDto>();
            var vehicles = await _vehicleRepository.GetAll();

            foreach (var vehicle in vehicles)
            {
                var vehicleDto = new VehicleDto(vehicle);

                vehicleDto.LitersUsed = (distanceCity / vehicleDto.FuelConsumptionCity) 
                                      + (distanceRoad / vehicleDto.FuelConsumptionRoad);
                                
                vehicleDto.TotalCosts = fuelPrice * vehicleDto.LitersUsed;

                vehiclesDto.Add(vehicleDto);
            }

            var OrderedVehicles = vehiclesDto.OrderBy(_ => _.TotalCosts);

            return OrderedVehicles;
        }

        public async Task<IEnumerable<VehicleDto>> ListVehicles()
        {
            var vehiclesDto = new List<VehicleDto>();
            var vehicles = await _vehicleRepository.GetAll();

            foreach(var vehicle in vehicles)
            {
                var vehicleDto = new VehicleDto(vehicle);
                vehiclesDto.Add(vehicleDto);
            }
            
            return vehiclesDto;
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects)
                }

                // TODO: free unmanaged resources (unmanaged objects) and override finalizer
                // TODO: set large fields to null
                disposedValue = true;
            }
        }

        // // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
        // ~SpendingForecastService()
        // {
        //     // Não altere este código. Coloque o código de limpeza no método 'Dispose(bool disposing)'
        //     Dispose(disposing: false);
        // }

        public void Dispose()
        {
            // Não altere este código. Coloque o código de limpeza no método 'Dispose(bool disposing)'
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}