using System;

namespace AliceAdventures
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = "Alice was beginning to get very tired of sitting by her sister on the bank, and of having nothing to do: once or twice she had peeped into the book her sister was reading, but it had no pictures or conversations in it, 'and what is the use of a book,' thought Alice 'without pictures or conversation?'";
            Console.WriteLine(sentence+ "\n");

            Console.WriteLine("Type a term to search: ");
            string term = Console.ReadLine();
            bool search = sentence.Contains(term.ToLower());
            Console.WriteLine("\n" + "Search for '" + term + "': " + search);

            int index = sentence.IndexOf(term);
            int length = term.Length;
            Console.WriteLine("Index: " + index + ", Length: " + length);
            string newSentence = sentence.Replace(term, "");
            Console.WriteLine("\n" + newSentence);
        }
    }
}
