// segundo programa com switch


namespace aula11_2;

public class Program
{
    public static void Main()
    {

        Console.WriteLine("============================");
        Console.WriteLine(" DESEMPENHO ESCOLAR ");
        Console.WriteLine("============================");
        
        Console.WriteLine(" Digite sua nota: ");
        int score = Convert.ToInt32(Console.ReadLine());
        string status = "";
        
        switch (score)
        {
            case 10:
            case 9:
                Console.WriteLine("Muito bem continue assim!!");
                status = "Acima da média";
                break;
            case 8:
            case 7:    
                Console.WriteLine("Bom mas pode melhorar!");
                status = "Acima da média";
                break;
            case 6:
            case 5:    
                Console.WriteLine("Você esta indo bem mas pode melhorar!");
                status = "Na média";
                break;
            case 4:
            case 3:
            case 2:
            case 1:
                Console.WriteLine("Você esta indo mal melhore suas notas!!!");
                status = "Abaixo da média";
                break;
            case 0:
                Console.WriteLine("Você esta muito mal melhore MUITO!!!");
                status = "zerado";
                break;
            default:
                Console.WriteLine("Erro: Valor inserido invalido!!");
                break;
        }
        
        Console.WriteLine("============================");
        Console.WriteLine("Estado atual do aluno: ");
        Console.WriteLine(status);
    }
}