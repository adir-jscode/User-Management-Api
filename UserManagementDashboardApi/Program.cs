using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;
using UserManagementDashboardApi.Core.DbContext;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.




builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();




//JSON converter

builder.Services
    .AddControllers()
    .AddJsonOptions(options =>
    {
        options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
    });

//EF injection
builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

//Dependency Injection

//Add Identity

//Config Identity

//Add JWTSchema and JWTBearer



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
