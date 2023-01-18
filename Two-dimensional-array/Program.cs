using System;

namespace Two_dimensional_array
{
    class Program
    {
        static void Main(string[] args)
        {


            int[,] arr = new int[3, 3]
                {
                      {1,2,3},
                      {4,5,6},
                      {7,8,9},
                };
            int sum = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        sum += arr[i, j];
                    }

                }

            }

            Console.WriteLine(sum);













        }
    }
}
