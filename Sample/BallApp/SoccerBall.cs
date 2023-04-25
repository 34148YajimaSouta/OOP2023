﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallApp {
    class SoccerBall : Object{



        //コンストラクタ
        public  SoccerBall(double xp,double yp) :base(xp,yp, @"pic\soccer_ball.png"){
            Random r1 = new System.Random();
           
            int rndX = r1.Next(-100, 100);
            MoveX = (rndX !=0 ? rndX:1);
            int rndY = r1.Next(-100, 100);
            MoveY = (rndY != 0 ? rndY : 1);
        }



        //メソッド
        public override void Move() {
            
            PosX += MoveX;
            PosY += MoveY;
            if (PosX > 750 || PosX <10)
            {
                MoveX = -MoveX;
            }
            if (PosY >550 || PosY <10)
            {
                MoveY = -MoveY;
            }
        }

    }
}
