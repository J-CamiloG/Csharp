using System;
using MiApp.TiposDeDatos;
using MiApp.NumerosYMetodos;
using MiApp.StringYMetodos;

namespace MiApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instanciamos la clase ClaseDeTipos y llamamos a su método MostrarTiposDeDatos
            ClaseDeTipos miObjetoDatos = new ClaseDeTipos();
            miObjetoDatos.MostrarTiposDeDatos();

            // Instanciamos la clase ClaseDeNumerosYMetodos y llamamos a su método MostrarMetodosNumeros
            ClaseDeNumerosYMetodos miObjetoNumerosYMetodos = new ClaseDeNumerosYMetodos();
            miObjetoNumerosYMetodos.MostrarMetodosNumeros();

            // Instanciamos la clase ClaseDeStringYMetodos y llamamos a su método MostrarStringYMetodos
            ClaseDeStringYMetodos miObjetoStringYMetodos = new ClaseDeStringYMetodos();
            miObjetoStringYMetodos.MostrarStrindYMetodos();
        }
    }
}
