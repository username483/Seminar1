Console.Clear(); //очищает консоль перед каждым новым запуском программы
Console.Write("Введите число ");
int number = int.Parse(Console.ReadLine()); //Console.Readline работает 
//только с типом переменных string (строковым), 
//а нам нужны целые числа, поэтому мы добавляем Parse

//Решение математическим путем
int sqr = number * number;
Console.WriteLine($"Квадрат числа {number} равен {sqr}");// Console.WriteLine работает
//только с типом переменных string (строковым), 
//а нам нужно вывести значения {number} {sqr}, поэтому мы добавляем амперсант $

//Решение с использованием библиотеки (готовые функции С#)
int sqr2 = Convert.ToInt32(Math.Pow(number,2));// Convert.ToInt32 конвертирует строковое значение
//введенное с клавиатуры в тип данных int (аналогично int.Parse)
// Math.Pow это возведение числа (number) в степень 2
Console.WriteLine($"Квадрат числа {number} равен {sqr2}");

