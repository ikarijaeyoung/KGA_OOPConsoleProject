namespace KGA_OOPConsoleProject
{
    public class Player
    {
        public Vector2 position;
        public bool[,] map;

        public void PrintPlayer()
        {
            Console.SetCursorPosition(position.x, position.y);
            Console.WriteLine("P");
        }
        public void Move(ConsoleKey input)
        {
            Vector2 nextPos = position;

            switch (input)
            {
                case ConsoleKey.UpArrow:
                    nextPos.y--;
                    break;
                case ConsoleKey.DownArrow:
                    nextPos.y++;
                    break;
                case ConsoleKey.LeftArrow:
                    nextPos.x--;
                    break;
                case ConsoleKey.RightArrow:
                    nextPos.x++;
                    break;
            }

            if (map[nextPos.x, nextPos.y] == true)
            {
                position = nextPos;
            }
        }
    }
}
