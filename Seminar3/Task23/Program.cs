// Задача 23: Таблица кубов (любой целой степени) от 1 до N

Console.Write("Введите число -->");
int n = Convert.ToInt32(Console.ReadLine());
int stepen = 3;

for (int i = 1; i <= n; i++)
{
    Console.Write($"{Math.Pow(i, stepen)}, ");
}