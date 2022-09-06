
using System.Collections.Generic;
using MascotaFeliz.App.Dominio;

namespace MascotaFeliz.App.Persistencia
{
    public interface IRepositorioMedico
    {
        IEnumerable<Medico> GetAllMedicos();
        Medico AddMedico(Medico medico);
        Medico UpdateMedico(Medico medico);
        int DeleteMedico(int idmedico);
        Medico GetMedico(int idmedico);

    }
}