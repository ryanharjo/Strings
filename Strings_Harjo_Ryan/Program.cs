using System.Runtime.Serialization;

namespace Strings_Harjo_Ryan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user to input a single character
            Console.WriteLine("Please input a character");
            // Read a single character input from the user
            char myChar = Console.ReadKey().KeyChar;
            // Check if the entered character is a letter
            bool isLetter = char.IsLetter(myChar);
            // Display the result of the letter check
            Console.WriteLine($"\n{myChar} is a lettter: {isLetter}.");
            // prompt the user to enter a sentence
            Console.WriteLine("Why do you like video games?");
            // Read the full sentence from user's input
            string sentence = Console.ReadLine();
            // Prompt the user to enter a word
            Console.WriteLine("Enter a word");
            // Read the word from user's input
            string word = Console.ReadLine();
            // Check if the word exists in the sentence
            bool isIn = sentence.Contains(word);
            // Display whether the word esists in the sentence 
            Console.WriteLine($"{word} exists in {sentence}, {isIn}.");
        }
    }
}
