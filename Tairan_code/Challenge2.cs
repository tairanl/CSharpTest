using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

public class Challenge2
{
    public void Run()
    {
        string filePath = "Coding Challenge RandomNumbers.csv";

        try
        {
            var rawData = File.ReadAllLines(filePath).FirstOrDefault()?.Split(',');

            if (rawData == null)
            {
                Console.WriteLine("No data found in the CSV file.");
                return;
            }

            List<int> data = new List<int>();
            foreach (var entry in rawData)
            {
                if (int.TryParse(entry, out int number))
                {
                    data.Add(number);
                }
            }

            if (data.Count == 0)
            {
                Console.WriteLine("No valid integer data found in the CSV file.");
                return;
            }

            Console.WriteLine("Parsed CSV values with indices:");
            for (int i = 0; i < data.Count; i++)
            {
                Console.WriteLine($"Index {i + 1}: {data[i]}");
            }

            Console.WriteLine($"Enter the index of the number for which you want the factorial (1-{data.Count}):");
            if (!int.TryParse(Console.ReadLine(), out int inputIndex) || inputIndex < 1 || inputIndex > data.Count)
            {
                Console.WriteLine("Invalid index. Please restart the program and try a valid index.");
                return;
            }

            int selectedNumber = data[inputIndex - 1];
            if (selectedNumber < 0)
            {
                Console.WriteLine($"The number at index {inputIndex}, {selectedNumber}, is negative. Factorial is not defined for negative numbers.");
                return;
            }

            long factorial = Factorial(selectedNumber);
            Console.WriteLine($"The factorial of number {selectedNumber} at index {inputIndex} is {factorial}.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error processing the file: " + ex.Message);
        }
    }

    private long Factorial(int number)
    {
        long result = 1;
        for (int i = 1; i <= number; i++)
        {
            result *= i;
        }
        return result;
    }
}
