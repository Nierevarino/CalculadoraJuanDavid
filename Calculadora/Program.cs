using System;
class Program
{
    static void Main(string[] args)
    {
        Suma suma= new Suma();
        Resta resta= new Resta();
        Multiplicar multiplicar= new Multiplicar();
        Dividir dividir= new Dividir();


        int a = 7;
        int b = 45;

        Console.WriteLine($"Suma: {suma.Calcular(a,b)}");
        Console.WriteLine($"Resta: {resta.Calcular(a,b)}");
        Console.WriteLine($"Multiplicar: {multiplicar.Calcular(a,b)}");
        Console.WriteLine($"Dividir: {dividir.Calcular(a,b)}");
    }
}