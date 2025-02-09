using System;
using System.Globalization;

namespace ConsoleSnake;

class Program
{
    public static void Main(string[] args)
    {
        Map map = new Map();

        string[,] grid = map.GenerateGrid();
        Snake snake = new Snake(2);
        
        map.DrawBorder();
        
        while (true)
        {
            //Console.Clear();
            map.DrawGrid(grid);
            System.Threading.Thread.Sleep(10);
            snake.Move();
            Console.WriteLine();
            Console.WriteLine($"({snake.HeadPosition[0]}, {snake.HeadPosition[1]})");
        }
        
    }
}