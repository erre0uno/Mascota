using System;
using System.ComponentModel.DataAnnotations;


namespace MascotaFeliz.App.Dominio
{
    public enum EstadoAnimo
    {
        Excelente,
        Bueno,
        Regular,
        Malo,
        Grave
    }

    public class Visita
    {
        //atributos
        public int VisitaID { get; set; }

        //atributoRelacion
        public int MedicoID { get; set; }

        [Required]
        [Display(Name = "Fecha Visita ")]
        [StringLength(10, ErrorMessage = "Fecha Visita no puede exceder 11 caracteres.")]
        public string FechaVisita { get; set; }

        [Display(Name = "Temperatura ")]
        public float Temperatura { get; set; }

        [Display(Name = "Peso ")]
        public float Peso { get; set; }

        [Display(Name = "FrecuenciaCardiaca ")]
        public int FrecuenciaCardiaca { get; set; }

        [Display(Name = "Frecuencia Respiratoria ")]
        public int FrecuenciaRespiratoria { get; set; }

        [Display(Name = "Estado Animo ")]
        public EstadoAnimo? EstadoAnimo { get; set; }

        [Display(Name = "Recomendaciones ")]
        [StringLength(100, ErrorMessage = "Recomendaciones no puede exceder 100 caracteres.")]
        public string Recomendacion { get; set; }

        //atributoEntidad
        public virtual Medico Medico { get; set; }

    }

}