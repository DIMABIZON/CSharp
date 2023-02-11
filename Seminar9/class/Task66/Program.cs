// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму 
// натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите значение M: --> ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение N: --> ");
int n = Convert.ToInt32(Console.ReadLine());

int RecurSumma(int m, int n)       
{
    if (n == m-1)
    {    
        return 0;
    }
    else
    {
        return n + RecurSumma(m, n-1);
    }
}
Console.WriteLine("Сумма элементов от " + m + " до "+ n +" составит: " + RecurSumma(m, n));