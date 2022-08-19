
public class Program
{
    public static void Main()
    {
        Console.Clear();

        Console.WriteLine("Seja bem vindo aos múltiplos de 3 e 5");


        Console.WriteLine(" Digite o primeiro número");
        int numero1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o segundo número");
        int numero2 = int.Parse(Console.ReadLine());


        Somar();

        Console.WriteLine("");

        static void Somar()
        {

            Somar();


            Console.WriteLine("");

            static void Somar()
            {
                int numero = 0;
                int n1;
                int n2;
                int resultado;

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
}