// Задача 15: выходной день!

Console.WriteLine("Введите цифру от 1 до 7, обозначающую день недели: ");
int a = Convert.ToInt32(Console.ReadLine());

if (a <=5)
{
    Console.WriteLine("нет, это не выходной день");
}
else
{
    Console.WriteLine("да, это выходной день!!!");
}

