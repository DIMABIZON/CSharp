// Чётные от 1 до N

Console.Write("Введите число N-->");
int n = Convert.ToInt32(Console.ReadLine());

int i = 0;

while (i < n)
{
    i += 2;
    Console.Write($"{i}, ");
    if (i == n-1) break;
}
