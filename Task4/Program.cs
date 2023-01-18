// Максимум из трёх чисел?

Console.WriteLine("Введите первое число {a}: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число {b}: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье число {c}: ");
int c = Convert.ToInt32(Console.ReadLine());

int max = a;

if (b > max) max = b;

if (c > max) max = c;

Console.WriteLine("Максимальным является число");  
Console.Write("max = ");
Console.WriteLine(max);