using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace Invaders
{
    public static class Art
    {
        public static Texture2D player;
        public static Texture2D green;
        public static Texture2D red;
        public static Texture2D yellow;

        public static void Load(ContentManager content)
        {
            player = content.Load<Texture2D>("player");
            green = content.Load<Texture2D>("green");
            red = content.Load<Texture2D>("red");
            yellow = content.Load<Texture2D>("yellow");
        }
    }
}
