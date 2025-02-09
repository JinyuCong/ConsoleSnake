namespace ConsoleSnake;

public class Snake
{
    private const string SnakeBlock = "\u2588\u2588";
    
    Map _map = new Map();
    public int SnakeLength { get; set; }
    public bool IsAlive { get; set; } = true;
    public int[] HeadPosition = new int[2];
    public Direction Direction { get; set; } = Direction.Down;

    public Snake(int snakeLength)
    {
        this.SnakeLength = snakeLength;
        this.HeadPosition[0] = _map.Width / 2;
        this.HeadPosition[1] = _map.Height / 2;
    }

    public void Move()
    {
        if (Direction == Direction.Right)
        {
            HeadPosition[0]++;
        }
        else if (Direction == Direction.Left)
        {
            HeadPosition[0]--;
        }
        else if (Direction == Direction.Up)
        {
            HeadPosition[1]--;
        }
        else if (Direction == Direction.Down)
        {
            HeadPosition[1]++;
        }
        
        Thread.Sleep(1000);
    }
}