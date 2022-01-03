using Microsoft.EntityFrameworkCore;
using Vocabook.AppData;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRazorPages();
builder.Services.AddDbContext<AppDbContext>();

var app = builder.Build();

//IServiceScope scope = app.Services.CreateScope();
//IServiceProvider services = scope.ServiceProvider;
//AppDbContext context = services.GetRequiredService<AppDbContext>();
//if (context.Database.EnsureCreated()) await context.Database.MigrateAsync();

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    // specific route should be created before the generic route
    // endpoints.MapGet("/license", async context => { await context.Response.WriteAsync(System.IO.File.ReadAllText("license.md")); });
    // endpoints.MapAreaControllerRoute(name: "admin", areaName: "admin", pattern: "admin/{controller=Home}/{action=Index}/{id?}");
    // endpoints.MapControllerRoute(name: "areaRoute", pattern: "{area:exists}/{controller}/{action}");
    endpoints.MapControllerRoute(name: "default", pattern: "{controller=Home}/{action=Index}/{id?}");
    endpoints.MapRazorPages();
});

app.Run();