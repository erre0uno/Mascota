
namespace MascotaFeliz.App.Dominio
{

    public class Class1
    {
        static void Main(string[] args)
        {
            Persona p = new Persona
            {
                Nombres = "andres",
                Apellidos = "montealegre",
                Direccion = "calle",
            };
            Console.WriteLine(p.Nombres);
        }
    }
}