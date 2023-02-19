using System.Globalization;

namespace DesafioCarnaval3;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Informa o Preço do alcool R$: ");
        double.TryParse(Console.ReadLine(), out double alcool);
        Console.Write("Informa o Preço da Gasolina R$: ");
        double.TryParse(Console.ReadLine(), out double gasolina);

        var correlacao = CoefienteEconomino(alcool, gasolina) * 100;
        var vantagemEconomina = Validar(correlacao);

        Console.WriteLine($"{correlacao.ToString("F2", CultureInfo.InvariantCulture)} %, \n{vantagemEconomina}");
    }

    private static string Validar(double correlacao)
    {
        if (correlacao <= 72)
            return "Vantagem em abastencer o tanque com alcool";
        return "vantagem em abasteccer o tanque com gasolina";
    }
    private static double CoefienteEconomino(double alcool, double gasolina)
            => alcool / gasolina;
}
