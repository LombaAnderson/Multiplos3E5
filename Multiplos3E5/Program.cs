
Console.Clear();

Console.WriteLine("Seja bem vindo aos múltiplos de 3 e 5");


Console.WriteLine(" Digite o primeiro número entre 1 e 10");
int numero1 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o segundo número entre 1 e 10");
int numero2 = int.Parse(Console.ReadLine());


Console.WriteLine("");


int multiplo3 = 3;
int multiplo5 = 5;
int resultado = 0;



for (int i = 0; i < 10; i++)
{
    if (i % multiplo3 == 0 || i % multiplo5 == 0)
    {
        resultado += i;
    }
}

Console.WriteLine("A soma dos múltiplos de 3 e 5 abaixo de 10 é: " + resultado);




