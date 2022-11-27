// Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, 
//второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

Console.Clear();
int num;

while (true)
{
    Console.Write("Введите размер массива: ");
    if (int.TryParse(Console.ReadLine(), out num))
        if (num > 0)
            break;
    Console.WriteLine("Ошибка ввода!");
}

int[] array = GetArray(num, -9, 9);
Console.WriteLine(String.Join(" ", array));

multArray(array);

void multArray(int[] array)
{
    int multNum = 1;
    for (int i = 0; i < array.Length / 2; i++)
    {
        multNum = array[i] * array[array.Length - i -1];
        Console.Write($"{multNum} ");
    }
}



int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}