using Logistics.Core.Entity;
using Logistics.Core.Interface;
using Logistics.SQLite;
using Logistics.SQLite.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<LogisticsContext>();

var app = builder.Build();

app.Logger.LogInformation("The app started");

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapGet("v1/veiculos", (LogisticsContext context) => {

    IVehicleRepository repository = new VehicleRepository(context);

    var vehicles = repository.GetAll();

    return Results.Ok(vehicles);

});


app.MapPost("v1/veiculos", (LogisticsContext context, Vehicle vehicle) => {

    IVehicleRepository repository = new VehicleRepository(context);

    repository.Insert(vehicle);

    return Results.Created($"v1/veiculos/{vehicle.Guid}", vehicle);

});

app.MapGet("v1/veiculos/consumo", (LogisticsContext context) => {

    IVehicleRepository repository = new VehicleRepository(context);

    var vehicles = repository.GetAll();

    return Results.Ok(vehicles);

});



//app.MapGet("/weatherforecast", () =>
//{
//    var forecast = Enumerable.Range(1, 5).Select(index =>
//       new WeatherForecast
//       (
//           DateTime.Now.AddDays(index),
//           Random.Shared.Next(-20, 55),
//           summaries[Random.Shared.Next(summaries.Length)]
//       ))
//        .ToArray();
//    return forecast;
//})
//.WithName("GetWeatherForecast");

app.Run();
