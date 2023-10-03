global using BlazorShop.Shared;
global using BlazorShop.Client.Shared;
global using Microsoft.EntityFrameworkCore;
global using BlazorShop.Server.Data;
global using BlazorShop.Server.Services.ProductService;
global using BlazorShop.Server.Services.CategoryService;
global using BlazorShop.Server.Services.CartService;
using Microsoft.AspNetCore.Connections;
using Microsoft.AspNetCore.ResponseCompression;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<DataContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IProductService, ProductService>(); //when IPS injected, use PS as implementation, can change class if want to make changes
builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddScoped<BlazorShop.Server.Services.CartService.ICartService, CartService>();

var app = builder.Build();

app.UseSwaggerUI();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseSwagger();

app.UseHttpsRedirection();

app.UseBlazorFrameworkFiles();
app.UseStaticFiles();

app.UseRouting();


app.MapRazorPages();
app.MapControllers();
app.MapFallbackToFile("index.html");

app.Run();
