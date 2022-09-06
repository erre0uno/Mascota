using System.ComponentModel.DataAnnotations;


namespace MascotaFeliz.App.Dominio
{

    public enum Estado
    {
        activo,
        inactivo
    }

    public class Mascota
    {
        //atributos
        public int MascotaID { get; set; }

        //referencias
        public int MedicoID {get; set;}
        public int HistoriaID {get; set;}

        //atributos
        [Required]
        [Display(Name = "Nombre ")]
        [StringLength(50, ErrorMessage = "Nombre no puede exceder 50 caracteres.")]
        public string Nombre { get; set; }

        [Required]
        [Display(Name = "Color ")]
        [StringLength(50, ErrorMessage = "Color no puede exceder 50 caracteres.")]
        public string Color { get; set; }

        [Required]
        [Display(Name = "Especie ")]
        [StringLength(50, ErrorMessage = "Especie no puede exceder 50 caracteres.")]
        public string Especie { get; set; }

        [Display(Name = "Raza ")]
        [StringLength(50, ErrorMessage = "Raza no puede exceder 50 caracteres.")]
        public string Raza { get; set; }

        [Display(Name = "Estado ")]
        public Estado? Estado { get; set; }

        //atributoEntidad
        public virtual Medico Medico { get; set; }
        public virtual Historia Historia { get; set; }

        public Mascota(){
            Estado=Dominio.Estado.activo;
        }

    }
}