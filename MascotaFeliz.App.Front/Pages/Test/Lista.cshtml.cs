using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using MascotaFeliz.App.Persistencia;
using MascotaFeliz.App.Dominio;

#pragma warning restore format

namespace MascotaFeliz.App.Front.Pages
{
    public class ListaModel : PageModel
    {
        private readonly IRepositorioDueno repositorioDueno;
        public IEnumerable<Dueno> Duenos { get; set; } 
        public ListaModel(IRepositorioDueno repositorioDueno)
        {
            this.repositorioDueno = repositorioDueno;
        }
        public void OnGet()
        {
            Duenos = repositorioDueno.GetAllDuenos();
        }
    }
}
