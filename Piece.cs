using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Chess
{
    public class Piece : GameObject // includes pawns
    {
        public Cell OccupiedCell { get; set; }

        public Piece(Texture2D texture, Cell occupiedCell) : base(texture, occupiedCell.Position, occupiedCell.Scale, true)
        {
            OccupiedCell = occupiedCell;
        }
    }
}
