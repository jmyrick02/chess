using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Chess
{
    public class GameObject
    {
        public Vector2 Position { get; set; }
        public Vector2 Scale { get; set; }
        public Texture2D Texture { get; }
        public bool IsActive { get; set; }

        public GameObject(Texture2D texture, Vector2 position, Vector2 scale, bool isActive)
        {
            Position = position;
            Scale = scale;
            Texture = texture;
            IsActive = isActive;

            Game1.GameObjects.Add(this);
        }
    }
}
