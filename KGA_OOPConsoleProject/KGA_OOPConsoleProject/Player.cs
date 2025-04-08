namespace KGA_OOPConsoleProject
{
    public class Player
    {
        public Vector2 position;

        public void PrintPlayer()
        {
            Console.SetCursorPosition(position.x, position.y);
            Console.WriteLine("○");
        }
        public void Move(ConsoleKey input)
        {
            switch (input)
            {
                case ConsoleKey.UpArrow:
                    position.y--;
                    break;
                case ConsoleKey.DownArrow:
                    position.y++;
                    break;
                case ConsoleKey.LeftArrow:
                    position.x--;
                    position.x--;
                    break;
                case ConsoleKey.RightArrow:
                    position.x++;
                    position.x++;
                    break;
            }
        }
    }
}
