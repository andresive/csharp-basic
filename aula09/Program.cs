// operadores logicos

using System.Runtime.InteropServices.JavaScript;

namespace teste;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("===========================");
        Console.WriteLine(" OPERADORES LOGICOS ");
        Console.WriteLine("===========================");
     
        // iniciando variveis
        bool logged = false;
        bool admin = false;
        
        Console.WriteLine("Você esta logado no sistema?");
        Console.WriteLine("[1]:Sim");
        Console.WriteLine("[2]:Não");
        int verify = Convert.ToInt16(Console.ReadLine());

        if (verify == 1)
        {
            logged = true;
        }
        else if (verify == 2)
        {
            logged = false;
        }
        else
        {
            Console.WriteLine("ERROR: o valor inserido não é valido tente novamente :(");
        }
        
        Console.WriteLine("Você é um usuario administrador?");
        Console.WriteLine("[1]:Sim");
        Console.WriteLine("[2]:Não");
        verify = Convert.ToInt16(Console.ReadLine());

        if (verify == 1)
        {
            admin = true;
        }
        else
        {
            admin = false;
        }
        
        // limpando o console
        Console.Clear();
        
        Console.WriteLine("===========================");    
        Console.WriteLine("Iformações do usuario: ");
        Console.WriteLine("===========================");

        //verificação usuario
        if (logged == true)
        {
            Console.WriteLine("Usuario Logado: true");
        }
        else
        {
            Console.WriteLine("Usurario Logado: false");
        }
        
        // verificação admin
        if (admin == true)
        {
            Console.WriteLine("Permisão de painel administrador: true");
        }
        else
        {
            Console.WriteLine("Permisão ao painel administrador: false");
        }
        
        // trabalhando os operadores melhor agora
        //operador (||) -OR

        if (logged || admin)
        {
            Console.WriteLine("Acesso ao sistema: Liberado");
        }
        else
        {
            Console.WriteLine("Acesso ao sistema: Negado");
        }
        
        
        // operador (&&) -AND
        // verifica se as duas condiçõessão veridadeiras
        if (logged && admin)
        {
            Console.WriteLine("Acesso ao painel administrador: concedido");
        }
        else
        {
            Console.WriteLine("Acesso ao painel administrador: negado");
        }
        
        // operador (!) -NOT
        if (!logged)
        {
            Console.WriteLine("O usuario não esta logado");
        }
        else
        {
            Console.WriteLine("O usuario esta logado");
        }
        
        // EXTRA operador ternario
        Console.WriteLine("testando o operador ternario :D ");

        // a sintaxe do operador ternario é essa porem a IDE mudou o formato do codigo
        // deixando mais organizado
        string msg = (logged && admin)
            ? "Você tem total acesso ao sistema agora :D"
            : "Você não tem acesso completo ao sistema sinto muito :(";
        
        Console.WriteLine("Status: " + msg);
    }
}