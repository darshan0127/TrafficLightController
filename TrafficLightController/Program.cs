var builder = WebApplication.CreateBuilder(args);

// Add services to the container
builder.Services.AddControllersWithViews();

var app = builder.Build();

app.UseStaticFiles(); // To serve static files (CSS, JS)

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
else
{
    app.UseDeveloperExceptionPage();
}


app.UseRouting();

// Map the default route
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=TrafficLight}/{action=Index}/{id?}");

app.Run();
