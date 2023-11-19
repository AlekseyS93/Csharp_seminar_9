// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int ReadInt(string text)
{
    System.Console.Write(text);
    return Math.Abs(Convert.ToInt32(Console.ReadLine()));
}

int CountSumma(int m, int n)
{
    if (m > n)

        return 0;
    else

        return m + CountSumma(m + 1, n);

}

//---------------------------------------
int m = ReadInt("Введите число M: ");
int n = ReadInt("Введите число N: ");

if (m > n)                // проверка на большее и меньшее число
{
    int temp = m;
    m = n;
    n = temp;
}

int sum = CountSumma(m, n);
System.Console.WriteLine(sum);