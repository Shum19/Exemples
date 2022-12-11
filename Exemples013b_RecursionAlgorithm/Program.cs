/*
*/
/*double Factorial (int n)
{
    if (n == 1) return 1;
    else return n * Factorial(n-1);
}

for (int i = 1; i < 40; i++)
{
    Console.WriteLine($"{i}! = {Factorial(i)}");
}
 */
 
 int Fibonacci (int n)
 {
    if ( n == 1 || n == 2) return 1;
    else return Fibonacci(n - 1) + Fibonacci(n - 2);
 }
 for (int j = 1; j < 10; j++)
 {
    Console.WriteLine($"{j} = {Fibonacci(j)}");
 }
