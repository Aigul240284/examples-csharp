// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5
Console.Clear();
int A = new Random().Next();
int CountNumbers = GetCountNumbers(A);
// Console.WriteLine (A);
// while (A > 0)
// {A = A/10;
// a ++;}
Console.WriteLine($"{A} ->{CountNumbers}");
int GetCountNumbers (int A)
{
        int count = 0;
        while (A > 0)
        {
            A = A/10;
            count ++;
        }
        return count;
}
    