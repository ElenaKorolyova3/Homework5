﻿// // Задача 34: Задайте массив заполненный случайными положительными 
// трёхзначными числами. Напишите программу, которая покажет 
// количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int size = 4;
int[] nums = GetArray(size);
Console.WriteLine(string.Join(", ", nums));

int[] GetArray(int size)
{
    int[] result = new int [size];
    Random rnd = new Random();
    for(int i = 0; i < size; i++)
        result[i] = rnd.Next(100, 1000);
   
    return result;
}
int CountNumPlus(int[] array)
{
int result = 0;
for(int i = 0; i < size; i++)
    {
         if (array[i] % 2 == 0)
         {      
            result = result + 1;
         }
     }
     return result;
 }

Console.WriteLine($"Количество чётных чисел в массиве равно: {CountNumPlus(nums)}");

