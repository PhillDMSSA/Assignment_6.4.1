namespace Assignment_6._4._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] matrix = {
            new int[] { 5, 1, 9, 11 },
            new int[] { 2, 4, 8, 10 },
            new int[] { 13, 3, 6, 7 },
            new int[] { 15, 14, 12, 16 }
        };

            Console.WriteLine("Original Matrix:");
            PrintMatrix(matrix);

            RotateMatrix(matrix);

            Console.WriteLine("\nRotated Matrix:");
            PrintMatrix(matrix);
        }

        static void RotateMatrix(int[][] matrix)
        {
            

            
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = i + 1; j < matrix.Length; j++)
                {
                    int temp = matrix[i][j];
                    matrix[i][j] = matrix[j][i];
                    matrix[j][i] = temp;
                }
            }

            // Reverse each row
            for (int i = 0; i < matrix.Length; i++)
            {
                int left = 0, right = matrix.Length- 1;
                while (left < right)
                {
                    int temp = matrix[i][left];
                    matrix[i][left] = matrix[i][right];
                    matrix[i][right] = temp;
                    left++;
                    right--;
                }
            }
        }

        static void PrintMatrix(int[][] matrix)
        {
            foreach (var row in matrix)
            {
                Console.WriteLine(string.Join(" ", row));
            }
        }
    }
}