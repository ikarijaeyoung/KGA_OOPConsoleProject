namespace KGA_OOPConsoleProject.Object
{
    public class Key : GameObject
    {
        public Key(Vector2 position) : base(position, ConsoleColor.Yellow, '*')
        {

        }

        public override void Interact(Player player)
        {
            player.hasKey = true;
        }

        public void Use()
        {

        }

    }
}
