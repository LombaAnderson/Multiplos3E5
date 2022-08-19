
public class Program
{   
    public static void Main()
    {
        Console.Clear();

        Console.WriteLine("Seja bem vindo aos múltiplos de 3 e 5");

        Console.WriteLine("Digite o primeiro número");
        int n1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o segundo número");
        int n2 = int.Parse(Console.ReadLine());

        Console.WriteLine($" O resultado da soma dos múltiplos é ");

        SomaMultiplos();
    }
         static void SomaMultiplos()
            { 
          int numero = 0;

        while (numero <= 100)
        {
            numero++;
            if (numero % 3 == 0  || numero % 5 == 0)
            {
                Console.WriteLine(numero);
            }

        }
           Console.ReadKey();

    }
            
    }
     
 
     


   

