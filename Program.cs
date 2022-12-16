// (1) Задача 65: Задайте значения M и N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

// (2) Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

// (3) Задача 69: Напишите программу, которая на вход принимает два числа A и B, 
// и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

Console.Write("Введите номер задачи: ");
int n = Convert.ToInt32(Console.ReadLine());
if(n == 1) Task65();
else if(n == 2) Task67();
else if(n == 3) Task69();

void Task65()  // (1)
{
    Console.Write("Введите число 1: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите число 2: ");
    int n = Convert.ToInt32(Console.ReadLine());
    if(m <= n && m>0 && n>0)
        Recursion(m,n);
    else Console.WriteLine("Введите числа корректно");
    void Recursion(int m, int n)
    {
        if(m > n)
            return;
        Console.Write($"{m} ");
        m++; 
        Recursion(m,n);
    }   
}

void Task67()    // (2)
{
    Console.Write("Введите число: ");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(Sum(n));
    int Sum(int n)
    {
        if(n < 1)
            return 0;
        return n%10+Sum(n/10);    
    }
}

void Task69()   // (3)
{
    Console.Write("Введите число 1: ");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите число 2: ");
    int b = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(Pow(a,b));
    int Pow(int a, int b)
    {
        if(b == 1)
            return a;
        b--;    
        return a*Pow(a,b);
    }

}
