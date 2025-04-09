using KGA_OOPConsoleProject.Object;

namespace KGA_OOPConsoleProject.Maps
{
    public abstract class Map : Scene
    {
        private ConsoleKey input;
        protected string[] mapData;
        protected bool[,] map;
        

        protected List<GameObject> gameObjects;

        public override void Render()
        {
            PrintMap();
            foreach (GameObject gameObject in gameObjects)
            {
                gameObject.Print();
            }
            Game.Player.PrintPlayer();
        }
        public override void Input()
        {
            input = Console.ReadKey(true).Key;
        }

        public override void Update()
        {
            Game.Player.Move(input);
        }

        public override void Result()
        {
            foreach (GameObject gameObject in gameObjects)
            {
                if (gameObject.position.y == Game.Player.position.y
                    && gameObject.position.x == Game.Player.position.x)
                {
                    gameObject.Interact(Game.Player);
                }
            }
        }

        protected void PrintMap()
        {
            Console.SetCursorPosition(0, 0);
            for (int y = 0; y < map.GetLength(0); y++)
            {
                for (int x = 0; x < map.GetLength(1); x++)
                {
                    if (map[y, x] == true)
                    {
                        Console.Write(' ');
                    }
                    else
                    {
                        Console.Write('#');
                    }
                }
                Console.WriteLine();
            }

        }
    }
}
