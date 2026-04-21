using AuthMVC.EF;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDistributedMemoryCache(); // Required for session 
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(30); // Session expiration 
    options.Cookie.HttpOnly = true;                // Prevent JavaScript access 
    options.Cookie.IsEssential = true;             // GDPR compliance 
});

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<AuthASp26Context>(opt => {
    opt.UseSqlServer(builder.Configuration.GetConnectionString("DbConn"));
});
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();

app.UseSession();
app.Run();
