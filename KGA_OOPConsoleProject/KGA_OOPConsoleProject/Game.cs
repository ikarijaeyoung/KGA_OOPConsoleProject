using KGA_OOPConsoleProject.Scenes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KGA_OOPConsoleProject
{
    public static class Game
    {
        private static bool gameOver;
        private static Dictionary<string, Scene> sceneDic;
        private static Scene curScene;
        public static void Run()
        {
            Start();

            while(gameOver == false)
            {
                Console.SetCursorPosition(0, 0);

                curScene.Render();
                curScene.Input();
                curScene.Update();
            }

            End();
        }

        public static void ChangeScene()
        {
            curScene = [];
        }

        public static void Start()
        {
            gameOver = false;
            Console.CursorVisible = false;

            sceneDic = new();
            sceneDic.Add("Title", new TitleScene());
            sceneDic.Add("Made by", new MadeBy());

            curScene = sceneDic["Title"];
        }

        public static void End()
        {

        }
    }
}
