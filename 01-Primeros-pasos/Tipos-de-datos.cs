//NOTA: En el codigo veras tendra muchos console.WriteLiene(), pero sera con el proposito de mostrar
//de una manera ordenada los datos que estamos representando en consola, lo que puedes ver 
//al comenzar el console es esta expresion "| {0,-15} | {1,20} |"   utiliza los llamados "formatos compuestos"
// en C# para dar formato a la salida.

// tener en cuenta que los bits en C# y la programación en 
//general son la base fundamental para la representación y manipulación de datos binarios, 
// por eso en la explicacion vas a encontrar en la descripcion de cada tipo de dato number su representacion en bits
using System;

namespace MiApp.TiposDeDatos
{
    public class ClaseDeTipos
    {
        public void MostrarTiposDeDatos()
        {
            // Encabezado de la tabla
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("-------------Tipos de datos primitivos----------------");
            Console.WriteLine("------------------------------------------------------");

            // Numeros enteros
            int numeroEntero = 10;  // Entero con signo de 32 bits.
            uint cantidadEntera = 100; // Entero sin signo de 32 bits.
            short numeroCorto = -100; // Entero con signo de 16 bits.
            ushort cantidadCorta = 500; // Entero sin signo de 16 bits.
            long poblacion = 8000000L; // Entero con signo de 64 bits.
            ulong espacio = 1000000UL; // Entero sin signo de 64 bits.
            byte edad = 25; // Entero sin signo de 8 bits.
            sbyte temperatura = -10; // Entero con signo de 8 bits.

            // Numeros de Punto flotante (con decimales)
            float altura = 1.75f; // Número de punto flotante de precisión simple de 32 bits.
            double pi = 3.14159; // Número de punto flotante de precisión doble de 64 bits.
            decimal salario = 3500.50m; // Número decimal de precisión alta de 128 bits.

            // Tipo Caracter
            char letra = 'a'; // Carácter Unicode de 16 bits.

            // Tipo Booleano
            bool estado = true;

            // Tipo string
            string saludar = "Hola mundo";

            // Imprimir todas las variables
            Console.WriteLine("| {0,-20} | {1,20} |", "Tipo", "Valor");
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("| {0,-20} | {1,20} |", "Entero (int)", numeroEntero);
            Console.WriteLine("| {0,-20} | {1,20} |", "Entero sin signo (uint)", cantidadEntera);
            Console.WriteLine("| {0,-20} | {1,20} |", "Corto (short)", numeroCorto);
            Console.WriteLine("| {0,-20} | {1,20} |", "Corto sin signo (ushort)", cantidadCorta);
            Console.WriteLine("| {0,-20} | {1,20} |", "Largo (long)", poblacion);
            Console.WriteLine("| {0,-20} | {1,20} |", "Largo sin signo (ulong)", espacio);
            Console.WriteLine("| {0,-20} | {1,20} |", "Byte", edad);
            Console.WriteLine("| {0,-20} | {1,20} |", "Byte con signo (sbyte)", temperatura);
            Console.WriteLine("| {0,-20} | {1,20} |", "Flotante (float)", altura);
            Console.WriteLine("| {0,-20} | {1,20} |", "Doble (double)", pi);
            Console.WriteLine("| {0,-20} | {1,20} |", "Decimal", salario);
            Console.WriteLine("| {0,-20} | {1,20} |", "Caracter (char)", letra);
            Console.WriteLine("| {0,-20} | {1,20} |", "Booleano (bool)", estado);
            Console.WriteLine("| {0,-20} | {1,20} |", "Cadena (string)", saludar);
            Console.WriteLine("------------------------------------------------------");
        }
    }
}


