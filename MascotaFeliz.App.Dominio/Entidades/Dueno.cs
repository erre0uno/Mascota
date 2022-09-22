using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace MascotaFeliz.App.Dominio
{
    public class Dueno 
    {
        public Dueno()
        {
            ListaMascotas = new HashSet<Mascota>();
        }
        public int DuenoID { get; set; } 
        
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
        [Display(Name = "Correo ")]
        [StringLength(65, ErrorMessage = "Correo no puede exceder 65 caracteres.")]
        public string Correo { get; set; } = null!;

        public ICollection<Mascota> ListaMascotas {get; set;}

    }
}