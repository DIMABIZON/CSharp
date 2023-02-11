// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
// A(0, n) = n + 1,   //это результаты вычисления по формуле Аккермана.
// A(1, n) = n + 2,   // Для всех m < 3 значение n не превышает 1000000, если же m = 3, то значение n не д.б.> 24.
// A(2, n) = 2n + 3,  // иначе переполнение стека!!!
// A(3, n) = 2 в степени (n+3) – 3

Console.WriteLine("Введите значение m: --> ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение n: --> ");
int n = Convert.ToInt32(Console.ReadLine());

int Akkerman(int m, int n)  
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0)
    {
        return Akkerman(m - 1, 1);
    }
    else
    {
        return Akkerman(m - 1, Akkerman(m, n - 1));
    }
}
Console.WriteLine("Значение функции Аккермана для m = " + m + " и n = "+ n +" составляет: " + Akkerman(m, n));     