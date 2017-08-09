using System;
using System.Collections.Generic;
using System.Linq;

class RectangleIntersection
{
    static void Main()
    {
        var tokens = Console.ReadLine().Split();
        var rectangleCount = int.Parse(tokens[0]);
        var intersectionCount = int.Parse(tokens[1]);
        List<Rectangle> all = new List<Rectangle>();

        for (int i = 0; i < rectangleCount; i++)
        {
            Rectangle current = new Rectangle();
            var rectangleTokens = Console.ReadLine().Split();

            current.id = rectangleTokens[0];
            current.width = double.Parse(rectangleTokens[1]);
            current.height = double.Parse(rectangleTokens[2]);
            current.topLeftX = double.Parse(rectangleTokens[3]);
            current.topLeftY = double.Parse(rectangleTokens[4]);

            all.Add(current);
        }

        for (int i = 0; i < intersectionCount; i++)
        {
            var rectangles = Console.ReadLine().Split();
            Console.WriteLine((all.Where(r => r.id == rectangles[0]).FirstOrDefault()
                .Intersect(all.Where(r => r.id == rectangles[1]).FirstOrDefault()).ToString().ToLower()));
        }
    }
}
