using Microsoft.EntityFrameworkCore;
using MarcasVehiculos.Models;

namespace MarcasVehiculos.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public DbSet<Vehiculo> Vehiculos { get; set; }
    }
}