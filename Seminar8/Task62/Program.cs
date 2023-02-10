// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

Console.WriteLine("Введите число строк массива m: --> ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число столбцов массива n; --> ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[m, n];
int count = 1;

SpirMatrix(matrix);

void SpirMatrix(int[,] matrix, int a = 0)       //  создаём метод заполнения одного кольца спирали матрицы
{
    for (int i = 0 + a; i < n - a; i++)
    {
        matrix [0 + a, i] = count;
        count++;
        if (count > m * n) return;              // условие выхода из рекурсии
    }
    for (int j = 1 + a; j < m - a; j++)
    {
        matrix [j, n - 1 - a] = count;
        count++;
        if (count > m * n) return;              // условие выхода из рекурсии
    }
    for (int k = n - 2 - a; k >= 0 + a; k--)
    {
        matrix [m - 1 - a, k] = count;
        count++;
        if (count > m * n) return;              // условие выхода из рекурсии
    }
    for (int l = m - 2 - a; l > 0 + a; l--)
    {
        matrix [l, 0 + a] = count;
        count++;
        if (count > m * n) return;              // условие выхода из рекурсии
    }
    SpirMatrix(matrix, a + 1);                  // делаем рекурсию для заполнения внутренних колец матрицы
}

void PrintMatrix(int[,] matrix)                 // создаём метод для печати матрицы в консоль
    {
        for (var i = 0; i < m; i++)
        {
            for (var j = 0; j < n; j++)
            {
                Console.Write(String.Format("{0,4}", matrix [i, j]) + " ");
            }
            Console.WriteLine();
        }
    }
PrintMatrix(matrix);