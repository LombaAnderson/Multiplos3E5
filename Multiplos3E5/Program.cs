
public class Program
{
   
    public static void Main()
    {
        
        Somar();

        static void Somar()
        {
            Console.Clear();

            Console.WriteLine("Seja bem vindo aos múltiplos de 3 e 5");


            Console.WriteLine(" Digite o primeiro número");
            int numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número");
            int numero2 = int.Parse(Console.ReadLine());

            Console.WriteLine("");

            int resultado = numero1 + numero2;
            Console.WriteLine($" O resultado da soma dos múltiplos é " + resultado);
            Console.WriteLine(numero1);

            int numero = 0;


            while (numero <= 100)
            {
                numero++;
                if (numero % 3 == 0)
                {
                    Console.WriteLine(numero);
                }
                if (numero % 5 == 0)
                {
                    Console.WriteLine(numero);
                }
            }
            Console.ReadKey();
        }

    }
}

   

