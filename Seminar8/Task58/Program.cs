// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
Random rnd = new Random();
int m = rnd.Next(2, 4);
int n = rnd.Next(2, 4);

int [,] array1 = new int [m, n];
for (int i = 0; i < array1.GetLength (0); i++)
{
    for (int j = 0; j < array1.GetLength (1); j++)
    {
        array1 [i,j] = rnd.Next(1, 10);
        Console.Write(String.Format("{0,2}", array1 [i, j]) + " ");
    }
    Console.WriteLine();  
}
Console.WriteLine(); 

int [,] array2 = new int [m, n];
for (int i = 0; i < array2.GetLength (0); i++)
{
    for (int j = 0; j < array2.GetLength (1); j++)
    {
        array2 [i,j] = rnd.Next(1, 10);
        Console.Write(String.Format("{0,2}", array2 [i, j]) + " ");
    }
    Console.WriteLine();  
}

int[,] MatrixMultiplication(int[,] array1, int[,] array2)     //  создаём метод для умножения матриц
{       
    if (array1.GetLength (1) != array2.GetLength (0))
    {
        throw new Exception("Умножение не возможно!");
    }

var array3 = new int[array1.GetLength (0), array2.GetLength (1)];

    for (var i = 0; i < array1.GetLength (0); i++)
    {
        for (var j = 0; j < array2.GetLength (1); j++)
        {
            array3[i, j] = 0;

            for (var k = 0; k < array1.GetLength (0); k++)
            {
                array3[i, j] += array1[i, k] * array2[k, j];
            }
        }
    }
    return array3;
}
    void PrintMatrix(int[,] array)                       // создаём метод для печати матрицы в консоль
    {
        for (var i = 0; i < array.GetLength (0); i++)
        {
            for (var j = 0; j < array.GetLength (1); j++)
            {
                Console.Write(String.Format("{0,2}", array [i, j]) + " ");
            }
            Console.WriteLine();
        }
    }
    var result = MatrixMultiplication(array1, array2);
        Console.WriteLine("Произведение ваших матриц:");
        PrintMatrix(result);