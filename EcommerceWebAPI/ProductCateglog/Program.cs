var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var app = builder.Build();

// Configure the HTTP request pipeline.



app.MapGet("/api/", () => "Welcome to Ecoomerce Site");
app.MapGet("/api/product", () => "List of Items available in Catalog");
app.MapGet("/api/cart", () => "List of Items in cart");
app.Run();


