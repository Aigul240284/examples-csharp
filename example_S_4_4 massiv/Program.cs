﻿// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]
Console.Clear();

int[] array = GetRandomNumbers(8);
for (int i = 0; i < 8; i++)
{
Console.Write(array[i] + " ");
}



int[] GetRandomNumbers(int Size)
  {
    int[] num = new int[Size];
    for (int i = 0; i < Size; i++)
      {
        num[i] = new Random().Next(0, 2);
      }

    return num;
  }












