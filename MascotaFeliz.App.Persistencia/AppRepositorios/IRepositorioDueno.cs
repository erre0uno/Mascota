
using System.Collections.Generic;
using MascotaFeliz.App.Dominio;

namespace MascotaFeliz.App.Persistencia
{
    public interface IRepositorioDueno
    {
        IEnumerable<Dueno> GetAllDuenos();
        Dueno AddDueno(Dueno dueno);
        Dueno UpdateDueno(Dueno dueno);
        int DeleteDueno(int id);
        Dueno GetDueno(int id);

    }
}