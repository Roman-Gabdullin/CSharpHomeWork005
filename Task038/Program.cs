// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементами массива.
// [3 7 22 2 78] -> 76

Console.Write("Введите количество элементов массива: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное число массива: ");
int minnum = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное число массива: ");
int maxnum = Convert.ToInt32(Console.ReadLine());

double [] massive = GetArray(length, minnum, maxnum);
PrintArray(massive);
Console.WriteLine();
double minel = MinEl(massive);
double maxel = MaxEl(massive);
double diff = Difference(maxel, minel);
Console.Write($"Разница между максимальным и минимальным элементом массива = {diff}");


double[] GetArray(int len, int mn, int mx)
{
    double[] array = new double[len];
    var rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(mn, mx);
    }
    return array;
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

double MinEl(double[] array)
{
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
        min = array[i];
    }
    return min;
}

double MaxEl(double[] array)
{
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        max = array[i];
    }
    return max;
}

double Difference(double max, double min)
{
    double diff = max - min;
    return diff;
}

