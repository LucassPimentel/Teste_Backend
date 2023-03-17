using Frutas.Core.Data;
using Frutas.Core.Repositories;
using Frutas.Core.Repositories.Interfaces;
using Frutas.Core.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<DataBaseContext>(opts => opts.UseSqlServer(connectionString));

builder.Services.AddScoped<IFruitRepository, FruitRepository>();

builder.Services.AddTransient<FruitService, FruitService>();

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

var app = builder.Build();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
