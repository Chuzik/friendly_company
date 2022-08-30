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

namespace Practica_2kyrs
{

    public partial class Form1 : Form
    {
        Ball[] krug = new Ball[4];
        Ball glkrug;

        public Form1()
        {
            InitializeComponent();
            //создание объектов
            int x = -250;
            for (int j = 0; j < 4; j++)
            {
                krug[j] = new Ball(Brushes.Green, new Point(x, 100), new Size(40, 40));
                x = x + 50;
            }
            glkrug = new Ball(Brushes.Green, new Point(-50, 100), new Size(40, 40), true);
  
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int j = 0; j < 4; j++)
            {
                krug[j].Move();
            }
            glkrug.Move();

            Invalidate();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
        
        private void button_Pause_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void Resume_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            int x = -250;
            for (int j = 0; j < 4; j++)
            {
                krug[j] = new Ball(Brushes.Green, new Point(x, 100), new Size(40, 40));
                x = x + 50;
            }
            glkrug = new Ball(Brushes.Green, new Point(-50, 100), new Size(40, 40), true);
        }
                      

        private void button_Info_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Вариант работы: 10.\nПриложение 'Дружная компания'.\nВыполнила студентка группы 4208,\nМиннекаева Гузель.", "Info");
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            glkrug.Draw2(e.Graphics);
            for (int j = 0; j < 4; j++)
            {
                krug[j].Draw(e.Graphics);
            }
        }
    }
    class Ball
    {
        Point koor;
        Point glkoor;
        Brush color;
        Size size;
        Brush glcolor;
        Size glsize;
        public delegate void Delegate();
        public event Delegate EventDelegate;
        
        public Ball(Brush pcolor, Point pkoor, Size psize)
        {
            color = pcolor;
            koor = pkoor;
            size = psize;
            EventDelegate += StopMoving;
        }
        public Ball(Brush pcolor, Point pkoor, Size psize, bool pmove)
        {
            glcolor = pcolor;
            glkoor = pkoor;
            glsize = psize;
            EventDelegate += StopMoving;
        }
        public void Draw(Graphics context)
        {
            context.FillEllipse(color, new Rectangle(koor, size));
        }
        public void Draw2(Graphics context)
        {
            context.FillEllipse(glcolor, new Rectangle(glkoor, glsize));

        }
        public void Move()
        {              
                if ( glkoor.X == 0 || glkoor.X == 50 || glkoor.X == 100 || glkoor.X == 150 || glkoor.X == 200)
                {
                    EventDelegate();
                }
                if (glkoor.X < 1050)
                {
                    glkoor.X = glkoor.X + 10;
                }
                if (glkoor.X >= 1050) { glkoor.X = 0; }
                
            if (koor.X < 1050)
                {
                    koor.X = koor.X + 10;
                }
                if (koor.X >= 1050) { koor.X = 0;  }
                
        }
        public void StopMoving()
        {
            Thread.Sleep(500);
        }
    }
}
    



