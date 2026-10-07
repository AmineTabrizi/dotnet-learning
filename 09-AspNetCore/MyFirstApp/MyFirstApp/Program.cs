var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.Run(async (HttpContext context) => 
{
    context.Response.Headers["MyKeys"] = "My Value";
    context.Response.Headers["Server"] = "My server";
    context.Response.Headers["Content-Type"] = "text/html";
    await context.Response.WriteAsync("<h1>Hello</h1>");
    await context.Response.WriteAsync(" WORLD");
    
});

app.Run();
