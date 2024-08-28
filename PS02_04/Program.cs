using System;
namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a word to check if it's a palindrome");
            string userInput = Console.ReadLine();
            (bool isPalindrome, string reversed) = checkPalindrome(userInput);
            if (isPalindrome)
            {
                Console.WriteLine($"The word {userInput} is a palindrome because if reversed, it is still {reversed}");
            }
            else
            {
                Console.WriteLine($"The word is not a palindrome as the word {userInput} if reversed is  {reversed} which is not the same");
            }

        }
        static (bool, string) checkPalindrome(string userInput)
        {
            string lowerInput = userInput.ToLower();
            int lengthInput = lowerInput.Length;
            string reversed = "";
            for (int i = lengthInput -1; i >= 0; i--)
            {
                reversed += lowerInput[i];
                
            }
            return (lowerInput == reversed, reversed);

        }
    }
}