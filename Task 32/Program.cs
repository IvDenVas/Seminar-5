// Напишите программу замена элементов массива: 
//положительные элементы замените на соответствующие отрицательные, и наоборот.
int num;

while (true)
{
    Console.Write("Введите размер массива: ");
    if (int.TryParse(Console.ReadLine(), out num))
        if (num > 0)
            break;
    Console.WriteLine("Ошибка ввода!");
}


int[] array = GetArray(num, -99, 99);
Console.WriteLine(String.Join(", ", array));
ReplaceSign(array);
Console.WriteLine(String.Join(", ", array));


int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res; 
}

void ReplaceSign(int[] array)
{
   
    for (int i = 0; i < array.Length; i++)
    {
        array[i] *=-1;

    }
}



// int GetPositiveRep(int[] arr)
// {
//     int[] res = new int[];
//     foreach (int el in arr)
//     {
//         if (el > 0) el = el * -1;
//     }
//     return res;
// }