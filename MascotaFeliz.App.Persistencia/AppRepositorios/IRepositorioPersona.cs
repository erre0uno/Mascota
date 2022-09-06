using System.Collections.Generic;
using MascotaFeliz.App.Dominio;


namespace MascotaFeliz.App.Persistencia
{
    public interface IRepositorioPersona
    {
        IEnumerable<Persona> GetAllPersonas();
        Persona AddPersona(Persona _persona);
        Persona UpdatePersona(Persona _persona);
        int DeletePersona(int _idpersona);
        Persona GetPersona(int _idpersona);
    }
}
