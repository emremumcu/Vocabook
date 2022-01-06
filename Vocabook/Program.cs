using Vocabook.AppData;

var builder = WebApplication.CreateBuilder(args);

// Install-Package Microsoft.AspNetCore.Mvc.Razor.RuntimeCompilation 
builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation();

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
    endpoints.MapControllerRoute(name: "default", pattern: "{controller=Home}/{action=Index}/{id?}");
    endpoints.MapRazorPages();
});

app.Run();