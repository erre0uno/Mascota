using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MascotaFeliz.App.Persistencia;
using MascotaFeliz.App.Dominio;

namespace MascotaFeliz.App.Front.Pages
{
    public class EliminarModel : PageModel
    {
        private readonly IRepositorioDueno repositorioDueno;

        [BindProperty]
        public Dueno Dueno { get; set; }
        public EliminarModel(IRepositorioDueno repositorioDueno)
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

        public IActionResult OnPost()
        {
            if (Dueno.DuenoID!=0)
            {
                repositorioDueno.DeleteDueno(Dueno.DuenoID);
                return RedirectToPage("./lista");
            }
            else
            {
                return Page();
            }
        }

    }
}
