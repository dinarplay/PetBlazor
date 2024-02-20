using Microsoft.EntityFrameworkCore;
using PetBlazor.Data;
using PetBlazor.Services;
using PetBlazor.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();
builder.Services.AddScoped<PassGenerateService>();
builder.Services.AddScoped<AgeCalculateService>();
builder.Services.AddScoped<ParseService>();
builder.Services.AddScoped<DbManagerService>();

string connection = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ApplicationContext>(options => options.UseSqlServer(connection));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapBlazorHub();
app.MapBlazorHub();
app.MapBlazorHub();
app.MapBlazorHub();
app.MapBlazorHub();
app.MapBlazorHub();
app.MapBlazorHub();
app.MapBlazorHub();
app.MapBlazorHub();
app.MapBlazorHub();
app.MapBlazorHub();
app.MapBlazorHub();
app.MapBlazorHub();
app.MapBlazorHub();
app.MapBlazorHub();
app.MapBlazorHub();
app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
