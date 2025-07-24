// aula sobre while


namespace aula12;

public class Program
{
    public static void Main()
    {
        double budget = 100;

        // enquanto budget for maior que 0 {...
        while (budget > 0) 
        {
            Console.WriteLine(budget);
            budget--;
        }
        Console.WriteLine("Atenção saldo insuficiente!!");
    }
}