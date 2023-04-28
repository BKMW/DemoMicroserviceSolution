using MongoDB.Driver;
using OrderWebApi.Data;
using OrderWebApi.Dtos;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.Configure<DatabaseSettings>(builder.Configuration.GetSection("OrderStoreDatabase"));

builder.Services.AddSingleton<IContext, Context>();
//builder.Services.AddScoped<IContext, Context>();

//builder.Services.AddScoped(typeof(IRepository<>), typeof(MongoRepository<>));

builder.Services.AddSingleton<IMongoClient>(s =>
{
    var mongoUrl = new MongoUrl("mongodb://orderdb:27017");
    return new MongoClient(mongoUrl);
});

builder.Services.AddSingleton<IMongoDatabase>(s =>
{
    var client = s.GetService<IMongoClient>();
    return client.GetDatabase("dms-order");
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

app.UseAuthorization();

app.MapControllers();

//using (var scope = app.Services.CreateScope())
//{
//    try
//    {
//        var service = scope.ServiceProvider.GetRequiredService<IContext>();
//        await Seed.SeedData(service.Orders);
//    }
//    catch (Exception ex)
//    {
//        app.Logger.LogError(ex, "An error occurred during migration");
//    }
//}

app.Run();
