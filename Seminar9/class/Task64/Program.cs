// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// Console.WriteLine("Введите значение N: --> ");
// int n = Convert.ToInt32(Console.ReadLine());

// int count = 1;

// Numbers1(n, count);                             // рекурсионный вывод чисел от 1 до заданного N

// void Numbers1(int n, int count)                 // создаем метод, использующий сам себя       
// {
//     Console.Write(String.Format("{0,2}", count) + ", ");

//     if (count < n)
//         Numbers1(n, ++ count);                  // если написать "count ++", то код вывод чисел будет бесконечен
//     else
//     {
//         return;                                 // условие выхода из рекурсии. должно быть прописано обязательно!
//     }                 
// }

Console.WriteLine("Введите значение N: --> ");
int n = Convert.ToInt32(Console.ReadLine());

int count = n;

Numbers2(n, count);                             // рекурсионный вывод чисел от заданного N до 1

void Numbers2(int n, int count)       
{
    Console.Write(String.Format("{0,2}", count) + ", ");

    if (count > 1)
        Numbers2(n, -- count);
    else
    {
        return;
    }                 
}