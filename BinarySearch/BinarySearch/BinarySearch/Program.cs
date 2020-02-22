using System;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arrayOrdered = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 13, 24, 25 };
            Console.WriteLine(BinarySearchIterative(arrayOrdered, 9));
            Console.ReadKey();
        }

        public static bool BinarySearchIterative(int[] array, int x)
        {

            int left = array[0];
            int right = array.Length - 1;

            while (left <= right)
            {

                int mid = left + ((right - left) / 2);

                if (array[mid] == x)
                {
                    return true;
                }
                else if (x < array[mid])
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }


            return false;
        }

        public static bool BinarySearchRecursive(int[] array, int x, int left, int right)
        {
            if (left > right)
            {
                return false;
            }

            int mid = (right + left) / 2;

            if (array[mid] == x)
            {
                return true;
            }
            else if (x < array[mid])
            {
                BinarySearchRecursive(array, x, left, mid - 1);
            }
            else
            {
                BinarySearchRecursive(array, x, mid + 1, right);
            }


            return false;
        }
    }
}
