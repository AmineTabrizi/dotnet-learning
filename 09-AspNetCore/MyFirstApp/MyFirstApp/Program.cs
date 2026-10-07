var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.Run(async (HttpContext context) => 
{
    string path = context.Request.Path;
    string method = context.Request.Method;
    // context.Response.Headers["MyKeys"] = "My Value";
    // context.Response.Headers["Server"] = "My server";
    context.Response.Headers["Content-Type"] = "text/html";
    await context.Response.WriteAsync($"<h1>{path}</h1>");
    await context.Response.WriteAsync($"<p>{method}</p>");
    
});

app.Run();
