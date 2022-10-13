// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120
Console.Clear();

Console.WriteLine ("Введите число N");
int N = Convert.ToInt32(Console.ReadLine());
int fac = GetFactirial(N);
Console.Write(fac);

int GetFactirial(int N)
{

    int a = 1;
    int fac = 1;
    {
        while (a<=N)
        {
            fac = a * fac;
             a++;
        }
        return fac;
    }
} 



