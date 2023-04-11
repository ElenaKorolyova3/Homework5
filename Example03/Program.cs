// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int size = 5;
double[] nums = GetArray(size);
Console.WriteLine(string.Join(", ", nums));

double[] GetArray(int size)
{
    double[] result = new double [size];
    Random rnd = new Random();
    for(int i = 0; i < size; i++)
        result[i] = rnd.Next (0, 100);
    return result;
}

double NumMax = nums[0];
double NumMin = nums[0];

for (int i = 0; i < nums.Length; i++)
{
    if (nums[i] > NumMax)
    {
        NumMax = nums[i];
    }
    else if (nums[i] < NumMin)
    {
        NumMin = nums[i];
    }
}

Console.WriteLine($"Максимальное число: {NumMax}");
Console.WriteLine($"Минимальное число: {NumMin}");
Console.WriteLine($"Разница между максимальным и минимальным числами: {NumMax-NumMin}");
