namespace KGA_OOPConsoleProject.Object
{
    public class Portal : GameObject
    {
        private string scene;
        public Portal(string scene, Vector2 position) : base(position, ConsoleColor.Blue, 'O', false)
        {
            this.scene = scene;
        }

        public override void Interact(Player player)
        {
            Game.ChangeScene(scene);
        }
    }
}
