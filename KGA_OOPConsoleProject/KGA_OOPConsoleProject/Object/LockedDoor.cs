namespace KGA_OOPConsoleProject.Object
{
    public class LockedDoor : GameObject
    {

        public LockedDoor(Vector2 position) : base(position, ConsoleColor.DarkBlue, '/')
        {

        }

        public override void Interact(Player player)
        {
            if (player.hasKey == false)
            {
                player.position = player.prevPos;
            }
            else { }
        }
    }
}
