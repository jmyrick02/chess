using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Chess
{
    public class Cell : GameObject
    {
        
        public Color Color { get; }
        public bool IsPromoting { get; }

        public Cell(Vector2 position, Vector2 scale, Color color, bool isPromoting) : base(new Texture2D(Game1.GDevice, 1, 1), position, scale, true)
        {
            Texture.SetData(new[] { color });

            Position = position;
            Scale = scale;
            Color = color;
            IsPromoting = isPromoting;
        }
    }
}
