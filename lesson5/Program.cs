//Задача 31: Задайте массив из 12 элементов, заполненный случайными числами 
//из промежутка [-9, 9]. Найдите сумму отрицательных и положительных 
//элементов массива.

/*
int[] GenerateArray(int length) // заполняет массив случайными значениями в диапазоне от -9 до 9
{
    int[] array = new int[length];
    Random random = new Random();
    for (var i = 0; i < length; i++)
    {
        array[i] = random.Next(-9, 10);
    }

    return array;
}

//int CalcukateSumPositiveAndNegativeNumbers(int[] array) //находит сумму положительных, сумму отрицательных элементов массива и возвращает их разницу
//{
//    int sumPositive = 0;
//    int sumNegative = 0;
//    for (var i = 0; i < array.Length; i++)
//    {
//        if (array[i] > 0)
//        { sumPositive += array[i]; }
//        else
//        { sumNegative += array[i]; }
//    }
//    return sumPositive + sumNegative;
//}

void PrintArray (int[] array) // Метод, печатающий массив
{
    Console.WriteLine(string.Join(" ", array));
}

int CalculatePositiveSum(int[] array)// метод, ищет в массиве сумму положительных элементов
{
    int sumPositive = 0;
    for (var i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        { sumPositive += array[i]; }
    }
    return sumPositive;
}

int CalculateNegativeSum(int[] array) // метод, ищет в массиве сумму отрицательных элементов
{
    int sumNegative = 0;
    for (var i = 0; i < array.Length; i++)
    {
        if (array[i] < 0)
        { sumNegative += array[i]; }
    }
    return  sumNegative;
}


int[] array = GenerateArray(12);
PrintArray(array);

int positiveSum = CalculatePositiveSum(array);
int negativeSum = CalculateNegativeSum(array);
Console.WriteLine($" Сумма положительных чисел равна {positiveSum}, сумма отрицательных чисел равна {negativeSum}");
*/





//Задача 32: Напишите программу замена элементов массива:
// положительные элементы замените на соответствующие отрицательные, и наоборот.

/*
int[] GenerateArray(int length) // заполняет массив случайными значениями в диапазоне 
{
    int[] array = new int[length];
    Random random = new Random();
    for (var i = 0; i < length; i++)
    {
        array[i] = random.Next(-15, 15);
    }
    return array;
}

void PrintArray(int[] array) // Метод, печатающий массив
{
    Console.WriteLine(string.Join(" ", array));
}

int[] AntiArray(int[] array) // Заменяет положительные элементы на отрицательные и наоборот
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = -array[i];
    }
    return array;
}

int[] array = GenerateArray(8);
PrintArray(array);

int[] anti = AntiArray(array);
PrintArray(anti);
*/



//Задача 33: Задайте массив. Напишите программу, которая определяет,
// присутствует ли заданное число в массиве.

/*
int[] GenerateArray(int length) // заполняет массив случайными значениями в диапазоне 
{
    int[] array = new int[length];
    Random random = new Random();
    for (var i = 0; i < length; i++)
    {
        array[i] = random.Next(0, 11);
    }
    return array;
}

void PrintArray(int[] array) // Метод, печатающий массив
{
    Console.WriteLine(string.Join(" ", array));
}

string SearchNumber(int[] array, int num) // ищет заданное число в массиве
{
    for (var i = 0; i < array.Length; i++)
    {
        if (array[i] == num)
        { return "да"; }
    }
    return "нет";

}

int n = int.Parse(Console.ReadLine());

int[] array = GenerateArray(5);
PrintArray(array);
Console.WriteLine(SearchNumber(array, n));
*/




/*Задача 35: Задайте одномерный массив из 123 случайных чисел.
Найдите количество элементов массива, значения которых лежат в
отрезке [10,99].*/

/*
int[] GenerateArray(int length) // заполняет массив случайными значениями в диапазоне 
{
    int[] array = new int[length];
    Random random = new Random();

    for (var i = 0; i < length; i++)
    { array[i] = random.Next(0, 134); }
    return array;
}

void PrintArray(int[] array) // Метод, печатающий массив
{ Console.WriteLine(string.Join(" ", array)); }

int SearchNumber(int[] array) // ищет количество элементов в заданном диапазоне
{
    int j = 0;
    for (var i = 0; i < array.Length; i++)
    {
        if (array[i] >= 10 & array[i] <= 99)
        { j++; }
    }
    return j;
}


int[] array = GenerateArray(123);
PrintArray(array);*/
//int result = SearchNumber(array);

//Console.WriteLine(result);




//Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
//и т.д. Результат запишите в новом массиве.


int[] array = new int[4];
FillArray(array, 0, 11);

int[] array2 = MultiplikateOfPairs(array);
PrintArray(array2);


void FillArray(int[] array, int a, int b)
{
    Random random = new Random();

    for (var i = 0; i < array.Length; i++)
    { array[i] = random.Next(a, b); }
    Console.WriteLine(string.Join(" ", array));
}

void PrintArray(int[] array) // Метод, печатающий массив
{ Console.WriteLine(string.Join(" ", array)); }

int[] MultiplikateOfPairs(int[] array)
{
    int isCetnoe = array.Length % 2;

    int[] array2 = new int[array.Length / 2 + isCetnoe];

    for (var i = 0; i < array2.Length; i++)
    {
        if (isCetnoe == 0)
        { array2[i] = array[i] * array[array.Length - 1 - i]; }

        else
        {
            array2[i] = array[i] * array[array.Length - 1 - i];
            if (i == array.Length / 2 + isCetnoe - 1)
            {
                array2[i] = array[i];
            }
        }
    }
    return array2;
}
