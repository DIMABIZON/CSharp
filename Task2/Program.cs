// Какое число большее?

Console.WriteLine("Введите первое число {a}: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число {b}: ");
int b = Convert.ToInt32(Console.ReadLine());

if (a > b) Console.WriteLine("Число {a} большее, а число {b} меньшее");

else
{
    Console.WriteLine("Число {b} большее, а число {a} меньшее");
}