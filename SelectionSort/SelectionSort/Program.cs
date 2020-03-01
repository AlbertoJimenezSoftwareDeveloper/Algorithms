
using System;

namespace SelectionSort
{
    class   Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 4,2,7,1,3};
            SelectionSort(array);
            foreach(int e in array)
            {
                Console.WriteLine(e);
            }
            Console.ReadKey();
        }

        public static void  SelectionSort( int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                //Note that we are actually tracking the index of the lowest number instead of 
                //the actual number it self.
                //This index will be 0 at the begining of the first passthroug
                //and will be 1 at the second passthrog and so on.
                int lowest_index = i;


                Console.WriteLine(String.Format("step {0} ", i));
                


                for (int j = i + 1; j < array.Length; j++)
                {
                    if(array[j] < array[lowest_index])
                    {
                        lowest_index = j;
                    }
                }

                Console.WriteLine(String.Format("lowest value is  {0} ", array[lowest_index]));

                //we have a change , we have a new index pointing to the new lowest value
                if (lowest_index != i)
                {
                    int temp = array[i];
                    array[i] = array[lowest_index];
                    array[lowest_index] = temp;
                }


            }
        }
    }
}
