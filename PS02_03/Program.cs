using System.Numerics;
using System.Runtime.CompilerServices;
using System.Xml;

public class PS02_03
{
 
    public static void Main(string[] args)
    {
    while (true)
    {
        //Eugene D. Sumandi

    
     Console.Write("Enter a letter to identify whether it's a vowel or a consonant: ");
     string letter = Console.ReadLine();
     string C = letter.ToUpper();
    

    if (C.Length == 1 && Char.IsLetter(C[0]))
     {
        if  (C == "A" || C == "E" || C == "I" || C == "O" || C == "U")
            {
            Console.WriteLine($"{C} Is Vowel");
            }
        else if (C != "A" || C != "E" || C != "I" || C != "O" || C != "U")
            {
             Console.WriteLine($"{C} Is Consonant");
            }
        }
    else
    {
        Console.WriteLine("Invalid, Please Try Again");
    }
    
    }

    }
}