using Imc.Model;
using System;


class Program
{
    static void Main()
    {
        Console.WriteLine("Aplicacion que calcula el indice de masa corporal de una persona");
        Console.WriteLine();
        decimal peso = ReadLine("Proporciona tu peso (kg): ");
        decimal estatura = ReadLine("Proporciona tu estatura (m): ");


        decimal imc = IndiceDeMasaCorporalLib.IndiceDeMasaCorporal(peso, estatura);
        Console.WriteLine($"Clasificación: {IndiceDeMasaCorporalLib.IndiceDeMasaCorporal(peso, estatura)}");
        Console.WriteLine($"Clasificación: {IndiceDeMasaCorporalLib.DeterminaEstadoNutricional(imc)}");

    }

    public static decimal ReadLine(string texto)
    {
        Console.Write(texto);
        return decimal.Parse(Console.ReadLine());
    }
}
