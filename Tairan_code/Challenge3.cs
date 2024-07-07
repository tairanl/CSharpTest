using System;
using System.Linq;

public class Challenge3
{
    public void Run()
    {
        Console.WriteLine("Please enter a word:");
        string word = Console.ReadLine().ToLower();

        char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
        var vowelsInWord = word.Where(c => vowels.Contains(c)).Distinct();

        Console.WriteLine("Vowels in the word:");
        foreach (var vowel in vowelsInWord)
        {
            Console.WriteLine(vowel);
        }

        bool isPalindrome = word.SequenceEqual(word.Reverse());
        Console.WriteLine($"The word '{word}' is " + (isPalindrome ? "" : "not ") + "a palindrome.");
    }
}
