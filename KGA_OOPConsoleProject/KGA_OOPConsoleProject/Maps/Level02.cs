using KGA_OOPConsoleProject.Object;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KGA_OOPConsoleProject.Maps
{
    public class Level02 : Map
    {
        public Level02()
        {
            name = "Level02";
            mapData = new string[]
            {
                "####################", //20개
                "#        #         #",
                "O        0         O",
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

            gameObjects = new List<GameObject>();
            gameObjects.Add(new Portal("Level01", new Vector2(0, 2)));
            gameObjects.Add(new Portal("Level03", new Vector2(19, 2)));
            // gameObjects = [new Key("Key", new Vector2(10, 1))];
        }

        public override void Enter()
        {
            Console.Clear();
            if (Game.prevSceneName == "Level01")
            {
                Game.Player.position = new Vector2(0, 2);
            }
            else if (Game.prevSceneName == "Level03")
            {
                Game.Player.position = new Vector2(17, 2);
            }

            Game.Player.map = map;
        }
    }
}
