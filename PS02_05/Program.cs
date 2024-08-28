using System;
namespace FrequencyCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a word");
            string userInput = Console.ReadLine();
            int[] frequency = new int[256];

            foreach (char letter in userInput)
            {
                frequency[letter]++;
            }
            for (int i = 0; i < frequency.Length; i++)
            {
                if (frequency[i] > 0)
                {
                    Console.WriteLine($"The letter  '{(char)i}'  appeared  {frequency[i]} time/s");
                }
            }

        }
    }
}