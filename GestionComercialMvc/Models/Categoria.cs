using System.ComponentModel.DataAnnotations;

namespace GestionComercialMvc.Models
{
    public class Categoria
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        [StringLength(50)]
        public string Nombre { get; set; } = string.Empty;

        [StringLength(150)]
        public string Descripcion { get; set; } = string.Empty;

        // Relación con Productos
        public ICollection<Producto>? Productos { get; set; }
    }
}