// 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии
// int n = InputInt("Введите положительное число");
// int m = 1;
// if (n < 1)
// {
//  Console.WriteLine("Ввели не положительное число");
// }
// Console.WriteLine(NaturalNumber(n, m));

// int NaturalNumber(int n, int m)
// {
//  if (n == m)
//  return n;
//  else
//  Console.Write($"{NaturalNumber(n, m + 1)}, ");
//  return m;
// }

// int InputInt(string output)
// {
//  Console.Write(output);
//  return int.Parse(Console.ReadLine());
// }








///Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.


// int m = int.Parse(Console.ReadLine());
// int n = int.Parse(Console.ReadLine());

// Console.WriteLine("Сумма элементов равна " + Sum(m, n)); ;

// static int downNumber(int n)
// {
//     Console.WriteLine(n);

//     if (n == 1)
//     {
//         return 1;
//     }

//     return downNumber(n - 1);
// }


// static int Sum(int m, int n)
// {
//     if (m == n)
//     {
//         return n;
//     }

//     return m + Sum(m + 1, n);
// }

//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
Console.WriteLine("Введите два положительных числа: M и N.");
int m = InputInt("Введите M: ");
int n = InputInt("Введите N: ");
Console.WriteLine($"A({m}, {n}) = {Akkerman(m, n)}");

int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}

int Akkerman(int m, int n)
{
    if (m == 0)
        return n + 1;
    if (m > 0 && n == 0)
        return Akkerman(m - 1, 1);
    else
        return Akkerman(m - 1, Akkerman(m, n - 1));
}