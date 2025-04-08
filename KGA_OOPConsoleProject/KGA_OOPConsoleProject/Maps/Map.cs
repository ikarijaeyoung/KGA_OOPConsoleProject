namespace KGA_OOPConsoleProject.Maps
{
    public class Map : Scene
    {
        private ConsoleKey input;
        private string[] mapData;
        private bool[,] map;

        public Map()
        {
            mapData = new string[]
            {
                "##########", //10개
                "#        #",
                "#        #",
                "#        #",
                "#        #",
                "#        #",
                "#        #",
                "#        #",
                "#        #",
                "##########"
            };

            map = new bool[10, 10];
            for (int y = 0; y < mapData.GetLength(0); y++)
            {
                for (int x = 0; x < mapData.GetLength(1); x++)
                {
                    map[y, x] = mapData[y][x] == '#' ? false : true;
                }
            }
        }

        public override void Render()
        {
            PrintMap();
        }
        public override void Input()
        {
            input = Console.ReadKey(true).Key;
        }

        public override void Update()
        {

        }

        private void PrintMap()
        {
            Console.SetCursorPosition(0, 0);
            for (int y = 0; y < mapData.GetLength(0); y++)
            {
                for (int x = 0; x < mapData.GetLength(1); x++)
                {
                    if (map[y, x] == true)
                    {
                        Console.Write(' ');
                    }
                    else
                    {
                        Console.Write("#");
                    }
                }
                Console.WriteLine();
            }

        }
    }
}
