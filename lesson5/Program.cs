//Задача 31: Задайте массив из 12 элементов, заполненный случайными числами 
//из промежутка [-9, 9]. Найдите сумму отрицательных и положительных 
//элементов массива.


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

int CalcukateSumPositiveAndNegativeNumbers(int[] array) //находит сумму положительных, сумму отрицательных элементов массива и возвращает их разницу
{
    int sumPositive = 0;
    int sumNegative = 0;
    for (var i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        { sumPositive += array[i]; }
        else
        { sumNegative += array[i]; }
    }
    return sumPositive + sumNegative;
}

void PrintArray (int[] array) // Метод, печатающий массив
{
    Console.WriteLine(string.Join(" ", array));
}

int[] array = GenerateArray(12);
PrintArray(array);