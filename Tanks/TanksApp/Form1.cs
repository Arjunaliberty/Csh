using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TanksClass;

namespace TanksApp
{
    public partial class Form1 : Form
    {
        GameField gameField = null;
        Figures tank1 = null;
        Figures tank2 = null;
        Figures wall1 = null;
        Figures wall2 = null;
        List<Figures> figures = new List<Figures>();

        public Form1()
        {
            InitializeComponent();

            Random rnd = new Random();
            gameField = new GameField(2, 2, this.Width - 24, this.Height - 46, this.BackColor, this.CreateGraphics());
           
            tank1 = new Tank1(rnd.Next(2, this.Width - 24), rnd.Next(2, this.Height - 46), 1, 1, 5, Color.BlueViolet, gameField);
            //tank2 = new Tank2(rnd.Next(2, this.Width - 24), rnd.Next(2, this.Height - 46), 1, 1, 5, Color.DarkGray, gameField);
            wall1 = new Wall(rnd.Next(2, this.Width - 24), rnd.Next(2, this.Height - 46), Color.Brown, gameField);
            wall2 = new Wall(rnd.Next(2, this.Width - 24), rnd.Next(2, this.Height - 46), Color.Brown, gameField);
            figures.Add(tank1);
            //figures.Add(tank2);
            figures.Add(wall1);
            figures.Add(wall2);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        /// <summary>
        /// Метод для проверки пересечения координат снаряда с другими объктами
        /// </summary>
        /// <returns></returns>
        private bool CheckBullet(Figures bullet)
        {
            foreach (Figures item in figures)
            {
                 if (item is Bonus)
                 {
                     if ((((Bullet)bullet).GetAverageX() >= ((Bonus)item).x0 && (((Bullet)bullet).GetAverageX() <= ((Bonus)item).x0 + ((Bonus)item).BonusWidth())) && 
                        ((((Bullet)bullet).GetAverageY() >= ((Bonus)item).y0) && (((Bullet)bullet).GetAverageY() <= ((Bonus)item).y0 + ((Bonus)item).BonusHight())))
                     {
                         return true;
                     }
                 }
                 /*if (item is Tanks)
                 {
                     if ((((Bullet)bullet).GetAverageX() >= ((Tanks)item).x0) && 
                        ((((Bullet)bullet).GetAverageY() >= ((Tanks)item).y0) && (((Bullet)bullet).GetAverageY() <= ((Tanks)item).y0 + ((Tanks)item).GetHight())))
                     {
                        return true;
                     }
                 }*/
                 if (item is Wall)
                 {
                     if ((((Bullet)bullet).GetAverageX() >= ((Wall)item).x0) && 
                        ((((Bullet)bullet).GetAverageY() >= ((Wall)item).y0) && (((Bullet)bullet).GetAverageY() <= ((Wall)item).y0 + ((Wall)item).GetHight())))
                     {
                        return true;
                     }
                 }
            }
            return false;
        }

        /// <summary>
        /// Метод для уничтожения объектов типа Bullet при пересечении с другими оъектами
        /// </summary>
        private void Bulletdestruction()
        {
            Queue<Figures> delObject = new Queue<Figures>();

            foreach (Figures bullet in figures)
            {
                if(bullet is Bullet)
                {
                    if(CheckBullet(bullet))
                    {

                        // Неправильно работает, уничтожет все объекты типа Bonus
                        foreach (Figures bonus in figures)
                        {
                            if (bonus is Bonus)
                            {
                                bullet.ClearDraw(this.BackColor);
                                delObject.Enqueue(bonus);
                            }
                        }

                        bullet.ClearDraw(this.BackColor);
                        delObject.Enqueue(bullet);
                    }
                }
                
            }

            while (delObject.Count > 0)
            {
                figures.Remove(delObject.Dequeue());
            }
        }

        /// <summary>
        /// Метод для генерации объетов типа Bonus
        /// </summary>
        private void BonusAdd()
        {
            Random rnd = new Random();

            figures.Add(new Bonus(rnd.Next(2, this.Width - 24), rnd.Next(2, this.Height - 46), 50, Color.Coral, gameField));
        }

        /// <summary>
        /// Метод по отрисовке объектов типа Figures
        /// </summary>
        private void ShowFigures()
        {
            foreach (Figures item in figures)
            {
                item.ShowDraw();
            }
        }

        /// <summary>
        /// Метод по стиранию объектов типа Figures
        /// </summary>
        private void ClearFigutes()
        {
            foreach (Figures item in figures)
            {
                item.ClearDraw(this.BackColor);
            }
        }

        /// <summary>
        /// Метод для проверки время жизни объектов и их уничтожения
        /// </summary>
        private void TTL()
        {
            Queue<Figures> delFigures = new Queue<Figures>();

            foreach (Figures item in figures)
            {
                if(item is Bullet)
                {
                    ((Bullet)item).ttl--;

                    if(((Bullet)item).ttl <= 0)
                    {
                        delFigures.Enqueue(item);
                        item.ClearDraw(this.BackColor);
                    }
                }
                if (item is Bonus)
                {
                    ((Bonus)item).ttl--;

                    if (((Bonus)item).ttl <= 0)
                    {
                        delFigures.Enqueue(item);
                        item.ClearDraw(this.BackColor);
                    }
                }
            }

            while (delFigures.Count > 0)
            {
                figures.Remove(delFigures.Dequeue());
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
            ClearFigutes();
            Bulletdestruction();
            TTL();
            foreach (Figures item in figures)
            {
                if(item is Bullet)
                {
                    ((Bullet)item).MoveX();
                }
            }
            ShowFigures();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            BonusAdd();
        }

        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            timer1.Start();
            timer2.Start();
        }

        /// <summary>
        /// Метод по обработке наижатий клавишь
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case ' ':
                    figures.Add(((Tank1)tank1).Fire());
                    break;
                case 'w':
                    tank1.ClearDraw(this.BackColor);
                    ((Tanks)tank1).MoveUpY();
                    tank1.ShowDraw();
                    break;
                case 's':
                    tank1.ClearDraw(this.BackColor);
                    ((Tanks)tank1).MoveDowbY();
                    tank1.ShowDraw();
                    break;
                case 'd':
                    tank1.ClearDraw(this.BackColor);
                    ((Tanks)tank1).MoveRightX();
                    tank1.ShowDraw();
                    break;
                case 'a':
                    tank1.ClearDraw(this.BackColor);
                    ((Tanks)tank1).MoveLeftX();
                    tank1.ShowDraw();
                    break;
            }
        }
    }
}
