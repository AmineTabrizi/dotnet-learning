var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
var app = builder.Build();

app.MapControllers();
app.UseStaticFiles();
// app.Map("/", async context =>
// {
//     await context.Response.WriteAsync(app.Configuration["myKey"]);
// });

app.Run();
