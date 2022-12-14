using HeroesWorld.API;
using HeroesWorld.API.Middlewares;
using HeroesWorld.Application;
using HeroesWorld.Infrastructure;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

var configbuilder = new ConfigurationBuilder();
configbuilder.SetBasePath(Directory.GetCurrentDirectory());
configbuilder.AddJsonFile("appsettings.json");
var config = configbuilder.Build();
string connectionString = config.GetConnectionString("DefaultConnection");
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<ApplicationDbContext>(options =>
options.UseNpgsql(
    connectionString,
    b => b.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName)));

builder.Services.AddAuthorization();
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(
    opt =>
    {
        opt.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters
        {
            ValidateIssuer = true,
            ValidateAudience = true,
            ValidateLifetime = true,
            ValidateIssuerSigningKey = true,
            ValidIssuer = AuthConfigs.ISSUER,
            ValidAudience = AuthConfigs.AUDIENCE,
            IssuerSigningKey = AuthConfigs.GetSymmetricSecurityKey()
        };
    });

builder.Services.AddInfrastructureServices();
builder.Services.AddApplicationServices();

var app = builder.Build();

app.UseMiddleware<ExceptionHandlerMiddleware>();

app.UseMiddleware<JwtMiddleware>();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();



app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();