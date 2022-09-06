using System.ComponentModel.DataAnnotations;


namespace MascotaFeliz.App.Dominio
{
    public class Medico : Persona
    {

        //atributos
        [Required]
        [Display(Name = "Tarjeta ")]
        [StringLength(10, ErrorMessage = "Tarjeta no puede exceder 10 caracteres.")]
        public string Tarjeta {get; set;}

    }

}