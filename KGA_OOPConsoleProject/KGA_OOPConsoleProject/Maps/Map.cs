using KGA_OOPConsoleProject.Object;

namespace KGA_OOPConsoleProject.Maps
{
    public abstract class Map : Scene
    {
        private ConsoleKey input;
        protected string[] mapData;
        protected bool[,] map;

        protected List<GameObject> gameObjects;

        public abstract void initMap();
        public abstract void initGameObject();
        public abstract void initPlayer();

        public void Reset()
        {
            initMap();
            initGameObject();
            initPlayer();
            Player.hasKey = false;
        }

        public override void Render()
        {
            PrintMap();
            PrintRule();
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
            switch (input)
            {
                case ConsoleKey.R:
                    Console.Clear();
                    Reset();
                    Render();
                    break;
            }
        }

        public override void Result()
        {
            foreach (GameObject gameObject in gameObjects)
            {
                if (gameObject.position.y == Game.Player.position.y
                    && gameObject.position.x == Game.Player.position.x)
                {
                    gameObject.Interact(Game.Player);
                    if (gameObject.isOnce == true)
                    {
                        gameObjects.Remove(gameObject);
                    }
                    break;
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
                        Console.BackgroundColor = ConsoleColor.Gray;
                        Console.Write('#');
                        Console.ResetColor();
                    }
                }
                Console.WriteLine();
            }

        }
        protected virtual void PrintRule()
        {

        }
    }
}
