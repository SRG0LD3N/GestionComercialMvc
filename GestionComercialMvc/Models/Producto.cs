using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GestionComercialMvc.Models
{
    public class Producto
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre del producto es obligatorio")]
        [StringLength(100)]
        public string Nombre { get; set; } = string.Empty;

        [Column(TypeName = "decimal(18,2)")]
        public decimal Precio { get; set; }

        public int Stock { get; set; }

        // Clave foránea hacia Categoria
        public int CategoriaId { get; set; }
        public Categoria? Categoria { get; set; }
    }
}