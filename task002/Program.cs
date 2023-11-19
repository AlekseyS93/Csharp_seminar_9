// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

using System;

public class AkkermanFunction
{
    static int CalculateAkkermanFunction(int m, int n) 
    {
        // Base cases for m and n
        if (m == 0 || n == 0) 
            return (m==0) ? n+1 : (n==0) ? 2*m : 1;

        // Recursive case 
        return (CalculateAkkermanFunction(m-1, 1) +
                CalculateAkkermanFunction(n, CalculateAkkermanFunction(m, n-1)) );
    } 

    public static void Main() 
    { 
        int m = int.Parse(Console.ReadLine().Trim()); 
        int n = int.Parse(Console.ReadLine().Trim());
        
        Console.WriteLine("A(" + m + ", " + n + ") = " + 
                          CalculateAkkermanFunction(m, n).ToString()); 
     } 
}