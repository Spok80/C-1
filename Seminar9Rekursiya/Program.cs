int number = 3;

int Factorial(int n)
{
    if (n < 0) return -1;
    if (n == 0 || n == 1) return 1;
    return n * Factorial(n - 1); 
}
Console.WriteLine(Factorial(number));