//Задача 25: возвести часло А в степень В

Console.WriteLine("Введите число А --> ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число В --> ");
int b = Convert.ToInt32(Console.ReadLine());

//int AvstepB(int a, int b)
//{
    int proizved = a * a;

    //return proizved;
//}

//int pr = AvstepB();

for (int i = 1; i <= b - 2; i++)
{
     proizved = proizved * a;
}

Console.Write("Ваше число А в степени В равно: ");
Console.WriteLine(proizved);