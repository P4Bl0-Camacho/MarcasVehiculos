using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MarcasVehiculos.Models
{
    public class Vehiculo
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El modelo es obligatorio.")]
        [StringLength(100, MinimumLength = 2,
            ErrorMessage = "El modelo debe tener entre 2 y 100 caracteres.")]
        [Display(Name = "Modelo")]
        public string Modelo { get; set; } = string.Empty;

        [Required(ErrorMessage = "El año es obligatorio.")]
        [Range(1950, 2030, ErrorMessage = "El año debe estar entre 1950 y 2030.")]
        [Display(Name = "Año de fabricación")]
        public int Anio { get; set; }

        [Required(ErrorMessage = "El precio es obligatorio.")]
        [Range(1, 10000000, ErrorMessage = "El precio debe ser mayor que 0 y no superar 10 000 000.")]
        [Column(TypeName = "decimal(18,2)")]
        [Display(Name = "Precio (USD)")]
        public decimal Precio { get; set; }

        [Display(Name = "Marca")]
        public int MarcaId { get; set; }

        [Display(Name = "Marca")]
        public Marca? Marca { get; set; }
    }
}
