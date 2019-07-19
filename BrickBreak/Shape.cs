using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BrickBreak
{
    public class Shape
    {
        Point Position { get; set; }
        Point Speed;
        Size size {get; set;}
        public Rectangle Hitbox
        {
            get
            {
                return new Rectangle(Position, size);
            }
          
        }

        public int x
        {
            get { return Position.X; }
            set { Position = new Point(value, Position.Y); }
        }
        public int y
        {
            get { return Position.Y; }
            set { Position = new Point(Position.X, value); }
        }
        public int width
        {
            get { return size.Width; }
            set { size = new Size(value, size.Height); }
        }
        public int height
        {
            get { return size.Height; }
            set { size = new Size(size.Width, value); }
        }
        public int speedX
        {
            get { return Speed.X; }
            set { Speed = new Point(value, Speed.Y); }
        }
        public int speedY
        {
            get { return Speed.Y; }
            set { Speed = new Point(Speed.X, value); }
        }
        public Shape(Point Pos, Point Speed, int width, int height = 0)
        {
            this.Position = Pos;
            this.Speed = Speed;

            if (height == 0)
            {
                this.size = new Size(width, width);
            }
            else
            {
                this.size = new Size(width, height);
            }
        }
        /*
        public void drawShape(Graphics graphics, Color color, Shape shape)
        {

            graphics.DrawEllipse(new Pen(color), shape.x, shape.y, shape.xSize, shape.ySize);
        }
        */

    }
}
