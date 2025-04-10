namespace KGA_OOPConsoleProject.Object
{
    public class LockedDoor : GameObject
    {

        public LockedDoor(Vector2 position) : base(position, ConsoleColor.DarkBlue, '/', false)
        {

        }

        public override void Interact(Player player)
        {
            if (Player.hasKey == true)
            {
                isOnce = true;
                // Player.hasKey = false;
            }
            else { player.position = player.prevPos; }
        }
    }
}
