using System;
using MiApp.TiposDeDatos;
using MiApp.NumerosYMetodos;
using MiApp.StringYMetodos;
using MiApp.PracticeLinQ;
using MiApp.EjerciciosPractice;
using MiApp.Entregable;

namespace MiApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // // Instanciamos la clase ClaseDeTipos y llamamos a su método MostrarTiposDeDatos
            // ClaseDeTipos miObjetoDatos = new ClaseDeTipos();
            // miObjetoDatos.MostrarTiposDeDatos();

            // // // // Instanciamos la clase ClaseDeNumerosYMetodos y llamamos a su método MostrarMetodosNumeros
            // ClaseDeNumerosYMetodos miObjetoNumerosYMetodos = new ClaseDeNumerosYMetodos();
            // miObjetoNumerosYMetodos.MostrarMetodosNumeros();

            // // // // Instanciamos la clase ClaseDeStringYMetodos y llamamos a su método MostrarStringYMetodos
            // ClaseDeStringYMetodos miObjetoStringYMetodos = new ClaseDeStringYMetodos();
            // miObjetoStringYMetodos.MostrarStrindYMetodos();
            
            // ClassPracticeLinQ miObjectPracticeLinQ = new ClassPracticeLinQ();
            // miObjectPracticeLinQ.primtPracticeLinQ();

            // ClassEjercicicosPractice miObjetoEjerciciosPractice = new ClassEjercicicosPractice();
            // miObjetoEjerciciosPractice.printEjerciciosPractice();\

            ClassEntregable miObjetoEntregable =  new ClassEntregable();
            miObjetoEntregable.printEntregable();
        }
    }
}
