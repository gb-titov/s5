using System.Runtime.CompilerServices;
using Extensions;

int[] array = new int[9].FillArrayRandomInt(1,10);

var newArray = MultiplyArray(array);

Console.WriteLine(array.WriteArrayAsString() + " -> " + newArray.WriteArrayAsString());



int[] MultiplyArray(int[] array)
{
    int[] newArray;
    int baseArrayLength = array.Length / 2;
    if (array.Length % 2 == 0)
    {
        newArray = new int[baseArrayLength];
    }
    else
    {
        newArray = new int[baseArrayLength + 1];
        newArray[baseArrayLength] = array[baseArrayLength];
    }

    for (int i = 0; i < baseArrayLength; i++)
    {
        newArray[i] = array[i] * array[array.Length - 1 - i];
    }

    return newArray;
}

