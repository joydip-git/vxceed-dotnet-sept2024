
namespace MatrixArrayApp
{
    internal class Program
    {
        //static int size = 0;
        static void Main()
        {
            //1. ask user about the two dim array size
            int size = GetSize();
            
            //2. create two dim array
            int[,] twoDimArr = new int[size, size];
            
            //3. ask user to enter values
            EnterValuesInArray(twoDimArr);
            
            //4. arrange the elements
            int[] result = ArrangeElementsInAnArray(twoDimArr);
            
            //5. print the elements
            foreach (var item in result)
            {
                Console.Write(item + " ");
            }
        }

        static int[] ArrangeElementsInAnArray(int[,] twoDimArr)
        {
            //1. copy all the elements from matrix array to a single dim array
            int[] temporary = CopyToSingleDimensionalArray(twoDimArr);
            //2. sort the elements in the single dim array
            Array.Sort(temporary);
            //3. create another single dim array and then place the elements from previous single dim array
            int[] result = new int[temporary.Length];
            int midIndex = result.Length / 2;
            result[midIndex] = temporary[0];

            int leftIndex = midIndex - 1;
            int rightIndex = midIndex + 1;

            for (int i = 1; i < temporary.Length; i++)
            {
                if (i % 2 == 0)
                {
                    result[leftIndex] = temporary[i];
                    leftIndex--;
                }
                else
                {
                    result[rightIndex] = temporary[i];
                    rightIndex++;
                }
            }
            return result;
        }

        private static int[] CopyToSingleDimensionalArray(int[,] twoDimArr)
        {
            int[] singleDimArr = new int[twoDimArr.Length];
            int index = 0;
            for (int i = 0; i < twoDimArr.GetLength(0); i++)
            {
                for (int j = 0; j < twoDimArr.GetLength(1); j++)
                {
                    singleDimArr[index] = twoDimArr[i, j];
                    index++;
                }
            }
            return singleDimArr;
        }

        static int GetSize()
        {
            Console.Write("enter two dim array size: ");
            return int.Parse(Console.ReadLine() ?? "3");
        }
        static void EnterValuesInArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"enter value at array [{i},{j}]: ");
                    array[i, j] = int.Parse(Console.ReadLine() ?? "0");
                }
            }
        }
    }
}
