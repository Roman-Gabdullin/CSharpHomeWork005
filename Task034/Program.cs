// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2



Console.Write("Введите количество элементов массива: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальный элемент массива: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальный элемент массива: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] massive = GetArray(length, min, max);
PrintArray(massive);
Console.WriteLine();
int numOfEvNum = NumberOfEvenNumbers(massive);
Console.Write($"Количество четных эллементов массива = {numOfEvNum}");

int[] GetArray(int len, int mn, int mx)
{
    int[] array = new int[len];
    var rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(mn, mx);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

int NumberOfEvenNumbers(int[] array)
{
    int noen = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            noen++;
        }
    }
    return noen;
}