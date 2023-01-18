using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Invaders
{
    abstract class Entity
    {
        public Vector2 position;
        public Texture2D image;
        public Color color = Color.White;
        public float rotation;
        public bool isExpired = false;

        public Vector2 Size => image == null ? Vector2.Zero : new Vector2(image.Width, image.Height);

        public abstract void Update();

        public virtual void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(image, position, null, color, rotation, Size / 2f, 1f, 0, 0);
        }

    }
}
