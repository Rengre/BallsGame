using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BallGame
{
    class Ball : PictureBox
    {
        private double vx = 10;
        private double vy = 10;
        public double Vx
        {
            get
            {
                return vx;
            }
            set
            {
                vx = value;
            }
        }
        public double Vy
        {
            get
            {
                return vy;
            }
            set
            {
                vy = value;
            }
        }
    }
}
