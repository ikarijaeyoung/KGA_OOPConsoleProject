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
        public static void Run()
        {
            Start();

            while(gameOver == false)
            {
                Console.Clear();

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

            sceneDic = new();
            sceneDic.Add("Title", new TitleSceneToStart());
            sceneDic.Add("Made By", new TitleSceneToMadeBy());
            sceneDic.Add("Map", new Map());

            curScene = sceneDic["Title"];
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
