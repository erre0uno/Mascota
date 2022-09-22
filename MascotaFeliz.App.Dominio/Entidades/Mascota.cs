using System.ComponentModel.DataAnnotations;


namespace MascotaFeliz.App.Dominio
{
    public class Mascota
    {
        //atributos
        public int MascotaID { get; set; }

        //atributos
        [Required]
        [Display(Name = "Nombre ")]
        [StringLength(50, ErrorMessage = "Nombre no puede exceder 50 caracteres.")]
        public string Nombre { get; set; } = null!;

        [Required]
        [Display(Name = "Color ")]
        [StringLength(50, ErrorMessage = "Color no puede exceder 50 caracteres.")]
        public string Color { get; set; } = null!;

        [Required]
        [Display(Name = "Especie ")]
        [StringLength(50, ErrorMessage = "Especie no puede exceder 50 caracteres.")]
        public string Especie { get; set; } = null!;

        [Display(Name = "Raza ")]
        [StringLength(50, ErrorMessage = "Raza no puede exceder 50 caracteres.")]
        public string? Raza { get; set; }


        //referencias
        /*
        public int MedicoID { get; set; }
        public int DuenoID { get; set; }
        */
        
        //atributoEntidad
        public virtual Medico Medico { get; set; } = null!;
        public virtual Dueno Dueno { get; set; } = null!;

    }
}