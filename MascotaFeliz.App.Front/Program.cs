using Microsoft.EntityFrameworkCore;
using MascotaFeliz.App.Persistencia;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


//Asociamos los repositorios a la capa de presentación para el uso del servicio DbContext.        
builder.Services.AddScoped<IRepositorioDueno , RepositorioDueno>();
//AppContext


/*
services.AddSingleton<PracticaVeterinaria.App.Persistencia.AppRepositorios.AppContext>();

builder.Services.AddDbContext<AppContext>(options =>
        options.UseSqlServer(builder.Configuration.GetConnectionString("conexion")));


builder.Services.AddDbContext<AppContext>;
builder.Services.AddDbContext<AppContext>(options=>options.UseSqlServer(
    builder.Configuration.GetConnectionString("*")
) );
*/

builder.Services.AddRazorPages();






var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
