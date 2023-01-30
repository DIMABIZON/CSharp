// Задача 27: Сумма цифр в числе

Console.WriteLine("Введите число --> ");
int a = Convert.ToInt32(Console.ReadLine());
int sum = 0;
string add = a.ToString(); //преобразование целого числа в строку

int numberofsimvols = add.Length;

for (int i = 0; i <= numberofsimvols - 1; i++)          // Способ 1
{
    sum = sum + add[i] - '0';
}

//do
//{
//    sum = sum + a % 10;                               // способ 2
//    a = a / 10;
//} while (a > 0);

    Console.Write("Сумма цифр в вашем числе равна ");
    Console.WriteLine(sum);

