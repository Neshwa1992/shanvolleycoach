var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseDefaultFiles();   // Looks for index.html by default
app.UseStaticFiles();    // Enables static file serving

app.Run();
