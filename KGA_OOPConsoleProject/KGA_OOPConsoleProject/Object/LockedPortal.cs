using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KGA_OOPConsoleProject.Object
{
    public class LockedPortal : GameObject
    {
        
        public LockedPortal(Vector2 position) : base(position, ConsoleColor.DarkBlue, '0')
        {
            
        }

        public override void Interact(Player player)
        {
            
        }
    }
}
