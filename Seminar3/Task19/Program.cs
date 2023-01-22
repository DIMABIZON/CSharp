// Задача 19: Пятизначный полиндром?

Console.WriteLine("Введите пятизначное число --> ");
int a = Convert.ToInt32(Console.ReadLine());

string palindrom = a.ToString(); //преобразование целого числа в строку

if (palindrom[0]==palindrom[4] && palindrom[1]==palindrom[3]) //ускоренная проверка логическим И условия палиндрома
{
    Console.Write("Поздравляю, у вас палиндром! ");
}
else
{
    Console.WriteLine("нет, ваше число не палиндром. Введите зеркальное число");
}
