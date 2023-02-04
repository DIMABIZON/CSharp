// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.WriteLine("введите количество строк m: --> ");
int m = Convert.ToInt32(Console.ReadLine()); 

Console.WriteLine("введите количество столбцов n: --> ");
int n = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine();

double [,] array = new double [m,n];
Random rnd = new Random (); 

for (int i = 0; i < array.GetLength (0); i++)
{
    for (int j = 0; j < array.GetLength (1); j++)
    {
        array [i,j] = rnd.Next(-9, 10) + rnd.NextDouble();
        Console.Write(Math.Round(array [i,j], 2) + "  ");
    }  
    System.Console.WriteLine();
}

System.Console.WriteLine();

Console.WriteLine("В какой строке стоит искомый элемент? --> ");
int row = Convert.ToInt32(Console.ReadLine()); 

Console.WriteLine("В каком столбце стоит искомый элемент? --> ");
int column = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine();

if (row < m && column < n)
{
    Console.WriteLine("Искомый элемент вашего массива:" + Math.Round(array [row - 1,column - 1], 2));
}
else
{
    Console.WriteLine("Такой ячейки с числом в вашем массиве нет");
}   