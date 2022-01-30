using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FigureClassLibrary
{
    public static class Init
    {
        public static Bitmap bitmap;
        public static PictureBox pictureBox;
        public static Pen pen;
    }
    abstract public class Figure
    {
        public int x { get; set; }
        public int y { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public string name { get; set; }
        abstract public void Draw();
        abstract public void MoveTo(int x, int y);
        public void Clear()
        {
            Graphics g = Graphics.FromImage(Init.bitmap);
            g.Clear(Color.White);
        }
        public void DeleteF(Figure deletedFigure, PictureBox pictureBox, bool flag = true)
        {
            if (flag == true)
            {
                Graphics g = Graphics.FromImage(Init.bitmap);
                ShapeContainer.figures.Remove(deletedFigure);
                this.Clear();
                Init.pictureBox.Image = Init.bitmap;
                foreach (Figure figure in ShapeContainer.figures)
                {
                    figure.Draw();
                }
            }
            else
            {
                Graphics g = Graphics.FromImage(Init.bitmap);
                ShapeContainer.figures.Remove(deletedFigure);
                this.Clear();
                pictureBox.Image = Init.bitmap;
                foreach (Figure figure in ShapeContainer.figures)
                {
                    figure.Draw();
                }
                ShapeContainer.figures.Add(deletedFigure);
            }
        }
    }
}
