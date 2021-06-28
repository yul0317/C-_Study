using System;

namespace _20210628_Two
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = -1;

            while (N <= 1 || N >= 1000000)
            {
                N = Convert.ToInt32(Console.ReadLine());
            }

            int num_flag = -1;
            int[] array = new int[N];
            while (num_flag == -1)
            {
                
                string[] inputNumber = Console.ReadLine().Split();
                for (int i = 0; i < N; i++)
                {
                    array[i] = Convert.ToInt32(inputNumber[i]);
                }
                foreach (int i in array)
                {
                    if (i < -1000000 || i > 1000000)
                    {
                        num_flag = -1;
                    }
                    else
                    {
                        num_flag = 1;
                    }
                }
            }

            Array.Sort(array);
            Console.WriteLine(array[0]+" "+array[N-1]);
            

        }
    }
}
