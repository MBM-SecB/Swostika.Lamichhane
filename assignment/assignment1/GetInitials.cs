using System;

public class GetInitials
{
    static void Main(string[] args)
    {
        GetInitials s = new GetInitials();
        s.Initials();
    }

    public void Initials()
    {
        Console.Write("Enter two words separated by space: ");
        string s = Console.ReadLine();
        string[] output = s.Split(' ');

        foreach (string a in output)
        {
            if (output.Length != 2)
            {
                Console.WriteLine(" Enter only two words.");
            }
            else
            {
                Console.Write(a[0]);
            }
        }

    }
}