using System.Globalization;

namespace MembrosEstaticosParte2;
class Program
{
    static void Main(String[] args)
    {
      

        Console.Write("Entre com o valor do raio: ");
        double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double circ = Calculadora.Circunferencia(raio);
        double volume = Calculadora.Volume(raio);

        Console.WriteLine($"Circunferência: {circ.ToString("F2", CultureInfo.InvariantCulture)}");
        Console.WriteLine($"Volumne: {volume.ToString("F2", CultureInfo.InvariantCulture)}");
        Console.WriteLine($"Pi: {Calculadora.Pi.ToString("F2", CultureInfo.InvariantCulture)}");
    }
}