
namespace aula2;

public class Program
{
    public static void Main()
    {
        // variaveis
    
        // varivel com tipo string (Texto)
        string lastname = "Gonzaga";
        string name = "Gabriel";
        
        // concatenacao de string dentro de variavel
        string completeName = name + lastname;
        
        // tipo de varivel con integer (numero inteiro)
        int age = 16;
        
        // tipo de variavel double ou float (numero com casas decimais)
        double height = 1.70;
        
        // tipo de variavel character armazena apenas um caractere entre aspas simples
        char gender = 'm';
        
        // tipo de variavel boolean (verdadeiro ou falso)
        bool overage = false;
        
        /*
         * esses foram os tipos principais de variveis mas tem mais varios outros
         * tipos como:
         *  long
         *  decimal
         *  etc...
         */
        
        // usando estrutura de controle para dar sentido ao codigo e praticar
        if (age >= 18)
        {
            overage = true;
        }
        else
        {
            overage = false;
        }
        
        
        // operador de contatenacao de texto é: +
        Console.WriteLine("Nome do usuario: " + name);
        Console.WriteLine("Sobrenome do usuario: " + lastname);
        Console.WriteLine("Idade do Usuario: " + age);
        Console.WriteLine("Altura do usuario: " + height + "M");
        Console.WriteLine("Nome completo do Usuario: " + completeName);
        Console.WriteLine("Genero do usuario: " + gender);
        
        // testando estrutura de controle 
        if (overage)
        {
            Console.WriteLine("O usuario é maior de idade!");
        }
        else
        {
            Console.WriteLine("O usuario é menor de idade!");
        }
    }
}



