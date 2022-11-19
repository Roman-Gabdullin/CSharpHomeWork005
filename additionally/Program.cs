// Дополнительно. Дан массив чисел. 
// Напишите функцию, которая ищет заданное число в массиве и показывает нужный индекс в нем. 
// При отсутствии числа возвращать -1.

Console.Write("Введите количество элементов массива: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное число массива: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное число массива: ");
int max = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите искомое значение: ");
int s = Convert.ToInt32(Console.ReadLine());

int[] massive = GetArray(length, min, max);
PrintArray(massive);
Console.WriteLine();
Search(s,massive);



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

void Search(int search,int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == search)
        {
            Console.Write($"Индекс искомого значения = {i} ");
            count++;
        }
    }
    if (count == 0)
    Console.Write("-1");
}