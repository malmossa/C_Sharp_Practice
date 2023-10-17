
using System.Net.Http.Headers;

namespace Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = { 1, 2, 3, 4, 5, };
            double[] doubleArray = { 1.0, 2.0, 3.0};
            string[] stringArray = { "1", "2", "3"};

            displayElements(intArray);
            displayElements(doubleArray);
            displayElements(stringArray);

            Console.ReadLine();

        }

        
        internal static void displayElements<T>(T[] array)
        {
            foreach(T item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        
                 
    }

}






