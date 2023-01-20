// Задача 8: Чётные от 1 до N

Console.Write("Введите целое число больше нуля -->");
int n = Convert.ToInt32(Console.ReadLine());

int i = 0;

while (i < n-1)
{
    i += 2;
    Console.Write($"{i},");
}
