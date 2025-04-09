using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KGA_OOPConsoleProject.Object
{
    public class LockedDoor : GameObject
    {
        
        public LockedDoor(Vector2 position) : base(position, ConsoleColor.DarkBlue, '0')
        {
            
        }

        public override void Interact(Player player)
        {
            
        }
    }
}
