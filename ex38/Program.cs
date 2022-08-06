using Extensions;

//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// 
// [3 7 22 2 78] -> 76

double[] doubleArray = new double[10].FillArrayRandomDouble(10,2);

double diffMinMax = GetDiffMinMax(doubleArray);

Console.WriteLine($"{doubleArray.WriteArrayAsString()} -> {diffMinMax:F2}");



double GetDiffMinMax(double[] array)
{
    double min = array[0];
    double max = array[0];

    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
            continue;
        }
        if(array[i] > max)
            max = array[i];
    }

    return max - min;
}
