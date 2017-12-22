using System;
using System.Collections;
using System.Linq;

namespace Arrays_Left_Rotation
{
    class Solution
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Number of Integers <space> Number of left rotations: ");
            int[] inputArr1 = Console.ReadLine().Split(' ').Select(n => Convert.ToInt32(n)).ToArray();

            Console.WriteLine("Enter array with spaces: ");
            int[] inputArr = Console.ReadLine().Split(' ').Select(n => Convert.ToInt32(n)).ToArray(); ;

            Console.WriteLine(  LeftShift(inputArr, inputArr1[1]));
        }

        private static string LeftShift(int[] inputArr, int rotationsCount)
        {
            var queue = new Queue(inputArr);
            for (int i = 0; i < rotationsCount; i++)
            {
                queue.Enqueue(queue.Peek());
                queue.Dequeue();
            }
            return String.Join(" ", queue.ToArray().Select(p => p.ToString()));
        }
    }
}
