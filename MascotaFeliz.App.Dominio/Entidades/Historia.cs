using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace MascotaFeliz.App.Dominio
{

    public class Historia
    {
        public Historia(){
            listaVisitas = new HashSet<Visita>();
        }
        
        public int HistoriaID { get; set; }
        
/*      [Required]
        [Display(Name = "Fecha Creacion ")]
        [StringLength(10, ErrorMessage = "Fecha Visita no puede exceder 11 caracteres.")]
        public string FechaCreacion { get; set; } = DateTime.Now.ToString();
*/        

        [Required]
        [Display(Name = "Fecha Creacion ")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime FechaCreacion { get; set; } = DateTime.Now;       

        [Display(Name = "Diagnostico ")]
        [StringLength(60, ErrorMessage = "Diagnostico no puede exceder 65 caracteres.")]
        public string? Diagnostico { get; set; }

        [Display(Name = "Medicamentos ")]
        [StringLength(200, ErrorMessage = "Medicamentos no puede exceder 200 caracteres.")]
        public string? Medicamentos { get; set; }

        //int MascotaID { get; set; }
        public Mascota Mascota {get; set;} = null!;

        public virtual ICollection<Visita> listaVisitas { get;set;}
    }

}