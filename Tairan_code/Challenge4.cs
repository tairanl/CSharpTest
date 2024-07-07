using System;

public class Challenge4
{
    public void Run()
    {
        Console.WriteLine("Please enter the radius of the circle:");
        double radius = double.Parse(Console.ReadLine());

        Console.WriteLine("Please enter the diagonal length of the square:");
        double diagonal = double.Parse(Console.ReadLine());

        double circleArea = Math.PI * radius * radius;
        Console.WriteLine($"The area of the circle is: {circleArea} square units.");

        double sideLength = diagonal / Math.Sqrt(2);
        double squareArea = sideLength * sideLength;
        Console.WriteLine($"The area of the square is: {squareArea} square units.");

        double areaDifference = Math.Abs(circleArea - squareArea);
        Console.WriteLine($"The difference in area is: {areaDifference} square units.");
    }
}
