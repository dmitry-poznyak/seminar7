// Задача 1: Задайте значения M и N. Напишите
// программу, которая выведет все натуральные числа
// в промежутке от M до N. Использовать рекурсию, не
// использовать циклы.


int ReadInt(string msg)
{
    System.Console.WriteLine(msg);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintNaturalNumbers(int m, int n)
{
    if(m <= n)
    {
        System.Console.Write(m + " ");
        PrintNaturalNumbers(m + 1, n);
    } 
}

int M = ReadInt("Введите первое натуральное число: ");
int N = ReadInt("Введите второе натуральное число: ");

PrintNaturalNumbers(M, N);















