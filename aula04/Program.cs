// input e output

namespace aula4;

public class Program
{
    public static void Main()
    {
        // output seria a saida de informação como o writeline
        Console.WriteLine("Isso é uma saida de informação");
        
        // exemplo de sistema de cadastro
        Console.WriteLine("CADASTRO DE USUARIO ------------------------");
        
        // socilitar o nome do usuario
        Console.WriteLine("Digite seu nome: ");
        // input seria a entrada do que esta no terminal
        string name = Console.ReadLine();
        // solicitando a idade do user
        Console.WriteLine("Digite sua idade: ");
        int age = Convert.ToInt32(Console.ReadLine());
        
        /*
         * o metodo ReadLine só lê e retorna strings por isso quando solicitar um dado
         * que seja um numero esse dado tem que ser convertido para int ou double
         */
        
        // exibindo dados do usuario
        Console.WriteLine("DADOS DO USUARIO ------------------------");
        Console.WriteLine("Nome: " + name);
        Console.WriteLine("Idade: " + age);
    }
}