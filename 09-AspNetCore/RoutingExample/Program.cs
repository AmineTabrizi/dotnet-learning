var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// enable routing
app.UseRouting();

// creating endpoints
// app.Map("employee/profile/{EmployeeName:minlength(3):maxlength(12)=Amin}", async (context) =>
app.Map("employee/profile/{EmployeeName:length(3, 7)=Amin}", async (context) =>
{
    string? employeeName = Convert.ToString(context.Request.RouteValues["employeename"]);
    await context.Response.WriteAsync($"Profile: {employeeName}");
});

app.Run();
