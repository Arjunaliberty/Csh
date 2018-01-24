using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clicker_WFA
{
    public partial class Form1 : Form
    {
        int pnts = 0;
        int gen = 0;
        Graphics gameField=null;
        List<Figure> figures= new List<Figure>();

        

        private void DrawFigures()
        {
            foreach (var item in figures)
            {
                item.Draw();
            }
        }

        private void TTL()
        {
            Queue<Figure> delFigures=new Queue<Figure>();
            
            foreach (var fgr in figures)
            {
                fgr.TTL--;
                if (fgr.TTL <= 0)
                {
                    delFigures.Enqueue(fgr);
                    fgr.ClearDraw(this.BackColor);
                }
            }

            while (delFigures.Count>0)
            {
                figures.Remove(delFigures.Dequeue());
            }
        }

        private void AddNewFigures()
        {
            int x0, y0, r, ttl;
            int typeFrg = 1;
            Color clr;
            Figure fgr = null;
            
            Random rnd = new Random();

            r = rnd.Next(1, 15);
            ttl = rnd.Next(5, 15);
            x0 = rnd.Next(0, this.Width);
            y0 = rnd.Next(0, this.Height);

            clr = Color.FromArgb(rnd.Next(0, 255), rnd.Next(0, 255), rnd.Next(0, 255), rnd.Next(0, 255));

            switch (typeFrg)
            {
                case 1:
                    fgr = new Circle(x0 - r, y0 - r, x0 + r, y0 + r, ttl, clr,
                          this.Width, this.Height, this.gameField);
                    figures.Add(fgr);
                    break;
                case 2:
                    break;
                case 3:
                    break;
            }
        }
	

	  private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            Figure delFigure=null;

            foreach (var fgr in figures)
            {
                if (fgr.CheckPoint(e.X,e.Y))
                {
                    delFigure=fgr;
                    pnts += fgr.GetPoint();
                    fgr.ClearDraw(this.BackColor);
                    label1.Text = pnts.ToString();
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            //if (gen == 0)
            //{
            //    gen++;
                AddNewFigures();
           // }
            TTL();
            DrawFigures();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddNewFigures();
            DrawFigures();
        }

      
    }
}
