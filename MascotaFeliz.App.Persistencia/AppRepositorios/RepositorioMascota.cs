using System.Collections.Generic;
using MascotaFeliz.App.Dominio;
using System.Linq;


namespace MascotaFeliz.App.Persistencia
{

    public class RepositorioMascota :IRepositorioMascota
    {
        private readonly AppDbContext _appContext;

        public  RepositorioMascota(AppDbContext appContext){
            _appContext=appContext;
        }

        Mascota IRepositorioMascota.AddMascota(Mascota mascota){
            var mascotaAdicionado= _appContext.Mascotas.Add(mascota);
            _appContext.SaveChanges();
            return mascotaAdicionado.Entity;
            //throw new System.NotImplementedException();
        }
        Mascota IRepositorioMascota.UpdateMascota(Mascota _mascota){
        var mascotaEncontrado =_appContext.Mascotas.FirstOrDefault(m => m.MascotaID == _mascota.MascotaID );
            if (mascotaEncontrado != null){
                mascotaEncontrado.Nombre = _mascota.Nombre;
                mascotaEncontrado.Color = _mascota.Color;
                mascotaEncontrado.Especie= _mascota.Especie;
                mascotaEncontrado.Raza = _mascota.Raza;

                _appContext.SaveChanges();
            }
            return mascotaEncontrado;
        }
        IEnumerable<Mascota> IRepositorioMascota.GetAllMascotas(){
            return _appContext.Mascotas;
        }
        int IRepositorioMascota.DeleteMascota(int id){
            var mascotaEncontrado = _appContext.Mascotas.FirstOrDefault(m =>m.MascotaID == id);
            if (mascotaEncontrado == null)
                return 0;
            _appContext.Mascotas.Remove(mascotaEncontrado);
            _appContext.SaveChanges();
            return 1;    
        }
        Mascota IRepositorioMascota.GetMascota(int id){
            return _appContext.Mascotas.FirstOrDefault(m =>m.MascotaID == id);
        }

    }

}