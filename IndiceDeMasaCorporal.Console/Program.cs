double peso, estatura;
Console.WriteLine("Proporciona tu peso (kg)");
peso=Double.Parse(Console.ReadLine());
Console.WriteLine("Proporciona tu estatura (m)");
estatura = Double.Parse(Console.ReadLine());
double imc = peso / Math.Pow(estatura, 2);
Console.WriteLine(imc);
if (imc <18.5)
{
    Console.WriteLine("Peso bajo"); 
}
if (imc >= 18.5 && imc<25)
{
    Console.WriteLine("Peso normal");
}
if (imc >= 25 && imc < 30)
{
    Console.WriteLine("Sobrepeso");
}
if (imc >= 30 && imc < 40)
{
    Console.WriteLine("Obesidad");
}
if (imc > 40)
{
    Console.WriteLine("Obesidad extrema");
}

