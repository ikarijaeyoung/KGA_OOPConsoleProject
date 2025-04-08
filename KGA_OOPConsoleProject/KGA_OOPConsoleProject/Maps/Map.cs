using KGA_OOPConsoleProject.Object;

namespace KGA_OOPConsoleProject.Maps
{
    public class Map : Scene
    {
        private ConsoleKey input;
        private string[] mapData;
        private bool[,] map;

        private List<GameObject> gameObjects;

        public Map()
        {
            mapData = new string[]
            {
                "####################", //20개
                "#                  #",
                "#                  #",
                "#                  #",
                "####################"
            };

            map = new bool[5, 20];
            for (int y = 0; y < map.GetLength(0); y++)
            {
                for (int x = 0; x < map.GetLength(1); x++)
                {
                    map[y, x] = mapData[y][x] == '#' ? false : true;
                }
            }

            gameObjects = new List<GameObject>();
            gameObjects.Add(new Portal("Level01", new Vector2(16, 2), ConsoleColor.Blue, 'O'));
            
            Game.Player.position = new Vector2(2, 2);
            Game.Player.map = map;

        }

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

        private void PrintMap()
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
