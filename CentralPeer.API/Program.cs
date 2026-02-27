using CentralPeer.Application;
using CentralPeer.Infrastructure;
using CentralPeer.Application.Interfaces;
using CentralPeer.API.Services;

var builder = WebApplication.CreateBuilder(args);

// API Controllers
builder.Services.AddControllers();

// Swagger Configuration
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Layer Dependencies
builder.Services.AddApplicationServices();
builder.Services.AddInfrastructureServices(builder.Configuration);

builder.Services.AddScoped<ICurrentUser, CurrentUserService>();
// builder.Services.AddOpenApi();

var app = builder.Build();

// Enabling Swagger UI middleware
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();