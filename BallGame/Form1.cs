using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BallGame
{
    public partial class Form1 : Form
    {
        private Ball ball1 = new Ball();
        List<Ball> listBalls = new List<Ball>();
        List<PictureBox> Balls = new List<PictureBox>();
        double relativeIntersectY;
        double normalizedRelativeIntersectionY;
        double bounceAngle;
        public Form1()
        {
            
            InitializeComponent();
            ballBox.Location = new Point(300, 30);
            ball1.Location = new Point(10, 10);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (start.Text == "start")
            {
                timer1.Start();
                start.Text = "stop";
            }
            else
            {
                timer1.Stop();
                start.Text = "start";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            paddle.Left = Cursor.Position.X - (paddle.Width) / 2;
             ballBox.Location = new Point(ballBox.Location.X + (int)ball1.Vx, ballBox.Location.Y + (int)ball1.Vy);
           /* if (paddle.Bounds.IntersectsWith(ballBox.Bounds))
            {
                relativeIntersectY = (paddle.Location.X + ((paddle.Width) / 2)) - ballBox.Location.X;
                normalizedRelativeIntersectionY = (relativeIntersectY / ((paddle.Width) / 2));
                bounceAngle = normalizedRelativeIntersectionY * 360;
                ball1.Vx *= (-Math.Sin(bounceAngle));
                ball1.Vy *= Math.Cos(bounceAngle);
               

            }
            else */
            if (ballBox.Location.X >= 535)
            {
                ball1.Vx = -ball1.Vx;
            }
            else if (ballBox.Location.X <= 0)
            {
                ball1.Vx = -ball1.Vx;
            }
            else if (ballBox.Location.Y <= 0)
            {
                ball1.Vy = -ball1.Vy;
            }
            else if (ballBox.Location.Y >= panel1.Bottom)
            {
               // timer1.Enabled = false;
              //  Application.Exit();

            }
                foreach (Ball ball in listBalls)
            {
                foreach (PictureBox ballbox in Balls)
                {
                    ballbox.Location = new Point(ballbox.Location.X + (int)ball.Vx, ballbox.Location.Y + (int)ball.Vy);
                   /* if (paddle.Bounds.IntersectsWith(ballBox.Bounds))
                    {
                         relativeIntersectY = (paddle.Location.X + ((paddle.Width) / 2)) - ballBox.Location.X;
                          normalizedRelativeIntersectionY = (relativeIntersectY / ((paddle.Width) / 2));
                          bounceAngle = normalizedRelativeIntersectionY * 360;
                          ball.Vx *=(-Math.Sin(bounceAngle));
                          ball.Vy *=Math.Cos(bounceAngle);
                        
                    }*/
                    //else
                    if (ballbox.Location.X >= 535)
                    {
                        ball.Vx = -ball.Vx;
                    }
                    else if (ballbox.Location.X <= 0)
                    {
                        ball.Vx = -ball.Vx;
                    }
                    else if (ballbox.Location.Y <= 0)
                    {
                        ball.Vy = -ball.Vy;
                    }
                    else if (ballBox.Location.Y >= panel1.Bottom)
                    {
                        timer1.Enabled = false;
                      //  Application.Exit();
                    }
                }
            }
        }

        private void ballBox_Click(object sender, EventArgs e)
        {

        }

        private void generate_Click(object sender, EventArgs e)
        {
            Ball tempBall = new Ball();
            PictureBox temp = new PictureBox();
            temp.Image = global::BallGame.Properties.Resources.ball;
            temp.Location = new System.Drawing.Point(33 , 24);
            temp.Size = new System.Drawing.Size(61, 55);
            temp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            temp.TabIndex = 0;
            temp.TabStop = false;
            listBalls.Add(tempBall);
            Balls.Add(temp);
            panel1.Controls.Add(temp);
        }

        private void paddle_Click(object sender, EventArgs e)
        {

        }
    }
}
