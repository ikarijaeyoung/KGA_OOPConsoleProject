using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KGA_OOPConsoleProject.Object
{
    public abstract class GameObject : IInteractable
    {
        public Vector2 position;
        public ConsoleColor color;
        public char symbol;

        public GameObject(Vector2 position, ConsoleColor color, char symbol)
        {
            this.position = position;
            this.color = color;
            this.symbol = symbol;
        }
        public void Print()
        {
            Console.SetCursorPosition(position.x, position.y);
            Console.ForegroundColor = color;
            Console.Write(symbol);
            Console.ResetColor();

        }

        public abstract void Interact(Player player);
    }
}
