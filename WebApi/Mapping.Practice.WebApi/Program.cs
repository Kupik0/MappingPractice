using FluentValidation;
using FluentValidation.AspNetCore;
using Mapping.Practice.WemApi.Extensions;
using MappingPractice.Core.Application.Dtos;
using MappingPractice.Core.Application.Interfaces;
using MappingPractice.Core.Application.ServiceRegistration;
using MappingPractice.Core.Application.Validations;
using MappingPractice.Infrastructure.Persistence.Repositories;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
        
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddFluentValidation();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddTransient<IValidator<UserDto>, UserValidator > ();
builder.Services.AddApplicationRegistration();
builder.Services.AddResponseCaching();
builder.Services.AddLogging(i =>
{ 

    i.SetMinimumLevel(LogLevel.Debug);
    i.ClearProviders();
    i.AddConsole();
    i.AddDebug();
}

);
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
