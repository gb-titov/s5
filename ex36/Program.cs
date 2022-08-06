using Extensions;

//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int[] intArray = new int[4].FillArrayRandomInt(-100, 100);
int oddSum = GetOddSum(intArray);

Console.WriteLine($"{intArray.WriteArrayAsString()} -> {oddSum}");


int GetOddSum(int[] array)
{
    int sum = array[1];
    for (int i = 3; i < array.Length; i+=2)
    {
        sum+=array[i];
    }
    return sum;
}