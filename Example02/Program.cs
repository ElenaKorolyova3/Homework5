// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int size = 4;
int[] nums = GetArray(size);
Console.WriteLine(string.Join(", ", nums));

int[] GetArray(int size)
{
    int[] result = new int [size];
    Random rnd = new Random();
    for(int i = 0; i < size; i++)
        result[i] = rnd.Next(-99, 100);
    return result;
}
int SumNum(int[] array)
{
int result = 0;
for(int i = 0; i < size; i = i + 2)
    {    
        result = result + array[i];   
    }
    return result;
}

Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях равна: {SumNum(nums)}");

