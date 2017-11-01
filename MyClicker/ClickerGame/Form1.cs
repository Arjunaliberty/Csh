using MyClicker;
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
        // Поле для хранения ???
        private int gen;
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
                // Удаляем фигуры из очереди удаления, а потом из общей коллекции
                while(delFigures.Count > 0)
                {
                    figures.Remove(delFigures.Dequeue());
                }
            }
        }






        public Form1()
        {
            InitializeComponent();
            gameField = this.CreateGraphics();
        }

        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
