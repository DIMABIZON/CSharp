// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
// которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Random rnd = new Random();
int m = rnd.Next(2, 5);
int n = rnd.Next(2, 5);
int o = rnd.Next(2, 5);

int [, ,] array = new int [m,n,o];
int nextNumber = 0;

for (int i = 0; i < array.GetLength (0); i++)
{
    for (int j = 0; j < array.GetLength (1); j++)
    {
        for (int k = 0; k < array.GetLength (2); k++)
        {  
            while (Povtor(nextNumber, array))           // делаем неповторяющиеся числа с помощью метода
            {
                nextNumber = rnd.Next(1,100);
            }
            array[i,j,k] = nextNumber;

            Console.Write($" {array[i,j,k]} ({i},{j},{k})");
        }
        Console.WriteLine();  
    } 
    Console.WriteLine();  
}

bool Povtor(int number, int [,,] array)
{
    foreach (int item in array)
    {
        if (item == number)
        {
            return true;
        }
    }
    return false;
}