
using Logistics.Api.V1.Schemas;
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

        public VehiclesController(ILogger<VehiclesController> logger)
        {
            _logger = logger;
        }

        [HttpGet("/v1/veiculos")]
        public ActionResult<IEnumerable<ListAllVehiclesResponse>> ListAllVehicles()
        {
            var vehicles = new List<ListAllVehiclesResponse>();


            if (vehicles.Any()) return Ok(vehicles);
            else return NoContent();
        }

        [HttpGet("/v1/veiculos/{guid}")]
        public ActionResult<GetVehicleByIdResponse> GetVehicleById([FromRoute]Guid guid)
        {
            var vehicle = new GetVehicleByIdResponse();


            if (vehicle is null) return NotFound();
            else return Ok(vehicle);
        }

        [HttpPost("/v1/veiculos")]
        public ActionResult RegisterVehicle([FromBody] RegisterVehicleRequest body)
        {

            // var uri = Url.Action(recuperar)

            return Created("/teste",body);
        }

        [HttpGet("/v1/veiculos/consumo")]
        public ActionResult<IEnumerable<SpendingForecastResponse>> SpendingForecast([FromQuery]SpendingForecastRequest queryParams)
        {
            var vehicles = new List<SpendingForecastResponse>();


            if (vehicles.Any()) return Ok(vehicles);
            else return NoContent();
        }
    }
}
