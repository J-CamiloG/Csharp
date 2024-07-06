using System;
// tener en cuenta que los bits en C# y la programación en 
//general son la base fundamental para la representación y manipulación de datos binarios, 
// por eso en la explicacion vas a encontrar en la descripcion de cada tipo de dato number su representacion en bits

namespace MiApp.TiposDeDatos
{
    public class ClaseDeTipos
    {
        public void MostrarTiposDeDatos()
        {
            //Tipos de datos primitivos
                // Numeros enteros:
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

                // Vamos a imprimir todas las variables
                    Console.WriteLine($"Numeros enteros: {numeroEntero}, {cantidadEntera}, {numeroCorto}, {cantidadCorta}, {poblacion}, {espacio}, {edad}, {temperatura}");
                    Console.WriteLine($"Numeros de punto flotante: {altura}, {pi}, {salario}");
                    Console.WriteLine($"Tipo caracter: {letra}");
                    Console.WriteLine($"Tipo booleano: {estado}");
                    Console.WriteLine($"Tipo string: {saludar}");
        }
    }
}


