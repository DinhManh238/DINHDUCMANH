﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DINHDUCMANH
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of items in the array: ");
            int n = Convert.ToInt32(Console.ReadLine());

            // Step 2: Declare the array
            int[] array = new int[n];

            // Step 3: Get input for the array
            Console.WriteLine("Enter the values for the array:");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Item {i + 1}: ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            // Step 4: Print the original array
            Console.WriteLine("\nOriginal array:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(array[i] + " ");
            }

            // Step 5: Increase each item by 2
            for (int i = 0; i < n; i++)
            {
                array[i] += 2;
            }

            // Step 6: Print the updated array
            Console.WriteLine("\nUpdated array:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(array[i] + " ");
            }

            Console.WriteLine();  // For a clean output
        }
    }
}

