// Задача 38: Разница между макс и мин элементами массива вещественных чисел

Console.WriteLine("Сколько чисел будет в вашем массиве?: --> ");
int kol = Convert.ToInt32(Console.ReadLine());

int [] array = new int [kol];
Random rnd = new Random (); 

for (int i = 0; i < kol; i++)              
{
    array [i] = rnd.Next(0, 100);
    Console.Write(array [i] + " ");     
}

int maxnumb = array [0];
int minnumb = array [0];

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

Console.WriteLine (minnumb);
Console.WriteLine (maxnumb);