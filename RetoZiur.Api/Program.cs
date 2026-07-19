var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
{
    options.AddPolicy("PermitirBlazor", policy =>
    {
        policy.AllowAnyOrigin()
              .AllowAnyMethod()
              .AllowAnyHeader();
    });
});

var app = builder.Build();

app.UseCors("PermitirBlazor");

var items = new List<Item>
{
    new() { Codigo = 29, Descripcion = "Ajuste al Inventario", VActiva = false },
    new() { Codigo = 51, Descripcion = "Avance Produccion", VActiva = false },
    new() { Codigo = 17, Descripcion = "Balance Inicial", VActiva = false }
};

app.MapGet("/api/items", () => items);

app.Run();