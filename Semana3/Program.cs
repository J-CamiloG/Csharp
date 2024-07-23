using Semana3.models.polimorfismo;
namespace App;
class Program
{
    private static void Main(string[] args)
    {
        Console.Clear();
        Perro perroNuevo = new Perro();
        Gato gatoNuevo = new Gato();

        perroNuevo.hablar();
        gatoNuevo.hablar();
        gatoNuevo.deplazarse();
    }
}