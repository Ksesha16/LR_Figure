using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureClassLibrary
{
    public class Line : Figure
    {
        public static int numberLine = 0;
        public Line()
        {
            this.x = 0;
            this.y = 0;
            this.width = 0;
            this.height = 0;
        }
        public Line(int x1, int y1, int x2, int y2)
        {
            this.x = x1;
            this.y = y1;
            this.width = x2;
            this.height = y2;
            this.name = "Линия " + numberLine.ToString();
            numberLine++;
        }
        public override void Draw()
        {
            Graphics g = Graphics.FromImage(Init.bitmap);
            g.DrawLine(Init.pen, x, y, width, height);
            Init.pictureBox.Image = Init.bitmap;
        }
        public override void MoveTo(int x, int y)
        {
            throw new NotImplementedException();
        }
    }
}
