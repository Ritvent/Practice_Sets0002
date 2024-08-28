using System;

public class PS02_7
{
    public static void Main(string[] args)
    {
        while (true)
        {
        Console.Write("Enter numbers separated by (,): ");
        string num = Console.ReadLine();
        string[] number = num.Split(',');
        int[] numbers = new int[number.Length];
        for (int i = 0; i < number.Length; i++)
        {
            numbers[i] = Convert.ToInt32(number[i]);
        }
               int sum = 0;
        foreach (int nums in numbers)
        {
            sum += nums;
        }
        
        Console.WriteLine("Total " + sum);
        }
    }
}
