using DataInitializer;
using EFDataAccessLibrary.DataAccess;
using EFDataAccessLibrary.Models;
using MapCalculation;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<PlaceContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("Default"));
});

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;

    var context = services.GetRequiredService<PlaceContext>();
    if (context.Database.GetPendingMigrations().Any())
    {
        context.Database.Migrate();
    }

    if (context.Places.Count() == 0)
    {
        var places = DataProvider.InitData();
        context.AddRange(places);
        context.SaveChanges();

        for (double lat = Utils.mapEdges.MinLat; lat < Utils.mapEdges.MaxLat; lat += Utils.precision)
        {
            for (double lon = Utils.mapEdges.MinLon; lon < Utils.mapEdges.MaxLon; lon += Utils.precision)
            {
                Dictionary<string, Category> categories = new Dictionary<string, Category>();
                foreach (var key in Utils.CategoryToPaths.Keys)
                {
                    categories.Add(key, new Category
                    {
                        Name = key,
                        Distance = 999,
                    });
                }

                places.ForEach(place =>
                {
                    double distance = place.GetDistance(lat, lon);

                    if (distance < categories[place.Category].Distance)
                    {
                        categories[place.Category].Distance = distance;
                        categories[place.Category].Nearest = place;
                    }
                });

                foreach (KeyValuePair<string, Category> entry in categories)
                {
                    entry.Value.Times = entry.Value.Distance.ToTime();
                }

                Address address = new Address
                {
                    Lat = lat,
                    Lon = lon,
                    Categories = categories.Values.ToList()
                };

                context.Address.Add(address);
            }
        }

        context.SaveChanges();
    }
}

app.Run();
