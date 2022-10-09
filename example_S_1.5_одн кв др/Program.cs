// Напишите программу, которая принимает на вход два числа и проверяет, 
// является ли одно число квадратом другого.
//5, 25  ->  да
//-4, 16  ->  да
//25, 5  ->  да
//8,9  ->  нет
Console.Clear();

Console.WriteLine("Введите первое число");
int a1 = int.Parse(Console.ReadLine() ?? "");
Console.WriteLine("Введите второе число");
int a2 = int.Parse(Console.ReadLine() ?? "");

if (a1*a1 == a2)
    Console.WriteLine($"{a1}, {a2} -> да");
    
else
    if (a2*a2 == a1)
    Console.WriteLine($"{a1}, {a2} -> да");
    else
    Console.WriteLine($"{a1}, {a2} -> нет");
    

