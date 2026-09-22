using System.ComponentModel.DataAnnotations;

namespace GestionComercialMvc.Models
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre completo es obligatorio")]
        [StringLength(100)]
        public string Nombre { get; set; } = string.Empty;

        [Required]
        [EmailAddress(ErrorMessage = "Correo electrónico no válido")]
        public string Email { get; set; } = string.Empty;

        [Phone]
        public string Telefono { get; set; } = string.Empty;
    }
}