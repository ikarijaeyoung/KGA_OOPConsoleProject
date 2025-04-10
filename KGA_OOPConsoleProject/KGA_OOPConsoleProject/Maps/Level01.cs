using KGA_OOPConsoleProject.Object;

namespace KGA_OOPConsoleProject.Maps
{
    public class Level01 : Map
    {
        public Level01()
        {
            Reset();
        }
        public override void initMap()
        {
            name = "Level01";

            mapData = new string[]
            {
                "####################", //20개
                "#  #               #",
                "#    #             O",
                "#  #               #",
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
        }
        public override void initGameObject()
        {
            gameObjects = new List<GameObject>();
            gameObjects.Add(new Portal("Level02", new Vector2(19, 2)));
        }

        public override void initPlayer()
        {
            Game.Player.position = new Vector2(1, 2);
        }

        protected override void PrintRule()
        {
            Console.WriteLine("\n방향키로 이동하세요.");
        }

        public override void Enter()
        {
            Console.Clear();
            if (Game.prevSceneName == "Level02")
            {
                Game.Player.position = new Vector2(18, 2);
            }
            else { Game.Player.position = new Vector2(1, 2); }

            Game.Player.map = map;
        }

    }
}
