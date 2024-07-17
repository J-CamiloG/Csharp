//NOTA: En el codigo veras tendra muchos console.WriteLiene(), pero sera con el proposito de mostrar
//de una manera ordenada los datos que estamos representando en consola, lo que puedes ver 
//al comenzar el console es esta expresion "| {0,-15} | {1,20} |"   utiliza los llamados "formatos compuestos"
// en C# para dar formato a la salida.

// a continuacion veras un repertorio de metodos  
//para usar con el tipo de dato String ( cadenas de texto )
using System;

namespace MiApp.StringYMetodos
{
    public class ClaseDeStringYMetodos
    {
        public void MostrarStrindYMetodos()
        {
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("------------- Métodos de Cadenas en C# ---------------");
            Console.WriteLine("------------------------------------------------------");

                // Length: Obtiene la longitud de la cadena.
                string cadena = "Hola, mundo!";
                int longitud = cadena.Length;
                Console.WriteLine("| {0,-20} | {1,30} |", "Length", longitud);

                // ToUpper: Convierte la cadena a mayúsculas.
                string mayusculas = cadena.ToUpper();
                Console.WriteLine("| {0,-20} | {1,30} |", "ToUpper", mayusculas);

                // ToLower: Convierte la cadena a minúsculas.
                string minusculas = cadena.ToLower();
                Console.WriteLine("| {0,-20} | {1,30} |", "ToLower", minusculas);

                // Contains: Determina si una subcadena está presente en la cadena.
                bool contiene = cadena.Contains("mundo");
                Console.WriteLine("| {0,-20} | {1,30} |", "Contains(\"mundo\")", contiene);

                // StartsWith: Determina si la cadena comienza con una subcadena específica.
                bool empiezaCon = cadena.StartsWith("Hola");
                Console.WriteLine("| {0,-20} | {1,30} |", "StartsWith(\"Hola\")", empiezaCon);

                // EndsWith: Determina si la cadena termina con una subcadena específica.
                bool terminaCon = cadena.EndsWith("mundo!");
                Console.WriteLine("| {0,-20} | {1,30} |", "EndsWith(\"mundo!\")", terminaCon);

                // IndexOf: Devuelve la posición de la primera aparición de una subcadena.
                int indice = cadena.IndexOf("mundo");
                Console.WriteLine("| {0,-20} | {1,30} |", "IndexOf(\"mundo\")", indice);

                // LastIndexOf: Devuelve la posición de la última aparición de una subcadena.
                int ultimoIndice = cadena.LastIndexOf("o");
                Console.WriteLine("| {0,-20} | {1,30} |", "LastIndexOf(\"o\")", ultimoIndice);

                // Substring: Devuelve una subcadena a partir de una posición específica.
                string subcadena = cadena.Substring(5, 5);
                Console.WriteLine("| {0,-20} | {1,30} |", "Substring(5, 5)", subcadena);

                // Replace: Reemplaza todas las ocurrencias de una subcadena por otra.
                string reemplazada = cadena.Replace("mundo", "C#");
                Console.WriteLine("| {0,-20} | {1,30} |", "Replace(\"mundo\", \"C#\")", reemplazada);

                // Trim: Elimina todos los caracteres de espacio en blanco del inicio y el final de la cadena.
                string cadenaConEspacios = "  Hola, mundo!  ";
                string recortada = cadenaConEspacios.Trim();
                Console.WriteLine("| {0,-20} | {1,30} |", "Trim", recortada);

                // TrimStart: Elimina todos los caracteres de espacio en blanco del inicio de la cadena.
                string recortadaInicio = cadenaConEspacios.TrimStart();
                Console.WriteLine("| {0,-20} | {1,30} |", "TrimStart", recortadaInicio);

                // TrimEnd: Elimina todos los caracteres de espacio en blanco del final de la cadena.
                string recortadaFinal = cadenaConEspacios.TrimEnd();
                Console.WriteLine("| {0,-20} | {1,30} |", "TrimEnd", recortadaFinal);

                // Split: Divide una cadena en una matriz de subcadenas.
                string[] partes = cadena.Split(',');
                string partesUnidas = string.Join(" | ", partes);
                Console.WriteLine("| {0,-20} | {1,30} |", "Split(',')", partesUnidas);

                // Join: Une una matriz de cadenas en una sola cadena, separadas por un delimitador.
                string[] palabras = { "Hola", "mundo", "C#" };
                string unidas = string.Join("carmelo", palabras);
                Console.WriteLine("| {0,-20} | {1,30} |", "Join(\" \", {\"Hola\", \"mundo\", \"C#\"})", unidas);

            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("------------------------------------------------------");
        }
    }
}