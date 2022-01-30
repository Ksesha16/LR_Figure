using FigureClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR1
{
    public partial class FormFigure : Form
    {
        private Bitmap _bitmap;
        private Pen _pen;
        public static FormDeleteFigure FormDeleteFigure;
        public static FormMoveToFigure FormMoveToFigure;
        public FormFigure()
        {
            InitializeComponent();
            this._bitmap = new Bitmap(pictureBoxBitmap.ClientSize.Width, pictureBoxBitmap.ClientSize.Height);
            this._pen = new Pen(Color.Black, 5);
            Init.bitmap = this._bitmap;
            Init.pictureBox = pictureBoxBitmap;
            Init.pen = this._pen;
        }
        private void FormFigure_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.R)
            {
                (new FormDrawRectangle(this, "Rectangle")).ShowDialog();
            }
            else if (e.KeyCode == Keys.L)
            {
                (new FormDrawRectangle(this, "Line")).ShowDialog();
            }
            else if(e.KeyCode == Keys.D)
            {
                FormDeleteFigure = new FormDeleteFigure(this);
                FormDeleteFigure.Visible = true;
            }
            else if(e.KeyCode == Keys.M)
            {

                FormMoveToFigure = new FormMoveToFigure();
                FormMoveToFigure.Visible = true;
            }
        }
    }
}
