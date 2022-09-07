using System;
using MascotaFeliz.App.Dominio;
using MascotaFeliz.App.Persistencia;

namespace MascotaFeliz.App.Consola
{
    class program
    {
        private static IRepositorioPersona repoPersona = new RepositorioPersona(new Persistencia.AppContext());
        private static IRepositorioMedico repoMedico = new RepositorioMedico(new Persistencia.AppContext());
        private static IRepositorioDueno repoDueno = new RepositorioDueno(new Persistencia.AppContext());

        static void Main(string[] args)
        {
            Console.WriteLine("saludos estamos en pruebas ");
            //AddPersona();
            //Consola.program.AddPersona();
            //AddMedico();
            //BuscarMedico(3);
            //BorrarMedico(5);
            //GetMedicos();
            //GetDuenos();

            Console.WriteLine("prueba Culminada !! ");
        }

        private static void AddPersona()
        {

            /*
            var med = new Medico{ 
                Nombres="Nelson Andres",
                Apellidos="Montealegre",
                Direccion="Calle",
                Tarjeta="abc123"
            };
            repoPersona.AddPersona(med);
            */

            /*
            var due = new Dueno{ 
                Nombres="Nelson Andres",
                Apellidos="Montealegre",
                Direccion="Calle",
                Correo="abc123@gmail.com"
            };
            repoPersona.AddPersona(due);
            */
        }
        private static void AddMedico()
        {

            var med = new Medico
            {
                Nombres = "Andres medico",
                Apellidos = "Montealegre medico",
                Direccion = "Calle",
                Tarjeta = "abc123"
            };
            repoMedico.AddMedico(med);

        }
        private static void BuscarMedico(int id)
        {
            try
            {
                var med = repoMedico.GetMedico(id);
                Console.WriteLine("Medico " + med.Nombres + " " + med.Apellidos + " tipo=" + med.GetType() + " ");
            }
            catch (Exception e)
            {
                Console.WriteLine("Medico no encontrado");
            }
        }
        private static void BorrarMedico(int id){
            try
            {
                var result = repoMedico.DeleteMedico(id);
                if(result == 0 ){
                    Console.WriteLine("Medico no encontrado");
                }else{
                    Console.WriteLine("Medico Eliminado");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine( e.GetBaseException() );
            }
        }
        private static void GetMedicos()
        {
            try
            {
                var med = repoMedico.GetAllMedicos();
                foreach (var item in med)
                {
                    Console.WriteLine("Medico " + item.Nombres + " " + item.Apellidos);
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.GetBaseException());
            }
        }
        private static void GetDuenos()
        {
            try
            {
                var duenos = repoDueno.GetAllDuenos();
                foreach (var item in duenos)
                {
                    Console.WriteLine("Dueños " + item.Nombres + " " + item.Apellidos);
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.GetBaseException());
            }
        }

                private static void BorrarDueno(int id){
            try
            {
                var result = repoDueno.DeleteDueno(id);
                if(result == 0 ){
                    Console.WriteLine("Dueno no encontrado");
                }else{
                    Console.WriteLine("Dueno Eliminado");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine( e.GetBaseException() );
            }
        }

    }
}