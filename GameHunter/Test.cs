using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RFPanda_dev
{
    class Target
    {
        int x = -10; // положение по длине с точки
        int y = 100; // положение по высоте с точки
        int d = 100; // положение по диагонали с точки
        int step = 5;
        public bool who = true;
        Point Wherego;
        bool Go;
        private const string birdyel = "C:\\Users\\RFPanda\\source\\repos\\Gamedev\\bird1.png"; // yellow bird
        private const string birdred = "C:\\Users\\RFPanda\\source\\repos\\Gamedev\\bird2.png"; // red bird
        public void Gonow()
        {
            Go = true;
        }
        public void Gonow(int X, int Y)
        {
            Go = true;
            Wherego = new Point(X, Y);
        }
        public void Draw(object sender, PaintEventArgs e)
        {
            if (Go)
            {
                if (x < Wherego.X)
                {
                    x += step;
                    if (x < 425)
                    {
                        e.Graphics.DrawImage(new Bitmap(birdyel), x, y);
                    }
                    else {
                        if (d>1)
                        {
                            d += step;
                        }
                        if (d == 470)
                        {
                            who = false;
                        }
                        e.Graphics.DrawImage(new Bitmap(birdred), x, d);
                    }
                }
                //e.Graphics.FillRectangle(new SolidBrush(Color.Yellow), x, y, 70, 50);
            }
        }

        public void Назад()
        {
            x = -10; // положение по длине с точки
            y = 100; // положение по высоте с точки
            d = 100;
            who = true;
        }
    }
}