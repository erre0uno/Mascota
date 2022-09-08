using System.Collections.Generic;
using MascotaFeliz.App.Dominio;
using System.Linq;


namespace MascotaFeliz.App.Persistencia
{
    public class RepositorioDueno : IRepositorioDueno
    {

        List<Dueno> ListaDuenos = new List<Dueno>();

        public RepositorioDueno()
        {
            ListaDuenos = new List<Dueno>(){
                new Dueno{PersonaID=10, Nombres="juan", Apellidos="juan", Direccion="calle",Correo="mail"},
                new Dueno{PersonaID=11, Nombres="pedro", Apellidos="pedro", Direccion="calle",Correo="mail"},
                new Dueno{PersonaID=12, Nombres="camila", Apellidos="camila", Direccion="calle",Correo="mail"}
            };
        }

        private readonly AppContext _appContext;
        public RepositorioDueno(AppContext appContext)
        {
            _appContext = appContext;
        }


        Dueno IRepositorioDueno.AddDueno(Dueno dueno)
        {
            var duenoAdicionado = _appContext.Duenos.Add(dueno);
            _appContext.SaveChanges();
            return duenoAdicionado.Entity;
            //throw new System.NotImplementedException();
        }
        Dueno IRepositorioDueno.UpdateDueno(Dueno _dueno)
        {
            var duenoEncontrado = _appContext.Duenos.FirstOrDefault(m => m.PersonaID == _dueno.PersonaID);
            if (duenoEncontrado != null)
            {
                duenoEncontrado.Nombres = _dueno.Nombres;
                duenoEncontrado.Apellidos = _dueno.Apellidos;
                duenoEncontrado.Direccion = _dueno.Direccion;
                duenoEncontrado.Correo = _dueno.Correo;
                _appContext.SaveChanges();
            }
            return duenoEncontrado;

        }

        IEnumerable<Dueno> IRepositorioDueno.GetAllDuenos()
        {
            return ListaDuenos;
            //return _appContext.Duenos;
        }

        int IRepositorioDueno.DeleteDueno(int id)
        {
            var duenoEncontrado = _appContext.Duenos.FirstOrDefault(m => m.PersonaID == id);
            if (duenoEncontrado == null)
                return 0;
            _appContext.Duenos.Remove(duenoEncontrado);
            _appContext.SaveChanges();
            return 1;
        }

        Dueno IRepositorioDueno.GetDueno(int id)
        {
            return _appContext.Duenos.FirstOrDefault(m => m.PersonaID == id);
            //return ListaDuenos.SingleOrDefault(m => m.PersonaID == id);
        }

    }
}