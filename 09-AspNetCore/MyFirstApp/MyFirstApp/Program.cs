
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Middleware 1
app.UseWhen(
    context => context.Request.Query.ContainsKey("username"),
    app =>
    {
        app.Use(async (context, next) =>
        {
            await context.Response.WriteAsync("From Middleware branch");
            await next();
        });

    });

app.Run(async context =>
{
    await context.Response.WriteAsync("From The Main Chain Middleware");
});



app.Run();
