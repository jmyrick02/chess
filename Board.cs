using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Chess
{
    public class Board
    {
        public List<Cell> Cells { get; private set; }

        public Board(Vector2 anchorPoint, Vector2 cellScale, Tuple<Color, Color> colors)
        {
            Cells = new List<Cell>();

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Cell cell = new Cell(anchorPoint + new Vector2(cellScale.X * i, cellScale.Y * j), cellScale, (i + j) % 2 == 0 ? colors.Item1 : colors.Item2, false);
                    Cells.Add(cell);
                    new Piece(Game1.ContentManager.Load<Texture2D>("wP"), cell);
                }
            }
        }
    }
}
