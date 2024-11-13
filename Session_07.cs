using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DINHDUCMANH
{
    internal class Session_07_Ex01
    {
        static void NhapMang(int[,] a, int rows, int columns)
        {
            Random random = new Random();
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    a[i, j] = random.Next(0, 100);
                }
                Console.WriteLine();
            }
        }
        static void InMang(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                    Console.WriteLine(a[i, j] + "\t");
            }
            Console.WriteLine();
        }


        static void InGiaTri(int[,] a, int value)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (a[i, j] != value)
                        Console.WriteLine($"(value) xuat hien tai dong {i} cot {j} \n");
                }
            }
        }
        static void TimMax(int[,] a)
        {
            int max = a[0, 0];
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                    if (a[i, j] > max)
                            
                { max = a[i, j]; }
            
            }
        }
        static void Main(string[] args)
        {
            int[,] a;
            Console.WriteLine("Nhap so dong: "); int rows = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so cot: "); int columns = int.Parse(Console.ReadLine());
            a = new int[rows, columns];
            NhapMang(a, rows, columns);
            Console.WriteLine("Nhap so can tim: ");
            int val = int.Parse(Console.ReadLine());
            InGiaTri(a, val);
            InMang(a);
        }
    }
}
/*  { 


// Function to create an N x M matrix with random values
static int[,] CreateMatrix(int N, int M)
    {
        Random rand = new Random();
        int[,] matrix = new int[N, M];
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < M; j++)
            {
                matrix[i, j] = rand.Next(1, 100);  // Random values between 1 and 99
            }
        }
        return matrix;
    }

    // Function to print the matrix
    static void PrintMatrix(int[,] matrix)
    {
        int N = matrix.GetLength(0);
        int M = matrix.GetLength(1);
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < M; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }

    // Function to print the i-th row or column
    static void PrintRowOrColumn(int[,] matrix, int i, bool isRow)
    {
        int N = matrix.GetLength(0);
        int M = matrix.GetLength(1);

        if (isRow)
        {
            if (i >= 0 && i < N)
            {
                for (int j = 0; j < M; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Invalid row index.");
            }
        }
        else
        {
            if (i >= 0 && i < M)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write(matrix[j, i] + "\t");
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Invalid column index.");
            }
        }
    }

    // Function to find the maximum value in the matrix
    static int FindMax(int[,] matrix)
    {
        int N = matrix.GetLength(0);
        int M = matrix.GetLength(1);
        int max = matrix[0, 0];
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < M; j++)
            {
                if (matrix[i, j] > max)
                    max = matrix[i, j];
            }
        }
        return max;
    }

    // Function to find the minimum value in the i-th row or column
    static int FindMinInRowOrColumn(int[,] matrix, int i, bool isRow)
    {
        int N = matrix.GetLength(0);
        int M = matrix.GetLength(1);
        int min = isRow ? matrix[i, 0] : matrix[0, i];

        if (isRow)
        {
            for (int j = 0; j < M; j++)
            {
                if (matrix[i, j] < min)
                    min = matrix[i, j];
            }
        }
        else
        {
            for (int j = 0; j < N; j++)
            {
                if (matrix[j, i] < min)
                    min = matrix[j, i];
            }
        }
        return min;
    }

    // Function to transpose the matrix
    static int[,] TransposeMatrix(int[,] matrix)
    {
        int N = matrix.GetLength(0);
        int M = matrix.GetLength(1);
        int[,] transposed = new int[M, N];

        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < M; j++)
            {
                transposed[j, i] = matrix[i, j];
            }
        }

        return transposed;
    }

    // Function to print the main and secondary diagonal of the matrix
    static void PrintDiagonals(int[,] matrix)
    {
        int N = matrix.GetLength(0);
        int M = matrix.GetLength(1);

        Console.WriteLine("Main Diagonal:");
        for (int i = 0; i < Math.Min(N, M); i++)
        {
            Console.Write(matrix[i, i] + "\t");
        }
        Console.WriteLine();

        Console.WriteLine("Secondary Diagonal:");
        for (int i = 0; i < Math.Min(N, M); i++)
        {
            Console.Write(matrix[i, M - 1 - i] + "\t");
        }
        Console.WriteLine();
    }

    static void Main(string[] args)
    {
        // Input matrix dimensions
        Console.Write("Enter number of rows (N): ");
        int N = int.Parse(Console.ReadLine());
        Console.Write("Enter number of columns (M): ");
        int M = int.Parse(Console.ReadLine());

        // Create the matrix
        int[,] matrix = CreateMatrix(N, M);

        // Print the matrix
        Console.WriteLine("Matrix:");
        PrintMatrix(matrix);

        // Get the row/column index to print
        Console.Write("Enter index for row/column (i): ");
        int i = int.Parse(Console.ReadLine());
        Console.Write("Print as row (true) or column (false): ");
        bool isRow = bool.Parse(Console.ReadLine());

        PrintRowOrColumn(matrix, i, isRow);

        // Find and print the max value
        int max = FindMax(matrix);
        Console.WriteLine($"Max value in the matrix: {max}");

        // Find and print the min value in the i-th row/column
        int min = FindMinInRowOrColumn(matrix, i, isRow);
        Console.WriteLine($"Min value in the {(isRow ? "row" : "column")} {i}: {min}");

        // Transpose the matrix and print it
        int[,] transposedMatrix = TransposeMatrix(matrix);
        Console.WriteLine("Transposed Matrix:");
        PrintMatrix(transposedMatrix);

        // Print main and secondary diagonals
        PrintDiagonals(matrix);
    }
}
*/
