using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BrickBreak
{
    class Paddle : Shape
    {

        public enum paddleMovement
        {
            goLeft,
            goRight,
        };
        public Paddle(Point Pos, Point Speed, int xSize, int ySize = 0) : base(Pos, Speed, xSize, ySize)
        {

        }
        public void draw(Graphics gfx, Color colour)
        {
            gfx.DrawRectangle(new Pen(colour), Hitbox);
        }
        void goLeft()
        {
            this.x -= this.speedX;

        }
        void goRight()
        {
            this.x += this.speedX;
        }
        public void movement(int rightScreen, paddleMovement directions)
        {

            if (this.x > 0 && directions == paddleMovement.goLeft)
            {
                goLeft();
            }
            else if (this.x + this.width<rightScreen && directions == paddleMovement.goRight)
            {
                goRight();
            }
        }
    }
}
