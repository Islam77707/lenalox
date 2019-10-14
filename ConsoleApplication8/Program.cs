using System;

namespace ConsoleApplication8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 1, -12, 124, 1, 4, 5, -1, -6 };
            int NumPlus;
            int ReversNum;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    NumPlus = array[i];
                    Console.WriteLine(NumPlus);
                }
                //ReversNum = -array[i];
                //Console.WriteLine(-array[i]); 
            }
            //foreach (int i in array)
            //{
            //    Console.WriteLine(-(array[i]));
            //}
            Console.ReadKey();
        }
    }
}
