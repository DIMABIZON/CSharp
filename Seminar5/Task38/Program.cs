// Задача 38: Разница между макс и мин элементами массива вещественных чисел

Console.WriteLine("Сколько чисел будет в вашем массиве?: --> ");
int kol = Convert.ToInt32(Console.ReadLine());

Double [] array = new Double [kol];
Random rnd = new Random (); 

for (int i = 0; i < kol; i++)              
{
    array [i] = rnd.Next(-99, 100);
    Console.Write(array [i] + " ");     
}

Double maxnumb = array [0];
Double minnumb = array [0];

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
Console.WriteLine (maxnumb);
Console.Write("Минимальное число в массиве равно: ");
Console.WriteLine (minnumb);
Console.Write("Разница между максимальным и минимальным числом равна: ");
Console.WriteLine (maxnumb - minnumb);