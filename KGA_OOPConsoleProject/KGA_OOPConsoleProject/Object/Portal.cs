using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KGA_OOPConsoleProject.Object
{
    public class Portal : GameObject
    {
        private string scene;
        public Portal(string scene, Vector2 position, ConsoleColor color, char symbol) : base(position, color, symbol)
        {
            this.scene = scene;
        }

        public override void Interact(Player player)
        {
            Game.ChangeScene(scene);
        }
    }
}
