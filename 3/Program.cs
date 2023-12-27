// Задача 3: Задайте произвольный массив. Выведете
// его элементы, начиная с конца. Использовать
// рекурсию, не использовать циклы.

void PrintArrayReverse(int[] arr, int index)
{
    if (index < 0) return;

    Console.WriteLine(arr[index]);
    PrintArrayReverse(arr, index - 1);
}

int [] array = {4, 2, 5, 7, 34, 12};

PrintArrayReverse(array, array.Length - 1);


