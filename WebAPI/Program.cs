using BusinessKatmani.Interfaces;
using BusinessKatmani.Mappers;
using BusinessKatmani.Services.ApiServices;
using BusinessKatmani.Services.ControlService;
using DataAccessKatmani.Contexts;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<Context>
    (
        options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))
    );


builder.Services.AddScoped<IUrunService, UrunService>();
builder.Services.AddScoped<IUyeService, UyeService>();
builder.Services.AddScoped<IUyeApiService, UyeApiService>();
builder.Services.AddHttpClient<IUyeApiService, UyeApiService>(client =>
{
    client.BaseAddress = new Uri("http://localhost:5233/api/");
});


builder.Services.AddAutoMapper(typeof(UyeMapper));
builder.Services.AddAutoMapper(typeof(UrunMapper));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
