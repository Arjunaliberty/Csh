using PingPongClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        const int WIDTH_PAD = 5;
        const int HEIGHT_PAD = 50;
        const int RACKET_SPEED = 6;
        const int BALL_RAD = 5;
        const int BALL_SPEED = 2;


        Ball ball;
        GameField gameField;
        RacketPad leftPad;
        RacketPad rightPad;
        /// <summary>
        /// Поля для хранения счета игроков
        /// </summary>
        int scorePad1 = 0, scorePad2 = 0;

        public Form1()
        {
            InitializeComponent();
            gameField = new GameField(0, 20, this.Width - 15, this.Height - 35, this.BackColor, this.CreateGraphics());
            leftPad = new RacketPad(0, (this.Height / 2) - (HEIGHT_PAD / 2), WIDTH_PAD, HEIGHT_PAD, Color.Lime, RACKET_SPEED, gameField);
            rightPad = new RacketPad(this.Width - 20, (this.Height / 2) - (HEIGHT_PAD / 2), WIDTH_PAD, HEIGHT_PAD, Color.Red, RACKET_SPEED, gameField);
            ball = new Ball(this.Width / 2, this.Height / 2, BALL_RAD, Color.Blue, BALL_SPEED, gameField, -1, this.Height / 2 + this.Width / 2);
        }

        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.label2.Text = scorePad1.ToString();
            this.label4.Text = scorePad2.ToString();

            if (!ball.CheckMinX() && !ball.CheckMaxX())
            {
                ball.ClearDraw();
                ball.Move(leftPad, rightPad);
                ball.Draw();
                leftPad.Draw();
                rightPad.Draw();
            }
            else if (ball.CheckMinX()) 
            {
                scorePad2 += 5;
                this.label4.Text = scorePad2.ToString();

                ball.ClearDraw();
                rightPad.ClearDraw();
                leftPad.ClearDraw();
                ball.x = this.Width / 2;
                ball.y = this.Height / 2;
                ball.b = this.Height / 2 + this.Width / 2;
                ball.k = -1;
                rightPad.y = this.Height / 2 - HEIGHT_PAD / 2;
                leftPad.y = this.Height / 2 - HEIGHT_PAD / 2;
            }
            else if (ball.CheckMaxX())
            {
                scorePad1 += 5;
                this.label2.Text = scorePad1.ToString();

                ball.ClearDraw();
                rightPad.ClearDraw();
                leftPad.ClearDraw();
                ball.x = this.Width / 2;
                ball.y = this.Height / 2;
                ball.b = this.Height / 2 + this.Width / 2;
                ball.k = -1;
                rightPad.y = this.Height / 2 - HEIGHT_PAD / 2;
                leftPad.y = this.Height / 2 - HEIGHT_PAD / 2;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Метод для передвижения ракеток по экрану
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (ball.speed < 0)
            {
                switch (e.KeyChar)
                {
                    case 'w':
                    case 'ц':
                        leftPad.ClearDraw();
                        leftPad.MoveUp();
                        leftPad.Draw();
                        break;
                    case 's':
                    case 'ы':
                        leftPad.ClearDraw();
                        leftPad.MoveDown();
                        leftPad.Draw();
                        break;
                }
                rightPad.ClearDraw();
                rightPad.y = this.Height / 2 - 25;
                rightPad.Draw();

            } else
            {
                switch (e.KeyChar)
                {
                    case 'o':
                    case 'щ':
                        rightPad.ClearDraw();
                        rightPad.MoveUp();
                        rightPad.Draw();
                        break;
                    case 'l':
                    case 'д':
                        rightPad.ClearDraw();
                        rightPad.MoveDown();
                        rightPad.Draw();
                        break;
                }
                leftPad.ClearDraw();
                leftPad.y = this.Height / 2 - 25;
                leftPad.Draw();
            }
        }


       
    }
}
