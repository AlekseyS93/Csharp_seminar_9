// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29



int ReadInt(string text)
{
    System.Console.Write(text);
    return Math.Abs(Convert.ToInt32(Console.ReadLine()));
}

int AckFunc(int m, int n)
{
    if (m == 0)
        return n + 1;
    else if (m > 0 && n == 0)
        return AckFunc(m - 1, 1);
    else
        return AckFunc(m - 1, AckFunc(m, n - 1));
}

//---------------------------------------
int m = ReadInt("Введите число M: ");
int n = ReadInt("Введите число N: ");
int result = AckFunc(m, n);
System.Console.WriteLine(result);