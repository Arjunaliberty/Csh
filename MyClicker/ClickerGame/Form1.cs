﻿using MyClicker;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClickerGame
{
    public partial class Form1 : Form
    {
        // Поле для хранения счета
        private int scr;
        // Поле для хранения игровой области
        private Graphics gameField = null;
        // Коллекция для хранения объектов типа Figure
        List<Figure> figures = new List<Figure>();

        // Метод для вызова функции отрисовки каждой фигуры
        private void DrawFigures()
        {
            foreach(var fgr in figures)
            {
                fgr.Draw();
            }
        }
        // Метод для определения время жизни фигур
        private void TTL()
        {
            // Создаем коллекцию (очередь) хранящую фигуры для удаления
            Queue<Figure> delFigures = new Queue<Figure>();
            
            foreach(var fgr in figures)
            {
                // Уменьшаем время жизни (ttl) конкретной фигуры
                fgr.ttl--;
                // Проверяем ttl жива ли фигура
                if(fgr.ttl <= 0)
                {
                    // Если ttl истекло, то добавляем данную фигуру в коллекцию для удаления
                    delFigures.Enqueue(fgr);
                    // И удаляем фигуру с экрана (делаем ее цвет такойже как и основного поля)
                    fgr.ClearDraw(this.BackColor);
                }
            }
            // Удаляем фигуры из очереди удаления, а потом из общей коллекции
            while (delFigures.Count > 0)
            {
                figures.Remove(delFigures.Dequeue());
            }
        }
        // Метод для добавления новой фигуры
        private void AddNewFigures()
        {
            // Поля для хранения координат и время жизни фигуры (для передачи конструктору Figure)
            int x0, y0, r, ttl;
            // Поле для хранения типа фигуры (для передачи конструктору Figure)
            int type;
            // Поле для хранения цвета фигуры (для передачи конструктору Figure)
            Color color;
            // Создаем тип для работы с классом Random
            Random rnd = new Random();

            // Инициализируем переменный
            x0 = rnd.Next(0, this.Width);
            y0 = rnd.Next(0, this.Height);
            r = rnd.Next(1, 10);
            ttl = rnd.Next(15, 120);
            type = rnd.Next(1, 3);
            color = Color.FromArgb(rnd.Next(0, 255), rnd.Next(0, 255), rnd.Next(0, 255), rnd.Next(0, 255));

            switch (type)
            {
                case 1:
                    // Добавляем элемент в список figures
                    figures.Add(new Circle(x0 - r, y0 - r, x0 + r, y0 + r, ttl, this.Width, this.Height, color, this.gameField));
                    break;
                case 2:
                    figures.Add(new Quadrate(x0 - r, y0 - r, x0 + r, y0 + r, ttl, this.Width, this.Height, color, this.gameField));
                    break;
                case 3:
                    break;
            }
        }
        // Метод для пермещения фигур по экрану
        private void MoveFigure()
        {
            foreach (var fgr in figures)
            {
                if (fgr.leftUpY <= 0 && fgr.rightDownY < this.Height)
                {
                    fgr.direct = true;
                    fgr.ClearDraw(this.BackColor);
                    fgr.MoveDown();
                }
                else if ((fgr.leftUpY > 0 && fgr.rightDownY < this.Height) && fgr.direct)
                {
                    fgr.ClearDraw(this.BackColor);
                    fgr.MoveDown();
                }
                else if (fgr.leftUpY > 0 && fgr.rightDownY >= this.Height)
                {
                    fgr.direct = false;
                    fgr.ClearDraw(this.BackColor);
                    fgr.MoveUp();
                }
                else if ((fgr.leftUpY > 0 && fgr.rightDownY < this.Height) && !fgr.direct)
                {
                    fgr.ClearDraw(this.BackColor);
                    fgr.MoveUp();
                }
            }
        }
        // Метод обрабатывающий щелчек мыши по фигуре
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            // Поле для хранения удаляемой фигуры
            Figure delFigure = null;

            foreach (var fgr in figures)
            {
                if (fgr.CheckPoint(e.X, e.Y))
                {
                    delFigure = fgr;
                    scr += fgr.GetScore();
                    fgr.ClearDraw(this.BackColor);
                    score.Text = scr.ToString();
                }
            }
            figures.Remove(delFigure);
        }
        public Form1()
        {
            InitializeComponent();
            gameField = this.CreateGraphics();
        }

        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            timer1.Start();
        }

        // В метод таймер записываем последовательность вызовов необходимых функций
        private void timer1_Tick(object sender, EventArgs e)
        {
            AddNewFigures();
            TTL();
            MoveFigure();
            DrawFigures();
        }
    }
}
