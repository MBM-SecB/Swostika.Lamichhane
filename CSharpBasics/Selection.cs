using System;
class SelectionStatement
{
    static void Main3()
    {
        SelectionStatement s = new SelectionStatement();
        s.CheckNumber();
    }
    void CheckNumber()
    {

        Console.Write("Enter a number: ");
        String input = Console.ReadLine();
        int number = int.Parse(input);
        if (number % 2 == 0)
        {
            Console.WriteLine("you entered even number");
        }
        else
        {
            Console.WriteLine("you entered odd number");
        }
    }
    void LearnSwitchStatements()
    {
        Console.Write("Enter some text: ");
        String input = Console.ReadLine();
        switch (input)
        {
            case "book":
                Console.WriteLine("Great! You are a good learner");
                break;
            case "badminton":
                Console.WriteLine("wow! that's a good indoor game for exercise");
                break;
            case "singing":
                Console.WriteLine("oh wow you may have good voice");
                break;
            case "teaching":
                Console.WriteLine("that may the strage one");
                break;
            default:
                Console.WriteLine("Not matched");
                break;

        }
    }
}