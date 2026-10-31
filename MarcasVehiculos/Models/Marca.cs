using System.ComponentModel.DataAnnotations;

namespace MarcasVehiculos.Models
{
    public class Marca
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre de la marca es obligatorio.")]
        [StringLength(80, MinimumLength = 2,
            ErrorMessage = "El nombre debe tener entre 2 y 80 caracteres.")]
        [Display(Name = "Nombre de la marca")]
        public string Nombre { get; set; } = string.Empty;

        [StringLength(60, ErrorMessage = "El país no puede superar 60 caracteres.")]
        [Display(Name = "País de origen")]
        public string? PaisOrigen { get; set; }

        public ICollection<Vehiculo> Vehiculos { get; set; } = new List<Vehiculo>();
    }
}