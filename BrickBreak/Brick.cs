using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrickBreak
{
    public class Brick : Shape
    {


        Graphics gfx;
        public Brick(Point Pos, Point Speed, int xSize, int ySize = 0) : base(Pos, Speed, xSize, ySize)
        {
        }

        public void draw(Graphics graph, Color color)
        {
            graph.DrawRectangle(new Pen(color), Hitbox);
        }

    }
}
