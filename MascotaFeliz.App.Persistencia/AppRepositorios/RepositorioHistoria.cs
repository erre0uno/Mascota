using System.Collections.Generic;
using MascotaFeliz.App.Dominio;
using System.Linq;


namespace MascotaFeliz.App.Persistencia
{
    public class RepositorioHistoria :IRepositorioHistoria
    {
        private readonly AppDbContext _appContext;

        public  RepositorioHistoria(AppDbContext appContext){
            _appContext=appContext;
        }

        Historia IRepositorioHistoria.AddHistoria(Historia historia){
            var historiaAdicionado= _appContext.Historias.Add(historia);
            _appContext.SaveChanges();
            return historiaAdicionado.Entity;
            //throw new System.NotImplementedException();
        }
        Historia IRepositorioHistoria.UpdateHistoria(Historia _historia){
            var historiaEncontrado =_appContext.Historias.FirstOrDefault(m => m.HistoriaID == _historia.HistoriaID );
            if (historiaEncontrado != null){
                historiaEncontrado.Diagnostico = _historia.Diagnostico;
                historiaEncontrado.Medicamentos= _historia.Medicamentos;
                _appContext.SaveChanges();
            }
            return historiaEncontrado;

        }
        IEnumerable<Historia> IRepositorioHistoria.GetAllHistorias(){
            return _appContext.Historias;
        }
        int IRepositorioHistoria.DeleteHistoria(int id){
            var historiaEncontrado = _appContext.Historias.FirstOrDefault(m =>m.HistoriaID == id);
            if (historiaEncontrado == null)
                return 0;
            _appContext.Historias.Remove(historiaEncontrado);
            _appContext.SaveChanges();
            return 1;    
        }
        Historia IRepositorioHistoria.GetHistoria(int id){
            return _appContext.Historias.FirstOrDefault(m =>m.HistoriaID == id);
        }

    }
}