using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrickBreak
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Graphics gfx;
        Paddle playerPaddle;
        Ball ball;
        public void Form1_Load(object sender, EventArgs e)
        {
            gfx = CreateGraphics();
            Point paddlePosition = new Point(0, ClientSize.Height);
            Point paddleSpeed = new Point(5, 10);
            playerPaddle = new Paddle(paddlePosition, paddleSpeed, 0, ClientSize.Height);

            Point ballPosition = new Point(ClientSize.Width / 2, ClientSize.Height - 50);
            Point ballSpeed = new Point(20, 10);
            ball = new Ball(ballPosition, ballSpeed, 20, 20);
        }
        private void Timer2_Tick(object sender, EventArgs e)
        {

            gfx.Clear(Color.CadetBlue);
            ball.ballMovement();
            ball.ballHitsXWall(ClientSize.Width);
            ball.draw(gfx, Color.BurlyWood);

         
        }
    }
}
