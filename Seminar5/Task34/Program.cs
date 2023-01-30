// Задача 34: Количество четных чисел случайного массива положительных трехзначных чисел

Console.WriteLine("Введите желаемое количество чисел массива --> ");
int kol = Convert.ToInt32(Console.ReadLine());

int [] array = new int [kol];
Random rand = new Random (); 

for (int i = 0; i < kol; i++)              
{
    array [i] = rand.Next(100,1000);
    Console.Write($"{array [i]}, ");     
}

Console.WriteLine ();

int count = 0;

for (int i = 0; i < kol; i++)              
{
    if (array [i] % 2 == 0)
    {
        count ++;
          
    } 
}
Console.Write($"Количество чётных чисел в массиве равно: {count}");