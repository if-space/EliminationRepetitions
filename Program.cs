using System;

namespace Lessons
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstArray = {"1","2","1" };
            string[] secondArray = { "3","2", };

            List<string> result = new List<string>();

            MergingArray(firstArray, result);
            MergingArray(secondArray, result);

            Console.WriteLine($"{string.Join(",", result)}");
        }

        static void MergingArray(string[] source, List<string> result)
        {
           foreach(var value in source)
           {
                if (!result.Contains(value))
                {
                    result.Add(value);
                }
           }
        }
    }
}
