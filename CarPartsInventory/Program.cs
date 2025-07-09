using CarPartsInventory.Repositories;
using CarPartsInventory.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Register services
builder.Services.AddSingleton<IPartRepository, InMemoryPartRepository>();
builder.Services.AddScoped<IPartService, PartService>();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();
app.MapControllers();
app.Run();