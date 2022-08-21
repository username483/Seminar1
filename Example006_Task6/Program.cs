Console.Clear();
Console.Write("Введите число ");
int lastNum=int.Parse(Console.ReadLine());

//математическое решение
while (lastNum>=10)
{
    lastNum=lastNum-10;

} 
Console.WriteLine($"{lastNum}");

// решение с использованием функции lastNum

Console.WriteLine($"Последнее число {lastNum % 10} " );
