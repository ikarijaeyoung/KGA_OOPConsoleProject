namespace KGA_OOPConsoleProject.Object
{
    public class Key : GameObject
    {
        public Key(Vector2 position) : base(position, ConsoleColor.Yellow, '*', true)
        {

        }

        public override void Interact(Player player)
        {
            Player.hasKey = true;
        }
    }
}
