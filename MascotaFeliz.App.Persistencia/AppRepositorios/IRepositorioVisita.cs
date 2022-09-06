
using System.Collections.Generic;
using MascotaFeliz.App.Dominio;

namespace MascotaFeliz.App.Persistencia
{
    public interface IRepositorioVisita
    {
        IEnumerable<Visita> GetAllVisitas();
        Visita AddVisita(Visita visita);
        Visita UpdateVisita(Visita visita);
        int DeleteVisita(int id);
        Visita GetVisita(int id);

    }
}