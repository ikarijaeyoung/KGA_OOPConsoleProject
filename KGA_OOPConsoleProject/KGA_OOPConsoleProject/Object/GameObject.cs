using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KGA_OOPConsoleProject.Object
{
    public abstract class GameObject
    {
        public Vector2 position;
        public ConsoleColor color;
        public char symbol;

        public void Print()
        {
            Console.SetCursorPosition(position.x, position.y);
        }
    }
}
