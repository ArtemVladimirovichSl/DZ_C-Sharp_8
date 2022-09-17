// Вывести первые N строк треугольника Паскаля. 
// Сделать вывод в виде равнобедренного треугольника.

Console.Write("Введите нужное количество строк треугольника Паскаля: ");
int N = Convert.ToInt32(Console.ReadLine());

int factorial(int N)
{
    int x = 1;
    for (int i = 1; i <= N; i++) x *= i;
    return x;
}

for (int i = 0; i < N; i++)
{
    for (int c = 0; c <= (N - i); c++) Console.Write(" "); 
    for (int c = 0; c <= i; c++) Console.Write(" " + (factorial(i) / (factorial(c) * factorial(i - c))));
    Console.WriteLine();
    Console.WriteLine();
}