using System;
class IterationStatement
{
    static void Main()
    {
        IterationStatement iterationStatement = new IterationStatement();
        iterationStatement.LearnWhileLoops();

        // AccessModifier s = new AccessModifier();
        // s.Dosomething();

        // Person person = new Person();
        // person.Age = 34;

    }
    void LearnForLoops()
    {
        int i;
        for (i = 0; i < 10; i++)
        {
            Console.WriteLine("hey");
        }

        byte[] personAges = { 23, 45, 6, 78, 23 };
        foreach (byte age in personAges)
        {
            if (age % 2 == 0)
            {
                Console.WriteLine(age + " is even");
            }
            else
            {
                Console.WriteLine(age + " is odd");
            }
        }

    }

    void LearnWhileLoops()
    {
        char confirm = 'Y';
        while (confirm == 'Y')
        {
            Console.WriteLine("inside a while loop");
            Console.WriteLine("enter Y to continue");
            confirm = Console.ReadKey().KeyChar;
        }
        do
        {
            Console.WriteLine("inside a while loop");
            Console.WriteLine("enter Y to continue");
            confirm = Console.ReadKey().KeyChar;
        } while (confirm == 'Y');
    }

}