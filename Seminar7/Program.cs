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
444444444444444444444444444444444444444
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
4444444444444444444444444

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

// Console.WriteLine("Enter an array of integer elements separated by SPASE, SLASH, DOT or COMMA, end press 'ENTER'");

// string str = Console.ReadLine();

// char [] separator =  new char [] {' ',',','.','/'};

// string [] array = str.Split(separator, StringSplitOptions.RemoveEmptyEntries);

// int [] a = Array.ConvertAll(array,int.Parse);

// Console.WriteLine("Your array:");

// Console.Write("{"+string.Join(",",a)+"}");

// int count=0;

// for (int i=0;i<array.Length;i++)

// {

// if(a[i]>0)count++;

// }

// Console.WriteLine("\nThe number of positive array elements is:");

// Console.WriteLine(count);