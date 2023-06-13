/*  Примеры методов
bool isEqual = CeckEqual(1,3);
bool isEqual2 = CeckEqual(3,3);
bool isEqual3 = CeckEqual(6,3);

if (CeckEqual(3,3))
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}

bool CeckEqual(int a, int b)
{
    return a == b;
}
*/




/*
Console.WriteLine("Введите координаты");

int x = int.Parse(Console.ReadLine());
int y = int.Parse(Console.ReadLine());
int qarterNumber = DetermineQarterNumber(x, y);

if (qarterNumber == -1)
{
    Console.WriteLine("Вы ввели координату равную нулю");
    return;
}

Console.WriteLine(qarterNumber);

int DetermineQarterNumber(int x, int y)
{
    if (x > 0 & y > 0)
    {
        return 1;
    }

    if (x < 0 & y > 0)
    {
        return 2;
    }

    if (x < 0 & y < 0)
    {
        return 3;
    }

    if (x > 0 & y < 0)
    {
        return 4;
    }

    return -1;
}
*/



/*
Console.WriteLine("Введите четверь");

int qarterNumber = int.Parse(Console.ReadLine());
string result = GetRangeBeQarterNumber(qarterNumber);

if (qarterNumber > 4 | qarterNumber < 1)
{
    Console.WriteLine("четверть отсутствует");
    return;
}

Console.WriteLine(result);

// Метод с командой "if" :
//string GetRangeBeQarterNumber(int qarterNumber)
//{
// if (qarterNumber == 1)
// {
//     return "x > 0 & y > 0";
//}

//if (qarterNumber == 2)
// {
//    return "x < 0 & y > 0";
// }

// if (qarterNumber == 3)
//  {
//    return "x < 0 & y < 0";
//  }

//if (qarterNumber == 4)
//{
//  return "x > 0 & y < 0";
//}
//return string.Empty;
//далее - медод с командой "switch" 


string GetRangeBeQarterNumber(int qarterNumber)
{
    switch (qarterNumber)
    {
        case 1: return "x > 0 & y > 0";
        case 2: return "x < 0 & y > 0";
        case 3: return "x < 0 & y < 0";
        case 4: return "x > 0 & y < 0";
        default: return string.Empty;
    }
}
*/




/*
Console.WriteLine("Введите  координаты первой точки");
Console.Write("x1 = ");
int x1 = int.Parse(Console.ReadLine());
Console.Write("y1 = ");
int y1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите  координаты второй точки");
Console.Write("x2 = ");
int x2 = int.Parse(Console.ReadLine());
Console.Write("y2 = ");
int y2 = int.Parse(Console.ReadLine());

double distance = DistanceBetweenTwoPoints(x1,y1,x2,y2);

Console.WriteLine("Расстояние между точками = ");
Console.Write(Math.Round(distance,2));

double DistanceBetweenTwoPoints(int x1, int y1, int x2, int y2)
{
    // √(xb - xa)^2 + (yb - ya)^2
    double result = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
    return result;
    
    // или:
    // return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
}
*/






 /* Console.WriteLine("Введите  число");
 Console.Write("number = ");
int n = int.Parse(Console.ReadLine());

int[] result = PrintTableOfSquares(n);*/

/*Console.WriteLine(string.Join(",",result)); // используется для вывода массива*/


//void PrintTableOfSquares(int n)
//{
//    for (int i = 1; i <= n; i++)
//    {
//        Console.Write(i*i);
//        Console.Write(" ");
//    }
//}
/*
int[] PrintTableOfSquares(int number)
{
    int[] tableOfSquares = new int[number];

    for (int i = 0; i < tableOfSquares.Length; i++)
    {
        int tmp = i + 1;
        tableOfSquares[i] = tmp * tmp;
    }
    return tableOfSquares;
}
*/




//Задача 30: Напишите программу, которая выводит массив из 8 элементов,
// заполненный нулями и единицами в случайном порядке.
//[1,0,1,1,0,1,0,0]


int length = int.Parse(Console.ReadLine());
int[] array = GetRandomArray(length);

Console.WriteLine(string.Join(",", array));

int[] GetRandomArray(int length)
{
    int[] array = new int[length];

    Random random = new Random();

    for (var i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(0, 2);
    }
    return array;
}
