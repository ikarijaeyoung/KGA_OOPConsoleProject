using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KGA_OOPConsoleProject.Scenes
{
    public class TitleScene : Scene
    {
        private ConsoleKey input;
        public override void Render()
        {
            Console.WriteLine("\tP is You"); // 나중에 디자인
            Console.WriteLine();
            Console.WriteLine("Press any key to start");
            Console.WriteLine();
            Console.WriteLine("\t0. 제작자");
        }
        public override void Input()
        {
            input = Console.ReadKey(true).Key;
        }

        public override void Update()
        {
            switch (input)
            {
                case ConsoleKey.NumPad0:
                    Game.ChangeScene("Made By");
                    break;
            }
        }
    }
}
