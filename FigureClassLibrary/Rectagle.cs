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
        public static int numberRectangle = 0;
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
            this.name = "Прямоугольник " + numberRectangle.ToString();
            numberRectangle++;
        }
        public override void Draw()
        {
            Graphics g = Graphics.FromImage(Init.bitmap);
            g.DrawRectangle(Init.pen, new System.Drawing.Rectangle(new Point(this.x, this.y), new Size(this.width, this.height)));
            Init.pictureBox.Image = Init.bitmap;
        }
        public override void MoveTo(int x, int y)
        {
            if (OutOfBoundsCheck(x, y))
            {
                this.x += x;
                this.y += y;
                this.DeleteF(this, Init.pictureBox, false);
                this.Draw();
            }
        }

        private bool OutOfBoundsCheck(int x, int y)
        {
            return !((this.x + x < 0 && this.y + y < 0) || (this.y + y < 0) || (this.x + x > Init.pictureBox.Width && this.y + y < 0) || (this.x + this.width + x > Init.pictureBox.Width) || (this.x + x > Init.pictureBox.Width && this.y + y > Init.pictureBox.Height) || (this.y + this.height + y > Init.pictureBox.Height) || (this.x + x < 0 && this.y + y > Init.pictureBox.Height) || (this.x + x < 0));
        }
    }
}
