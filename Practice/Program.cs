
namespace Practice
{
  class Program
  {
    static void Main(string[] args)
    {
            // Declaring jagged array with items
            int[][] jaggedArray =
            {
                new int[]{1, 2},
                new int[]{3, 4, 5},
                new int[]{6},
                new int[]{7, 8}
            };

            // Access an item in the jagged array
            int[] secondArray = jaggedArray[1]; // [3, 4, 5]
    
            // Iterating through the array 
            foreach (int[] array in jaggedArray)
            {
                foreach (int item in array)
                {
                    Console.Write(item);
                    Console.Write(" ");
                }

                Console.WriteLine();
            }



            Console.ReadLine();

    }
  }

    
}
