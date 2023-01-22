// Задача 21: Расстояние между точками в 3D

Console.Write("Введите координаты x точки А: ");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координаты y точки А: ");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координаты z точки А: ");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координаты x точки В: ");
int x2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координаты y точки В: ");
int y2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координаты z точки В: ");
int z2 = Convert.ToInt32(Console.ReadLine());

double distance3D = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));

Console.Write("Расстояние между двумя точками в 3D пространстве: ");
Console.WriteLine(Math.Round(distance3D,2)); //после запятой оставляет для вывода только 2 знака числа

