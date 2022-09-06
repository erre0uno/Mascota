
using System.Collections.Generic;
using MascotaFeliz.App.Dominio;

namespace MascotaFeliz.App.Persistencia
{
    public interface IRepositorioHistoria
    {
        IEnumerable<Historia> GetAllHistorias();
        Historia AddHistoria(Historia historia);
        Historia UpdateHistoria(Historia historia);
        int DeleteHistoria(int id);
        Historia GetHistoria(int id);

    }
}