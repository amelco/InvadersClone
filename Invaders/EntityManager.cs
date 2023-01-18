using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;

namespace Invaders
{
    static class EntityManager
    {
        public static List<Entity> entities = new List<Entity>();
        public static List<Entity> queuedEntities = new List<Entity>();
        public static int Count => entities.Count;

        public static bool isUpdating;

        public static void Add(Entity entity)
        {
            if (isUpdating)
                queuedEntities.Add(entity);
            else
                entities.Add(entity);
        }

        public static void Update()
        {
            isUpdating = true;
            foreach (var entity in entities)
                entity.Update();
            isUpdating = false;

            foreach (var entity in queuedEntities)
                entities.Add(entity);
            queuedEntities.Clear();

            entities.RemoveAll(e => e.isExpired);
        }

        public static void Draw(SpriteBatch spriteBatch)
        {
            foreach (var entity in entities)
                entity.Draw(spriteBatch);
        }
    }
}
