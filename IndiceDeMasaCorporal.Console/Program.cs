using System;

class Persona
{
    public double Peso { get; set; }
    public double Estatura { get; set; }

    public Persona(double peso, double estatura)
    {
        Peso = peso;
        Estatura = estatura;
    }

    public double Calcular()
    {
        return Peso / Math.Pow(Estatura, 2);
    }

    public string Clasificar()
    {
        double imc = Calcular();

        if (imc < 18.5)
            return "Peso bajo";
        else if (imc >= 18.5 && imc < 25)
            return "Peso normal";
        else if (imc >= 25 && imc < 30)
            return "Sobrepeso";
        else if (imc >= 30 && imc < 40)
            return "Obesidad";
        else
            return "Obesidad extrema";
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Proporciona tu peso (kg): ");
        double peso = double.Parse(Console.ReadLine());

        Console.Write("Proporciona tu estatura (m): ");
        double estatura = double.Parse(Console.ReadLine());

        Persona persona = new Persona(peso, estatura);

        Console.WriteLine($"Clasificación: {persona.Clasificar()}");
    }
}
