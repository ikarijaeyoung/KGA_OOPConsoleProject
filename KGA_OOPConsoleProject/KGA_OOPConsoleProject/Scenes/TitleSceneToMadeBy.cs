using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KGA_OOPConsoleProject.Scenes
{
    class TitleSceneToMadeBy : Scene
    {
        private ConsoleKey input;
        public override void Render()
        {
            Console.WriteLine("\tP is You"); // 나중에 디자인
            Console.WriteLine();
            Console.WriteLine("\tstart");
            Console.WriteLine();
            Console.WriteLine("\t▶제작자");
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
                    Game.ChangeScene("Made By");
                    break;
                case ConsoleKey.DownArrow:
                    Game.ChangeScene("TitleSceneToStart");
                    break;
            }
        }
    }
}
