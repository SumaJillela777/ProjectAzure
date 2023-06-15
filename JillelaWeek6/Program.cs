using JillelaWeek6.Models; 
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
//get the output directory of the project
var path=Directory.GetCurrentDirectory();
//get access to connection string object through confirguration settings
IConfiguration configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
//DI passes the connstring to the context object with correct output directory path
builder.Services.AddDbContext<HogwartsContext>(option => option.UseSqlServer(configuration.GetConnectionString("AZURE_SQL_CONNECTIONSTRING").Replace("|DataDirectory|",path)));
builder.Services.AddStackExchangeRedisCache(options =>
{
options.Configuration = builder.Configuration["AZURE_REDIS_CONNECTIONSTRING"];
options.InstanceName = "SampleInstance";
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
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
