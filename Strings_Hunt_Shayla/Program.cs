namespace Strings_Hunt_Shayla
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Asks user to input a character and assigns input to a variable.
            Console.WriteLine("Please input a character!");
            char myChar = Console.ReadKey().KeyChar;

            bool isLetter = Char.IsLetter(myChar); // Checks if the character entered is a letter.

            Console.WriteLine($"\n{myChar} is a letter: {isLetter}."); // Prints the results to console.

            // Asks user a question and saves response to a variable.
            Console.WriteLine("Why do you like video games?");
            string sentence = Console.ReadLine();

            // Asks user to enter a word, saves response to a variable called word.
            Console.WriteLine("Enter a word");
            string word = Console.ReadLine();

            bool isIn = sentence.Contains(word); // Checks if the word is in the sentence.

            Console.WriteLine($"{word} exists in {sentence}, {isIn}!");// Prints the results to console.

        }
    }
}
