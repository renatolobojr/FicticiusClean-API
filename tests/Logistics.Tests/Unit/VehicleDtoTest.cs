using Logistics.Core;
using Logistics.Core.Entity;
using Logistics.WebApi.V1.Model;
using System;
using Xunit;

namespace Logistics.Tests.Unit
{
    public class VehicleDtoTest
    {
        //private readonly VehicleDto _vehicleDto;

        public VehicleDtoTest()
        {
            //_vehicleDto = new();
        }


        [Fact]
        public void ChecksConvertionDtoToEntity()
        {
            //Arrange
            var vehicleDto = new VehicleDto()
            {
                Guid = Guid.NewGuid(),
                Name = "Carro Teste",
                LicensePlate = "ABC-1234",
                Make = "GM",
                Model = "Bolt",
                ModelYear = 21,
                ProductionDate = 22,
                FuelConsumptionCity = 10,
                FuelConsumptionRoad = 9,
            };

            //Act
            var vehicle = vehicleDto.ToEntity();

            //Assert
            Assert.NotNull(vehicle);
            Assert.Equal(vehicle.Guid, vehicleDto.Guid);
            Assert.Equal(vehicle.Name, vehicleDto.Name);
            Assert.Equal(vehicle.LicensePlate, vehicleDto.LicensePlate);
            Assert.Equal(vehicle.Make, vehicleDto.Make);
            Assert.Equal(vehicle.Model, vehicleDto.Model);
            Assert.Equal(vehicle.ModelYear, vehicleDto.ModelYear);
            Assert.Equal(vehicle.ProductionDate, vehicleDto.ProductionDate);
            Assert.Equal(vehicle.FuelConsumptionCity, vehicleDto.FuelConsumptionCity);
            Assert.Equal(vehicle.FuelConsumptionRoad, vehicleDto.FuelConsumptionRoad);
        }

        [Fact]
        public void ChecksConvertionEntityToDto()
        {
            //Arrange
            var vehicle = new Vehicle()
            {
                Guid = Guid.NewGuid(),
                Name = "Carro Teste",
                LicensePlate = "ABC-1234",
                Make = "GM",
                Model = "Bolt",
                ModelYear = 21,
                ProductionDate = 22,
                FuelConsumptionCity = 10,
                FuelConsumptionRoad = 9,
            };

            //Act
            var vehicleDto = new VehicleDto(vehicle);

            //Assert
            Assert.NotNull(vehicle);
            Assert.Equal(vehicle.Guid, vehicleDto.Guid);
            Assert.Equal(vehicle.Name, vehicleDto.Name);
            Assert.Equal(vehicle.LicensePlate, vehicleDto.LicensePlate);
            Assert.Equal(vehicle.Make, vehicleDto.Make);
            Assert.Equal(vehicle.Model, vehicleDto.Model);
            Assert.Equal(vehicle.ModelYear, vehicleDto.ModelYear);
            Assert.Equal(vehicle.ProductionDate, vehicleDto.ProductionDate);
            Assert.Equal(vehicle.FuelConsumptionCity, vehicleDto.FuelConsumptionCity);
            Assert.Equal(vehicle.FuelConsumptionRoad, vehicleDto.FuelConsumptionRoad);
        }

        [Fact]
        public void ChecksConvertionInputModelToDto()
        {
            //Arrange
            var inputModel = new RegisterVehicleRequest()
            {
                Name = "Carro Teste",
                LicensePlate = "ABC-1234",
                Make = "GM",
                Model = "Bolt",
                ModelYear = 21,
                ProductionDate = 22,
                FuelConsumptionCity = 10,
                FuelConsumptionRoad = 9,
            };

            //Act
            var vehicleDto = inputModel.ToDto();

            //Assert
            Assert.NotNull(inputModel);
            Assert.Equal(inputModel.Name, vehicleDto.Name);
            Assert.Equal(inputModel.LicensePlate, vehicleDto.LicensePlate);
            Assert.Equal(inputModel.Make, vehicleDto.Make);
            Assert.Equal(inputModel.Model, vehicleDto.Model);
            Assert.Equal(inputModel.ModelYear, vehicleDto.ModelYear);
            Assert.Equal(inputModel.ProductionDate, vehicleDto.ProductionDate);
        }

        [Fact]
        public void ChecksConvertionDtoToViewModelGetbyId()
        {
            //Arrange
            var vehicleDto = new VehicleDto()
            {
                Guid = Guid.NewGuid(),
                Name = "Carro Teste",
                LicensePlate = "ABC-1234",
                Make = "GM",
                Model = "Bolt",
                ModelYear = 21,
                ProductionDate = 22,
                FuelConsumptionCity = 10,
                FuelConsumptionRoad = 9,
            };

            //Act
            var viewModel = new GetVehicleByIdResponse(vehicleDto);

            //Assert
            Assert.NotNull(viewModel);
            Assert.Equal(viewModel.Name, vehicleDto.Name);
            Assert.Equal(viewModel.LicensePlate, vehicleDto.LicensePlate);
            Assert.Equal(viewModel.Make, vehicleDto.Make);
            Assert.Equal(viewModel.Model, vehicleDto.Model);
            Assert.Equal(viewModel.ModelYear, vehicleDto.ModelYear);
            Assert.Equal(viewModel.ProductionDate, vehicleDto.ProductionDate);
            Assert.Equal(viewModel.FuelConsumptionCity, vehicleDto.FuelConsumptionCity);
            Assert.Equal(viewModel.FuelConsumptionRoad, vehicleDto.FuelConsumptionRoad);
        }

        [Fact]
        public void ChecksConvertionDtoToViewModelListAll()
        {
            //Arrange
            var vehicleDto = new VehicleDto()
            {
                Guid = Guid.NewGuid(),
                Name = "Carro Teste",
                LicensePlate = "ABC-1234",
                Make = "GM",
                Model = "Bolt",
                ModelYear = 21,
                ProductionDate = 22,
                FuelConsumptionCity = 10,
                FuelConsumptionRoad = 9,
            };

            //Act
            var viewModel = new ListAllVehiclesResponse(vehicleDto);

            //Assert
            Assert.NotNull(viewModel);
            Assert.Equal(viewModel.Guid, vehicleDto.Guid);
            Assert.Equal(viewModel.Name, vehicleDto.Name);
            Assert.Equal(viewModel.LicensePlate, vehicleDto.LicensePlate);
        }

        [Fact]
        public void ChecksConvertionDtoToViewModelSpendingForecast()
        {
            //Arrange
            var vehicleDto = new VehicleDto()
            {
                Guid = Guid.NewGuid(),
                Name = "Carro Teste",
                LicensePlate = "ABC-1234",
                Make = "GM",
                Model = "Bolt",
                ModelYear = 21,
                ProductionDate = 22,
                LitersUsed = 55.8,
                TotalCosts = 345.89,
            };

            //Act
            var viewModel = new SpendingForecastResponse(vehicleDto);

            //Assert
            Assert.NotNull(viewModel);
            Assert.Equal(viewModel.Name, vehicleDto.Name);
            Assert.Equal(viewModel.Make, vehicleDto.Make);
            Assert.Equal(viewModel.Model, vehicleDto.Model);
            Assert.Equal(viewModel.ModelYear, vehicleDto.ModelYear);
            Assert.Equal(viewModel.LitersUsed, vehicleDto.LitersUsed);
            Assert.Equal(viewModel.TotalCosts, vehicleDto.TotalCosts);
        }

    }
}