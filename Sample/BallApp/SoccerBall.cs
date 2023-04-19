using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallApp {
    class SoccerBall {
        //フィールド
        private Image image;    //画像データ

        private double posX;    //ｘ座標
        private double posY;    //ｙ座標

        private double moveX ;  //移動量（ｘ方向）
        private double moveY ;  //移動量（ｙ方向）

        //コンストラクタ
        public  SoccerBall(double xp,double yp) {
            Image = Image.FromFile(@"pic\soccer_ball.png");
            Random r1 = new System.Random();
            PosX = xp;
            PosY = yp;
            int rndX = r1.Next(-100, 100);
            moveX = (rndX !=0 ? rndX:1);
            int rndY = r1.Next(-100, 100);
            moveY = (rndY != 0 ? rndY : 1);
        }

        //プロパティ
        public double PosX { get => posX; set => posX = value; }
        public double PosY { get => posY; set => posY = value; }
        public Image Image { get => image; set => image = value; }

        //メソッド
        public void Move() {
            
            posX += moveX;
            posY += moveY;
            if (posX > 750 || posX <10)
            {
                moveX = -moveX;
            }
            if (posY >550 || posY <10)
            {
                moveY = -moveY;
            }
        }

    }
}
