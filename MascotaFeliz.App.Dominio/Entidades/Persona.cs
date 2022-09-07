using System.ComponentModel.DataAnnotations;

namespace MascotaFeliz.App.Dominio
{
    public class Persona
    {
        //atributos
        public int PersonaID { get; set; } // forma de propiedades // private int id; // forma 

        [Required]
        [Display(Name = "Nombres ")]
        [StringLength(50, ErrorMessage = "Nombre no puede exceder 50 caracteres.")]
        public string Nombres { get; set; }
        
        [Required]
        [Display(Name = "Apellidos ")]
        [StringLength(50, ErrorMessage = "Apellido no puede exceder 50 caracteres.")]
        public string Apellidos { get; set; }

        [Required]
        [Display(Name = "Direccion ")]
        [StringLength(80, ErrorMessage = "Direccion no puede exceder 80 caracteres.")]
        public string Direccion { get; set; }

       
    }
}