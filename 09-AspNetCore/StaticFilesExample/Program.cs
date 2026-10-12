var builder = WebApplication.CreateBuilder(new WebApplicationOptions()
{
    WebRootPath = "MyRoot"
});
var app = builder.Build();

app.UseStaticFiles();

app.MapGet("/", async context =>
{
    await context.Response.WriteAsync("Hello");
});

app.Run();
