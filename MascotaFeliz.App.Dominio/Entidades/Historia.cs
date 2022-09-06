using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace MascotaFeliz.App.Dominio
{

    public class Historia
    {
        public int HistoriaID { get; set; }
        
        [Required]
        [Display(Name = "Fecha Creacion ")]
        [StringLength(10, ErrorMessage = "Fecha Visita no puede exceder 11 caracteres.")]
        public string FechaCreacion { get; set; }

        [Display(Name = "Diagnostico ")]
        [StringLength(60, ErrorMessage = "Diagnostico no puede exceder 65 caracteres.")]
        public string Diagnostico { get; set; }

        [Display(Name = "Medicamentos ")]
        [StringLength(200, ErrorMessage = "Medicamentos no puede exceder 200 caracteres.")]
        public string Medicamentos { get; set; }

        public virtual ICollection<Visita> listaVisitas { get;set;}
    }

}