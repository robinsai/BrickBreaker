using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BrickBreak
{


    public class Ball : Shape
    {
        //  public void

        public Ball(Point Pos, Point Speed, int xSize, int ySize = 0) : base(Pos, Speed, xSize, ySize)
        {

        }
        public void ballMovement()
        {
            this.x +=this.speedX;
            this.y += this.speedY;
        }
        public void draw(Graphics gfx, Color colour)
        {
            gfx.DrawEllipse(new Pen(colour), Hitbox);
        }

      
        
        public void bounce(bool xBounce = false, bool yBounce = false)
        {
            if (xBounce)
            {
                this.speedX *= -1;
            }
            if (yBounce)
            {
                this.speedY *= -1;
            }


        }
        public void ballhittingBottomScreen(int ClientSizeHeight)
        {
            if (this.y + this.height > ClientSizeHeight)

            {

                this.x = ClientSizeHeight;
                this.y = ClientSizeHeight / 2;
            }
           
        }
    }
}


