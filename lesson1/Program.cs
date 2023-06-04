/*1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
a = 5; b = 25 -> да a = 2 b = 10 -> нет a = 9; b = -3 -> нет a = -3 b = 9 -> да */

/*Console.WriteLine("Введите число a");

int a = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число b");

int b = int.Parse(Console.ReadLine());

if (a*a == b){

Console.WriteLine("Yes");}
else 
{Console.WriteLine("No");}
*/




/* 2. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
3 -> Среда 5 -> Пятница */

/*Console.WriteLine("Введите число");

int number = int.Parse(Console.ReadLine());

if (number == 1)
{ Console.WriteLine("Понедельник"); }

if (number == 2)
{ Console.WriteLine("Вторник"); }

if (number == 3)
{ Console.WriteLine("Среда"); }

if (number == 4)
{ Console.WriteLine("Четверг"); }

if (number == 5)
{ Console.WriteLine("Пятница"); }

if (number == 6)
{ Console.WriteLine("суббота"); }

if (number == 7)
{ Console.WriteLine("Воскресенье"); }

if (number > 7 | number < 1)
{ Console.WriteLine("Некорректное значение"); } 
*/




/* 3. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 2 -> " -2, -1, 0, 1, 2" */

/*Console.WriteLine("Введите число");

int N = int.Parse(Console.ReadLine());

int i = -N;

while (i <= N)
{
    Console.Write(i);
    Console.Write(" ");
    i++;
}
*/





/* 4. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
456->6
782->2
918->8*/

Console.WriteLine("Введите трехзначное число");

int number = int.Parse(Console.ReadLine());

if (number < 100 | number > 999)
{
    Console.WriteLine("Недопустимое значение");
    return;
}

double result = (double)number % 10;

Console.WriteLine(result);