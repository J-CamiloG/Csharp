using System;

namespace MiApp.ClassPublicacion;

public class Publicacion
{
    public string Titulo { get; set; }
    public string AñoPublicacion {get; set;}
    
    public Publicacion(string titulo, string añoPublicacion)
    {
        Titulo = titulo;
        AñoPublicacion = añoPublicacion;
    }
}