// Задача 38: Разница между макс и мин элементами массива вещественных чисел

Console.WriteLine("Сколько чисел будет в вашем массиве?: --> ");
int kol = Convert.ToInt32(Console.ReadLine());

double [] array = new double [kol];
Random rnd = new Random (); 

for (int i = 0; i < kol; i++)              
{
    array [i] = rnd.Next(-99, 100) + rnd.NextDouble();
    Console.WriteLine("{0: 0.000}", array [i]);     
}

double maxnumb = array [0];
double minnumb = array [0];

for (int i = 0; i < kol; i++)
{
    if (array [i] < minnumb)
    {
        minnumb = array [i];
    }
    
    if (array [i] > maxnumb)
    {
        maxnumb = array [i];
    }
}

Console.WriteLine ();
Console.Write("Максимальное число в массиве равно: ");
Console.WriteLine ("{0: 0.000}", maxnumb);
Console.Write("Минимальное число в массиве равно: ");
Console.WriteLine ("{0: 0.000}", minnumb);
Console.Write("Разница между максимальным и минимальным числом равна: ");
Console.WriteLine ("{0: 0.000}", maxnumb - minnumb);