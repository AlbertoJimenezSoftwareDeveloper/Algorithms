using System;


namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int []{ 4,2,7,1,3};
            BubbleSort(array);

           

            Console.ReadKey();
        }

        static void PrintArray(int[] array)
        {
            foreach (int e in array)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine("-----------");

        }

        public static void BubbleSort(int [] array)
        {

            int unsorted_until_index = array.Length - 1;
            bool sorted = false;

            while (!sorted)
            {
                sorted = true;
                for(int i =0; i < unsorted_until_index; i++)
                {
                    if(array[i] > array[i +1])
                    {
                        swap(array,i,i+1);
                        sorted = false;
                    }
                    PrintArray(array);
                }
                unsorted_until_index--;

            }


        }

        public static void  swap(int[] array,int i,int j)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] =  temp;

        }
    }
}
