using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

public class Challenge1
{
    public void Run()
    {
        string filePath = "Coding Challenge RandomNumbers.csv";

        try
        {
            var rawData = File.ReadAllLines(filePath).FirstOrDefault()?.Split(',');

            if (rawData == null)
            {
                Console.WriteLine("The file is empty!");
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

            var counts = data.GroupBy(x => x).ToDictionary(g => g.Key, g => g.Count());

            var nonDuplicates = counts.Where(kvp => kvp.Value == 1).Select(kvp => kvp.Key).ToList();
            var duplicates = counts.Where(kvp => kvp.Value > 1).ToDictionary(kvp => kvp.Key, kvp => kvp.Value);

            Console.WriteLine("Non-duplicate numbers:");
            nonDuplicates.ForEach(Console.WriteLine);

            Console.WriteLine("\nDuplicate numbers and their counts:");
            foreach (var kvp in duplicates)
            {
                Console.WriteLine($"{kvp.Key} appears {kvp.Value} times");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error processing the file: " + ex.Message);
        }
    }
}