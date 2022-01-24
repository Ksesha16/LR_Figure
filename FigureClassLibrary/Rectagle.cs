using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureClassLibrary
{
    public class Rectangle : Figure
    {
        public Rectangle()
        {
            this.x = 0;
            this.y = 0;
            this.width = 0;
            this.height = 0;
        }
        public Rectangle(int x, int y, int width, int height)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
        }
        public override void Draw()
        {
            Graphics g = Graphics.FromImage(Init.bitmap);
            g.DrawRectangle(Init.pen, new System.Drawing.Rectangle(new Point(this.x, this.y), new Size(this.width, this.height)));
            Init.pictureBox.Image = Init.bitmap;
        }
        public override void MoveTo(int x, int y)
        {
            throw new NotImplementedException();
        }
    }
}
