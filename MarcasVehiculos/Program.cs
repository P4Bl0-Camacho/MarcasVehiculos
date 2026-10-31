using MarcasVehiculos.Data;
using Microsoft.EntityFrameworkCore;
var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("ApplicationDbContext") ?? throw new InvalidOperationException("Connection string 'ApplicationDbContext' not found.");

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Add services to the container.
builder.Services.AddControllersWithViews(options =>
{
    var mensajes = options.ModelBindingMessageProvider;
    mensajes.SetValueMustNotBeNullAccessor(_ => "Este campo es obligatorio.");
    mensajes.SetMissingBindRequiredValueAccessor(campo => $"Falta el valor de {campo}.");
    mensajes.SetMissingKeyOrValueAccessor(() => "Se requiere un valor.");
    mensajes.SetValueIsInvalidAccessor(valor => $"El valor '{valor}' no es válido.");
    mensajes.SetAttemptedValueIsInvalidAccessor((valor, campo) => $"El valor '{valor}' no es válido para {campo}.");
    mensajes.SetUnknownValueIsInvalidAccessor(campo => $"El valor ingresado no es válido para {campo}.");
    mensajes.SetNonPropertyUnknownValueIsInvalidAccessor(() => "El valor ingresado no es válido.");
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
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();


app.Run();
