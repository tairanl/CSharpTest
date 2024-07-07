using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

public class ChallengeBonus
{
    public void Run()
    {
        Console.WriteLine("================================== Challenge Bonus Start! ==================================");

        string filePath = "Coding Challenge RandomNumbers.csv";
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

        Console.WriteLine("Enter 'asc' for ascending order or 'desc' for descending order (input is case insensitive):");
        string sortOrder = Console.ReadLine().Trim().ToLower();

        if (sortOrder == "asc")
        {
            data.Sort();
        }
        else if (sortOrder == "desc")
        {
            data.Sort();
            data.Reverse();
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter 'asc' or 'desc'.");
            return;
        }

        Console.WriteLine($"Sorted data ({sortOrder}):");
        foreach (var num in data)
        {
            Console.WriteLine(num);
        }
    }
}
