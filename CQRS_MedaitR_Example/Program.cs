using AutoMapper;
using CQRS_MedaitR_Example.Mapper;
using CQRS_MedaitR_Example.Repositories;
using MediatR;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddMediatR(typeof(Program));
builder.Services.AddSingleton<IProductRepository, ProductRepository>();
builder.Services.AddControllers();

#region Automapper register
var config = new MapperConfiguration(conf =>
{
    conf.AddProfile<RegisterMapper>();
});
builder.Services.AddScoped(s => config.CreateMapper());

#endregion
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
