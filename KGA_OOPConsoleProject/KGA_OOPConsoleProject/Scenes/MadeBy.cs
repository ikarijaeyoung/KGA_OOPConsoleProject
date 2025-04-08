﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KGA_OOPConsoleProject.Scenes
{
    public class MadeBy : Scene
    {

        public override void Render()
        {
            Console.Clear();
            Console.WriteLine("\t만든이 : 정재영");
        }
        public override void Input()
        {
            Console.ReadKey(true);
        }

        public override void Update()
        {
            Console.Clear();
            Game.ChangeScene("TitleSceneToStart");
        }

        public override void Result()
        {
            
        }
    }
}
