using copyqr.Models.Entities;

var builder = WebApplication.CreateBuilder(args);

QrCodesContext.SetConnectionString($"Host={Environment.GetEnvironmentVariable("DB_IP")};" +
    $"Port=5432;" +
    $"Database={Environment.GetEnvironmentVariable("POSTGRES_DB")};" +
    $"Username={Environment.GetEnvironmentVariable("POSTGRES_USER")};" +
    $"Password={Environment.GetEnvironmentVariable("POSTGRES_PASSWORD")}");

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<QrCodesContext>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
