using backend.Data;
using backend.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<AppDbContext>(
    opt => opt.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection"))
);

builder.Services.AddScoped<IReceitaService,ReceitaService>();
builder.Services.AddScoped<IEtapaService,EtapaService>();
builder.Services.AddScoped<IIngredienteService,IngredienteService>();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors();

var app = builder.Build();

app.UseCors(options =>
{
    options.WithOrigins();
    options.AllowAnyMethod();
    options.AllowAnyHeader();
});

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapGet("/getallreceitas",async (IReceitaService service) => {
    var result = await service.GetAllReceitas();
    
    return Results.Ok(result);
});

app.MapGet("/getreceitas",async (IReceitaService service) => {
    var result = await service.GetReceitas();
    
    return Results.Ok(result);
});


app.MapGet("/getallingredientes",async (IIngredienteService service) => {
    var result = await service.GetAllIngredientes();
    
    return Results.Ok(result);
});

app.MapGet("/getalletapas",async (IEtapaService service) => {
    var result = await service.GetAllEtapas();
    
    return Results.Ok(result);
});


app.UseHttpsRedirection();

app.Run();


