using KGA_OOPConsoleProject.Object;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KGA_OOPConsoleProject.Maps
{
    public class Level03 : Map
    {
        public Level03()
        {
            Reset();
        }
        public override void initMap()
        {
            name = "Level03";
            mapData = new string[]
            {
                "####################", //20개
                "#       *#         #",
                "O        /         O",
                "#        #         #",
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
            gameObjects.Add(new Portal("Level02", new Vector2(0, 2)));
            gameObjects.Add(new Portal("Level02", new Vector2(19, 2))); //임시로 2로 가는 포탈
            gameObjects.Add(new LockedDoor(new Vector2(9, 2)));
            gameObjects.Add(new Key(new Vector2(8, 1)));
        }


        public override void initPlayer()
        {
            Game.Player.position = new Vector2(1, 2);
        }
        public override void Enter()
        {
            Console.Clear();
            if (Game.prevSceneName == "Level02")
            {
                Game.Player.position = new Vector2(0, 2);
            }
            // else if (Game.prevSceneName == "Level03")
            // {
            //     Game.Player.position = new Vector2(17, 2);
            // }

            Game.Player.map = map;
        }
        protected override void PrintRule()
        {
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("*");
            Console.ResetColor();
            Console.Write("을 먹으면 막혀있는 ");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write("/");
            Console.ResetColor();
            Console.Write("을 열 수 있습니다.");
        }
    }

}
