using ConfigurationExample;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.Configure<WeatherApiOptions>(builder.Configuration.GetSection("weatherapi"));

var app = builder.Build();

app.MapControllers();
app.UseStaticFiles();

app.Run();
