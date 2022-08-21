Console.Clear();
Console.Write("Введите число ");
int number=int.Parse(Console.ReadLine());

while (number>=10)
{
    number=number-10;

} 
Console.Write($"{number}");
