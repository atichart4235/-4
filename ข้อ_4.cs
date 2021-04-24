using System;

namespace ConsoleApp53
{
    class Program
    {
        static void Main(string[] args)
        {
            float x, y, dx, dy, step;
            Console.Write("input X1:");
            float x1 = float.Parse(Console.ReadLine());
            Console.Write("input Y1:");
            float y1 = float.Parse(Console.ReadLine());
            Console.Write("input X2:");
            float x2 = float.Parse(Console.ReadLine());
            Console.Write("input Y2:");
            float y2 = float.Parse(Console.ReadLine());
            dx = x2 - x1;
            dy = y2 - y1;
        }
    }
}
