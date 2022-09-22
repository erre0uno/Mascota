using System.Runtime.CompilerServices;
using System.Collections.Generic;
using MascotaFeliz.App.Dominio;
using System.Linq;


namespace MascotaFeliz.App.Persistencia
{
    public class RepositorioDueno : IRepositorioDueno
    {
        private readonly AppDbContext _appContext;
        private List<Dueno> ListaDueno;

        public RepositorioDueno(AppDbContext appContext)
        {
            _appContext = appContext;
        }

        public IEnumerable<Dueno> GetAllDuenos()
        {
            return _appContext.Duenos;
            //return ListaDueno = _appContext.Duenos.ToList<Dueno>();
            
        }

        public Dueno UpdateDueno(Dueno dueno)
        {
            var duenoEncontrado = _appContext.Duenos.FirstOrDefault(m => m.DuenoID == dueno.DuenoID);
            if (duenoEncontrado != null)
            {
                duenoEncontrado.Nombres = dueno.Nombres;
                duenoEncontrado.Apellidos = dueno.Apellidos;
                duenoEncontrado.Direccion = dueno.Direccion;
                duenoEncontrado.Telefono = dueno.Telefono;
                duenoEncontrado.Correo = dueno.Correo;
                _appContext.SaveChanges();
            }
            return duenoEncontrado;
        }
        public Dueno GetDueno(int duenoId)
        {   
            return _appContext.Duenos.FirstOrDefault(m => m.DuenoID == duenoId);
        }
        public Dueno AddDueno(Dueno dueno)
        {
            var duenoAdicionado = _appContext.Duenos.Add(dueno);
            _appContext.SaveChanges();
            return duenoAdicionado.Entity;
        }
        public int DeleteDueno(int duenoId)
        {
            var duenoEncontrado = _appContext.Duenos.FirstOrDefault(m => m.DuenoID == duenoId);
            if (duenoEncontrado == null)
                return 0;
            _appContext.Duenos.Remove(duenoEncontrado);
            _appContext.SaveChanges();
            return 1;
        }

    }
}