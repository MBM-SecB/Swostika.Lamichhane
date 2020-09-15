using System;
public class NumberOfPoints
{
    static void Main3()
    {
        NumberOfPoints s = new NumberOfPoints();
        s.number_of_points();
    }
    public void number_of_points()
    {
        int win, draw, lose, points;
        Console.Write("Enter number of wins: ");
        win = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter number of draws: ");
        draw = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter number of losses: ");
        lose = Convert.ToInt32(Console.ReadLine());

        win = win * 5;
        draw = draw * 2;
        lose = 0;
        points = win + draw;
        Console.WriteLine($"Total Points:{points} ");
    }
}