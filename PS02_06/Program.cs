using System;
namespace SumofDigits;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Input any integer");
        int userInput = int.Parse(Console.ReadLine());
        int sum = AddAllDigits(userInput);
        Console.WriteLine($"The sum of all the digits in {userInput} is equal to {sum}");

        
    }
    static int AddAllDigits(int userInput)
    {
        int total = 0;
        foreach (char digit in userInput.ToString()) 
        {
            total += int.Parse(digit.ToString());
        }
        return total;
    }

}