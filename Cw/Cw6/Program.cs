using Cw6.WarehouseV2;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IProductWarehouseRepository, ProductWarehouseRepository>();
builder.Services.AddScoped<IProductWarehouseService, ProductWarehouseService>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.RegisterEndpointsForProductWarehouse();

app.UseHttpsRedirection();

app.Run();
