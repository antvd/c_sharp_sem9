// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// System.Console.WriteLine("Введите первое число");
// int numberA = int.Parse(Console.ReadLine());
// System.Console.WriteLine("Введите второе число");
// int numberB = int.Parse(Console.ReadLine());
// SumOfNaturalNumbers(numberA, numberB);

// void SumOfNaturalNumbers(int numberA, int numberB) 
// { 
//     int sum = 0; 
//     for (int i = numberA; i <= numberB; i++) 
//     { 
//         sum += i; 
//     } 
//     System.Console.WriteLine(sum);
// }


// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

System.Console.WriteLine("Введите первое неотрицательное число");
int m = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите второе неотрицательное число");
int n = int.Parse(Console.ReadLine());

int Ackermann(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0)
    {
        return Ackermann(m - 1, 1);
    }
    else
    {
        return Ackermann(m - 1, Ackermann(m, n - 1));
    }
}

int PrintAckermann = Ackermann(m, n);
System.Console.WriteLine(PrintAckermann);