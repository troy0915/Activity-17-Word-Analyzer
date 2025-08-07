using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity_17_Word_Analyzer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> sentences = new List<string>();
            List<string> uniqueWords = new List<string>();

            Console.WriteLine("Enter 5 different sentences:");
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Sentence {i + 1}: ");
                string sentence = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(sentence))
                {
                    sentences.Add(sentence);
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid sentence.");
                    i--;
                }
            }

            foreach (string sentence in sentences)
            {
                string[] words = sentence.Split(new[] { ' ', '.', ',', '!', '?', ';', ':', '-', '\t', '\n', '\r' },
                                              StringSplitOptions.RemoveEmptyEntries);

                foreach (string word in words)
                {
                    string lowerWord = word.ToLower();
                    if (!uniqueWords.Contains(lowerWord))
                    {
                        uniqueWords.Add(lowerWord);
                    }
                }
            }
            uniqueWords.Sort();
            Console.WriteLine($"\nTotal unique words: {uniqueWords.Count}");
            Console.WriteLine("Sorted list of unique words:");
            foreach (string word in uniqueWords)
            {
                Console.WriteLine(word);
            }
        }
    }
}






