using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KGA_OOPConsoleProject
{
    public class Game
    {
        private static bool gameOver;
        public static void Run()
        {
            Start();

            while(gameOver == false)
            {
                Scene.Render();
                Scene.Input();
                Scene.Update();
            }
        }

        public static void Start()
        {
            gameOver = false;
        }

        public static void End()
        {

        }
    }
}
