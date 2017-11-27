using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TanksClass;

namespace TanksApp
{
    public partial class Form1 : Form
    {
        GameField gameField = null;
        List<Figures> figures = new List<Figures>();
        Figures tank = null;
        Figures bonus = null;

        public Form1()
        {
            InitializeComponent();

            gameField = new GameField(20, 20, this.Width - 20, this.Height - 20, this.BackColor, this.CreateGraphics());

            tank = new Tank(70, 150, 1, 1, 1, Color.Red, gameField);

            figures.Add(tank);
            figures.Add(new Wall(100, 50, Color.Red, gameField));
            figures.Add(new Wall(200, 100, Color.Red, gameField));
        }

        /// <summary>
        /// Метод для добавления фигур в спсиок Figures
        /// </summary>
        private void AddFigures()
        {
            Random rnd = new Random();
        }

        /// <summary>
        /// Метод для проверки время жизни фигур и их удаления из списка Figures
        /// </summary>
        private void TTLBullet()
        {
            // Создаем очередб для добавления удаляемых элементов
            Queue<Figures> delFigures = new Queue<Figures>();

            // Перебираем в цикле все элементы из коллекции Figures, проверяем время жизни
            // и если оно законцено добавляем в очередь для удаления
            foreach (var item in figures)
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
                    
                    if(((Bonus)item).ttl <= 0)
                    {
                        delFigures.Enqueue(item);
                        item.ClearDraw(this.BackColor);
                    }
                }
            }

            // Удаляем все помеченные на удаление элементы из очереди,
            // а затем из списка фигур
            while (delFigures.Count > 0)
            {
                figures.Remove(delFigures.Dequeue());
            }
        }



        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            this.timer1.Start();            
        }

        /// <summary>
        /// Обработка событий по срабатыванию таймера
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            // Сделать это одельным методом
            foreach (var item in figures)
            {
                item.ClearDraw(this.BackColor);
            }

            TTLBullet();

            foreach (var item in figures)
            {
                if(item is Bullet)
                {
                    ((Bullet)item).MoveX();
                }
            }

            foreach (var item in figures)
            {
                item.ShowDraw();
            }
        }

        /// <summary>
        /// Метод для обработки нажатий клавишь
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Если нажат ' ', то вызываем метод Fire из объекта Tank
            if(e.KeyChar == ' ')
            {
                figures.Add(((Tank)tank).Fire());
            }
        }
    }
}
