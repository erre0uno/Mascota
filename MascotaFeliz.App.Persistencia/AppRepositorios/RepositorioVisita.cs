using System.Collections.Generic;
using MascotaFeliz.App.Dominio;
using System.Linq;


namespace MascotaFeliz.App.Persistencia
{

    public class RepositorioVisita :IRepositorioVisita
    {
        private readonly AppDbContext _appContext;

        public  RepositorioVisita(AppDbContext appContext){
            _appContext=appContext;
        }

        Visita IRepositorioVisita.AddVisita(Visita visita){
            var visitaAdicionado= _appContext.Visitas.Add(visita);
            _appContext.SaveChanges();
            return visitaAdicionado.Entity;
            //throw new System.NotImplementedException();
        }
        Visita IRepositorioVisita.UpdateVisita(Visita _visita){
            var visitaEncontrado =_appContext.Visitas.FirstOrDefault(m => m.VisitaID == _visita.VisitaID );
            if (visitaEncontrado != null){
                visitaEncontrado.FechaVisita = _visita.FechaVisita;
                visitaEncontrado.Temperatura = _visita.Temperatura;
                visitaEncontrado.Peso = _visita.Peso;
                visitaEncontrado.FrecuenciaCardiaca = _visita.FrecuenciaCardiaca;
                visitaEncontrado.FrecuenciaRespiratoria = _visita.FrecuenciaRespiratoria;
                visitaEncontrado.EstadoAnimo = _visita.EstadoAnimo;
                visitaEncontrado.Recomendacion = _visita.Recomendacion;
                //visitaEncontrado.MedicoID = _visita.MedicoID;

                _appContext.SaveChanges();
            }
            return visitaEncontrado;
        }
        IEnumerable<Visita> IRepositorioVisita.GetAllVisitas(){
            return _appContext.Visitas;
        }
        int IRepositorioVisita.DeleteVisita(int id){
            var visitaEncontrado = _appContext.Visitas.FirstOrDefault(m =>m.VisitaID == id);
            if (visitaEncontrado == null)
                return 0;
            _appContext.Visitas.Remove(visitaEncontrado);
            _appContext.SaveChanges();
            return 1;    
        }
        Visita IRepositorioVisita.GetVisita(int id){
            return _appContext.Visitas.FirstOrDefault(m =>m.VisitaID == id);
        }

    }

}