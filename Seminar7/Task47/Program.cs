// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5  7       -2      -0,2
// 1    -3,3    8       -9,9
// 8    7,8     -7,1    9

Console.WriteLine("введите количество строк m: --> ");
int m = Convert.ToInt32(Console.ReadLine()); 

Console.WriteLine("введите количество столбцов n: --> ");
int n = Convert.ToInt32(Console.ReadLine());

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

