using System;

namespace MiApp.EjerciciosPractice
{
    public class ClassEjercicicosPractice
    {
        public class BaseDatosStrings
        {
            public int Id;
            public string Name;
            public int Edad;

            //cremos el contructor
            public BaseDatosStrings()
            {
                Name = ""; 
                Edad = 0;
            }

             // Constructor con parámetros
            public BaseDatosStrings(int id, string name, int edad)
            {
                Id = id;
                Name = name;
                Edad = edad;
            }
        }
        
        public class BaseDatosNumbers
        {
            public int Numero { get; set; }

            // Constructor
            public BaseDatosNumbers(int numero)
            {
                Numero = numero;
            }
        }
        
        public void printEjerciciosPractice()
        {
            //intanciamos las listas para trabajar con ellas
            List<BaseDatosStrings> listaPractica = new List<BaseDatosStrings>
            {
                new BaseDatosStrings(1, "Juan", 25),
                new BaseDatosStrings(2, "Ana", 30),
                new BaseDatosStrings(3, "Luis", 22),
                new BaseDatosStrings(4, "María", 28),
                new BaseDatosStrings(5, "Pedro", 35)
            };
            List<BaseDatosNumbers> listaPracticaNumeros = new List<BaseDatosNumbers>
            {
                new BaseDatosNumbers { Number = 1 },
                new BaseDatosNumbers { Number = 2 },
                new BaseDatosNumbers { Number = 3 },
                new BaseDatosNumbers { Number = 4 },
                new BaseDatosNumbers { Number = 5 },
                new BaseDatosNumbers { Number = 435 },
                new BaseDatosNumbers { Number = 345 },
                new BaseDatosNumbers { Number = 8 },
                new BaseDatosNumbers { Number = 1 },
                new BaseDatosNumbers { Number = 4 }
            };

            // 1. Filtra los números mayores a 10 en una lista de enteros.
            var numerosFiltrados = listaPracticaNumeros.Where(x => x.Numero > 10).ToList();
            
            foreach (var numero in numerosFiltrados)
            {
                Console.WriteLine(numero.Numero);
            }
            // 2. Obtén una lista con los cuadrados de cada número en una lista de enteros.
            // 3. Ordena alfabéticamente una lista de nombres.
            // 4. Ordena una lista de precios de mayor a menor.
            // 5. Encuentra el primer número par en una lista de enteros.
            // 6. Encuentra el último nombre en una lista de nombres.
            // 7. Obtén el primer número negativo en una lista de enteros, o un valor por defecto si no hay
            // ninguno.
            // 8. Encuentra el último número mayor a 50 en una lista de enteros, o un valor por defecto si
            // no hay ninguno.
            // 9. Verifica si algún elemento en una lista de booleanos es verdadero.
            // 10. Verifica si todos los elementos en una lista de números son mayores a 0.
            // 11. Comprueba si una lista de palabras contiene la palabra "LINQ".
            // 12. Cuenta cuántos números pares hay en una lista de enteros.
            // 13. Calcula la suma de los elementos en una lista de precios.
            // 14. Calcula el promedio de una lista de edades.
            // 15. Encuentra el número mínimo en una lista de temperaturas.
            // 16. Encuentra el número máximo en una lista de alturas.
            // 17. Obtén los primeros 5 elementos de una lista de puntuaciones.

        }
    }
}