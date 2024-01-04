using Microsoft.EntityFrameworkCore;
using RentACar.Data;
using RentACar.Repository.CarRepository;
using RentACar.Repository.PersonRepository;
using RentACar.Repository.RentalRepository;
using RentACar.Services.CarService;
using RentACar.Services.PersonService;
using RentACar.Services.RentalService;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<DataContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddMvc().AddNewtonsoftJson();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<ICarService, CarService>();
builder.Services.AddScoped<ICarRepository, CarRepository>();
builder.Services.AddScoped<IPersonService, PersonService>();
builder.Services.AddScoped<IPersonRepository, PersonRepository>();
builder.Services.AddScoped<IRentalService, RentalService>();
builder.Services.AddScoped<IRentalRepository, RentalRepository>();
builder.Services.AddAutoMapper(typeof(Program));

builder.Services.AddControllers().AddNewtonsoftJson(options =>
{
    options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
});

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
