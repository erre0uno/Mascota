using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace MascotaFeliz.App.Dominio
{
    public class Dueno : Persona
    {
        //atributos
        [Required]
        [Display(Name = "Correo ")]
        [StringLength(65, ErrorMessage = "Correo no puede exceder 65 caracteres.")]
        public string Correo { get; set; }

        public ICollection<Mascota> ListaMascotas {get; set;}

    }
}