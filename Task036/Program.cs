// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Write("Введите количество элементов массива: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное число массива: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное число массива: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] massive = GetArray(length, min, max);
PrintArray(massive);
Console.WriteLine();
int sumofelono = SumOfElementsOnOdd(massive);
Console.Write($"Сумма элементов массива, стоящих на нечетных позициях = {sumofelono}");

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

int SumOfElementsOnOdd(int[] array)
{
    int soeoo = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if ( i == 1 || i % 2 != 0)
        soeoo = soeoo + array[i];
    }
    return soeoo;
}
