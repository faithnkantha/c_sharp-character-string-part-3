using System;
class QuestionOne
{
    static void Main()
    {
        string sentence;


        Console.WriteLine("Enter a number ,letter or special character");
        sentence = Console.ReadLine();
        int lettercount = 0;
        int digitcount = 0;
        int spacecount = 0;
        int specialcount = 0;

        foreach (char c in sentence)
        {
            if (char.IsLetter(c))
                lettercount++;
            else if(char.IsDigit(c))
                digitcount++;  
            else if(char.IsWhiteSpace(c))
                spacecount++;
            else specialcount++;    
        }
        Console.WriteLine($"Your {sentence}has :-");
        Console.WriteLine($"{lettercount} letters, {digitcount} digits and {specialcount} special characters");
    }
}