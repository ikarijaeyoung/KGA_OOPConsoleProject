using KGA_OOPConsoleProject.Object;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KGA_OOPConsoleProject.Maps
{
    public class Level01 : Scene
    {
        private ConsoleKey input;
        private string[] mapData;
        private bool[,] map;

        private List<GameObject> gameObjects;

        public Level01()
        {
            mapData = new string[]
            {
                "####################", //20개
                "#  #               #",
                "O                  #",
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

            gameObjects = [new Portal("Map", new Vector2(0, 2))];
            // gameObjects = [new Key("Key", new Vector2(10, 1))];

            Game.Player.position = new Vector2(1, 2);
            Game.Player.map = map;
        }

        public override void Render()
        {
            PrintMap();
            Console.WriteLine("\tLevel : 1");
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
                    Console.Clear();
                    gameObject.Interact(Game.Player);
                }
            }
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
