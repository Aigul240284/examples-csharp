// Напишите программу, которая принимает на вход число и проверяет, 
// кратно ли оно одновременно 7 и 23.
//14 -> нет 
//46 -> нет 
//161 -> да

Console.WriteLine("Введите число");
int a1 = int.Parse(Console.ReadLine() ?? "");

if (a1 % 7 == 00)
    if (a1% 23 ==00)
    Console.WriteLine($"{a1} -> да");
else
 Console.WriteLine($"{a1} -> нет");
