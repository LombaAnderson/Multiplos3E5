
public class Program
{   
    public static void Main(string[] args)
    {

        string a;
        int numero;

        Console.WriteLine("Bem-Vindo(a), por favor insira um número" +
            " inteiro : ");

        a = Console.ReadLine();
        
        numero = Convert.ToInt32(a);

        
        if (numero % 3 == 0 && numero % 5 == 0)
        {
            Console.WriteLine("É divisivel por 3 e por 5!");
        }
        
        else if (numero % 5 == 0)
        {
            Console.WriteLine("É divisivel por 5!");
        }
        
        else if (numero % 3 == 0)
        {
            Console.WriteLine("É divisivel por 3!");
        }
        
        else
        {
            Console.WriteLine($"{numero} : não é um número divisivel nem por 3 nem por 5!");
        }

        Console.ReadKey();


    }
}





