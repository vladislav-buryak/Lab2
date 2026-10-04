using System;

// A
Console.Write("а) Введіть чотиризначне число: ");
int n = int.Parse(Console.ReadLine()!);

bool fourDigits = n >= 1000 && n <= 9999;
bool palindrome = fourDigits
                  && n / 1000 == n % 10
                  && n / 100 % 10 == n / 10 % 10;

Console.WriteLine(palindrome ? "TRUE" : "FALSE");

// B
Console.Write("б) Введіть a, b, c через пробіл: ");
string[] p = Console.ReadLine()!.Split(' ', StringSplitOptions.RemoveEmptyEntries);
double a = double.Parse(p[0]);
double b = double.Parse(p[1]);
double c = double.Parse(p[2]);

bool geometric = a * b >= 0 && c >= 0
                 && Math.Abs(c - Math.Sqrt(a * b)) < 1e-9;

if (geometric)
    Console.WriteLine("TRUE");
else
    Console.WriteLine("FALSE");