using Microsoft.Xna.Framework;

namespace Invaders
{
    class PlayerShip : Entity
    {
        public PlayerShip()
        {
            this.image = Art.player;
            this.rotation = 0;
            this.position = new Vector2(GameRoot.ScreenSize.X / 2, GameRoot.ScreenSize.Y - this.Size.Y);
        }

        public override void Update()
        {
        }
    }
}
