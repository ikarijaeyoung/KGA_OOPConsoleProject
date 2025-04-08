using KGA_OOPConsoleProject.Maps;
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

        private static Player player;
        public static Player Player { get { return player; } }

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


        public static void Start()
        {
            gameOver = false;
            Console.CursorVisible = false;
            player = new();

            sceneDic = new();
            sceneDic.Add("TitleSceneToStart", new TitleSceneToStart());
            sceneDic.Add("TitleSceneToMadeBy", new TitleSceneToMadeBy());
            sceneDic.Add("Made By", new MadeBy());
            sceneDic.Add("Map", new Map());

            curScene = sceneDic["TitleSceneToStart"];

        }

        public static void End()
        {

        }
        public static void ChangeScene(string sceneName)
        {
            curScene = sceneDic[sceneName];
        }
    }
}
