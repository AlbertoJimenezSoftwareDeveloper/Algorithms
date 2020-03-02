using System;


namespace InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] {4,2,7,1,3 };
            InsertionSort(array);

            foreach(int e in array)
            {
                Console.WriteLine(e);
            }

            Console.ReadKey();
        }

        public static void InsertionSort(int [] array)
        {
            for(int index = 1;index < array.Length; index++)
            {
                //we start from position 1 
                int position = index;
                //we get the value of array(current index) starting from index 1
                int temp_value = array[index];
 

                //now we compare the previous 
                while (position  > 0 && array[position - 1] > temp_value)
                {
                    array[position] = array[position - 1];
                    position = position - 1;

                }

                
                array[position] = temp_value;
            }
            
        }
    }
}
