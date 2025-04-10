using KGA_OOPConsoleProject.Maps;

namespace KGA_OOPConsoleProject.Object
{
    public class Box : GameObject
    {

        public Box(Vector2 position) : base(position, ConsoleColor.White, '@')
        {

        }

        public override void Interact(Player player)
        {
            //if (map[overPos.y, overPos.x] == true)
            //{
            //
            //position.y = player.overPos.y;
            //    position.x = player.overPos.x;
            //}
            //else { }

            Vector2 nextPos = new Vector2(position.x, position.y);
            
            if (player.prevPos.x < position.x) nextPos.x++;
            else if (player.prevPos.x > position.x) nextPos.x--;
            if (player.prevPos.y < position.y) nextPos.y++;
            else if (player.prevPos.y > position.y) nextPos.y--;
            
            if (nextPos.y >= 0 && nextPos.y < player.map.GetLength(0)
             && nextPos.x >= 0 && nextPos.x < player.map.GetLength(1)
             && player.map[nextPos.y, nextPos.x] == true)
            {
                position = nextPos;
            }
            else
            {
                player.position = player.prevPos;
            }
        }
    }
}
