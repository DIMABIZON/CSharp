// Задача 10: вторая цифра трёхзначного числа

Console.Write("Введите трёхзначное число -->");
int n = Convert.ToInt32(Console.ReadLine());

int d = (n/10) % 10;

Console.Write("вторая цифра вашего числа = ");
Console.WriteLine(d);