/*
Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int start = -Math.Abs(n);
int finish = Math.Abs(n);;

Console.WriteLine("Начало вывода:");
while (start <= finish)
{
    Console.WriteLine(start);
    start++;
}
*/

Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
//int b;
//b=n%10;
if (n>99&& n < 1000)
{
Console.WriteLine("Последнее число: ");
Console.WriteLine(n%10);
}
else
{
    Console.WriteLine("Вы ввели не трехзначное число");
}
