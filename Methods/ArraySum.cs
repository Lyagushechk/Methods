using System;

namespace ConsoleApp
{
    public class ArraySum
    {
        public static void ArraySumMethod(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum = sum + array[i];
            }
            Console.WriteLine(sum);
        }
    }
}
