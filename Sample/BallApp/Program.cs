﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BallApp {
    class Program : Form {

        Bar bar;
        PictureBox pbBar;
        private Timer moveTimer;    //タイマー用
        private PictureBox pb;

        private List<Object> balls = new List<Object>();
        private List<PictureBox> pbs = new List<PictureBox>();

        static void Main(string[] args) {
            Application.Run(new Program());
        }

        public Program() {
            
            this.Size = new Size(800, 600);
            this.BackColor = Color.Green;
            
            this.MouseClick += Program_MouseClick;
            this.KeyDown += Program_KeyDown;

            bar = new Bar(340, 500);
            pbBar = new PictureBox();
            pbBar.Image = bar.Image;
            pbBar.Location = new Point((int)bar.PosX, (int)bar.PosY); //画像の位置
            pbBar.Size = new Size(150, 10);
            pbBar.SizeMode = PictureBoxSizeMode.StretchImage;  //画像の表示モード
            pbBar.Parent = this;

            moveTimer = new Timer();
            moveTimer.Interval = 1; //タイマーのインターバル（ms）
            moveTimer.Tick += MoveTimer_Tick;　//デリゲート登録
        }

         private void Program_KeyDown(object sender, KeyEventArgs e) {
            bar.Move(e.KeyData);
            pbBar.Location = new Point((int)bar.PosX, (int)bar.PosY);
        }

        //マウスクリック時のイベントハンドラ
        private void Program_MouseClick(object sender, MouseEventArgs e) {
            //ボールインスタンス生成
            Object ballobj = null;
            pb = new PictureBox();
            if(e.Button== MouseButtons.Left)
            {
                ballobj = new SoccerBall(e.X - 25, e.Y - 25);
                pb.Size = new Size(50, 50);
            }
            else if (e.Button == MouseButtons.Right)
            {
                ballobj = new TennisBall(e.X - 12, e.Y - 12);
                pb.Size = new Size(25, 25);
            }

            pb.Image = ballobj.Image;
            pb.Location = new Point((int)ballobj.PosX, (int)ballobj.PosY); //画像の位置
            pb.SizeMode = PictureBoxSizeMode.StretchImage;  //画像の表示モード
            pb.Parent = this;
            balls.Add(ballobj);
            pbs.Add(pb);

            this.Text=("サッカーボール" + SoccerBall.Count + "テニスボール" + TennisBall.Count);
            moveTimer.Start();
      
        }

        

        //タイマータイムアウト時のイベントハンドラ
        private void MoveTimer_Tick(object sender, EventArgs e) {
            for(int i = 0; i < balls.Count; i++)
            {
               balls[i].Move(pbBar,pbs[i]);
               pbs[i].Location = new Point((int)balls[i].PosX, (int)balls[i].PosY);
            }
        }
    }
}
