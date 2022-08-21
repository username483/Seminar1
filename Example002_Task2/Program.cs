Console.Clear();
Console.Write("Введите число ");
string? string1=Console.ReadLine();
int number = 0;

if (string1 !=null)
{
    number = int.Parse(string1);
}
//Решение математическим путем
int sqr = number * number;
Console.WriteLine($"Квадрат числа {number} равен {sqr}");
//Решение с использованием библиотеки (готовые функции С#)
int sqr2 = Convert.ToInt32(Math.Pow(number,2));
Console.WriteLine($"Квадрат числа {number} равен {sqr2}");
