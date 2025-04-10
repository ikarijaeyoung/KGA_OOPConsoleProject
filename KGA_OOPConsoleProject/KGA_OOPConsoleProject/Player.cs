namespace KGA_OOPConsoleProject
{
    public class Player
    {
        public Vector2 position;
        public Vector2 prevPos; 
        public bool[,] map;
        public bool hasKey = false;

        public void PrintPlayer()
        {
            Console.SetCursorPosition(position.x, position.y);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine('P');
            Console.ResetColor();
        }
        public void Move(ConsoleKey input)
        {
            // Vector2 nextPos = position; 이전에 이거 썼다가 오류남
            Vector2 nextPos = new Vector2(position.x, position.y);
            // Vector2 overPos = new Vector2(position.x, position.y);
            prevPos = new Vector2(position.x, position.y);

            switch (input)
            {
                case ConsoleKey.UpArrow:
                    nextPos.y--;
                    //overPos.y--;
                    break;
                case ConsoleKey.DownArrow:
                    nextPos.y++;
                    //overPos.y++;
                    break;
                case ConsoleKey.LeftArrow:
                    nextPos.x--;
                    //overPos.x--;
                    break;
                case ConsoleKey.RightArrow:
                    nextPos.x++;
                    //overPos.x++;
                    break;
            }
            
            if (nextPos.y >= 0 && nextPos.y < map.GetLength(0)
             && nextPos.x >= 0 && nextPos.x < map.GetLength(1)
             && map[nextPos.y, nextPos.x] == true)
            {
                position = nextPos;
            }
            
        }
    }
}
