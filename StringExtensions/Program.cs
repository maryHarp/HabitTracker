namespace StringExtensions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string testCount = "I bet you can't count how many words I'm saying!";
            Console.WriteLine($"Input: \"{testCount}\"");
            Console.WriteLine($"Output: {testCount.WordCount()}"); 
            Console.WriteLine();

            string testReverse = "Dang, you got it!";
            Console.WriteLine($"Input: \"{testReverse}\"");
            Console.WriteLine($"Output: \"{testReverse.ReverseWord()}\""); 
            Console.WriteLine();

            string testPalindrome = "Taco cat";
            Console.WriteLine($"Input: \"{testPalindrome}\"");
            Console.WriteLine($"Output: {testPalindrome.IsPalindrome()}"); 
            Console.WriteLine();

            string testFlip = "I really like CATS!";
            Console.WriteLine($"Input: \"{testFlip}\"");
            Console.WriteLine($"Output: \"{testFlip.FlipCasing()}\""); 
        }

    }
}
