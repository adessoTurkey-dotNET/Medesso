using System.Reflection;
using System.Runtime.Loader;
using FluentValidation;
using Medesso;
using Medesso.Processor;
using Medesso.Sample.Core.CqrsProcessors;
using Medesso.Sample.Repository.Context;
using Medesso.Sample.Repository.Contracts;
using Medesso.Sample.Repository.UnitOfWork;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseInMemoryDatabase("Product"));
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

var assemblies = GetAssemblies();
builder.Services.AddValidatorsFromAssemblies(assemblies);
builder.Services.AddMedesso(assemblies);
builder.Services.AddTransient(typeof(IMedessoRequestPreProcessor<>), typeof(ValidationPreProcessor<>));



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



static Assembly[] GetAssemblies()
{
    var path = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
            
    return Directory
        .GetFiles(path, "Medesso.Sample.*.dll", SearchOption.TopDirectoryOnly)
        .Select(AssemblyLoadContext.Default.LoadFromAssemblyPath)
        .ToArray();
}