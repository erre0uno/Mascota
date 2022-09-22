using System;
using System.ComponentModel.DataAnnotations;


namespace MascotaFeliz.App.Dominio
{
    public class Visita
    {
        //atributos
        public int VisitaID { get; set; }

        /*
        [Display(Name = "Fecha Visita ")]
        [StringLength(10, ErrorMessage = "Fecha Visita no puede exceder 11 caracteres.")]
        public string FechaVisita { get; set; } = null!;
        */
        
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime FechaVisita { get; set; }

        [Required]
        [Display(Name = "Temperatura ")]
        public float Temperatura { get; set; } 

        [Required]
        [Display(Name = "Peso ")]
        public float Peso { get; set; }

        [Required]
        [Display(Name = "FrecuenciaCardiaca ")]
        public int FrecuenciaCardiaca { get; set; } 

        [Required]
        [Display(Name = "Frecuencia Respiratoria ")]
        public int FrecuenciaRespiratoria { get; set; }

        [Required]
        [Display(Name = "Estado Animo ")]
        public string EstadoAnimo { get; set; } = null!;

        [Display(Name = "Recomendaciones ")]
        [StringLength(100, ErrorMessage = "Recomendaciones no puede exceder 100 caracteres.")]
        public string? Recomendacion { get; set; }


        //atributoRelacion
        /*
        public int MedicoID { get; set; } 
        public int HistoriaID{ get; set; }
        */
        
        //atributoEntidad
        public virtual Medico Medico { get; set; } = null!;
    //    public virtual Historia Historia { get; set; } = null!;

    }

}