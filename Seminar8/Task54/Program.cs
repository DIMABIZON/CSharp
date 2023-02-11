// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Random rnd = new Random();
int m = rnd.Next(3, 5);
int n = rnd.Next(4, 6);

int [,] array = new int [m, n];

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array [i,j] = rnd.Next(1, 10);
        Console.Write(String.Format("{0,2}", array [i,j]) + " ");
    }  
    Console.WriteLine();
} 

for (int i = 0; i < m; i++)
{
    int index = 1;                  // Начало Гномьей сортировки массива по убыванию
    int nextIndex = index + 1;      // Во внешнем цикле нужно определять index, nextIndex, temp.
    int temp;

    while (index < n)
    {
        if (array [i, index - 1] > array [i, index]) // если предыдущий элемент строки больше следующего, идём дальше
        {
            index = nextIndex;
            nextIndex++;
        }
        else                                        // иначе переприсваиваем индексы = передвигаем больший элемент влево
        {
            temp = array [i, index - 1];
            array [i, index - 1] = array [i, index];
            array [i, index] = temp;
            index--;
            if (index == 0)                          // и проверяем условие возврата в начало строки, а затем переходим к
            {                                        // к следующему неотсортированному элементу
                index = nextIndex;
                nextIndex++;
            }
        }
    }
} 

Console.WriteLine();

for (int i = 0; i < array.GetLength (0); i++)
{
    for (int j = 0; j < array.GetLength (1); j++)
    {
        Console.Write(String.Format("{0,2}", array [i, j]) + " ");
    }  
    Console.WriteLine();
}