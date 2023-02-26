// Из имеющегося массива строк сформировать массив из строк, длина которых меньше, либо равна 3 символа.

Console.WriteLine("Введите несколько слов или чисел: --> ");
string wordsmassiv = Convert.ToString(Console.ReadLine()); 
char[] delimiterChars = {' ', ',', '.', ':'};
string [] words = wordsmassiv.Split(delimiterChars);            

for (int n = 0; n < words.Length; n++)
{
    string simbols = words [n];
    
    if (simbols.Length <= 3)
    {
        Console.Write(($"{words[n]}, "));
    }
}