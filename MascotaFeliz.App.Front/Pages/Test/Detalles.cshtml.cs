using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MascotaFeliz.App.Persistencia;
using MascotaFeliz.App.Dominio;

namespace MascotaFeliz.App.Front.Pages
{
    public class DetallesModel : PageModel
    {
        private readonly IRepositorioDueno repositorioDueno;
        public Dueno Dueno { get; set; }
        public DetallesModel(IRepositorioDueno repositorioDueno)
        {
            this.repositorioDueno = repositorioDueno;
        }
        public IActionResult OnGet(int duenoId)
        {
            Dueno = repositorioDueno.GetDueno(duenoId);
            if (Dueno == null)
            {
                return RedirectToPage("../Error");
            }
            else
            {
                return Page();
            }
        }
    }
}
