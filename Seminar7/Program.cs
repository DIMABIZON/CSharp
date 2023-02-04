// Console.WriteLine("введите количество строк: --> ");
// int m = Convert.ToInt32(Console.ReadLine()); 

// Console.WriteLine("введите количество столбцов: --> ");
// int n = Convert.ToInt32(Console.ReadLine());

// int [,] array = new int [m,n];

// for (int i = 0; i < array.GetLength (0); i++)
// {
//     for (int j = 0; j < array.GetLength (1); j++)
//     {
//         array [i,j] = i + j;
//         Console.Write(array [i, j]);
//     }  
//     System.Console.WriteLine();
// }

// Console.WriteLine("введите количество строк: --> ");
// int m = Convert.ToInt32(Console.ReadLine()); 

// Console.WriteLine("введите количество столбцов: --> ");
// int n = Convert.ToInt32(Console.ReadLine());

// int [,] array = new int [m,n];

// for (int i = 0; i < array.GetLength (0); i++)
// {
//     for (int j = 0; j < array.GetLength (1); j++)
//     {
//         array [i,j] = new Random().Next(-10, 10);
//         Console.Write(array [i, j] + " ");
//     }  
//     System.Console.WriteLine();
// }
// System.Console.WriteLine();

// for (int i = 0; i < array.GetLength (0); i++)
// {
//     for (int j = 0; j < array.GetLength (1); j++)
//     {
//         if (i % 2 == 0 && j % 2 ==0)
//         {
//             array [i,j] = array [i,j] * array [i,j];
//         }
//         Console.Write(array [i, j] + " ");
//     }  
//     System.Console.WriteLine();
// }

Console.WriteLine("введите количество строк: --> ");
int m = Convert.ToInt32(Console.ReadLine()); 

Console.WriteLine("введите количество столбцов: --> ");
int n = Convert.ToInt32(Console.ReadLine());

int [,] array = new int [m,n];

for (int i = 0; i < array.GetLength (0); i++)
{
    for (int j = 0; j < array.GetLength (1); j++)
    {
        array [i,j] = new Random().Next(10);
        Console.Write(array [i, j] + " ");
    }  
    System.Console.WriteLine();
}
System.Console.WriteLine();


int summa = 0;

for (int i = 0; i < array.GetLength (0); i++)
{
    for (int j = 0; j < array.GetLength (1); j++)
    {
        if (i == j)
        {
            summa = summa + array [i,j];
        }
    }  
}
System.Console.WriteLine(summa);