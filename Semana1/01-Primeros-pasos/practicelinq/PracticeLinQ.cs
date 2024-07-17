using System;
using System.Collections.Generic;

namespace MiApp.PracticeLinQ
{
    public class ClassPracticeLinQ
    {
        // Definición de la entidad (clase) DataBase
        public class DataBase
        {
            public int Id { get; set; }
            public string Name { get; set; } 
            public List<string> Projects { get; set; }

            // Creamos el constructor de nuestra clase.
            // En este caso, el constructor se utiliza para inicializar una nueva instancia de la clase DataBase.

            // Asignamos un valor inicial a la propiedad Name con una cadena vacía ("") para evitar valores nulos.
            // Inicializamos la propiedad Projects con una nueva lista vacía de strings utilizando new List<string>().
            
            // Esto asegura que cada objeto de tipo DataBase tenga sus propiedades inicializadas adecuadamente al ser creado.

            // Un constructor en programación orientada a objetos es un método especial dentro de una 
            //clase que se utiliza para inicializar los objetos de esa clase
            public DataBase()
            {
                Name = ""; 
                Projects = new List<string>();
            }
        }

        // Lista que contendrá objetos del tipo DataBase
        List<DataBase> listPeople = new List<DataBase>();

        // Constructor de la clase
        public  ClassPracticeLinQ()
        {
            // Inicialización de listPeople (puedes hacerlo aquí o en otro método según tu necesidad)

            // Aquí agregamos datos a la lista
            DataBase person1 = new DataBase
            {
                Id = 1,
                Name = "Camilo",
                Projects = new List<string> { "Proyecto Carros", "Proyecto Motos" }
            };
            listPeople.Add(person1);
            
            // Puedes agregar más personas aquí o en otros métodos según lo necesites
        }

        // Método que podrías implementar según lo mencionado
        public void primtPracticeLinQ() // Corregido el nombre del método
        {   
            foreach (var i in listPeople)
            {
                Console.WriteLine(i.Name);
            }
            // Implementación del método aquí
        }
    }
}


