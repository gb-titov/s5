using Extensions;

//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

int[] intArray = new int[10].FillArrayRandomInt(100, 999);
int positiveCount = CountPositiveNums(intArray);

Console.WriteLine($"{intArray.WriteArrayAsString()} -> {positiveCount}");


int CountPositiveNums(int[] array)
{
    int counter = 0;
    foreach (var a in array)
    {
        if(a % 2 == 0)
            counter++;
    }
    return counter;
}