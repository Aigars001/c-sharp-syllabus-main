using System;

namespace Exercise10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, -11, -12, -13, -14, -15 };
            int[] arr1 = new int[] {};
            int[] arr2 = new int[] { 92, 6, 73, -77, 81, -90, 99, 8, -85, 34 };

            Console.WriteLine(String.Join(" ", CountAndSum(arr2)));
            Console.ReadKey();
        }

        static int[] CountAndSum(int[] arr)
        {
            int positivesCount = 0;
            int negativesSum = 0;
            int[] resultArray = new int[2];

            if (arr.Length > 0)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] > 0)
                    {
                        positivesCount++;
                    }
                    else if (arr[i] < 0)
                    {
                        negativesSum += arr[i];
                    }
                }

                resultArray[0] = positivesCount;
                resultArray[1] = negativesSum;
                
                return resultArray;
            }

            return arr;
        }
    }
}
