using Basket;
using Catalog;
using Ordering;

var builder = WebApplication.CreateBuilder(args);

// Add Services to the container
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCatalogServices(builder.Configuration);
builder.Services.AddBasketServices(builder.Configuration);
builder.Services.AddOrderingServices(builder.Configuration);

var app = builder.Build();

// Configure the HTTP request pipeline
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapGet("/", () => "Hello World!");

app.Run();
