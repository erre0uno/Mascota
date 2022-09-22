using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MascotaFeliz.App.Persistencia;
using MascotaFeliz.App.Dominio;
using System.Threading.Tasks;


namespace MascotaFeliz.App.Front.Pages
{
    //[BindProperties]
    public class EditarModel : PageModel
    {
        private readonly IRepositorioDueno repositorioDueno;
        
        [BindProperty]
        public Dueno Dueno { get; set; }
        public String alert{get ; set ;} = null;
        
        public EditarModel(IRepositorioDueno repositorioDueno)
        {
            this.repositorioDueno = repositorioDueno;
        }
        public IActionResult OnGet(int? duenoId)
        {   
            
            if(duenoId.HasValue){
                Dueno = repositorioDueno.GetDueno(duenoId.Value);
            }
            else{
                Dueno = new Dueno();
            }
            
            if (Dueno == null){
                return RedirectToPage("../Error");
            }
            else{
                return Page();
            }
        }
        public IActionResult OnPost()
        {   
            // update
            if(Dueno.DuenoID>0){
                Dueno = repositorioDueno.UpdateDueno(Dueno);
                alert="Editado corectamente";
                return Page();
            }
            else // nuevo
            {
                try{
                    repositorioDueno.AddDueno(Dueno);
                    alert="Creado corectamente";
                    return Page();

                }catch(Exception e){
                    ModelState.AddModelError("",e.InnerException.Message);
                    //ModelState.AddModelError("",e.Message);
                    return Page();
                }
            }
            return RedirectToPage("./lista");
        }

        /*
        
        // GET: Duenos/Create
        public IActionResult Create()
        {
            return RedirectToPage("./lista");
        }

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("DuenoID,Nombres,Apellidos,Direccion,Telefono,Correo")] Dueno dueno)
        {
            if (!ModelState.IsValid)
            {
                repositorioDueno.AddDueno(dueno);
                //await repositorioDueno.SaveChangesAsync();
                return RedirectToPage("./lista");
            }
            return RedirectToPage("./lista");
        }

        */






    }
}
