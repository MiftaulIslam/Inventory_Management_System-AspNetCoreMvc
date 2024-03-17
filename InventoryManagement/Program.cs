using InventoryManagement.Data;
using Microsoft.EntityFrameworkCore;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<InventoryManagementContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("defaultConnection") ?? throw new InvalidOperationException("Connection string 'defaultConnection' not found.")));

// Add services to the container.
builder.Services.AddMvc().AddRazorRuntimeCompilation();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();
app.MapControllerRoute(
    name: "product",
    pattern: "product",
    defaults: new { controller = "Product", action = "ManageProduct" }
);
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Dashboard}/{action=Index}/{id?}");

app.Run();
