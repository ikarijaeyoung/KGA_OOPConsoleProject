using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KGA_OOPConsoleProject.Object
{
    public class Box : GameObject
    {

        public Box(Vector2 position) : base(position, ConsoleColor.White, '@')
        {

        }

        public override void Interact(Player player)
        {
            
        }
    }
}
