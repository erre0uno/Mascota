using System.Collections.Generic;
using MascotaFeliz.App.Dominio;
using System.Linq;


namespace MascotaFeliz.App.Persistencia
{
    public class RepositorioMedico :IRepositorioMedico
    {
        private readonly AppContext _appContext;

        public  RepositorioMedico(AppContext appContext){
            _appContext=appContext;
        }

        Medico IRepositorioMedico.AddMedico(Medico medico){
            var medicoAdicionado= _appContext.Medicos.Add(medico);
            _appContext.SaveChanges();
            return medicoAdicionado.Entity;
            //throw new System.NotImplementedException();
        }
        Medico IRepositorioMedico.UpdateMedico(Medico _medico){
            var medicoEncontrado =_appContext.Medicos.FirstOrDefault(m => m.PersonaID == _medico.PersonaID );
            if (medicoEncontrado != null){
                medicoEncontrado.Nombres= _medico.Nombres;
                medicoEncontrado.Apellidos= _medico.Apellidos;
                medicoEncontrado.Direccion= _medico.Direccion;
                medicoEncontrado.Tarjeta= _medico.Tarjeta;
                _appContext.SaveChanges();
            }
            return medicoEncontrado;

        }
        IEnumerable<Medico> IRepositorioMedico.GetAllMedicos(){
            return _appContext.Medicos;
        }
        int IRepositorioMedico.DeleteMedico(int idmedico){
            var medicoEncontrado = _appContext.Medicos.FirstOrDefault(m =>m.PersonaID == idmedico);
            if (medicoEncontrado == null)
                return 0;
            _appContext.Medicos.Remove(medicoEncontrado);
            _appContext.SaveChanges();
            return 1;    
        }
        Medico IRepositorioMedico.GetMedico(int idmedico){
            return _appContext.Medicos.FirstOrDefault(m =>m.PersonaID == idmedico);
        }

    }
}