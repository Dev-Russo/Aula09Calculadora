using System;

namespace Calculadora09
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ficou faltando a média
            Calculadora calculadora = new Calculadora();
            Calculadora calculadora1 = new Calculadora(20, 30);
            
            Console.WriteLine(calculadora.Calcular("20", "+", "20"));
            Console.WriteLine(calculadora.Calcular("20", "-", "20"));
            Console.WriteLine(calculadora.Calcular("20", "/", "0"));
            Console.WriteLine(calculadora.Calcular("20", "*", "20"));
        }
    }
}
