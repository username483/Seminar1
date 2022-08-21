Console.Clear();
Console.Write("Введите первое число ");
int number1=int.Parse(Console.ReadLine());
Console.Write("Введите второе число ");
int number2=int.Parse(Console.ReadLine());

if (Convert.ToInt32(Math.Pow(number1,2))==number2)
    {Console.WriteLine($"Квадрат числа {number1} равен введенному вами числу {number2}");}
else
   {Console.WriteLine($"Квадрат числа {number1} не равен введенному вами числу {number2}");}






