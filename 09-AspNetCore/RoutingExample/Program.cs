var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// enable routing
app.UseRouting();

// creating endpoints
app.Map("products/details/{id?}", async (context) =>
{
    if (context.Request.RouteValues.ContainsKey("id"))
    {
        int id = Convert.ToInt32(context.Request.RouteValues["id"]);
        await context.Response.WriteAsync($"Products details : {id}");
    }
    else
    {
        await context.Response.WriteAsync($"Products details , Id not supplied.");
    }
});

app.Run();
