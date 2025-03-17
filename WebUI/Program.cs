using BusinessKatmani.Interfaces;
using BusinessKatmani.Services.ApiServices;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddHttpClient<IUyeApiService, UyeApiService>(client =>
{
    client.BaseAddress = new Uri("http://localhost:5233/api/");
});

builder.Services.AddHttpClient<IUrunApiService, UrunApiService>(client =>
{
    client.BaseAddress = new Uri("http://localhost:5233/api/");
});

var app = builder.Build();



// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=GirisEkrani}/{action=GirisYap}/{id?}");

app.Run();
