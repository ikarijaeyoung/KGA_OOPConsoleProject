using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KGA_OOPConsoleProject.Scenes
{
    public class TitleSceneToStart : Scene
    {
        private ConsoleKey input;
        public override void Render()
        {
            Console.WriteLine("\tP is You"); // 나중에 디자인
            Console.WriteLine();
            Console.WriteLine("\t▶start");
            Console.WriteLine();
            Console.WriteLine("\t제작자");
        }
        public override void Input()
        {
            input = Console.ReadKey(true).Key;
        }

        public override void Update()
        {
            switch (input)
            {
                case ConsoleKey.Enter:
                    Game.ChangeScene("Map");
                    break;
                case ConsoleKey.DownArrow:
                    Game.ChangeScene("TitleSceneToMadeBy");
                    break;
            }
        }
    }
}
