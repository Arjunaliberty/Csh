using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MyClicker
{
    public abstract class Figure
    {
       
        // Поля хранения координая квадрата крайней верхней точки
        public int leftUpX { get; set; }
        public int leftUpY { get; set; }

        // Поля хранения координая квадрата крайней нижней точки
        public int rightDownX { get; set; }
        public int rightDownY { get; set; }

        // Свойство для хранения направления движения фигуры
        public int direct { get; set; }

        // Поле для хранения время жизни фигуры (time to life)
        public int ttl { get; set; }

        // Поля для хранения размеров экрана для отображения фигуры 
        protected int maxX, maxY;

        // Поле для хранания информации о пространстве для отображения фигуры
        protected Graphics gameField;
        
        // Поле для хранения цвета фигуры
        protected Color color;

        public Figure(int leftUpX, int leftUpY, int rightDownX, int rightDownY, int ttl, int maxX, int maxY, int direct, Color color, Graphics gameField)
        {
            this.leftUpX = leftUpX;
            this.leftUpY = leftUpY;
            this.rightDownX = rightDownX;
            this.rightDownY = rightDownY;
            this.ttl = ttl;
            this.direct = direct;
            this.color = color;
            this.gameField = gameField;
        }

        // Функция для передвижения фигуры по вертикали вниз
        public void MoveDown()
        {
            leftUpY += 2;
            rightDownY +=2;
            

        }
        // Функция для передвижения фигуры по вертикали вверх
        public void MoveUp()
        {
            leftUpY -= 2;
            rightDownY -=2;
        }
        // Функция для передвижения фигуры вправо по горизонтали
        public void MoveRight()
        {
            leftUpX++;
            rightDownX++;
        }
        // Функция для перемещения фигуры влево по горизонтали
        public void MoveLeft()
        {
            leftUpX--;
            rightDownX--;
        }
        // Виртуальная функция для возвращения количества очков при попадании на фигуру
        public abstract int GetScore();
        // Виртуальна функция для проверки координат мыши на соответсвия координатам фигруры
        public abstract bool CheckPoint(int X, int Y);
        // Виртуальная функция для отрисовки фигуры
        public abstract void Draw();
        // Виртуальная функция для стирания фигуры с экрана
        public abstract void ClearDraw(Color clrColor);
    } 
}
