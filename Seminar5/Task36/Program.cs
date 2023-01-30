// Задача 36: Cумма элементов, стоящих на нечетных позициях одномерного массива

Console.WriteLine("Сколько чисел будет в вашем массиве?: --> ");
int kol = Convert.ToInt32(Console.ReadLine());

int [] array = new int [kol];
Random rnd = new Random (); 

for (int i = 0; i < kol; i++)              
{
    array [i] = rnd.Next(-99, 100);
    Console.Write(array [i] + " ");     
}
int summa = 0;

for (int i = 1; i < kol; i += 2)
{
    summa = summa + array [i];
}
Console.Write("\n" + $"Сумма элементов, стоящих на нечётных позициях в массиве: {summa}");
