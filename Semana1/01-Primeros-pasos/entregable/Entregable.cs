using System;


namespace MiApp.Entregable
{
    public class ClassEntregable
    {
        public void printEntregable()
        {
            //Nota: cuando estes revisando solo es llamar a la funcion que quieres que se ejecute para que la revises
            //para que no tengas que imprimir todo en la consolo, solo lo necesario

            //practicaEnListaNumbers();
            //practicaEnListaStrings();

            static void  practicaEnListaNumbers()
            {
                Console.WriteLine(@"
            ******************************************
                    entregable  Taller  LINQ
            ------------------------------------------
            ");

                //Filtrar y mostrar solo los números pares de la lista numbers
                Console.WriteLine("-----------------------------------------------");
                Console.WriteLine("Filtrar y mostrar solo los números pares de la lista numbers");
                List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
                
                var numerosFiltrados = numbers.Where( x => x % 2 == 0 ).ToList();
                foreach (var item in numerosFiltrados)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("-----------------------------------------------");

                //Usando LINQ, calcular la suma de todos los números impares en la lista numbers
                Console.WriteLine("-----------------------------------------------");
                Console.WriteLine("Usando LINQ, calcular la suma de todos los números impares en la lista numbers");

                var numerosSumados = numbers.Sum();
                Console.WriteLine(numerosSumados);
                Console.WriteLine("-----------------------------------------------");

                //Ordenar de manera descendente los números mayores que 5 en la lista numbers
                Console.WriteLine("-----------------------------------------------");
                Console.WriteLine("Ordenar de manera descendente los números mayores que 5 en la lista numbers");

                var numeroOdenados = numbers.OrderByDescending(x => x ).ToList();
                foreach (var item in numeroOdenados)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("-----------------------------------------------");

                //Contar cuántos números son menores o iguales a 3 en la lista numbers.
                Console.WriteLine("-----------------------------------------------");
                Console.WriteLine("Contar cuántos números son menores o iguales a 3 en la lista numbers.");

                var numerosMayoresQueTres = numbers.Where(x => x <= 3).ToList();

                Console.WriteLine($"los numeros mayores o iguales a 3 que hay son {numerosMayoresQueTres.Count} y son los siguientes:" );
                foreach (var item in numerosMayoresQueTres)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("-----------------------------------------------");

                //Seleccionar cada número en la lista numbers y multiplicarlo por 2
                Console.WriteLine("-----------------------------------------------");
                Console.WriteLine("Seleccionar cada número en la lista numbers y multiplicarlo por 2");

                var numerosMultiplicados = numbers.Select( x => x * 2).ToList();

                foreach (var item in numerosMultiplicados)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("-----------------------------------------------");
                }
            
            static void practicaEnListaStrings()
            {
                Console.WriteLine(@"
            ******************************************
                    entregable  Taller  LINQ Strings
            ------------------------------------------
            ");

                List<string> names = new List<string> { "Alice", "Bob", "Charlie", "David","Eve" };

                //Ordenar los nombres en la lista names alfabéticamente
                Console.WriteLine("-----------------------------------------------");
                Console.WriteLine("Ordenar los nombres en la lista names alfabéticamente");
                
                var nombresOrdenados = names.Order().ToList();
                foreach (var item in nombresOrdenados)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("-----------------------------------------------");

                //Seleccionar los nombres en la lista names que empiezan con la letra 'A'.
                Console.WriteLine("-----------------------------------------------");
                Console.WriteLine("Seleccionar los nombres en la lista names que empiezan con la letra 'A'.");

                var nombreComenzando = names.Where( x => x.StartsWith('A')).ToList();

                foreach (var item in nombreComenzando)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("-----------------------------------------------");

                // Contar cuántos nombres en la lista names tienen más de 5 caracteres.
                Console.WriteLine("-----------------------------------------------");
                Console.WriteLine("Contar cuántos nombres en la lista names tienen más de 5 caracteres.");

                var nombres5 = names.Count(name => name.Length > 5);
                Console.WriteLine($"Nombres con más de 5 caracteres: {nombres5}");

                Console.WriteLine("-----------------------------------------------");

                // Concatenar todos los nombres de la lista names en una sola cadena separada por espacios.
                Console.WriteLine("-----------------------------------------------");
                Console.WriteLine("Concatenar todos los nombres de la lista names en una sola cadena separada por espacios.");

                var namesConcatenados = String.Join(" ", names);
                Console.WriteLine($"Nombres concatenados: {namesConcatenados}");

                Console.WriteLine("-----------------------------------------------");

                // Encontrar y mostrar el nombre más largo en la lista names.
                Console.WriteLine("-----------------------------------------------");
                Console.WriteLine(" // Encontrar y mostrar el nombre más largo en la lista names.");

                var largerName = names.OrderByDescending(name => name.Length).FirstOrDefault();
                Console.WriteLine($"Nombre más largo: {largerName}");

                Console.WriteLine("-----------------------------------------------");

                Console.WriteLine(@"
            ******************************************
            entregable  Taller  LINQ Strings parte 2 
            ------------------------------------------
            ");

                List<string> words = new List<string> { "apple", "banana", "cherry", "date",
                "elderberry" };

                // Verificar si todas las palabras en la lista words tienen más de 3 caracteres.

                Console.WriteLine("\n---------------Ejercicios con strings parte 2-----------------\n");

                var words3 = words.All(word => word.Length > 3);
                Console.WriteLine($"Todas tienen más de 3 caracteres: {words3}");


                // Encontrar y mostrar la primera palabra en la lista words que empieza con la letra 'b'.

                var wordB = words.FirstOrDefault(word => word.StartsWith('b'));
                Console.WriteLine($"La primera palabra que empieza por b es: {wordB}");

                // Contar cuántas palabras en la lista words contienen la letra 'e'.

                var wordsE = words.Count(word => word.Contains('e'));
                Console.WriteLine($"Palabras que contienen la letra 'e': {wordsE}");

                // Seleccionar todas las palabras en la lista words y convertirlas a mayúsculas.

                var wordsMayus = words.Select(word => word.ToUpper());
                foreach (var word in wordsMayus)
                {
                    Console.WriteLine(word);
                }

                // Verificar si alguna palabra en la lista words termina con la letra 'y'.

                var endsY = words.Any(word => word.EndsWith('y'));
                Console.WriteLine($"Alguna palabra termina con y: {endsY}");

                // -- Ejercicios con listas
                Console.WriteLine(@"
                ******************************************
                entregable  Taller Ejercicios con Listas
                ------------------------------------------
                ");

                List<int> data = new List<int> { 2, 5, 1, 6, 3, 8, 4, 7, 9 };
                List<int> moreData = new List<int> { 10, 12, 15, 11, 14, 13 };

                // Combinar y ordenar las listas data y moreData de forma ascendente.

                var combinadas = data.Concat(moreData).OrderBy(c => c);

                Console.WriteLine("Listas combinadas y ordenadas de manera ascendente");

                foreach (var c in combinadas)
                {
                    Console.WriteLine($"{c}");
                }


                // Calcular la suma de todos los números pares en la lista data.

                var sumaParesData = data.Where(n => n % 2 == 0).Sum();
                Console.WriteLine($"Suma de pares: {sumaParesData}");

                // Encontrar el número más grande en la lista data.
                var mayorData = data.Max();
                Console.WriteLine($"Número más grande: {mayorData}");

                // Unir las listas data y moreData, eliminando los elementos duplicados.

                var combinadas2 = data.Union(moreData);

                Console.WriteLine("Listas combinadas sin duplicados: ");

                foreach (var c in combinadas2)
                {
                    Console.WriteLine($"{c}");
                }

                // Calcular el promedio de la lista moreData y seleccionar los números en data que son mayores que ese promedio.

                var dataMayores = moreData.Where(data => data > moreData.Average());

                Console.WriteLine("Promedio: " + moreData.Average());

                Console.WriteLine("Mayores del promedio: ");

                foreach (var dataMayor in dataMayores)
                {
                    Console.WriteLine(dataMayor);
                }

                // Contar cuántos números en la lista moreData son números primos(te recomiendo crear una función independiente que valide si el número es primo o no lo es, luego esa funciona pasala al método LINQ adecuado).

                var numerosPrimos = moreData.Count(n => revisarPrimo(n));
                Console.WriteLine($"Numeros primos: {numerosPrimos}");

                static bool revisarPrimo(int number)
                {
                    if (number <= 1 || (number % 2 == 0 && number != 2)) return false;
                    for (int i = 3; i < Math.Sqrt(number); i += 2)
                    {
                        if (number % i == 0) return false;
                    }
                    return true;
                }
            }
        }

    }

}