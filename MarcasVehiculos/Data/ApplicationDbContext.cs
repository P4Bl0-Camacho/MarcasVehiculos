using Microsoft.EntityFrameworkCore;
using MarcasVehiculos.Models;

namespace MarcasVehiculos.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<MarcasVehiculos.Models.Marca> Marca { get; set; } = default!;
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public DbSet<Vehiculo> Vehiculos { get; set; }

        public DbSet<Marca> Marcas { get; set; }
    }
}