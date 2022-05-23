using Logistics.Core.Entity;
using Logistics.Core.Interface;

namespace Logistics.Mock.Repository
{

    public class VehicleRepository : IVehicleRepository
    {
        public async Task<IEnumerable<Vehicle>> GetAll()
        {
            await Task.Delay(3000);
            return _vehiclesMock.ToList();
        }

        public async Task Insert(Vehicle vehicle)
        {
            await Task.Delay(1000);
            _vehiclesMock.Add(vehicle);
        }

        public async Task<Vehicle> GetById(Guid guid)
        {
            await Task.Delay(500);
            var lista = _vehiclesMock.Where<Vehicle>(_=>_.Guid == guid);

            return lista.FirstOrDefault();
        }

        private static List<Vehicle> _vehiclesMock = new()
        {
            new Vehicle() { Guid = Guid.NewGuid() ,Name = "Fusca Azul" , LicensePlate = "g" , Make = "Volkswagen" , Model = "Fusca" , ModelYear = 76, ProductionDate = 76, FuelConsumptionCity = 8 , FuelConsumptionRoad = 8},
            new Vehicle() { Guid = Guid.NewGuid() ,Name = "Corsa Preto" , LicensePlate = "g" , Make = "Chevrolet" , Model = "Corsa Classic 1.0 Flexpower 4P" , ModelYear = 13, ProductionDate = 12, FuelConsumptionCity = 7.4 , FuelConsumptionRoad = 9.2},
            new Vehicle() { Guid = Guid.NewGuid() ,Name = "Corola Prata" , LicensePlate = "g" , Make = "Toyota" , Model = "Corola GLi 2.0 16V Flex" , ModelYear = 20, ProductionDate = 19, FuelConsumptionCity = 11.4 , FuelConsumptionRoad = 13.2},
            new Vehicle() { Guid = Guid.NewGuid() ,Name = "Ford Ka Antigo" , LicensePlate = "g" , Make = "Ford" , Model = "Ka CLX 1.3i 3p" , ModelYear = 97, ProductionDate = 97, FuelConsumptionCity = 12.7 , FuelConsumptionRoad = 16.8},
            new Vehicle() { Guid = Guid.NewGuid() ,Name = "HB20 Novo" , LicensePlate = "g" , Make = "Hyundai" , Model = "HB20 Evolution 1.0 Turbo Flex 12V Automático" , ModelYear = 22, ProductionDate = 22, FuelConsumptionCity = 12.8 , FuelConsumptionRoad = 14.6},
            new Vehicle() { Guid = Guid.NewGuid() ,Name = "Uno branco" , LicensePlate = "g" , Make = "Fiat" , Model = "Uno Mille Way Economy 1.0 Fire Flex 4p " , ModelYear = 11, ProductionDate = 11, FuelConsumptionCity = 11.1 , FuelConsumptionRoad = 15.6}
        };

    }
}