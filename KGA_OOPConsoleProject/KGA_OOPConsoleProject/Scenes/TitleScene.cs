using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KGA_OOPConsoleProject.Scenes
{
    public class TitleScene : Scene
    {
        public override void Render()
        {
            Console.WriteLine("\tP is You"); // 나중에 디자인
            Console.WriteLine();
            Console.WriteLine("Press any key to start");
        }
        public override void Input()
        {
            Console.ReadKey(true);
        }

        public override void Update()
        {
            
        }
    }
}
