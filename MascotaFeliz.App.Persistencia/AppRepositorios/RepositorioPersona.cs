using System.Collections.Generic;
using MascotaFeliz.App.Dominio;
using System.Linq;


namespace MascotaFeliz.App.Persistencia
{
    public class RepositorioPersona :IRepositorioPersona
    {
        private readonly AppContext _appContext;

        public  RepositorioPersona(AppContext appContext){
            _appContext=appContext;
        }

        Persona IRepositorioPersona.AddPersona(Persona _persona){
            var personaAdicionado= _appContext.Personas.Add(_persona);
            _appContext.SaveChanges();
            return personaAdicionado.Entity;
            //throw new System.NotImplementedException();
        }
        Persona IRepositorioPersona.UpdatePersona(Persona _persona){
            var personaEncontrada =_appContext.Personas.FirstOrDefault(m => m.PersonaID == _persona.PersonaID);
            if (personaEncontrada != null){
                personaEncontrada.Nombres=_persona.Nombres;
                personaEncontrada.Apellidos=_persona.Apellidos;
                personaEncontrada.Direccion=_persona.Direccion;
                _appContext.SaveChanges();
            }
            return personaEncontrada;

        }
        IEnumerable<Persona> IRepositorioPersona.GetAllPersonas(){
            return _appContext.Personas;
        }
        int IRepositorioPersona.DeletePersona(int _idpersona){
            var personaEncontrada = _appContext.Personas.FirstOrDefault(m =>m.PersonaID == _idpersona);
            if (personaEncontrada == null)
                return 0;
            _appContext.Personas.Remove(personaEncontrada);
            _appContext.SaveChanges();
            return 1;    
        }
        Persona IRepositorioPersona.GetPersona(int _idpersona){
            return _appContext.Personas.FirstOrDefault(m =>m.PersonaID == _idpersona);
        }

    }



}
