
int i=number;


if (number<0)
{
    number=number*-1;
}
else if (number >0)
{
    i=i*-1;
}
else{
    System.Console.WriteLine("0");
}
while(i<number)
{
    System.Console.WriteLine(i);
    i++;
}
System.Console.WriteLine(number);