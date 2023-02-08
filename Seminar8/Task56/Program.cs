// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, чтобы находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Random rnd = new Random();
int m = rnd.Next(3, 6);
int n = rnd.Next(3, 6);

int [,] array = new int [m, n];

for (int i = 0; i < array.GetLength (0); i++)
{
    for (int j = 0; j < array.GetLength (1); j++)
    {
        array [i,j] = rnd.Next(-9, 10);
        Console.Write(String.Format("{0,2}", array [i,j]) + " ");
    }  
    System.Console.WriteLine();
}
int [] summa = new int [m];

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        summa [i] = summa [i] + array [i,j]; 
    }  
    Console.WriteLine();
    Console.Write("Сумма элементов " + (i+1) + " строки: " + summa [i] + "  ");   
}
int minrowe = summa [0];
int index = 0;

for (int i = 0; i < m; i++)
{
    if (summa [i] < minrowe)
    {
        minrowe = summa [i];
        index = i;
    } 
}
Console.WriteLine();
Console.Write("\n" + $"Сумма элементов " + (index+1) + " строки наименьшая.");