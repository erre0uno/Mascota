using System.ComponentModel.DataAnnotations;


namespace MascotaFeliz.App.Dominio
{
    public class Medico  
    {
        public int MedicoID { get; set; } 
        
        [Required]
        [Display(Name = "Nombres ")]
        [StringLength(50, ErrorMessage = "Nombre no puede exceder 50 caracteres.")]
        public string Nombres { get; set; } = null!;
        
        [Required]
        [Display(Name = "Apellidos ")]
        [StringLength(50, ErrorMessage = "Apellido no puede exceder 50 caracteres.")]
        public string Apellidos { get; set; } = null!;

        [Required]
        [Display(Name = "Direccion ")]
        [StringLength(80, ErrorMessage = "Direccion no puede exceder 80 caracteres.")]
        public string Direccion { get; set; } = null!;

        [Required]
        [Display(Name = "Telefono ")]
        [StringLength(21, ErrorMessage = "Telefono no puede exceder 21 caracteres.")]
        public string Telefono { get; set; } = null!;

        [Required]
        [Display(Name = "Tarjeta ")]
        [StringLength(10, ErrorMessage = "Tarjeta no puede exceder 10 caracteres.")]
        public string Tarjeta {get; set;} = null!;

    }

}