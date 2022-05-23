
using Logistics.Core.Interface;
using Logistics.Services;
using Logistics.WebApi.V1.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Logistics.Api.V1.Controllers
{
    [ApiController]
    [Route("v1/[controller]")]
    public class VehiclesController : ControllerBase
    {
        private readonly ILogger<VehiclesController> _logger;
        private readonly ISpendingForecastService _spendingForecastService;

        public VehiclesController(ILogger<VehiclesController> logger,
                                  ISpendingForecastService spendingForecastService)
        {
            _logger = logger;
            _spendingForecastService = spendingForecastService;
        }

        [HttpGet("/v1/veiculos")]
        public ActionResult<IEnumerable<ListAllVehiclesResponse>> ListAllVehicles()
        {
            var vehicles = new List<ListAllVehiclesResponse>();
            var vehiclesDto = _spendingForecastService.ListVehicles().Result;

            foreach ( var vehicleDto in vehiclesDto)
            {
                var vehicle = new ListAllVehiclesResponse(vehicleDto);
                vehicles.Add(vehicle);
            }            

            if (vehicles.Any()) return Ok(vehicles);
            else return NoContent();
        }

        [HttpGet("/v1/veiculos/{guid}")]
        public ActionResult<GetVehicleByIdResponse> GetVehicleById([FromRoute]Guid guid)
        {
            var vehicleDto = _spendingForecastService.GetVehicle(guid).Result;

            var vehicle = new GetVehicleByIdResponse(vehicleDto);

            if (vehicle is null) return NotFound();
            else return Ok(vehicle);
        }

        [HttpPost("/v1/veiculos")]
        public ActionResult RegisterVehicle([FromBody] RegisterVehicleRequest body)
        {
            _spendingForecastService.InsertVehicle(body.ToDto());

            return Created("/v1/veiculos", body);
        }

        [HttpGet("/v1/veiculos/consumo")]
        public ActionResult<IEnumerable<SpendingForecastResponse>> SpendingForecast([FromQuery]SpendingForecastParams queryParams)
        {
            var vehicles = new List<SpendingForecastResponse>();
            var vehiclesDto = _spendingForecastService.ListTravelCosts( queryParams.FuelPrice, 
                                                                        queryParams.DistanceCity,
                                                                        queryParams.DistanceRoad ).Result;

            foreach (var vehicleDto in vehiclesDto)
            {
                var vehicle = new SpendingForecastResponse(vehicleDto);
                vehicles.Add(vehicle);
            }

            if (vehicles.Any()) return Ok(vehicles);
            else return NoContent();
        }
    }
}
