namespace ConsoleSnake;

public class Map
{
    public int Width = 12;
    public int Height = 12;

    public string[,] GenerateGrid()
    {
        string[,] grid = new string[Width, Height];
        for (int y = 0; y < Height; y++)
        {
            for (int x = 0; x < Width; x++)
            {
                grid[y, x] = ". ";
            }
        }
        return grid;
    }
    
    public void DrawGrid(string[,] grid)
    {
        Console.SetCursorPosition(1, 1);
        
        for (int y = 0; y < Height; y++)
        {
            
            for (int x = 0; x < Width; x++)
            {
                Console.Write(grid[y, x]);    
            }
            Console.SetCursorPosition(1, y+2);
        }
    }

    public void DrawBorder()
    {
        // 上边
        Console.SetCursorPosition(1, 0);
        for (int i = 0; i < 2*Width; i++)
        {
            Console.Write("\u2550");
        }
        
        // 下边
        Console.SetCursorPosition(1, Height+1);
        for (int i = 0; i < 2*Width; i++)
        {
            Console.Write("\u2550");
        }
        
        // 左边
        for (int i = 0; i < Height; i++)
        {
            Console.SetCursorPosition(0, i+1);
            Console.Write('\u2551');
        }
        
        // 右边
        for (int i = 0; i < Height; i++)
        {
            Console.SetCursorPosition(2*Width + 1, i+1);
            Console.Write('\u2551');
        }
        
        // 四个角
        Console.SetCursorPosition(0,0);
        Console.Write('\u2554');
        Console.SetCursorPosition(2*Width+1,0);
        Console.Write('\u2557');
        Console.SetCursorPosition(0,Height+1);
        Console.Write('\u255a');
        Console.SetCursorPosition(2*Width+1,Height+1);
        Console.Write('\u255d');
        
    }
}