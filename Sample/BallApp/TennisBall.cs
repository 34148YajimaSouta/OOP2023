using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BallApp {
    class TennisBall : Object {
        private static int count;
        public static int Count { get => count; set => count = value; }

        public TennisBall(double xp, double yp) : base(xp, yp, @"pic\tennis_ball.png") {
            Random r1 = new System.Random();

            int rndX = r1.Next(-100, 100);
            MoveX = (rndX != 0 ? rndX : 1);
            int rndY = r1.Next(-100, 100);
            MoveY = (rndY != 0 ? rndY : 1);
            Count++;
        }



        public override void Move(PictureBox pbBar, PictureBox pbBall) {

            Rectangle rBar = new Rectangle(pbBar.Location.X, pbBar.Location.Y, pbBar.Width, pbBar.Height);
            Rectangle rBall = new Rectangle(pbBall.Location.X, pbBall.Location.Y, pbBall.Width, pbBall.Height);
            PosX += MoveX;
            PosY += MoveY;
            if (PosX > 750 || PosX < 10 || rBar.IntersectsWith(rBall))
            {
                MoveX = -MoveX;
            }
            if (PosY > 550 || PosY < 10)
            {
                MoveY = -MoveY;
            }
        }
        public override void Move(Keys derection) {
        }

     }
 }
