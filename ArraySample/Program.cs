using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySample
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[]
            {
                1,2,3,4,5,6
            };

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(" " + array[i]);
            }

            Console.Read();

        }

        void Process(int[]arr)
        {
            if (arr != null)
                throw new AccessViolationException();
            if (arr != null)
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(" " + arr[i]);
            }
        }
    }
}
