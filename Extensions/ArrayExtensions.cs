using System.Runtime.CompilerServices;
using System.Text;

namespace Extensions
{
    public static class ArrayExtensions
    {
        public static int[] FillArrayRandomInt(this int[] array, int minValue, int maxValue)
        {
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(minValue, maxValue);
            }
            return array;
        }
        /// <summary>
        /// Заполнение массива случайными дробными числами
        /// </summary>
        /// <param name="array">массив для заполнения</param>
        /// <param name="factor">множитель для получения значений больше 1</param>
        /// <param name="round">округлить до знака</param>
        /// <returns></returns>
        public static double[] FillArrayRandomDouble(this double[] array, int factor = 1, int? round = null)
        {
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                var val = rnd.NextDouble() * factor;
                array[i] = round == null ? val : Math.Round(val, (int)round);
            }
            return array;
        }

        public static string WriteArrayAsString(this int[] array)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("[");
            for (int i = 0; i < array.Length; i++)
            {
                sb.Append(array[i]);
                if(i < array.Length - 1)
                    sb.Append(", ");
            }
            sb.Append("]");

            return sb.ToString();
        }
        public static string WriteArrayAsString(this double[] array)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("[");
            for (int i = 0; i < array.Length; i++)
            {
                sb.Append(array[i]);
                if (i < array.Length - 1)
                    sb.Append(", ");
            }
            sb.Append("]");

            return sb.ToString();
        }

    }
}
