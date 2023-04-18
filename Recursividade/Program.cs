Console.WriteLine("Cálculo Fatorial Recursivo");
Console.WriteLine("**************************");
Console.WriteLine();

Console.WriteLine("Digite um número: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Fatorial de {number} é {Factorial(number)}");
Console.WriteLine($"Fibonacci de {number} é {Fibonacci(number)}");

static int Factorial(int number)
{
    //Caso base
    if(number < 0)
    {
        throw new ArgumentException(
            message: $"A função fatorial não suporta números negativos. Input{number}",
            paramName: nameof(number)
        );
    }
    else if(number == 0)//caso base 2
    {
        return 1;
    }
    else //Caso Recursivo
    {
        return number * Factorial(number - 1);
    }
}


static long Fibonacci(int n )
{
    if(n <= 2L)
        return 1L;
    
    return Fibonacci(n - 1) + Fibonacci(n - 2);
}