// Задача 35: Задайте одномерный массив из 123 случайных чисел. 
//Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
//Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
//[5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5
Console.Clear();

int[] array = GetArray(5, 0, 200);
Console.WriteLine(String.Join(" ", array));
//int CountNumbers(int[] array);
Console.WriteLine(CountNumbers(array, 10, 99));

int CountNumbers(int[] arr, int firstNumber, int lastNumber)
{
    int count = 0;
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] >= firstNumber && arr[i] <= lastNumber) count ++;
    }
    return count;
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