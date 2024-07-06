using System;
// a continuacion veras un repertorio de metodos  
//para usar con el tipo de dato numero

namespace MiApp.NumerosYMetodos
{
    public class ClaseDeNumerosYMetodos 
    {
        public void MostrarMetodosNumeros()
        {
            // Abs(): Devuelve el valor absoluto de un número.
            int numeroEntero = -10;
            int absoluto = Math.Abs(numeroEntero);
            Console.WriteLine($"Abs(-10) = {absoluto}");

            // Ceiling(): Redondea un número decimal hacia arriba al entero más cercano
            double numeroDecimalCeiling = 3.14;
            double techo = Math.Ceiling(numeroDecimalCeiling);
            Console.WriteLine($"Ceiling(3.14) = {techo}");

            // Floor(): Redondea un número decimal hacia abajo al entero más cercano.
            double numeroDecimalFloor = 3.14;
            double piso = Math.Floor(numeroDecimalFloor);
            Console.WriteLine($"Floor(3.14) = {piso}");

            // Round(): Redondea un número decimal al entero más cercano.
            double numeroDecimalRound = 3.6;
            double redondeado = Math.Round(numeroDecimalRound);
            Console.WriteLine($"Round(3.6) = {redondeado}");

            // Pow(): Calcula la potencia de un número.
            double baseNumero = 2;
            double exponente = 3;
            double potencia = Math.Pow(baseNumero, exponente);
            Console.WriteLine($"Pow(2, 3) = {potencia}");

            // Sqrt(): Calcula la raíz cuadrada de un número.
            double numeroSqrt = 25;
            double raizCuadrada = Math.Sqrt(numeroSqrt);
            Console.WriteLine($"Sqrt(25) = {raizCuadrada}");

            // Sin(), Cos(), Tan(): Calcula el seno, coseno y tangente de un ángulo dado en radianes.
            double anguloEnRadianes = Math.PI / 2; // 90 grados en radianes
            double seno = Math.Sin(anguloEnRadianes);
            double coseno = Math.Cos(anguloEnRadianes);
            double tangente = Math.Tan(anguloEnRadianes);
            Console.WriteLine($"Sin(π/2) = {seno}, Cos(π/2) = {coseno}, Tan(π/2) = {tangente}");

            // Max() y Min(): Devuelven el máximo y mínimo entre dos números.
            int numero1 = 10;
            int numero2 = 20;
            int maximo = Math.Max(numero1, numero2);
            int minimo = Math.Min(numero1, numero2);
            Console.WriteLine($"Max(10, 20) = {maximo}, Min(10, 20) = {minimo}");

            // Log() y Log10(): Calcula el logaritmo natural y el logaritmo base 10 de un número.
            double numeroLog = 100;
            double logNatural = Math.Log(numeroLog);
            double logBase10 = Math.Log10(numeroLog);
            Console.WriteLine($"Log(100) = {logNatural}, Log10(100) = {logBase10}");

            // Truncate(): Trunca un número decimal eliminando su parte fraccionaria.
            double numeroDecimalTruncate = 3.9;
            double truncado = Math.Truncate(numeroDecimalTruncate);
            Console.WriteLine($"Truncate(3.9) = {truncado}");
        }
    }
}
