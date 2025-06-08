using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
					
public class Program
{
	public static void Main()
	{
		string input = "Four, One two two three Three three four  four   four";
        var result = WordFrequency(input);

        foreach (var listWord in result)
        {
            Console.WriteLine($"{listWord.Key} => {listWord.Value}");
        }
	}
	
	static Dictionary<string, int> WordFrequency(string input)
    {
        // Remove punctuation and convert all to lowercase
        string cleaned = Regex.Replace(input.ToLower(), @"[^\w\s]", ""); // Remove commas, etc.

        // Split by whitespace
        string[] words = cleaned.Split(new[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

        // Count word frequencies
        var frequency = new Dictionary<string, int>();

        foreach (var word in words)
        {
            if (frequency.ContainsKey(word))
                frequency[word]++;
            else
                frequency[word] = 1;
        }

        return frequency;
    }
}